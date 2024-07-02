namespace OncorVariableAutomation
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = Properties.Resources.pictureBox1_Image;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(318, 340);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Heavy", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 92, 169);
            label1.Location = new Point(190, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(382, 24);
            label1.TabIndex = 1;
            label1.Text = "Oncor Variable Replace: Microstation Tool";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 92, 169);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(352, 302);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 30);
            button1.TabIndex = 2;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(42, 51);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 78);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(482, 45);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(117, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(317, 45);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(526, 16);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 7;
            label8.Text = "SN#";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(358, 16);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 6;
            label7.Text = "PO#";
            label7.Click += label7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 47);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Station 1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Delta Star", "Prolec GE", "Hitachi ABB", "Royal Smit SGB", "Virginia Transformer" });
            comboBox1.Location = new Point(133, 45);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 16);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 0;
            label2.Text = "Transformer Manufacturer";
            label2.Click += label2_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Delta Star", "Prolec GE", "Hitachi ABB", "Royal Smit SGB", "Virginia Transformer" });
            comboBox4.Location = new Point(133, 7);
            comboBox4.Margin = new Padding(2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(129, 23);
            comboBox4.TabIndex = 18;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Delta Star", "Prolec GE", "Hitachi ABB", "Royal Smit SGB", "Virginia Transformer" });
            comboBox3.Location = new Point(133, 14);
            comboBox3.Margin = new Padding(2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(129, 23);
            comboBox3.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Delta Star", "Prolec GE", "Hitachi ABB", "Royal Smit SGB", "Virginia Transformer" });
            comboBox2.Location = new Point(133, 17);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(129, 23);
            comboBox2.TabIndex = 16;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(482, 7);
            textBox8.Margin = new Padding(2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(117, 23);
            textBox8.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(317, 7);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(117, 23);
            textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(482, 14);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(117, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(317, 14);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(117, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(482, 17);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(117, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(317, 17);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(117, 23);
            textBox3.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 10);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 5;
            label6.Text = "Station 4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 17);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Station 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 20);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Station 2";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox4);
            panel2.Location = new Point(42, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 51);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(comboBox3);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox6);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(42, 191);
            panel3.Name = "panel3";
            panel3.Size = new Size(701, 52);
            panel3.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Controls.Add(comboBox4);
            panel4.Controls.Add(textBox7);
            panel4.Controls.Add(textBox8);
            panel4.Location = new Point(42, 249);
            panel4.Name = "panel4";
            panel4.Size = new Size(701, 48);
            panel4.TabIndex = 21;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(781, 383);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}