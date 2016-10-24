using System;
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
      }

      private void closeButton_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void button_Click(object sender, EventArgs e)
      {
         string digit = ((Button)sender).Text;

      }

      private void OperationButton_Click(object sender, EventArgs e)
      {

      }
   }
}
