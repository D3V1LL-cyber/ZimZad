namespace CaesarCipher
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм

        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.shiftNumeric = new System.Windows.Forms.NumericUpDown();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.alphabetGroup = new System.Windows.Forms.GroupBox();
            this.englishRadio = new System.Windows.Forms.RadioButton();
            this.russianRadio = new System.Windows.Forms.RadioButton();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumeric)).BeginInit();
            this.alphabetGroup.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.buttonPanel);
            this.mainPanel.Controls.Add(this.contentPanel);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainPanel.Size = new System.Drawing.Size(684, 511);
            this.mainPanel.TabIndex = 0;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonPanel.Controls.Add(this.exitButton);
            this.buttonPanel.Controls.Add(this.clearButton);
            this.buttonPanel.Controls.Add(this.saveFileButton);
            this.buttonPanel.Controls.Add(this.loadFileButton);
            this.buttonPanel.Controls.Add(this.decryptButton);
            this.buttonPanel.Controls.Add(this.encryptButton);
            this.buttonPanel.Location = new System.Drawing.Point(10, 460);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(640, 80);
            this.buttonPanel.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(540, 45);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 35);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(20, 45);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 35);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.saveFileButton.FlatAppearance.BorderSize = 0;
            this.saveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFileButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFileButton.ForeColor = System.Drawing.Color.White;
            this.saveFileButton.Location = new System.Drawing.Point(440, 15);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(120, 35);
            this.saveFileButton.TabIndex = 3;
            this.saveFileButton.Text = "Сохранить в файл";
            this.saveFileButton.UseVisualStyleBackColor = false;
            this.saveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // loadFileButton
            // 
            this.loadFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.loadFileButton.FlatAppearance.BorderSize = 0;
            this.loadFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFileButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadFileButton.ForeColor = System.Drawing.Color.White;
            this.loadFileButton.Location = new System.Drawing.Point(300, 15);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(120, 35);
            this.loadFileButton.TabIndex = 2;
            this.loadFileButton.Text = "Загрузить файл";
            this.loadFileButton.UseVisualStyleBackColor = false;
            this.loadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.decryptButton.FlatAppearance.BorderSize = 0;
            this.decryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptButton.ForeColor = System.Drawing.Color.White;
            this.decryptButton.Location = new System.Drawing.Point(160, 15);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(120, 35);
            this.decryptButton.TabIndex = 1;
            this.decryptButton.Text = "Расшифровать";
            this.decryptButton.UseVisualStyleBackColor = false;
            this.decryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.encryptButton.FlatAppearance.BorderSize = 0;
            this.encryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptButton.ForeColor = System.Drawing.Color.White;
            this.encryptButton.Location = new System.Drawing.Point(20, 15);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(120, 35);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.UseVisualStyleBackColor = false;
            this.encryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Controls.Add(this.shiftNumeric);
            this.contentPanel.Controls.Add(this.shiftLabel);
            this.contentPanel.Controls.Add(this.alphabetGroup);
            this.contentPanel.Controls.Add(this.outputTextBox);
            this.contentPanel.Controls.Add(this.outputLabel);
            this.contentPanel.Controls.Add(this.inputTextBox);
            this.contentPanel.Controls.Add(this.inputLabel);
            this.contentPanel.Controls.Add(this.divider);
            this.contentPanel.Location = new System.Drawing.Point(10, 100);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(640, 350);
            this.contentPanel.TabIndex = 1;
            // 
            // shiftNumeric
            // 
            this.shiftNumeric.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.shiftNumeric.Location = new System.Drawing.Point(295, 285);
            this.shiftNumeric.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.shiftNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shiftNumeric.Name = "shiftNumeric";
            this.shiftNumeric.Size = new System.Drawing.Size(60, 25);
            this.shiftNumeric.TabIndex = 7;
            this.shiftNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // shiftLabel
            // 
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.shiftLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.shiftLabel.Location = new System.Drawing.Point(240, 285);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(49, 19);
            this.shiftLabel.TabIndex = 6;
            this.shiftLabel.Text = "Сдвиг:";
            // 
            // alphabetGroup
            // 
            this.alphabetGroup.Controls.Add(this.englishRadio);
            this.alphabetGroup.Controls.Add(this.russianRadio);
            this.alphabetGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alphabetGroup.Location = new System.Drawing.Point(20, 270);
            this.alphabetGroup.Name = "alphabetGroup";
            this.alphabetGroup.Size = new System.Drawing.Size(200, 60);
            this.alphabetGroup.TabIndex = 5;
            this.alphabetGroup.TabStop = false;
            this.alphabetGroup.Text = " Алфавит ";
            // 
            // englishRadio
            // 
            this.englishRadio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.englishRadio.Location = new System.Drawing.Point(100, 25);
            this.englishRadio.Name = "englishRadio";
            this.englishRadio.Size = new System.Drawing.Size(90, 20);
            this.englishRadio.TabIndex = 1;
            this.englishRadio.Text = "Английский";
            this.englishRadio.UseVisualStyleBackColor = true;
            this.englishRadio.CheckedChanged += new System.EventHandler(this.AlphabetRadio_CheckedChanged);
            // 
            // russianRadio
            // 
            this.russianRadio.Checked = true;
            this.russianRadio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.russianRadio.Location = new System.Drawing.Point(15, 25);
            this.russianRadio.Name = "russianRadio";
            this.russianRadio.Size = new System.Drawing.Size(80, 20);
            this.russianRadio.TabIndex = 0;
            this.russianRadio.TabStop = true;
            this.russianRadio.Text = "Русский";
            this.russianRadio.UseVisualStyleBackColor = true;
            this.russianRadio.CheckedChanged += new System.EventHandler(this.AlphabetRadio_CheckedChanged);
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTextBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.outputTextBox.Location = new System.Drawing.Point(20, 180);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(600, 80);
            this.outputTextBox.TabIndex = 4;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.outputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.outputLabel.Location = new System.Drawing.Point(20, 150);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(79, 19);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Результат:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTextBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.inputTextBox.Location = new System.Drawing.Point(20, 50);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(600, 80);
            this.inputTextBox.TabIndex = 2;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.inputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.inputLabel.Location = new System.Drawing.Point(20, 20);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(113, 19);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Исходный текст:";
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.divider.Location = new System.Drawing.Point(20, 70);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(600, 1);
            this.divider.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.ForeColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(10, 10);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(640, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(300, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "ШИФР ЦЕЗАРЯ";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumeric)).EndInit();
            this.alphabetGroup.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.GroupBox alphabetGroup;
        private System.Windows.Forms.RadioButton englishRadio;
        private System.Windows.Forms.RadioButton russianRadio;
        private System.Windows.Forms.NumericUpDown shiftNumeric;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

