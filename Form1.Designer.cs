namespace трпо
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            panel5 = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            label4 = new Label();
            radioButton1 = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button4 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(20, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 475);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(panel2);
            groupBox1.Location = new Point(12, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 698);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(298, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 472);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(radioButton3);
            panel5.Controls.Add(radioButton2);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(radioButton1);
            panel5.Location = new Point(13, 53);
            panel5.Name = "panel5";
            panel5.Size = new Size(131, 202);
            panel5.TabIndex = 4;
            panel5.Paint += panel5_Paint;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 85);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(79, 19);
            radioButton3.TabIndex = 5;
            radioButton3.Text = "19 литров";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 60);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 19);
            radioButton2.TabIndex = 4;
            radioButton2.Text = "5 литров";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 13);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 0;
            label4.Text = "Выберите объем";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.Menu;
            radioButton1.ForeColor = Color.MidnightBlue;
            radioButton1.Location = new Point(12, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 19);
            radioButton1.TabIndex = 3;
            radioButton1.Text = "1 литр";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 23);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "ЦЕНА ЗА ЛИТР - 10Р";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 284);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Пуск";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(179, 284);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Сдача";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(98, 284);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Стоп";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(15, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 321);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 327);
            label5.Name = "label5";
            label5.Size = new Size(282, 105);
            label5.TabIndex = 8;
            label5.Text = "Инструкция:\r\n1. Установите тару в зону разлива\r\n2. Выберите литраж\r\n3. Оплатите\r\n4. Нажмите на \"Пуск\"\r\n5. Для остановки подачи воды нажмите на \"Стоп\"\r\n5. Для получения сдачи нажмите на \"Сдача\"";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(39, 38);
            label6.Name = "label6";
            label6.Size = new Size(187, 37);
            label6.TabIndex = 1;
            label6.Text = "Зона розлива";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(251, 24);
            label7.Name = "label7";
            label7.Size = new Size(104, 37);
            label7.TabIndex = 2;
            label7.Text = "ЧистСу";
            label7.Click += label7_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(150, 53);
            button4.Name = "button4";
            button4.Size = new Size(139, 202);
            button4.TabIndex = 9;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 867);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private Label label1;
        private Panel panel5;
        private Label label4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button4;
    }
}
