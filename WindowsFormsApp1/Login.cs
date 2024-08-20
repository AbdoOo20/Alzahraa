using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.ClientSize.Width, this.ClientSize.Height);
            Panel panel = PanelLeft;
            panel.Width = this.ClientSize.Width / 2;
            panel.Height = this.ClientSize.Height;
            this.Controls.Add(panel);
            this.Resize += (s, e) =>
            {
                panel.Width = this.ClientSize.Width / 2;
                WelcomeLabel.Location = new Point(panel.Width / 10, panel.Height / 2);
                WelcomeLabel.Font = new Font("Arial", this.ClientSize.Width / 50 == 0 ? 10 : this.ClientSize.Width / 50);
                ImagePanel.Size = new Size(this.ClientSize.Width / 10, this.ClientSize.Width / 10);
                ImagePanel.Location = new Point(panel.Width / 3, panel.Height / 4);
                LoginLabel.Location = new Point((int)(this.ClientSize.Width / 1.8), this.ClientSize.Height / 8);
                LoginLabel.Font = new Font("Arial", this.ClientSize.Width / 40 == 0 ? 10 : this.ClientSize.Height / 20);
                BodyLabel.Location = new Point((int)(this.ClientSize.Width / 1.78), this.ClientSize.Height / 5);
                BodyLabel.Font = new Font("Arial", this.ClientSize.Width / 80 == 0 ? 10 : this.ClientSize.Height / 70);
                EmailLabel.Location = new Point((int)(this.ClientSize.Width / 1.78), this.ClientSize.Height / 3);
                TextBoxEmail.Location = new Point((int)(this.ClientSize.Width / 1.55), this.ClientSize.Height / 3);
                TextBoxEmail.Size = new Size(this.ClientSize.Width /4, this.ClientSize.Height / 35);
                EmailLabel.Font = new Font("Arial", this.ClientSize.Width / 90 == 0 ? 10 : this.ClientSize.Width / 90);
                TextBoxPassword.Location = new Point((int)(this.ClientSize.Width / 1.55), this.ClientSize.Height / 2);
                TextBoxPassword.Size = new Size(this.ClientSize.Width / 4, this.ClientSize.Height / 35);
                PasswordLabel.Font = new Font("Arial", this.ClientSize.Width / 90 == 0 ? 50 : this.ClientSize.Width / 90);
                PasswordLabel.Location = new Point((int)(this.ClientSize.Width / 1.78), this.ClientSize.Height / 2);
                TextBoxPassword.Controls.Add(HidePassword);
                TextBoxPassword.Controls.Add(ShowPassword);
                HidePassword.Size = new Size(this.ClientSize.Height / 35, this.ClientSize.Height / 30);
                ShowPassword.Size = new Size(this.ClientSize.Height / 35, this.ClientSize.Height / 30);
                LoginBTN.Location = new Point((int)(this.ClientSize.Width / 1.78), (int)(this.ClientSize.Height / 1.5));
                LoginBTN.Size = new Size((int)(this.ClientSize.Width / 2.9) , this.ClientSize.Height / 15);
            };
        }

        private void HidePassword_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.PasswordChar == '*')
            {
                TextBoxPassword.PasswordChar = '\0';
                HidePassword.Visible = !HidePassword.Visible;
                ShowPassword.Visible = true;
            }
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.PasswordChar == '\0')
            {
                ShowPassword.Visible = !ShowPassword.Visible;
                HidePassword.Visible = true;
                TextBoxPassword.PasswordChar = '*';
            }
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
         
        }
    }
}
