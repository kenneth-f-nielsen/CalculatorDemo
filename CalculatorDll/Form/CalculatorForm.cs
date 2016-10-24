using System;

namespace CalculatorDll.Form
{
   public partial class CalculatorForm: System.Windows.Forms.Form
   {
      public CalculatorForm()
      {
         InitializeComponent();
      }

      private void closeButton_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
