using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taim
{
    public class TaimTextBox : TextBox
    {
        public TaimTextBox() : base()
        {
            this.ReadOnly = true;
            this.GotFocus += TaimTextBox_GotFocus;
            this.LostFocus += TaimTextBox_LostFocus;
        }

        private void TaimTextBox_GotFocus(object sender, EventArgs e)
        {
            this.ReadOnly = false;
            this.BackColor = SystemColors.Window;
            this.SelectAll();
        }

        private void TaimTextBox_LostFocus(object sender, EventArgs e)
        {
            this.ReadOnly = true;
            this.BackColor = SystemColors.Control;
        }
    }
}
