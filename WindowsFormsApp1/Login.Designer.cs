
namespace WindowsFormsApp1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.BodyLabel = new System.Windows.Forms.Label();
            this.ShowPassword = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.HidePassword = new System.Windows.Forms.Button();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.PanelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PanelLeft.Controls.Add(this.ImagePanel);
            this.PanelLeft.Controls.Add(this.WelcomeLabel);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(424, 758);
            this.PanelLeft.TabIndex = 0;
            // 
            // ImagePanel
            // 
            this.ImagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImagePanel.BackgroundImage")));
            this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagePanel.Location = new System.Drawing.Point(50, 114);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(312, 210);
            this.ImagePanel.TabIndex = 1;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WelcomeLabel.Location = new System.Drawing.Point(27, 405);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(370, 29);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome To Alzahra Company";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(609, 237);
            this.TextBoxEmail.Multiline = true;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(329, 25);
            this.TextBoxEmail.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.LoginLabel.Location = new System.Drawing.Point(492, 114);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(124, 38);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "LOGIN";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.EmailLabel.Location = new System.Drawing.Point(494, 237);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(65, 25);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email";
            // 
            // BodyLabel
            // 
            this.BodyLabel.AutoSize = true;
            this.BodyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.BodyLabel.Location = new System.Drawing.Point(495, 152);
            this.BodyLabel.Name = "BodyLabel";
            this.BodyLabel.Size = new System.Drawing.Size(254, 20);
            this.BodyLabel.TabIndex = 0;
            this.BodyLabel.Text = "Login and browse the application";
            // 
            // ShowPassword
            // 
            this.ShowPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowPassword.BackgroundImage")));
            this.ShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowPassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShowPassword.Location = new System.Drawing.Point(1097, 0);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(30, 758);
            this.ShowPassword.TabIndex = 0;
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.Visible = false;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.PasswordLabel.Location = new System.Drawing.Point(494, 318);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 25);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(609, 318);
            this.TextBoxPassword.Multiline = true;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(329, 25);
            this.TextBoxPassword.TabIndex = 2;
            // 
            // HidePassword
            // 
            this.HidePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HidePassword.BackgroundImage")));
            this.HidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HidePassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.HidePassword.Location = new System.Drawing.Point(1067, 0);
            this.HidePassword.Name = "HidePassword";
            this.HidePassword.Size = new System.Drawing.Size(30, 758);
            this.HidePassword.TabIndex = 0;
            this.HidePassword.UseVisualStyleBackColor = true;
            this.HidePassword.Click += new System.EventHandler(this.HidePassword_Click);
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBTN.ForeColor = System.Drawing.Color.White;
            this.LoginBTN.Location = new System.Drawing.Point(499, 478);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(439, 63);
            this.LoginBTN.TabIndex = 3;
            this.LoginBTN.Text = "LOGIN";
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 758);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.HidePassword);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.BodyLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelLeft.ResumeLayout(false);
            this.PanelLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label BodyLabel;
        private System.Windows.Forms.Button ShowPassword;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button HidePassword;
        private System.Windows.Forms.Button LoginBTN;
    }
}

