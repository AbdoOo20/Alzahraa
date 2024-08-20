
namespace WindowsFormsApp1
{
    partial class Search
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
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FilterSearchCompo = new System.Windows.Forms.ComboBox();
            this.SearchHint = new System.Windows.Forms.Label();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.ClientBox = new System.Windows.Forms.GroupBox();
            this.PhoneValue = new System.Windows.Forms.ComboBox();
            this.ClientPhone = new System.Windows.Forms.Label();
            this.ValueSSN = new System.Windows.Forms.Label();
            this.SSNTitle = new System.Windows.Forms.Label();
            this.ValueClient = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.ProjectBox = new System.Windows.Forms.GroupBox();
            this.ValueOFReminingUnit = new System.Windows.Forms.Label();
            this.ReminingUnitTitle = new System.Windows.Forms.Label();
            this.ValueOFCountUnit = new System.Windows.Forms.Label();
            this.CountUnitTitle = new System.Windows.Forms.Label();
            this.ValueType = new System.Windows.Forms.Label();
            this.TypeTitle = new System.Windows.Forms.Label();
            this.ValueCost = new System.Windows.Forms.Label();
            this.ValueDate = new System.Windows.Forms.Label();
            this.ValueProjectName = new System.Windows.Forms.Label();
            this.CostTitle = new System.Windows.Forms.Label();
            this.ProjectTitle = new System.Windows.Forms.Label();
            this.BuyDate = new System.Windows.Forms.Label();
            this.BaymentBox = new System.Windows.Forms.GroupBox();
            this.ValueSellDate = new System.Windows.Forms.Label();
            this.SellDate = new System.Windows.Forms.Label();
            this.ValueNumberSellUnit = new System.Windows.Forms.Label();
            this.NumberSellUnit = new System.Windows.Forms.Label();
            this.ValueBayTypeProject = new System.Windows.Forms.Label();
            this.BayTypeProject = new System.Windows.Forms.Label();
            this.ValueSell = new System.Windows.Forms.Label();
            this.ValueBayClientName = new System.Windows.Forms.Label();
            this.ValueBuyProjectName = new System.Windows.Forms.Label();
            this.SellTitle = new System.Windows.Forms.Label();
            this.BuyProjectName = new System.Windows.Forms.Label();
            this.BayClientName = new System.Windows.Forms.Label();
            this.BuyMethod = new System.Windows.Forms.Label();
            this.ValueBuyMethod = new System.Windows.Forms.Label();
            this.TransferNumber = new System.Windows.Forms.Label();
            this.ValueTransferNumber = new System.Windows.Forms.Label();
            this.ReceiverPerson = new System.Windows.Forms.Label();
            this.ValueReceiverPerson = new System.Windows.Forms.Label();
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.ClientBox.SuspendLayout();
            this.ProjectBox.SuspendLayout();
            this.BaymentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(35, 106);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(609, 62);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FilterSearchCompo
            // 
            this.FilterSearchCompo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterSearchCompo.FormattingEnabled = true;
            this.FilterSearchCompo.ItemHeight = 16;
            this.FilterSearchCompo.Items.AddRange(new object[] {
            "مشروع",
            "عميل",
            "عملية بيع"});
            this.FilterSearchCompo.Location = new System.Drawing.Point(35, 60);
            this.FilterSearchCompo.Name = "FilterSearchCompo";
            this.FilterSearchCompo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FilterSearchCompo.Size = new System.Drawing.Size(304, 24);
            this.FilterSearchCompo.TabIndex = 1;
            this.FilterSearchCompo.SelectedIndexChanged += new System.EventHandler(this.FilterSearchCompo_SelectedIndexChanged);
            // 
            // SearchHint
            // 
            this.SearchHint.AutoSize = true;
            this.SearchHint.BackColor = System.Drawing.Color.Honeydew;
            this.SearchHint.ForeColor = System.Drawing.Color.SeaGreen;
            this.SearchHint.Location = new System.Drawing.Point(496, 67);
            this.SearchHint.Name = "SearchHint";
            this.SearchHint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SearchHint.Size = new System.Drawing.Size(81, 17);
            this.SearchHint.TabIndex = 2;
            this.SearchHint.Text = "اختر نوع البحث";
            this.SearchHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchBTN
            // 
            this.SearchBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SearchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBTN.ForeColor = System.Drawing.Color.White;
            this.SearchBTN.Location = new System.Drawing.Point(713, 106);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(90, 62);
            this.SearchBTN.TabIndex = 3;
            this.SearchBTN.Text = "بحث";
            this.SearchBTN.UseVisualStyleBackColor = false;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // ClientBox
            // 
            this.ClientBox.Controls.Add(this.PhoneValue);
            this.ClientBox.Controls.Add(this.ClientPhone);
            this.ClientBox.Controls.Add(this.ValueSSN);
            this.ClientBox.Controls.Add(this.SSNTitle);
            this.ClientBox.Controls.Add(this.ValueClient);
            this.ClientBox.Controls.Add(this.ClientName);
            this.ClientBox.ForeColor = System.Drawing.Color.Green;
            this.ClientBox.Location = new System.Drawing.Point(35, 219);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClientBox.Size = new System.Drawing.Size(1044, 105);
            this.ClientBox.TabIndex = 4;
            this.ClientBox.TabStop = false;
            this.ClientBox.Text = "بيانات العميل";
            this.ClientBox.Visible = false;
            // 
            // PhoneValue
            // 
            this.PhoneValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PhoneValue.FormattingEnabled = true;
            this.PhoneValue.Location = new System.Drawing.Point(633, 55);
            this.PhoneValue.Name = "PhoneValue";
            this.PhoneValue.Size = new System.Drawing.Size(121, 24);
            this.PhoneValue.TabIndex = 22;
            // 
            // ClientPhone
            // 
            this.ClientPhone.AutoSize = true;
            this.ClientPhone.Location = new System.Drawing.Point(694, 27);
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClientPhone.Size = new System.Drawing.Size(62, 17);
            this.ClientPhone.TabIndex = 21;
            this.ClientPhone.Text = "أرقام الهاتف";
            // 
            // ValueSSN
            // 
            this.ValueSSN.AutoSize = true;
            this.ValueSSN.Location = new System.Drawing.Point(828, 58);
            this.ValueSSN.Name = "ValueSSN";
            this.ValueSSN.Size = new System.Drawing.Size(46, 17);
            this.ValueSSN.TabIndex = 20;
            this.ValueSSN.Text = "label1";
            // 
            // SSNTitle
            // 
            this.SSNTitle.AutoSize = true;
            this.SSNTitle.Location = new System.Drawing.Point(821, 27);
            this.SSNTitle.Name = "SSNTitle";
            this.SSNTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SSNTitle.Size = new System.Drawing.Size(53, 17);
            this.SSNTitle.TabIndex = 19;
            this.SSNTitle.Text = "رقم الهوية";
            // 
            // ValueClient
            // 
            this.ValueClient.AutoSize = true;
            this.ValueClient.Location = new System.Drawing.Point(953, 58);
            this.ValueClient.Name = "ValueClient";
            this.ValueClient.Size = new System.Drawing.Size(46, 17);
            this.ValueClient.TabIndex = 19;
            this.ValueClient.Text = "label1";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Location = new System.Drawing.Point(945, 27);
            this.ClientName.Name = "ClientName";
            this.ClientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClientName.Size = new System.Drawing.Size(54, 17);
            this.ClientName.TabIndex = 19;
            this.ClientName.Text = "اسم العميل";
            // 
            // ProjectBox
            // 
            this.ProjectBox.Controls.Add(this.ValueOFReminingUnit);
            this.ProjectBox.Controls.Add(this.ReminingUnitTitle);
            this.ProjectBox.Controls.Add(this.ValueOFCountUnit);
            this.ProjectBox.Controls.Add(this.CountUnitTitle);
            this.ProjectBox.Controls.Add(this.ValueType);
            this.ProjectBox.Controls.Add(this.TypeTitle);
            this.ProjectBox.Controls.Add(this.ValueCost);
            this.ProjectBox.Controls.Add(this.ValueDate);
            this.ProjectBox.Controls.Add(this.ValueProjectName);
            this.ProjectBox.Controls.Add(this.CostTitle);
            this.ProjectBox.Controls.Add(this.ProjectTitle);
            this.ProjectBox.Controls.Add(this.BuyDate);
            this.ProjectBox.ForeColor = System.Drawing.Color.Green;
            this.ProjectBox.Location = new System.Drawing.Point(35, 330);
            this.ProjectBox.Name = "ProjectBox";
            this.ProjectBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProjectBox.Size = new System.Drawing.Size(1044, 158);
            this.ProjectBox.TabIndex = 5;
            this.ProjectBox.TabStop = false;
            this.ProjectBox.Text = "بيانات المشروع";
            this.ProjectBox.Visible = false;
            // 
            // ValueOFReminingUnit
            // 
            this.ValueOFReminingUnit.AutoSize = true;
            this.ValueOFReminingUnit.Location = new System.Drawing.Point(796, 121);
            this.ValueOFReminingUnit.Name = "ValueOFReminingUnit";
            this.ValueOFReminingUnit.Size = new System.Drawing.Size(46, 17);
            this.ValueOFReminingUnit.TabIndex = 18;
            this.ValueOFReminingUnit.Text = "label1";
            // 
            // ReminingUnitTitle
            // 
            this.ReminingUnitTitle.AutoSize = true;
            this.ReminingUnitTitle.Location = new System.Drawing.Point(848, 121);
            this.ReminingUnitTitle.Name = "ReminingUnitTitle";
            this.ReminingUnitTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReminingUnitTitle.Size = new System.Drawing.Size(165, 17);
            this.ReminingUnitTitle.TabIndex = 17;
            this.ReminingUnitTitle.Text = "عدد الوحدات المتبقية من المشروع:\r\n";
            // 
            // ValueOFCountUnit
            // 
            this.ValueOFCountUnit.AutoSize = true;
            this.ValueOFCountUnit.Location = new System.Drawing.Point(836, 95);
            this.ValueOFCountUnit.Name = "ValueOFCountUnit";
            this.ValueOFCountUnit.Size = new System.Drawing.Size(46, 17);
            this.ValueOFCountUnit.TabIndex = 16;
            this.ValueOFCountUnit.Text = "label1";
            // 
            // CountUnitTitle
            // 
            this.CountUnitTitle.AutoSize = true;
            this.CountUnitTitle.Location = new System.Drawing.Point(903, 95);
            this.CountUnitTitle.Name = "CountUnitTitle";
            this.CountUnitTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CountUnitTitle.Size = new System.Drawing.Size(110, 17);
            this.CountUnitTitle.TabIndex = 15;
            this.CountUnitTitle.Text = "عدد وحدات المشروع:";
            // 
            // ValueType
            // 
            this.ValueType.AutoSize = true;
            this.ValueType.Location = new System.Drawing.Point(599, 64);
            this.ValueType.Name = "ValueType";
            this.ValueType.Size = new System.Drawing.Size(46, 17);
            this.ValueType.TabIndex = 14;
            this.ValueType.Text = "label1";
            // 
            // TypeTitle
            // 
            this.TypeTitle.AutoSize = true;
            this.TypeTitle.Location = new System.Drawing.Point(587, 33);
            this.TypeTitle.Name = "TypeTitle";
            this.TypeTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TypeTitle.Size = new System.Drawing.Size(69, 17);
            this.TypeTitle.TabIndex = 13;
            this.TypeTitle.Text = "نوع المشروع";
            // 
            // ValueCost
            // 
            this.ValueCost.AutoSize = true;
            this.ValueCost.Location = new System.Drawing.Point(715, 64);
            this.ValueCost.Name = "ValueCost";
            this.ValueCost.Size = new System.Drawing.Size(46, 17);
            this.ValueCost.TabIndex = 12;
            this.ValueCost.Text = "label1";
            // 
            // ValueDate
            // 
            this.ValueDate.AutoSize = true;
            this.ValueDate.Location = new System.Drawing.Point(836, 64);
            this.ValueDate.Name = "ValueDate";
            this.ValueDate.Size = new System.Drawing.Size(46, 17);
            this.ValueDate.TabIndex = 11;
            this.ValueDate.Text = "label1";
            // 
            // ValueProjectName
            // 
            this.ValueProjectName.AutoSize = true;
            this.ValueProjectName.Location = new System.Drawing.Point(958, 64);
            this.ValueProjectName.Name = "ValueProjectName";
            this.ValueProjectName.Size = new System.Drawing.Size(46, 17);
            this.ValueProjectName.TabIndex = 10;
            this.ValueProjectName.Text = "label1";
            // 
            // CostTitle
            // 
            this.CostTitle.AutoSize = true;
            this.CostTitle.Location = new System.Drawing.Point(694, 33);
            this.CostTitle.Name = "CostTitle";
            this.CostTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CostTitle.Size = new System.Drawing.Size(73, 17);
            this.CostTitle.TabIndex = 9;
            this.CostTitle.Text = "تكلفة المشروع";
            // 
            // ProjectTitle
            // 
            this.ProjectTitle.AutoSize = true;
            this.ProjectTitle.Location = new System.Drawing.Point(945, 33);
            this.ProjectTitle.Name = "ProjectTitle";
            this.ProjectTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProjectTitle.Size = new System.Drawing.Size(68, 17);
            this.ProjectTitle.TabIndex = 8;
            this.ProjectTitle.Text = "اسم المشروع";
            // 
            // BuyDate
            // 
            this.BuyDate.AutoSize = true;
            this.BuyDate.Location = new System.Drawing.Point(821, 33);
            this.BuyDate.Name = "BuyDate";
            this.BuyDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BuyDate.Size = new System.Drawing.Size(66, 17);
            this.BuyDate.TabIndex = 7;
            this.BuyDate.Text = "تاريخ الشراء";
            // 
            // BaymentBox
            // 
            this.BaymentBox.Controls.Add(this.ReceiverPerson);
            this.BaymentBox.Controls.Add(this.ValueReceiverPerson);
            this.BaymentBox.Controls.Add(this.TransferNumber);
            this.BaymentBox.Controls.Add(this.ValueTransferNumber);
            this.BaymentBox.Controls.Add(this.BuyMethod);
            this.BaymentBox.Controls.Add(this.ValueBuyMethod);
            this.BaymentBox.Controls.Add(this.ValueSellDate);
            this.BaymentBox.Controls.Add(this.BayClientName);
            this.BaymentBox.Controls.Add(this.SellDate);
            this.BaymentBox.Controls.Add(this.BuyProjectName);
            this.BaymentBox.Controls.Add(this.ValueNumberSellUnit);
            this.BaymentBox.Controls.Add(this.SellTitle);
            this.BaymentBox.Controls.Add(this.NumberSellUnit);
            this.BaymentBox.Controls.Add(this.ValueBuyProjectName);
            this.BaymentBox.Controls.Add(this.ValueBayTypeProject);
            this.BaymentBox.Controls.Add(this.ValueBayClientName);
            this.BaymentBox.Controls.Add(this.BayTypeProject);
            this.BaymentBox.Controls.Add(this.ValueSell);
            this.BaymentBox.ForeColor = System.Drawing.Color.Green;
            this.BaymentBox.Location = new System.Drawing.Point(35, 504);
            this.BaymentBox.Name = "BaymentBox";
            this.BaymentBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BaymentBox.Size = new System.Drawing.Size(1044, 161);
            this.BaymentBox.TabIndex = 6;
            this.BaymentBox.TabStop = false;
            this.BaymentBox.Text = "بيانات عملية البيع";
            this.BaymentBox.Visible = false;
            // 
            // ValueSellDate
            // 
            this.ValueSellDate.AutoSize = true;
            this.ValueSellDate.Location = new System.Drawing.Point(811, 116);
            this.ValueSellDate.Name = "ValueSellDate";
            this.ValueSellDate.Size = new System.Drawing.Size(46, 17);
            this.ValueSellDate.TabIndex = 30;
            this.ValueSellDate.Text = "label1";
            // 
            // SellDate
            // 
            this.SellDate.AutoSize = true;
            this.SellDate.Location = new System.Drawing.Point(946, 116);
            this.SellDate.Name = "SellDate";
            this.SellDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SellDate.Size = new System.Drawing.Size(58, 17);
            this.SellDate.TabIndex = 29;
            this.SellDate.Text = "تاريخ البيع:";
            // 
            // ValueNumberSellUnit
            // 
            this.ValueNumberSellUnit.AutoSize = true;
            this.ValueNumberSellUnit.Location = new System.Drawing.Point(851, 90);
            this.ValueNumberSellUnit.Name = "ValueNumberSellUnit";
            this.ValueNumberSellUnit.Size = new System.Drawing.Size(46, 17);
            this.ValueNumberSellUnit.TabIndex = 28;
            this.ValueNumberSellUnit.Text = "label1";
            // 
            // NumberSellUnit
            // 
            this.NumberSellUnit.AutoSize = true;
            this.NumberSellUnit.Location = new System.Drawing.Point(918, 90);
            this.NumberSellUnit.Name = "NumberSellUnit";
            this.NumberSellUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NumberSellUnit.Size = new System.Drawing.Size(95, 17);
            this.NumberSellUnit.TabIndex = 27;
            this.NumberSellUnit.Text = "رقم الوحده المباعه:";
            // 
            // ValueBayTypeProject
            // 
            this.ValueBayTypeProject.AutoSize = true;
            this.ValueBayTypeProject.Location = new System.Drawing.Point(614, 59);
            this.ValueBayTypeProject.Name = "ValueBayTypeProject";
            this.ValueBayTypeProject.Size = new System.Drawing.Size(46, 17);
            this.ValueBayTypeProject.TabIndex = 26;
            this.ValueBayTypeProject.Text = "label1";
            // 
            // BayTypeProject
            // 
            this.BayTypeProject.AutoSize = true;
            this.BayTypeProject.Location = new System.Drawing.Point(602, 28);
            this.BayTypeProject.Name = "BayTypeProject";
            this.BayTypeProject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BayTypeProject.Size = new System.Drawing.Size(69, 17);
            this.BayTypeProject.TabIndex = 25;
            this.BayTypeProject.Text = "نوع المشروع";
            // 
            // ValueSell
            // 
            this.ValueSell.AutoSize = true;
            this.ValueSell.Location = new System.Drawing.Point(715, 59);
            this.ValueSell.Name = "ValueSell";
            this.ValueSell.Size = new System.Drawing.Size(46, 17);
            this.ValueSell.TabIndex = 24;
            this.ValueSell.Text = "label1";
            // 
            // ValueBayClientName
            // 
            this.ValueBayClientName.AutoSize = true;
            this.ValueBayClientName.Location = new System.Drawing.Point(851, 59);
            this.ValueBayClientName.Name = "ValueBayClientName";
            this.ValueBayClientName.Size = new System.Drawing.Size(46, 17);
            this.ValueBayClientName.TabIndex = 23;
            this.ValueBayClientName.Text = "label1";
            // 
            // ValueBuyProjectName
            // 
            this.ValueBuyProjectName.AutoSize = true;
            this.ValueBuyProjectName.Location = new System.Drawing.Point(973, 59);
            this.ValueBuyProjectName.Name = "ValueBuyProjectName";
            this.ValueBuyProjectName.Size = new System.Drawing.Size(46, 17);
            this.ValueBuyProjectName.TabIndex = 22;
            this.ValueBuyProjectName.Text = "label1";
            // 
            // SellTitle
            // 
            this.SellTitle.AutoSize = true;
            this.SellTitle.Location = new System.Drawing.Point(709, 28);
            this.SellTitle.Name = "SellTitle";
            this.SellTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SellTitle.Size = new System.Drawing.Size(51, 17);
            this.SellTitle.TabIndex = 21;
            this.SellTitle.Text = "تكلفة البيع";
            // 
            // BuyProjectName
            // 
            this.BuyProjectName.AutoSize = true;
            this.BuyProjectName.Location = new System.Drawing.Point(960, 28);
            this.BuyProjectName.Name = "BuyProjectName";
            this.BuyProjectName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BuyProjectName.Size = new System.Drawing.Size(68, 17);
            this.BuyProjectName.TabIndex = 20;
            this.BuyProjectName.Text = "اسم المشروع";
            // 
            // BayClientName
            // 
            this.BayClientName.AutoSize = true;
            this.BayClientName.Location = new System.Drawing.Point(836, 28);
            this.BayClientName.Name = "BayClientName";
            this.BayClientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BayClientName.Size = new System.Drawing.Size(54, 17);
            this.BayClientName.TabIndex = 19;
            this.BayClientName.Text = "اسم العميل";
            // 
            // BuyMethod
            // 
            this.BuyMethod.AutoSize = true;
            this.BuyMethod.Location = new System.Drawing.Point(546, 90);
            this.BuyMethod.Name = "BuyMethod";
            this.BuyMethod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BuyMethod.Size = new System.Drawing.Size(60, 17);
            this.BuyMethod.TabIndex = 31;
            this.BuyMethod.Text = "طريقة الدفع";
            // 
            // ValueBuyMethod
            // 
            this.ValueBuyMethod.AutoSize = true;
            this.ValueBuyMethod.Location = new System.Drawing.Point(552, 121);
            this.ValueBuyMethod.Name = "ValueBuyMethod";
            this.ValueBuyMethod.Size = new System.Drawing.Size(46, 17);
            this.ValueBuyMethod.TabIndex = 32;
            this.ValueBuyMethod.Text = "label1";
            // 
            // TransferNumber
            // 
            this.TransferNumber.AutoSize = true;
            this.TransferNumber.Location = new System.Drawing.Point(358, 90);
            this.TransferNumber.Name = "TransferNumber";
            this.TransferNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TransferNumber.Size = new System.Drawing.Size(61, 17);
            this.TransferNumber.TabIndex = 33;
            this.TransferNumber.Text = "رقم التحويل";
            // 
            // ValueTransferNumber
            // 
            this.ValueTransferNumber.AutoSize = true;
            this.ValueTransferNumber.Location = new System.Drawing.Point(364, 121);
            this.ValueTransferNumber.Name = "ValueTransferNumber";
            this.ValueTransferNumber.Size = new System.Drawing.Size(46, 17);
            this.ValueTransferNumber.TabIndex = 34;
            this.ValueTransferNumber.Text = "label1";
            // 
            // ReceiverPerson
            // 
            this.ReceiverPerson.AutoSize = true;
            this.ReceiverPerson.Location = new System.Drawing.Point(224, 90);
            this.ReceiverPerson.Name = "ReceiverPerson";
            this.ReceiverPerson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReceiverPerson.Size = new System.Drawing.Size(79, 17);
            this.ReceiverPerson.TabIndex = 35;
            this.ReceiverPerson.Text = "الشخص المستلم";
            // 
            // ValueReceiverPerson
            // 
            this.ValueReceiverPerson.AutoSize = true;
            this.ValueReceiverPerson.Location = new System.Drawing.Point(230, 121);
            this.ValueReceiverPerson.Name = "ValueReceiverPerson";
            this.ValueReceiverPerson.Size = new System.Drawing.Size(46, 17);
            this.ValueReceiverPerson.TabIndex = 36;
            this.ValueReceiverPerson.Text = "label1";
            // 
            // LoadingBar
            // 
            this.LoadingBar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.LoadingBar.Location = new System.Drawing.Point(417, 180);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(179, 33);
            this.LoadingBar.Step = 1;
            this.LoadingBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.LoadingBar.TabIndex = 7;
            this.LoadingBar.Visible = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1112, 750);
            this.Controls.Add(this.LoadingBar);
            this.Controls.Add(this.BaymentBox);
            this.Controls.Add(this.ProjectBox);
            this.Controls.Add(this.ClientBox);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.SearchHint);
            this.Controls.Add(this.FilterSearchCompo);
            this.Controls.Add(this.SearchTextBox);
            this.Name = "Search";
            this.Text = "Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Search_Load);
            this.ClientBox.ResumeLayout(false);
            this.ClientBox.PerformLayout();
            this.ProjectBox.ResumeLayout(false);
            this.ProjectBox.PerformLayout();
            this.BaymentBox.ResumeLayout(false);
            this.BaymentBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ComboBox FilterSearchCompo;
        private System.Windows.Forms.Label SearchHint;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.GroupBox ClientBox;
        private System.Windows.Forms.GroupBox ProjectBox;
        private System.Windows.Forms.GroupBox BaymentBox;
        private System.Windows.Forms.Label BuyDate;
        private System.Windows.Forms.Label CostTitle;
        private System.Windows.Forms.Label ProjectTitle;
        private System.Windows.Forms.Label ValueCost;
        private System.Windows.Forms.Label ValueDate;
        private System.Windows.Forms.Label ValueProjectName;
        private System.Windows.Forms.Label ValueType;
        private System.Windows.Forms.Label TypeTitle;
        private System.Windows.Forms.Label ValueOFReminingUnit;
        private System.Windows.Forms.Label ReminingUnitTitle;
        private System.Windows.Forms.Label ValueOFCountUnit;
        private System.Windows.Forms.Label CountUnitTitle;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label ValueClient;
        private System.Windows.Forms.ComboBox PhoneValue;
        private System.Windows.Forms.Label ClientPhone;
        private System.Windows.Forms.Label ValueSSN;
        private System.Windows.Forms.Label SSNTitle;
        private System.Windows.Forms.Label ValueSellDate;
        private System.Windows.Forms.Label BayClientName;
        private System.Windows.Forms.Label SellDate;
        private System.Windows.Forms.Label BuyProjectName;
        private System.Windows.Forms.Label ValueNumberSellUnit;
        private System.Windows.Forms.Label SellTitle;
        private System.Windows.Forms.Label NumberSellUnit;
        private System.Windows.Forms.Label ValueBuyProjectName;
        private System.Windows.Forms.Label ValueBayTypeProject;
        private System.Windows.Forms.Label ValueBayClientName;
        private System.Windows.Forms.Label BayTypeProject;
        private System.Windows.Forms.Label ValueSell;
        private System.Windows.Forms.Label TransferNumber;
        private System.Windows.Forms.Label ValueTransferNumber;
        private System.Windows.Forms.Label BuyMethod;
        private System.Windows.Forms.Label ValueBuyMethod;
        private System.Windows.Forms.Label ReceiverPerson;
        private System.Windows.Forms.Label ValueReceiverPerson;
        private System.Windows.Forms.ProgressBar LoadingBar;
    }
}