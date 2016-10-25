using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CommonPatterns
{
   public class NotifyingProperty<T>: INotifyPropertyChanged
   {
      public event PropertyChangedEventHandler PropertyChanged;
      public string PropertyName { get; }

      private bool isVisible;
      public bool IsVisible
      {
         get { return isVisible; }
         set
         {
            if( value == isVisible ) return;
            isVisible = value;
            OnPropertyChanged(PropertyName + ".Visible");
         }
      }

      private bool isEnabled;
      public bool IsEnabled
      {
         get { return isEnabled; }
         set
         {
            if( value == isEnabled ) return;
            isEnabled = value;
            OnPropertyChanged(PropertyName + ".Enabled");
         }
      }

      private T currentValue;
      public T Value
      {
         get { return currentValue; }
         set { SetValue(value); }
      }

      public NotifyingProperty(string propertyName)
      {
         PropertyName = propertyName;
         IsVisible = true;
         IsEnabled = true;
      }

      protected virtual void SetValue(T value)
      {
         if( Equals(currentValue, value) ) return;
         currentValue = value;
         OnPropertyChanged(PropertyName);
      }

      [NotifyPropertyChangedInvocator]
      protected void OnPropertyChanged(string propertyName)
      {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }
   }

   public class NotifyingString: NotifyingProperty<string>
   {
      public NotifyingString(string propertyName)
         : base(propertyName)
      {
      }

      protected override void SetValue(string value)
      {
         if( string.Compare(value, Value, StringComparison.CurrentCulture) == 0 ) return;
         base.SetValue(value);
      }
   }

   public class NotifyingInt: NotifyingProperty<int>
   {
      public NotifyingInt(string propertyName)
         : base(propertyName)
      {
      }

      protected override void SetValue(int value)
      {
         if( value == Value ) return;
         base.SetValue(value);
      }
   }

   public class ManualNotifyingProperty<T>: NotifyingProperty<T>
   {
      public ManualNotifyingProperty(string propertyName)
         : base(propertyName)
      {
      }
      // provides the ability to fake a change..
      public void Touch()
      {
         OnPropertyChanged(PropertyName);
      }
   }

   public class NotifyWithUIInfo<T>: ManualNotifyingProperty<T>
   {
      public MediaTypeNames.Image Image { get; set; }
      public MediaTypeNames.Image DisabledImage { get; set; }
      public string Text { get; set; }
      public string ToolTip { get; set; }
      public NotifyWithUIInfo(string propertyName)
         : base(propertyName)
      {
      }
   }

   public class NotifyingMenu<T>: NotifyingProperty<T>
   {
      public NotifyingMenu(string propertyName)
         : base(propertyName)
      {
      }

      private List<Tuple<T, string>> entries;
      public List<Tuple<T, string>> Entries
      {
         get { return entries; }
         set
         {
            if( Equals(value, entries) ) return;
            entries = value;
            OnPropertyChanged(PropertyName + "." + nameof(Entries));
         }
      }
      private string selected;
      public string Selected
      {
         get { return selected; }
         set
         {
            if( string.Compare(value, selected, StringComparison.CurrentCulture) == 0 ) return;
            SetEntry(entries.Find(x => x.Item2 == value));
         }
      }

      public new T Value
      {
         get
         {
            if( string.IsNullOrEmpty(Selected) )
               SetEntry(entries[0]);
            return base.Value;
         }
         set
         {
            if( Equals(value, base.Value) ) return;
            SetEntry(Entries.Find(x => Equals(x.Item1, value)));
         }
      }

      private void SetEntry(Tuple<T, string> entry)
      {
         if( entry == null ) return;
         base.Value = entry.Item1;
         selected = entry.Item2;
         OnPropertyChanged(PropertyName + "." + nameof(Selected));
      }
   }

   public class NotifyingStringMenu: NotifyingProperty<string>
   {
      public NotifyingStringMenu(string propertyName) : base(propertyName)
      {
      }

      private List<string> entries;
      public List<string> Entries
      {
         get { return entries; }
         set
         {
            if( Equals(value, entries) ) return;
            entries = value;
            OnPropertyChanged(PropertyName + "." + nameof(Entries));
         }
      }
      private string selected;
      public string Selected
      {
         get { return selected; }
         set
         {
            if( value == selected ) return;
            if( entries != null && !entries.Contains(value) )
               value = string.Empty;
            selected = value;
            OnPropertyChanged(PropertyName + "." + nameof(Selected));
         }
      }
      public new string Value
      {
         get { return Selected; }
         set { Selected = value; }
      }
   }
}
