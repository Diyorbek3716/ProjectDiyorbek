namespace OnlineShop.Forms
{
    partial class Registratsiya
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            FullName = new TextBox();
            UserName = new TextBox();
            NewLogin = new TextBox();
            NewPassword = new TextBox();
            RegistrLogin = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            againNewPassword = new TextBox();
            PhoneNumber = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 39);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "FullName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 92);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 142);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 2;
            label3.Text = "New Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 188);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 3;
            label4.Text = "New Password";
            // 
            // FullName
            // 
            FullName.Location = new Point(296, 39);
            FullName.Name = "FullName";
            FullName.Size = new Size(413, 31);
            FullName.TabIndex = 4;
            // 
            // UserName
            // 
            UserName.Location = new Point(296, 92);
            UserName.Name = "UserName";
            UserName.Size = new Size(413, 31);
            UserName.TabIndex = 5;
            // 
            // NewLogin
            // 
            NewLogin.Location = new Point(296, 142);
            NewLogin.Name = "NewLogin";
            NewLogin.Size = new Size(413, 31);
            NewLogin.TabIndex = 6;
            // 
            // NewPassword
            // 
            NewPassword.Location = new Point(296, 188);
            NewPassword.Name = "NewPassword";
            NewPassword.Size = new Size(413, 31);
            NewPassword.TabIndex = 7;
            // 
            // RegistrLogin
            // 
            RegistrLogin.Location = new Point(75, 353);
            RegistrLogin.Name = "RegistrLogin";
            RegistrLogin.Size = new Size(663, 47);
            RegistrLogin.TabIndex = 8;
            RegistrLogin.Text = "Enter";
            RegistrLogin.UseVisualStyleBackColor = true;
            RegistrLogin.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 92);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 9;
            label5.Text = "UserName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 271);
            label6.Name = "label6";
            label6.Size = new Size(132, 25);
            label6.TabIndex = 10;
            label6.Text = "Phone Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(117, 228);
            label7.Name = "label7";
            label7.Size = new Size(127, 25);
            label7.TabIndex = 11;
            label7.Text = "New Password";
            // 
            // againNewPassword
            // 
            againNewPassword.Location = new Point(296, 228);
            againNewPassword.Name = "againNewPassword";
            againNewPassword.Size = new Size(413, 31);
            againNewPassword.TabIndex = 12;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(296, 271);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(413, 31);
            PhoneNumber.TabIndex = 13;
            PhoneNumber.Text = "+998";
            PhoneNumber.TextChanged += textBox6_TextChanged;
            // 
            // Registratsiya
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PhoneNumber);
            Controls.Add(againNewPassword);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(RegistrLogin);
            Controls.Add(NewPassword);
            Controls.Add(NewLogin);
            Controls.Add(UserName);
            Controls.Add(FullName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registratsiya";
            Text = "Registry";
            Load += NewLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox FullName;
        private TextBox UserName;
        private TextBox NewLogin;
        private TextBox NewPassword;
        private Button RegistrLogin;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox againNewPassword;
        private TextBox PhoneNumber;
    }
}