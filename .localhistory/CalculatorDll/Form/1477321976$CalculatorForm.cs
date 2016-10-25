using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDll.Form
{
    public partial class CalculatorForm:System.Windows.Forms.Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender , EventArgs e)
        {
            Close();
        }
    }
}
