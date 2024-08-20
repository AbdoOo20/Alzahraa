
namespace WindowsFormsApp1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 40D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 20D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 30D);
            this.DataBox = new System.Windows.Forms.GroupBox();
            this.Image3 = new System.Windows.Forms.PictureBox();
            this.Image2 = new System.Windows.Forms.PictureBox();
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.NotificationButton = new System.Windows.Forms.Button();
            this.ButtonBox = new System.Windows.Forms.GroupBox();
            this.UnitGroup = new System.Windows.Forms.GroupBox();
            this.TitleUnit = new System.Windows.Forms.Label();
            this.ValueUnit = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ClientGroup = new System.Windows.Forms.GroupBox();
            this.ValueClient = new System.Windows.Forms.Label();
            this.TitleClient = new System.Windows.Forms.Label();
            this.ClientImage = new System.Windows.Forms.PictureBox();
            this.UnitImage = new System.Windows.Forms.PictureBox();
            this.LandGroup = new System.Windows.Forms.GroupBox();
            this.LandImage = new System.Windows.Forms.PictureBox();
            this.ValueLand = new System.Windows.Forms.Label();
            this.TitleLand = new System.Windows.Forms.Label();
            this.TowerGroup = new System.Windows.Forms.GroupBox();
            this.TowerImage = new System.Windows.Forms.PictureBox();
            this.ValueTower = new System.Windows.Forms.Label();
            this.TitleTower = new System.Windows.Forms.Label();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            this.ButtonBox.SuspendLayout();
            this.UnitGroup.SuspendLayout();
            this.ClientGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitImage)).BeginInit();
            this.LandGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LandImage)).BeginInit();
            this.TowerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TowerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // DataBox
            // 
            this.DataBox.BackColor = System.Drawing.Color.Honeydew;
            this.DataBox.Controls.Add(this.Image3);
            this.DataBox.Controls.Add(this.Image2);
            this.DataBox.Controls.Add(this.Image1);
            this.DataBox.Controls.Add(this.LabelTitle);
            this.DataBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.DataBox.Location = new System.Drawing.Point(560, 0);
            this.DataBox.Name = "DataBox";
            this.DataBox.Padding = new System.Windows.Forms.Padding(50);
            this.DataBox.Size = new System.Drawing.Size(547, 754);
            this.DataBox.TabIndex = 0;
            this.DataBox.TabStop = false;
            // 
            // Image3
            // 
            this.Image3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Image3.BackgroundImage")));
            this.Image3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image3.Location = new System.Drawing.Point(24, 558);
            this.Image3.Name = "Image3";
            this.Image3.Size = new System.Drawing.Size(500, 143);
            this.Image3.TabIndex = 3;
            this.Image3.TabStop = false;
            // 
            // Image2
            // 
            this.Image2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Image2.BackgroundImage")));
            this.Image2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image2.Location = new System.Drawing.Point(283, 402);
            this.Image2.Name = "Image2";
            this.Image2.Size = new System.Drawing.Size(241, 143);
            this.Image2.TabIndex = 2;
            this.Image2.TabStop = false;
            // 
            // Image1
            // 
            this.Image1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Image1.BackgroundImage")));
            this.Image1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image1.Location = new System.Drawing.Point(24, 402);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(241, 143);
            this.Image1.TabIndex = 1;
            this.Image1.TabStop = false;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Location = new System.Drawing.Point(6, 18);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Padding = new System.Windows.Forms.Padding(10);
            this.LabelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelTitle.Size = new System.Drawing.Size(538, 350);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = resources.GetString("LabelTitle.Text");
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyButton.ForeColor = System.Drawing.Color.White;
            this.BuyButton.Location = new System.Drawing.Point(286, 489);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(240, 78);
            this.BuyButton.TabIndex = 1;
            this.BuyButton.Text = "شراء";
            this.BuyButton.UseVisualStyleBackColor = false;
            // 
            // SellButton
            // 
            this.SellButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellButton.ForeColor = System.Drawing.Color.White;
            this.SellButton.Location = new System.Drawing.Point(28, 489);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(240, 78);
            this.SellButton.TabIndex = 2;
            this.SellButton.Text = "بيع";
            this.SellButton.UseVisualStyleBackColor = false;
            // 
            // ReportButton
            // 
            this.ReportButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.Location = new System.Drawing.Point(28, 573);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(240, 78);
            this.ReportButton.TabIndex = 3;
            this.ReportButton.Text = "تقارير";
            this.ReportButton.UseVisualStyleBackColor = false;
            // 
            // NotificationButton
            // 
            this.NotificationButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.NotificationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotificationButton.ForeColor = System.Drawing.Color.White;
            this.NotificationButton.Location = new System.Drawing.Point(286, 573);
            this.NotificationButton.Name = "NotificationButton";
            this.NotificationButton.Size = new System.Drawing.Size(240, 78);
            this.NotificationButton.TabIndex = 4;
            this.NotificationButton.Text = "إشعارات";
            this.NotificationButton.UseVisualStyleBackColor = false;
            // 
            // ButtonBox
            // 
            this.ButtonBox.BackColor = System.Drawing.Color.Honeydew;
            this.ButtonBox.Controls.Add(this.PieChart);
            this.ButtonBox.Controls.Add(this.TowerGroup);
            this.ButtonBox.Controls.Add(this.LandGroup);
            this.ButtonBox.Controls.Add(this.ClientGroup);
            this.ButtonBox.Controls.Add(this.SearchBtn);
            this.ButtonBox.Controls.Add(this.UnitGroup);
            this.ButtonBox.Controls.Add(this.SellButton);
            this.ButtonBox.Controls.Add(this.NotificationButton);
            this.ButtonBox.Controls.Add(this.BuyButton);
            this.ButtonBox.Controls.Add(this.ReportButton);
            this.ButtonBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonBox.Location = new System.Drawing.Point(0, 0);
            this.ButtonBox.Name = "ButtonBox";
            this.ButtonBox.Size = new System.Drawing.Size(554, 754);
            this.ButtonBox.TabIndex = 5;
            this.ButtonBox.TabStop = false;
            // 
            // UnitGroup
            // 
            this.UnitGroup.Controls.Add(this.UnitImage);
            this.UnitGroup.Controls.Add(this.ValueUnit);
            this.UnitGroup.Controls.Add(this.TitleUnit);
            this.UnitGroup.Location = new System.Drawing.Point(28, 329);
            this.UnitGroup.Name = "UnitGroup";
            this.UnitGroup.Size = new System.Drawing.Size(240, 142);
            this.UnitGroup.TabIndex = 5;
            this.UnitGroup.TabStop = false;
            // 
            // TitleUnit
            // 
            this.TitleUnit.AutoSize = true;
            this.TitleUnit.Location = new System.Drawing.Point(132, 33);
            this.TitleUnit.Name = "TitleUnit";
            this.TitleUnit.Size = new System.Drawing.Size(68, 17);
            this.TitleUnit.TabIndex = 0;
            this.TitleUnit.Text = "عدد الوحدات";
            this.TitleUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValueUnit
            // 
            this.ValueUnit.AutoSize = true;
            this.ValueUnit.Location = new System.Drawing.Point(148, 79);
            this.ValueUnit.Name = "ValueUnit";
            this.ValueUnit.Size = new System.Drawing.Size(24, 17);
            this.ValueUnit.TabIndex = 1;
            this.ValueUnit.Text = "20";
            this.ValueUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(28, 657);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(498, 78);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "بحث";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // ClientGroup
            // 
            this.ClientGroup.Controls.Add(this.ClientImage);
            this.ClientGroup.Controls.Add(this.ValueClient);
            this.ClientGroup.Controls.Add(this.TitleClient);
            this.ClientGroup.Location = new System.Drawing.Point(286, 329);
            this.ClientGroup.Name = "ClientGroup";
            this.ClientGroup.Size = new System.Drawing.Size(240, 142);
            this.ClientGroup.TabIndex = 6;
            this.ClientGroup.TabStop = false;
            // 
            // ValueClient
            // 
            this.ValueClient.AutoSize = true;
            this.ValueClient.Location = new System.Drawing.Point(175, 79);
            this.ValueClient.Name = "ValueClient";
            this.ValueClient.Size = new System.Drawing.Size(24, 17);
            this.ValueClient.TabIndex = 1;
            this.ValueClient.Text = "50";
            this.ValueClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleClient
            // 
            this.TitleClient.AutoSize = true;
            this.TitleClient.Location = new System.Drawing.Point(159, 33);
            this.TitleClient.Name = "TitleClient";
            this.TitleClient.Size = new System.Drawing.Size(60, 17);
            this.TitleClient.TabIndex = 0;
            this.TitleClient.Text = "عدد العملاء";
            this.TitleClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientImage
            // 
            this.ClientImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClientImage.BackgroundImage")));
            this.ClientImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientImage.Location = new System.Drawing.Point(26, 45);
            this.ClientImage.Name = "ClientImage";
            this.ClientImage.Size = new System.Drawing.Size(50, 50);
            this.ClientImage.TabIndex = 2;
            this.ClientImage.TabStop = false;
            // 
            // UnitImage
            // 
            this.UnitImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UnitImage.BackgroundImage")));
            this.UnitImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UnitImage.Location = new System.Drawing.Point(27, 45);
            this.UnitImage.Name = "UnitImage";
            this.UnitImage.Size = new System.Drawing.Size(50, 50);
            this.UnitImage.TabIndex = 3;
            this.UnitImage.TabStop = false;
            // 
            // LandGroup
            // 
            this.LandGroup.Controls.Add(this.LandImage);
            this.LandGroup.Controls.Add(this.ValueLand);
            this.LandGroup.Controls.Add(this.TitleLand);
            this.LandGroup.Location = new System.Drawing.Point(286, 181);
            this.LandGroup.Name = "LandGroup";
            this.LandGroup.Size = new System.Drawing.Size(240, 142);
            this.LandGroup.TabIndex = 7;
            this.LandGroup.TabStop = false;
            // 
            // LandImage
            // 
            this.LandImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LandImage.BackgroundImage")));
            this.LandImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LandImage.Location = new System.Drawing.Point(26, 45);
            this.LandImage.Name = "LandImage";
            this.LandImage.Size = new System.Drawing.Size(50, 50);
            this.LandImage.TabIndex = 2;
            this.LandImage.TabStop = false;
            // 
            // ValueLand
            // 
            this.ValueLand.AutoSize = true;
            this.ValueLand.Location = new System.Drawing.Point(175, 79);
            this.ValueLand.Name = "ValueLand";
            this.ValueLand.Size = new System.Drawing.Size(24, 17);
            this.ValueLand.TabIndex = 1;
            this.ValueLand.Text = "40";
            this.ValueLand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleLand
            // 
            this.TitleLand.AutoSize = true;
            this.TitleLand.Location = new System.Drawing.Point(159, 33);
            this.TitleLand.Name = "TitleLand";
            this.TitleLand.Size = new System.Drawing.Size(71, 17);
            this.TitleLand.TabIndex = 0;
            this.TitleLand.Text = "عدد الأراضى";
            this.TitleLand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TowerGroup
            // 
            this.TowerGroup.Controls.Add(this.TowerImage);
            this.TowerGroup.Controls.Add(this.ValueTower);
            this.TowerGroup.Controls.Add(this.TitleTower);
            this.TowerGroup.Location = new System.Drawing.Point(28, 181);
            this.TowerGroup.Name = "TowerGroup";
            this.TowerGroup.Size = new System.Drawing.Size(240, 142);
            this.TowerGroup.TabIndex = 8;
            this.TowerGroup.TabStop = false;
            // 
            // TowerImage
            // 
            this.TowerImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TowerImage.BackgroundImage")));
            this.TowerImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TowerImage.Location = new System.Drawing.Point(26, 45);
            this.TowerImage.Name = "TowerImage";
            this.TowerImage.Size = new System.Drawing.Size(50, 50);
            this.TowerImage.TabIndex = 2;
            this.TowerImage.TabStop = false;
            // 
            // ValueTower
            // 
            this.ValueTower.AutoSize = true;
            this.ValueTower.Location = new System.Drawing.Point(175, 79);
            this.ValueTower.Name = "ValueTower";
            this.ValueTower.Size = new System.Drawing.Size(24, 17);
            this.ValueTower.TabIndex = 1;
            this.ValueTower.Text = "30";
            this.ValueTower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleTower
            // 
            this.TitleTower.AutoSize = true;
            this.TitleTower.Location = new System.Drawing.Point(159, 33);
            this.TitleTower.Name = "TitleTower";
            this.TitleTower.Size = new System.Drawing.Size(62, 17);
            this.TitleTower.TabIndex = 0;
            this.TitleTower.Text = "عدد الأبراج";
            this.TitleTower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PieChart
            // 
            this.PieChart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PieChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PieChart.Legends.Add(legend1);
            this.PieChart.Location = new System.Drawing.Point(28, 18);
            this.PieChart.Name = "PieChart";
            this.PieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.PieChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.OliveDrab,
        System.Drawing.Color.Gold};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.Label = "الأراضى";
            dataPoint1.LabelForeColor = System.Drawing.Color.Black;
            dataPoint2.Label = "الأبراج";
            dataPoint2.LabelForeColor = System.Drawing.Color.Black;
            dataPoint3.IsValueShownAsLabel = true;
            dataPoint3.Label = "الوحدات";
            dataPoint3.LabelForeColor = System.Drawing.Color.Black;
            dataPoint4.Label = "العملاء";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            this.PieChart.Series.Add(series1);
            this.PieChart.Size = new System.Drawing.Size(498, 163);
            this.PieChart.TabIndex = 9;
            this.PieChart.Text = "chart1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 754);
            this.Controls.Add(this.ButtonBox);
            this.Controls.Add(this.DataBox);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DataBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.ButtonBox.ResumeLayout(false);
            this.UnitGroup.ResumeLayout(false);
            this.UnitGroup.PerformLayout();
            this.ClientGroup.ResumeLayout(false);
            this.ClientGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitImage)).EndInit();
            this.LandGroup.ResumeLayout(false);
            this.LandGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LandImage)).EndInit();
            this.TowerGroup.ResumeLayout(false);
            this.TowerGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TowerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DataBox;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.PictureBox Image3;
        private System.Windows.Forms.PictureBox Image2;
        private System.Windows.Forms.PictureBox Image1;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button NotificationButton;
        private System.Windows.Forms.GroupBox ButtonBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.GroupBox UnitGroup;
        private System.Windows.Forms.Label ValueUnit;
        private System.Windows.Forms.Label TitleUnit;
        private System.Windows.Forms.GroupBox ClientGroup;
        private System.Windows.Forms.Label ValueClient;
        private System.Windows.Forms.Label TitleClient;
        private System.Windows.Forms.PictureBox ClientImage;
        private System.Windows.Forms.PictureBox UnitImage;
        private System.Windows.Forms.GroupBox TowerGroup;
        private System.Windows.Forms.PictureBox TowerImage;
        private System.Windows.Forms.Label ValueTower;
        private System.Windows.Forms.Label TitleTower;
        private System.Windows.Forms.GroupBox LandGroup;
        private System.Windows.Forms.PictureBox LandImage;
        private System.Windows.Forms.Label ValueLand;
        private System.Windows.Forms.Label TitleLand;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
    }
}