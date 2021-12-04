using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D44IUP_Lehmer_Generator
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            txtA.Text = "1103515245";
            txtB.Text = "12345";
            txtC.Text = "2147483648";
            txtX.Text = "12345";
        }

        public string returnA
        {
            get { return txtA.Text; }
        }
        public string returnB
        {
            get { return txtB.Text; }
        }
        public string returnC
        {
            get { return txtC.Text; }
        }
        public string returnX
        {
            get { return txtX.Text; }
        }
    }
}
