using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CalculatorDll.Form
{
   public partial class CalculatorForm: System.Windows.Forms.Form
   {
      private CalculatorViewModel ViewModel;
      public CalculatorForm()
      {
         InitializeComponent();
         ViewModel = new CalculatorViewModel();
         ViewModel.PropertyChanging += ViewModelOnPropertyChanging;
      }

      private void ViewModelOnPropertyChanging(object sender, PropertyChangingEventArgs e)
      {
         switch( e.PropertyName )
         {
            case "Number":

         }
      }

      private void digitButton_Click(object sender, EventArgs e)
      {
         ViewModel.Number.Value += ((Button)sender).Text;
      }

      private void operationButton_Click(object sender, EventArgs e)
      {

      }

      private void closeButton_Click(object sender, EventArgs e)
      {
         Close();
      }

   }
}
