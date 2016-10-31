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
         ViewModel.PropertyChanged += ViewModelOnPropertyChanged;
      }

      private void ViewModelOnPropertyChanged( object sender, PropertyChangedEventArgs e )
      {
         switch( e.PropertyName )
         {
            case "Number":

               break;
         }

      }


      private void digitButton_Click( object sender, EventArgs e )
      {
         int digit = int.Parse(((Button)sender).Text);
         ViewModel.Number = ViewModel.Number * 10 + digit;
      }

      private void operationButton_Click( object sender, EventArgs e )
      {

      }

      private void closeButton_Click( object sender, EventArgs e )
      {
         Close();
      }

   }
}
