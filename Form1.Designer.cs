namespace OncorVariableAutomation
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
            button1 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label6 = new Label();
            comboBox4 = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            label1.TabIndex = 0;
            label1.Text = "Oncor Variable Replace: Microstation Tool";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 99);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 92, 169);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(344, 281);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 30);
            button1.TabIndex = 2;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 116);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 3;
            label3.Text = "Station Type:";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "SUB IV", "Switching Station" });
            comboBox1.Location = new Point(172, 116);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 182);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 5;
            label4.Text = "Voltage Type:";
            // 
            // comboBox2
            // 
            comboBox2.AllowDrop = true;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "25kv", "12.5 kv" });
            comboBox2.Location = new Point(172, 181);
            comboBox2.Margin = new Padding(2, 2, 2, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(129, 23);
            comboBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 118);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 7;
            label5.Text = "Type of Exits:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Overhead", "Underground" });
            comboBox3.Location = new Point(458, 114);
            comboBox3.Margin = new Padding(2, 2, 2, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(129, 23);
            comboBox3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(335, 185);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 9;
            label6.Text = "Number of Stations:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBox4.Location = new Point(458, 182);
            comboBox4.Margin = new Padding(2, 2, 2, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(129, 23);
            comboBox4.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.pictureBox1_Image;
            pictureBox1.Image = Properties.Resources.pictureBox1_Image;
            pictureBox1.InitialImage = Properties.Resources.pictureBox1_Image;
            pictureBox1.Location = new Point(308, 323);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(781, 383);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox4);
            Controls.Add(label6);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox3;
        private Label label6;
        private ComboBox comboBox4;
        private PictureBox pictureBox1;
    }
}
