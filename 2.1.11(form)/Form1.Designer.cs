namespace _2._1._11_form_
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
            this.choosePerformanceClassRButton = new System.Windows.Forms.RadioButton();
            this.choosePerformanceChildClassRButton = new System.Windows.Forms.RadioButton();
            this.startViewersCountTextBox = new System.Windows.Forms.TextBox();
            this.startViewersCountLabel = new System.Windows.Forms.Label();
            this.endViewersCountLabel = new System.Windows.Forms.Label();
            this.endViewersCountTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.yearOfWritingLabel = new System.Windows.Forms.Label();
            this.yearOfWritingTextBox = new System.Windows.Forms.TextBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choosePerformanceClassRButton
            // 
            this.choosePerformanceClassRButton.AutoSize = true;
            this.choosePerformanceClassRButton.Location = new System.Drawing.Point(13, 24);
            this.choosePerformanceClassRButton.Name = "choosePerformanceClassRButton";
            this.choosePerformanceClassRButton.Size = new System.Drawing.Size(165, 17);
            this.choosePerformanceClassRButton.TabIndex = 0;
            this.choosePerformanceClassRButton.TabStop = true;
            this.choosePerformanceClassRButton.Text = "Выбрать класс Performance";
            this.choosePerformanceClassRButton.UseVisualStyleBackColor = true;
            this.choosePerformanceClassRButton.CheckedChanged += new System.EventHandler(this.choosePerformanceClassRButton_CheckedChanged);
            // 
            // choosePerformanceChildClassRButton
            // 
            this.choosePerformanceChildClassRButton.AutoSize = true;
            this.choosePerformanceChildClassRButton.Location = new System.Drawing.Point(13, 58);
            this.choosePerformanceChildClassRButton.Name = "choosePerformanceChildClassRButton";
            this.choosePerformanceChildClassRButton.Size = new System.Drawing.Size(188, 17);
            this.choosePerformanceChildClassRButton.TabIndex = 1;
            this.choosePerformanceChildClassRButton.TabStop = true;
            this.choosePerformanceChildClassRButton.Text = "Выбрать класс PerformanceChild";
            this.choosePerformanceChildClassRButton.UseVisualStyleBackColor = true;
            this.choosePerformanceChildClassRButton.CheckedChanged += new System.EventHandler(this.choosePerformanceChildClassRButton_CheckedChanged);
            // 
            // startViewersCountTextBox
            // 
            this.startViewersCountTextBox.Location = new System.Drawing.Point(345, 23);
            this.startViewersCountTextBox.Name = "startViewersCountTextBox";
            this.startViewersCountTextBox.Size = new System.Drawing.Size(54, 20);
            this.startViewersCountTextBox.TabIndex = 2;
            // 
            // startViewersCountLabel
            // 
            this.startViewersCountLabel.AutoSize = true;
            this.startViewersCountLabel.Location = new System.Drawing.Point(224, 18);
            this.startViewersCountLabel.Name = "startViewersCountLabel";
            this.startViewersCountLabel.Size = new System.Drawing.Size(115, 26);
            this.startViewersCountLabel.TabIndex = 3;
            this.startViewersCountLabel.Text = "Введите начальное\r\nколичество зрителей\r\n";
            // 
            // endViewersCountLabel
            // 
            this.endViewersCountLabel.AutoSize = true;
            this.endViewersCountLabel.Location = new System.Drawing.Point(224, 58);
            this.endViewersCountLabel.Name = "endViewersCountLabel";
            this.endViewersCountLabel.Size = new System.Drawing.Size(115, 26);
            this.endViewersCountLabel.TabIndex = 4;
            this.endViewersCountLabel.Text = "Введите конечное \nколичество зрителей\r\n";
            // 
            // endViewersCountTextBox
            // 
            this.endViewersCountTextBox.Location = new System.Drawing.Point(345, 64);
            this.endViewersCountTextBox.Name = "endViewersCountTextBox";
            this.endViewersCountTextBox.Size = new System.Drawing.Size(54, 20);
            this.endViewersCountTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 100);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 26);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Введите название\r\n спектакля";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(118, 106);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(138, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // yearOfWritingLabel
            // 
            this.yearOfWritingLabel.AutoSize = true;
            this.yearOfWritingLabel.Location = new System.Drawing.Point(262, 100);
            this.yearOfWritingLabel.Name = "yearOfWritingLabel";
            this.yearOfWritingLabel.Size = new System.Drawing.Size(120, 26);
            this.yearOfWritingLabel.TabIndex = 8;
            this.yearOfWritingLabel.Text = "Введите год\r\n написания спектакля";
            // 
            // yearOfWritingTextBox
            // 
            this.yearOfWritingTextBox.Location = new System.Drawing.Point(388, 106);
            this.yearOfWritingTextBox.Name = "yearOfWritingTextBox";
            this.yearOfWritingTextBox.Size = new System.Drawing.Size(54, 20);
            this.yearOfWritingTextBox.TabIndex = 9;
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(470, 109);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(133, 23);
            this.outputButton.TabIndex = 10;
            this.outputButton.Text = "Рассчитать качество";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(427, 48);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 144);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.yearOfWritingTextBox);
            this.Controls.Add(this.yearOfWritingLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.endViewersCountTextBox);
            this.Controls.Add(this.endViewersCountLabel);
            this.Controls.Add(this.startViewersCountLabel);
            this.Controls.Add(this.startViewersCountTextBox);
            this.Controls.Add(this.choosePerformanceChildClassRButton);
            this.Controls.Add(this.choosePerformanceClassRButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton choosePerformanceClassRButton;
        private System.Windows.Forms.RadioButton choosePerformanceChildClassRButton;
        private System.Windows.Forms.TextBox startViewersCountTextBox;
        private System.Windows.Forms.Label startViewersCountLabel;
        private System.Windows.Forms.Label endViewersCountLabel;
        private System.Windows.Forms.TextBox endViewersCountTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label yearOfWritingLabel;
        private System.Windows.Forms.TextBox yearOfWritingTextBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

