namespace Theme26._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBoxAdd = new CheckBox();
            checkBoxSub = new CheckBox();
            textBoxResult = new TextBox();
            buttonResult = new Button();
            buttonClean = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(93, 43);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(111, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(93, 43);
            textBox2.TabIndex = 1;
            // 
            // checkBoxAdd
            // 
            checkBoxAdd.AutoSize = true;
            checkBoxAdd.Location = new Point(227, 12);
            checkBoxAdd.Name = "checkBoxAdd";
            checkBoxAdd.Size = new Size(83, 19);
            checkBoxAdd.TabIndex = 2;
            checkBoxAdd.Text = "Сложение";
            checkBoxAdd.UseVisualStyleBackColor = true;
            // 
            // checkBoxSub
            // 
            checkBoxSub.AutoSize = true;
            checkBoxSub.Location = new Point(227, 37);
            checkBoxSub.Name = "checkBoxSub";
            checkBoxSub.Size = new Size(87, 19);
            checkBoxSub.TabIndex = 3;
            checkBoxSub.Text = "Вычитание";
            checkBoxSub.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(12, 62);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(302, 43);
            textBoxResult.TabIndex = 4;
            textBoxResult.TextChanged += textBox3_TextChanged;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(12, 111);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(302, 23);
            buttonResult.TabIndex = 5;
            buttonResult.Text = "Посчитать";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonClean
            // 
            buttonClean.Location = new Point(12, 140);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(302, 23);
            buttonClean.TabIndex = 6;
            buttonClean.Text = "Очистить";
            buttonClean.UseVisualStyleBackColor = true;
            buttonClean.Click += buttonClean_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 176);
            Controls.Add(buttonClean);
            Controls.Add(buttonResult);
            Controls.Add(textBoxResult);
            Controls.Add(checkBoxSub);
            Controls.Add(checkBoxAdd);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Тема 26, 2/2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBoxAdd;
        private CheckBox checkBoxSub;
        private TextBox textBoxResult;
        private Button buttonResult;
        private Button buttonClean;
    }
}
