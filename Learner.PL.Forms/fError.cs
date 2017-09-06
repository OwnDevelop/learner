using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learner.PL.Forms
{
    public partial class fError : Form
    {
        public fError(string errorMessage)
        {
            InitializeComponent();
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                lbl_errorText.Text = errorMessage;
            }
            else
            {
                lbl_errorText.Text = "Unknow error. Try again";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
