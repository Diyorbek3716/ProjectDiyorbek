namespace OnlineShop
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
            Login = new Button();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Signup = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackColor = Color.Green;
            Login.Font = new Font("Stencil", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = Color.GreenYellow;
            Login.Location = new Point(343, 283);
            Login.Margin = new Padding(4, 3, 4, 3);
            Login.Name = "Login";
            Login.Size = new Size(647, 46);
            Login.TabIndex = 1;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SkyBlue;
            label1.Location = new Point(347, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // Signup
            // 
            Signup.BackColor = Color.DarkGreen;
            Signup.ForeColor = Color.GreenYellow;
            Signup.Location = new Point(849, 245);
            Signup.Margin = new Padding(4, 3, 4, 3);
            Signup.Name = "Signup";
            Signup.Size = new Size(146, 33);
            Signup.TabIndex = 3;
            Signup.Text = "Signup";
            Signup.UseVisualStyleBackColor = false;
            Signup.Click += Registr_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SkyBlue;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(347, 176);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightCyan;
            textBox1.Location = new Point(347, 203);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(646, 33);
            textBox1.TabIndex = 5;
            textBox1.TabStop = false;
            textBox1.Tag = "Password";
            textBox1.UseSystemPasswordChar = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightCyan;
            textBox2.Location = new Point(347, 117);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(646, 34);
            textBox2.TabIndex = 6;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.WordWrap = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(465, 20);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(298, 68);
            label3.TabIndex = 7;
            label3.Text = "Welcome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 245);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 24);
            label4.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(66, 90);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 239);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Highlight;
            label5.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(626, 247);
            label5.Name = "label5";
            label5.Size = new Size(223, 26);
            label5.TabIndex = 10;
            label5.Text = "Haven't you registered?\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.Screenshot_2024_04_30_112913;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1004, 534);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(Signup);
            Controls.Add(label1);
            Controls.Add(Login);
            DoubleBuffered = true;
            Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.SeaShell;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "OnlineShop";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Login;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Signup;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
    }
}
