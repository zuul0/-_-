namespace трпо
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            ctoimost = new Label();
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            hundred = new Button();
            fifty = new Button();
            ten = new Button();
            five = new Button();
            two = new Button();
            one = new Button();
            vneseno = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ctoimost
            // 
            ctoimost.AutoSize = true;
            ctoimost.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ctoimost.Location = new Point(31, 9);
            ctoimost.Name = "ctoimost";
            ctoimost.Size = new Size(162, 37);
            ctoimost.TabIndex = 0;
            ctoimost.Text = "Стоимость: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(hundred);
            panel1.Controls.Add(fifty);
            panel1.Controls.Add(ten);
            panel1.Controls.Add(five);
            panel1.Controls.Add(two);
            panel1.Controls.Add(one);
            panel1.Location = new Point(31, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 355);
            panel1.TabIndex = 1;
            // 
            // button8
            // 
            button8.Location = new Point(426, 281);
            button8.Name = "button8";
            button8.Size = new Size(119, 42);
            button8.TabIndex = 7;
            button8.Text = "Отмена";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(43, 281);
            button7.Name = "button7";
            button7.Size = new Size(119, 42);
            button7.TabIndex = 6;
            button7.Text = "Оплатить";
            button7.UseVisualStyleBackColor = true;
            // 
            // hundred
            // 
            hundred.BackgroundImage = (Image)resources.GetObject("hundred.BackgroundImage");
            hundred.BackgroundImageLayout = ImageLayout.Stretch;
            hundred.Location = new Point(290, 144);
            hundred.Name = "hundred";
            hundred.Size = new Size(277, 108);
            hundred.TabIndex = 5;
            hundred.UseVisualStyleBackColor = true;
            hundred.Click += hundred_Click;
            // 
            // fifty
            // 
            fifty.BackgroundImage = (Image)resources.GetObject("fifty.BackgroundImage");
            fifty.BackgroundImageLayout = ImageLayout.Stretch;
            fifty.Location = new Point(25, 144);
            fifty.Name = "fifty";
            fifty.Size = new Size(259, 108);
            fifty.TabIndex = 4;
            fifty.UseVisualStyleBackColor = true;
            fifty.Click += fifty_Click;
            // 
            // ten
            // 
            ten.BackgroundImage = (Image)resources.GetObject("ten.BackgroundImage");
            ten.BackgroundImageLayout = ImageLayout.Stretch;
            ten.Location = new Point(426, 19);
            ten.Name = "ten";
            ten.Size = new Size(122, 110);
            ten.TabIndex = 3;
            ten.UseVisualStyleBackColor = true;
            ten.Click += ten_Click;
            // 
            // five
            // 
            five.BackgroundImage = (Image)resources.GetObject("five.BackgroundImage");
            five.BackgroundImageLayout = ImageLayout.Stretch;
            five.Location = new Point(308, 19);
            five.Name = "five";
            five.Size = new Size(112, 110);
            five.TabIndex = 2;
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // two
            // 
            two.BackgroundImage = (Image)resources.GetObject("two.BackgroundImage");
            two.BackgroundImageLayout = ImageLayout.Stretch;
            two.Location = new Point(179, 19);
            two.Name = "two";
            two.Size = new Size(123, 110);
            two.TabIndex = 1;
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // one
            // 
            one.BackgroundImage = (Image)resources.GetObject("one.BackgroundImage");
            one.BackgroundImageLayout = ImageLayout.Stretch;
            one.Location = new Point(43, 19);
            one.Name = "one";
            one.Size = new Size(130, 110);
            one.TabIndex = 0;
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // vneseno
            // 
            vneseno.AutoSize = true;
            vneseno.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            vneseno.Location = new Point(352, 9);
            vneseno.Name = "vneseno";
            vneseno.Size = new Size(133, 37);
            vneseno.TabIndex = 2;
            vneseno.Text = "Внесено: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 37);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(478, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 37);
            label2.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 451);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(vneseno);
            Controls.Add(panel1);
            Controls.Add(ctoimost);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ctoimost;
        private Panel panel1;
        private Button five;
        private Button two;
        private Button one;
        private Button button8;
        private Button button7;
        private Button hundred;
        private Button fifty;
        private Button ten;
        private Label vneseno;
        private Label label1;
        private Label label2;
    }
}