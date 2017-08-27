using Learner.Entities;
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
        fError errorForm;

        public fAddWords()
        {
            InitializeComponent();
            labels = new List<Label>();
            textBoxes = new List<TextBox>();
            InitializeLists();
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
                var noEmptyBoxes = textBoxes.Where(x => !string.IsNullOrWhiteSpace(x.Text));

                if (noEmptyBoxes.Count() != 0)
                {
                    //add in bll
                    WordDTO word = new WordDTO();
                    word.Id = Guid.NewGuid();
                    word.Word = txtb_word.Text;

                    HashSet<string> interedTranslate = new HashSet<string>();

                    foreach (var item in noEmptyBoxes)
                    {
                        interedTranslate.Add(item.Text.ToLower());
                    }

                    //Output test
                    lbl_val6.Text = string.Format("word '{0}' translate as ", word.Word);

                    foreach (var item in interedTranslate)
                    {
                        lbl_val6.Text += item + " ";
                    }
                    lbl_val6.Visible = true;

                    word.Translates = interedTranslate;
                   //Learner.bll.Add(word);
                }
                else
                {
                    errorForm = new fError("Word hasn't translate");
                    errorForm.ShowDialog();
                }
            }
            else
            {
                errorForm = new fError("Field with word is empty");
                errorForm.ShowDialog();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
