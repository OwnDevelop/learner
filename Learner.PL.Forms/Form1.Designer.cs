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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_addWord = new System.Windows.Forms.Button();
            this.btn_startLearn = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addWord
            // 
            this.btn_addWord.BackColor = System.Drawing.Color.Lime;
            this.btn_addWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_addWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addWord.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_addWord.FlatAppearance.BorderSize = 6;
            this.btn_addWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addWord.Location = new System.Drawing.Point(3, 198);
            this.btn_addWord.Name = "btn_addWord";
            this.btn_addWord.Size = new System.Drawing.Size(414, 133);
            this.btn_addWord.TabIndex = 0;
            this.btn_addWord.Text = "Add new word";
            this.btn_addWord.UseVisualStyleBackColor = false;
            this.btn_addWord.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_startLearn
            // 
            this.btn_startLearn.BackColor = System.Drawing.Color.Lime;
            this.btn_startLearn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_startLearn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_startLearn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_startLearn.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_startLearn.FlatAppearance.BorderSize = 6;
            this.btn_startLearn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btn_startLearn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btn_startLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_startLearn.Location = new System.Drawing.Point(3, 3);
            this.btn_startLearn.Name = "btn_startLearn";
            this.btn_startLearn.Size = new System.Drawing.Size(414, 93);
            this.btn_startLearn.TabIndex = 1;
            this.btn_startLearn.Text = "Start learning";
            this.btn_startLearn.UseVisualStyleBackColor = false;
            this.btn_startLearn.Click += new System.EventHandler(this.btn_startLearn_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Lime;
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_settings.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_settings.FlatAppearance.BorderSize = 6;
            this.btn_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_settings.Location = new System.Drawing.Point(3, 102);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(414, 90);
            this.btn_settings.TabIndex = 2;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Exit, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_startLearn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_settings, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_addWord, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.76923F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 420);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Lime;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_Exit.FlatAppearance.BorderSize = 6;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Exit.Location = new System.Drawing.Point(3, 337);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(414, 59);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(422, 401);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Learner";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addWord;
        private System.Windows.Forms.Button btn_startLearn;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Exit;
    }
}

