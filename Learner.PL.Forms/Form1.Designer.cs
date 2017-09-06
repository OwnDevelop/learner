namespace Learner.PL.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_addWord = new System.Windows.Forms.Button();
            this.btn_startLearn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addWord
            // 
            this.btn_addWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addWord.Location = new System.Drawing.Point(41, 46);
            this.btn_addWord.Name = "btn_addWord";
            this.btn_addWord.Size = new System.Drawing.Size(276, 64);
            this.btn_addWord.TabIndex = 0;
            this.btn_addWord.Text = "Add new word";
            this.btn_addWord.UseVisualStyleBackColor = true;
            this.btn_addWord.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_startLearn
            // 
            this.btn_startLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_startLearn.Location = new System.Drawing.Point(41, 151);
            this.btn_startLearn.Name = "btn_startLearn";
            this.btn_startLearn.Size = new System.Drawing.Size(276, 67);
            this.btn_startLearn.TabIndex = 1;
            this.btn_startLearn.Text = "Start learning";
            this.btn_startLearn.UseVisualStyleBackColor = true;
            this.btn_startLearn.Click += new System.EventHandler(this.btn_startLearn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 261);
            this.Controls.Add(this.btn_startLearn);
            this.Controls.Add(this.btn_addWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Learner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addWord;
        private System.Windows.Forms.Button btn_startLearn;
    }
}

