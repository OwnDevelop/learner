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
    public partial class fAddWords : Form
    {
        List<Label> labels;
        List<TextBox> textBoxes;

        public fAddWords()
        {
            InitializeComponent();
            labels = new List<Label>();
            textBoxes = new List<TextBox>();
        }

        private void InitializeLists()
        {
            labels.Add(lbl_1val);
            labels.Add(lbl_2val);
            labels.Add(lbl_3val);
            labels.Add(lbl_4val);
            labels.Add(lbl_5val);

            textBoxes.Add(txtb_val1);
            textBoxes.Add(txtb_val2);
            textBoxes.Add(txtb_val3);
            textBoxes.Add(txtb_val4);
            textBoxes.Add(txtb_val5);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtb_word.Text))
            {
                var a = textBoxes.Where(x => !string.IsNullOrEmpty(x.Text));

                if (a != null)
                {
                    //add in bll
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
