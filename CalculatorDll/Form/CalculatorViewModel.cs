using System.ComponentModel;

namespace CalculatorDll.Form
{
   public class CalculatorViewModel : INotifyPropertyChanging
   {
      public event PropertyChangingEventHandler PropertyChanging;

      private string number;
      public string Number {
         get { return number; }
         set { number=value; }
      }

      public CalculatorViewModel()
      {
      }

      
   }
}
