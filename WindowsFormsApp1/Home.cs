using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();          
            this.MinimumSize = new Size(this.ClientSize.Width, this.ClientSize.Height);
            this.Resize += (s, e) =>
            {
                DataBox.Size = new Size(this.ClientSize.Width / 2, this.ClientSize.Height);
                ButtonBox.Size = new Size(this.ClientSize.Width / 2, this.ClientSize.Height);
                DataBox.Controls.Add(LabelTitle);
                LabelTitle.Font = new Font("Arial", this.ClientSize.Width / 110);
                LabelTitle.Size = new Size(DataBox.Size.Width, DataBox.Size.Height / 2);
                Image1.Size = new Size((int)(DataBox.Size.Width / 2.5), DataBox.Size.Height / 5);
                Image2.Size = new Size((int)(DataBox.Size.Width / 2.5), DataBox.Size.Height / 5);
                Image3.Size = new Size((int)(DataBox.Size.Width / 1.25), DataBox.Size.Height / 5);
                Image1.Location = new Point(DataBox.Size.Width / 2, DataBox.Size.Height / 2);
                Image2.Location = new Point((int)(DataBox.Size.Width / 10), DataBox.Size.Height / 2);
                Image3.Location = new Point((int)(DataBox.Size.Width / 10), (int)(DataBox.Size.Height / 1.42));
                BuyButton.Font = new Font("Arial", ButtonBox.Width / 45 == 0 ? 10 : ButtonBox.Width / 45);
                SellButton.Font = new Font("Arial", ButtonBox.Width / 45 == 0 ? 10 : ButtonBox.Width / 45);
                ReportButton.Font = new Font("Arial", ButtonBox.Width / 45 == 0 ? 10 : ButtonBox.Width / 45);
                NotificationButton.Font = new Font("Arial", ButtonBox.Width / 45 == 0 ? 10 : ButtonBox.Width / 45);
                SearchBtn.Font = new Font("Arial", ButtonBox.Width / 45 == 0 ? 10 : ButtonBox.Width / 45);
                TitleUnit.Font = new Font("Arial", ButtonBox.Width / 45 == 0 ? 10 : ButtonBox.Width / 45);
                ValueUnit.Font = new Font("Arial", ButtonBox.Width / 45 == 0 ? 10 : ButtonBox.Width / 45);
                TitleClient.Font = new Font("Arial", ButtonBox.Width / 45 == 0 ? 10 : ButtonBox.Width / 45);
                ValueClient.Font = new Font("Arial", ButtonBox.Width / 45 == 0 ? 10 : ButtonBox.Width / 45);
                TitleLand.Font = new Font("Arial", ButtonBox.Width / 45 == 0 ? 10 : ButtonBox.Width / 45);
                ValueLand.Font = new Font("Arial", ButtonBox.Width / 45 == 0 ? 10 : ButtonBox.Width / 45);
                TitleTower.Font = new Font("Arial", ButtonBox.Width / 45 == 0 ? 10 : ButtonBox.Width / 45);
                ValueTower.Font = new Font("Arial", ButtonBox.Width / 45 == 0 ? 10 : ButtonBox.Width / 45);
                BuyButton.Size = new Size((int)(ButtonBox.Size.Width / 2.3), ButtonBox.Size.Height / 13);
                SellButton.Size = new Size((int)(ButtonBox.Size.Width / 2.3), ButtonBox.Size.Height / 13);
                ReportButton.Size = new Size((int)(ButtonBox.Size.Width / 2.3), ButtonBox.Size.Height / 13);
                NotificationButton.Size = new Size((int)(ButtonBox.Size.Width / 2.3), ButtonBox.Size.Height / 13);
                SearchBtn.Size = new Size((int)(ButtonBox.Size.Width / 1.11), ButtonBox.Size.Height / 13);
                BuyButton.Location = new Point((int)(DataBox.Size.Width / 2), (int)(DataBox.Size.Height / 1.6));
                SellButton.Location = new Point((int)(DataBox.Size.Width / 30.1), (int)(DataBox.Size.Height / 1.6));
                ReportButton.Location = new Point((int)(DataBox.Size.Width / 2), (int)(DataBox.Size.Height / 1.4));
                NotificationButton.Location = new Point((int)(DataBox.Size.Width / 30.1), (int)(DataBox.Size.Height / 1.4));
                SearchBtn.Location = new Point((int)(DataBox.Size.Width / 30.1), (int)(DataBox.Size.Height / 1.24));
                UnitGroup.Size = new Size((int)(ButtonBox.Size.Width / 2.3), ButtonBox.Size.Height / 7);
                UnitGroup.Location = new Point((int)(DataBox.Size.Width / 2), (int)(DataBox.Size.Height / 2.2));
                ClientGroup.Size = new Size((int)(ButtonBox.Size.Width / 2.3), ButtonBox.Size.Height / 7);
                ClientGroup.Location = new Point((int)(DataBox.Size.Width / 30.1), (int)(DataBox.Size.Height / 2.2));
                LandGroup.Size = new Size((int)(ButtonBox.Size.Width / 2.3), ButtonBox.Size.Height / 7);
                LandGroup.Location = new Point((int)(DataBox.Size.Width / 2), (int)(DataBox.Size.Height / 3.5));
                TowerGroup.Size = new Size((int)(ButtonBox.Size.Width / 2.3), ButtonBox.Size.Height / 7);
                TowerGroup.Location = new Point((int)(DataBox.Size.Width / 30.1), (int)(DataBox.Size.Height / 3.5));
                TitleUnit.Location = new Point(this.ClientSize.Width / 8, this.ClientSize.Height / 40);
                ValueUnit.Location = new Point(this.ClientSize.Width / 7, this.ClientSize.Height / 12);
                ClientImage.Location = new Point(this.ClientSize.Width / 20, this.ClientSize.Height / 25);
                ClientImage.Size = new Size((int)(ButtonBox.Size.Width / 12), ButtonBox.Size.Height / 15);
                UnitImage.Location = new Point(this.ClientSize.Width / 20, this.ClientSize.Height / 25);
                UnitImage.Size = new Size((int)(ButtonBox.Size.Width / 12), ButtonBox.Size.Height / 15);
                LandImage.Location = new Point(this.ClientSize.Width / 20, this.ClientSize.Height / 25);
                LandImage.Size = new Size((int)(ButtonBox.Size.Width / 12), ButtonBox.Size.Height / 15);
                TowerImage.Location = new Point(this.ClientSize.Width / 20, this.ClientSize.Height / 25);
                TowerImage.Size = new Size((int)(ButtonBox.Size.Width / 12), ButtonBox.Size.Height / 15);
                TitleClient.Location = new Point(this.ClientSize.Width / 8, this.ClientSize.Height / 40);
                ValueClient.Location = new Point(this.ClientSize.Width / 7, this.ClientSize.Height / 12);
                TitleTower.Location = new Point(this.ClientSize.Width / 8, this.ClientSize.Height / 40);
                ValueTower.Location = new Point(this.ClientSize.Width / 7, this.ClientSize.Height / 12);
                TitleLand.Location = new Point(this.ClientSize.Width / 8, this.ClientSize.Height / 40);
                ValueLand.Location = new Point(this.ClientSize.Width / 7, this.ClientSize.Height / 12);
                PieChart.Size = new Size((int)(ButtonBox.Size.Width / 1.11), (int)(ButtonBox.Size.Height / 4.5));
                PieChart.Location = new Point((int)(DataBox.Size.Width / 30.1), (int)(DataBox.Size.Height / 22));
            };
        }
    }
}
