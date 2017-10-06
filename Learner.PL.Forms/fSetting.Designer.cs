namespace Learner.PL.Forms
{
    partial class fSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSetting));
            this.cmb_numWords = new System.Windows.Forms.ComboBox();
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.chbox_timer = new System.Windows.Forms.CheckBox();
            this.chbox_music = new System.Windows.Forms.CheckBox();
            this.cmb_timerSec = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_numWords
            // 
            this.cmb_numWords.FormattingEnabled = true;
            this.cmb_numWords.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "30",
            "50"});
            this.cmb_numWords.Location = new System.Drawing.Point(169, 32);
            this.cmb_numWords.MaxLength = 3;
            this.cmb_numWords.Name = "cmb_numWords";
            this.cmb_numWords.Size = new System.Drawing.Size(52, 21);
            this.cmb_numWords.TabIndex = 0;
            this.cmb_numWords.Text = "10";
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_num.Location = new System.Drawing.Point(12, 33);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(109, 16);
            this.lbl_num.TabIndex = 1;
            this.lbl_num.Text = "Number of words";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_timer.Location = new System.Drawing.Point(12, 68);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(140, 16);
            this.lbl_timer.TabIndex = 2;
            this.lbl_timer.Text = "Timer for answer (sec)";
            // 
            // chbox_timer
            // 
            this.chbox_timer.AutoSize = true;
            this.chbox_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbox_timer.Location = new System.Drawing.Point(15, 126);
            this.chbox_timer.Name = "chbox_timer";
            this.chbox_timer.Size = new System.Drawing.Size(148, 20);
            this.chbox_timer.TabIndex = 5;
            this.chbox_timer.Text = "Use timer for answer";
            this.chbox_timer.UseVisualStyleBackColor = true;
            // 
            // chbox_music
            // 
            this.chbox_music.AutoSize = true;
            this.chbox_music.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbox_music.Location = new System.Drawing.Point(15, 152);
            this.chbox_music.Name = "chbox_music";
            this.chbox_music.Size = new System.Drawing.Size(138, 20);
            this.chbox_music.TabIndex = 6;
            this.chbox_music.Text = "Background music";
            this.chbox_music.UseVisualStyleBackColor = true;
            // 
            // cmb_timerSec
            // 
            this.cmb_timerSec.FormattingEnabled = true;
            this.cmb_timerSec.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "30",
            "40",
            "60"});
            this.cmb_timerSec.Location = new System.Drawing.Point(169, 67);
            this.cmb_timerSec.MaxLength = 2;
            this.cmb_timerSec.Name = "cmb_timerSec";
            this.cmb_timerSec.Size = new System.Drawing.Size(52, 21);
            this.cmb_timerSec.TabIndex = 7;
            this.cmb_timerSec.Text = "20";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(243, 226);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // fSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(341, 261);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_timerSec);
            this.Controls.Add(this.chbox_music);
            this.Controls.Add(this.chbox_timer);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.cmb_numWords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSetting";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_numWords;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.CheckBox chbox_timer;
        private System.Windows.Forms.CheckBox chbox_music;
        private System.Windows.Forms.ComboBox cmb_timerSec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cancel;
    }
}