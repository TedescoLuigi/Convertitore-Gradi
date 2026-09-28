namespace Convertitore_Gradi
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 119);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 0;
            label1.Text = "TEMPERATURA CELSIUS";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 273);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 1;
            label2.Text = "TEMPERATURA FARENIGTH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 28);
            label3.Name = "label3";
            label3.Size = new Size(166, 15);
            label3.TabIndex = 2;
            label3.Text = "CONVERSIONE TEMPERATURE";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(104, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(248, 137);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "CONVERTI";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(248, 290);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "CONVERTI";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 140);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 9;
            label4.Text = "=";
            label4.Click += label4_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(422, 140);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 10;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(422, 294);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(363, 294);
            label7.Name = "label7";
            label7.Size = new Size(15, 15);
            label7.TabIndex = 11;
            label7.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
