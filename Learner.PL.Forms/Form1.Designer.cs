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
            this.WatchAllWords = new System.Windows.Forms.Button();
            this.btn_startLearn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.importWords = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addWord
            // 
            this.btn_addWord.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_addWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addWord.Location = new System.Drawing.Point(3, 214);
            this.btn_addWord.Name = "btn_addWord";
            this.btn_addWord.Size = new System.Drawing.Size(362, 68);
            this.btn_addWord.TabIndex = 0;
            this.btn_addWord.Text = "Add New Word";
            this.btn_addWord.UseVisualStyleBackColor = false;
            this.btn_addWord.Click += new System.EventHandler(this.button1_Click);
            // 
            // WatchAllWords
            // 
            this.WatchAllWords.BackColor = System.Drawing.Color.Khaki;
            this.WatchAllWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WatchAllWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WatchAllWords.Location = new System.Drawing.Point(3, 143);
            this.WatchAllWords.Name = "WatchAllWords";
            this.WatchAllWords.Size = new System.Drawing.Size(362, 65);
            this.WatchAllWords.TabIndex = 2;
            this.WatchAllWords.Text = "Watch All Words";
            this.WatchAllWords.UseVisualStyleBackColor = false;
            // 
            // btn_startLearn
            // 
            this.btn_startLearn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_startLearn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_startLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_startLearn.Location = new System.Drawing.Point(3, 3);
            this.btn_startLearn.Name = "btn_startLearn";
            this.btn_startLearn.Size = new System.Drawing.Size(362, 134);
            this.btn_startLearn.TabIndex = 1;
            this.btn_startLearn.Text = "Start Learning";
            this.btn_startLearn.UseVisualStyleBackColor = false;
            this.btn_startLearn.Click += new System.EventHandler(this.btn_startLearn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_startLearn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_addWord, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.WatchAllWords, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.importWords, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.35071F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.64929F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 361);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // importWords
            // 
            this.importWords.BackColor = System.Drawing.Color.Coral;
            this.importWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importWords.Location = new System.Drawing.Point(3, 288);
            this.importWords.Name = "importWords";
            this.importWords.Size = new System.Drawing.Size(362, 70);
            this.importWords.TabIndex = 3;
            this.importWords.Text = "Import Words From File";
            this.importWords.UseVisualStyleBackColor = false;
            this.importWords.Click += new System.EventHandler(this.importWords_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Txt Files(*.txt)|*.txt|All files (*.*)|*.*  ";
            this.openFileDialog1.Title = "Import Words From File Dialog";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Learner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addWord;
        private System.Windows.Forms.Button WatchAllWords;
        private System.Windows.Forms.Button btn_startLearn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button importWords;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

