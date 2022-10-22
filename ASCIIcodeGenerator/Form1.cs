using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCIIcodeGenerator
{
    public partial class ASCIIcode : Form
    {
        public ASCIIcode()
        {
            InitializeComponent();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string str;
            byte asc;
            str = InputTb.Text;
            Output.Text = "";
            for(int i=0; i<str.Length; i++)
            {
                asc = (byte)str[i];
                Output.Text += " " + asc.ToString();
            }
        }
    }
}
