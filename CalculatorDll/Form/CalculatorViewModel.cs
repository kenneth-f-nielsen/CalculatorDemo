using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CalculatorDll.Annotations;

namespace CalculatorDll.Form
{
   public class CalculatorViewModel : INotifyPropertyChanged
   {
      private double number;
      public double Number {
         get { return number; }
         set {
            if ( Math.Abs( number - value ) < double.Epsilon) return;
            number = value;
            OnPropertyChanged();
         }
      }

      public CalculatorViewModel()
      {
      }

      public event PropertyChangedEventHandler PropertyChanged;

      [NotifyPropertyChangedInvocator]
      protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
         PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
      }
   }
}
