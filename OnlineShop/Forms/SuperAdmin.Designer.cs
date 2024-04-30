namespace OnlineShop.Forms
{
    partial class SuperAdmin
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
            Super = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // Super
            // 
            Super.AutoSize = true;
            Super.Location = new Point(24, 50);
            Super.Name = "Super";
            Super.Size = new Size(226, 25);
            Super.TabIndex = 0;
            Super.Text = "Ma'lumotlar shu faylda--->";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(275, 50);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(511, 25);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "C:\\Users\\Hp\\source\\repos\\OnlineShop\\OnlineShop\\UserList.txt";
            // 
            // SuperAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 473);
            Controls.Add(linkLabel1);
            Controls.Add(Super);
            Name = "SuperAdmin";
            Text = "SuperAdmin";
            Load += SuperAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Super;
        private LinkLabel linkLabel1;
    }
}