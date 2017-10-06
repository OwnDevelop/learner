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
    public partial class Form1 : Form
    {
        fSetting settingsForm;
        fAddWords addForm;

        public Form1()
        {
            InitializeComponent();
            Learner.Initialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addForm = new fAddWords();
            addForm.ShowDialog();
        }

        private void btn_startLearn_Click(object sender, EventArgs e)
        {

        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            settingsForm = new fSetting();
            settingsForm.ShowDialog();
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
