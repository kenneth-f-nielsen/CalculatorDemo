using System.ComponentModel;

namespace CalculatorDll.Form
{
   public class CalculatorViewModel : INotifyPropertyChanging
   {
      public CalculatorViewModel()
      {

      }

      public event PropertyChangingEventHandler PropertyChanging;
   }
}
