using System;
using System.Windows.Forms;

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

      private void button_Click(object sender, EventArgs e)
      {
         string digit = ((Button)sender).Text;

      }
   }
}
