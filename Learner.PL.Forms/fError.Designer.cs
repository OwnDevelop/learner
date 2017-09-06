namespace Learner.PL.Forms
{
    partial class fError
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
            this.lbl_errorText = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_errorText
            // 
            this.lbl_errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_errorText.Location = new System.Drawing.Point(12, 9);
            this.lbl_errorText.Name = "lbl_errorText";
            this.lbl_errorText.Size = new System.Drawing.Size(274, 56);
            this.lbl_errorText.TabIndex = 0;
            this.lbl_errorText.Text = "label";
            this.lbl_errorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(101, 86);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(84, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Understood";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // fError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 121);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_errorText);
            this.Name = "fError";
            this.Text = "Error";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_errorText;
        private System.Windows.Forms.Button btn_close;
    }
}