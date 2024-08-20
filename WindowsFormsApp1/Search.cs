using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBOfAlzahraaProject;

namespace WindowsFormsApp1
{
    public partial class Search : Form
    {
        ProjectDBContext context = new ProjectDBContext();
        public Search()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.ClientSize.Width, this.ClientSize.Height);
            
            this.Resize += (s, e) =>
            {
                SearchTextBox.Size = new Size((int)(ClientSize.Width / 1.8), ClientSize.Height / 20);
                SearchTextBox.Location = new Point((int)(ClientSize.Width / 35), ClientSize.Height / 10);
                SearchTextBox.Font = new Font("Arial", ClientSize.Width / 80 == 0 ? 10 : ClientSize.Width / 80);
                FilterSearchCompo.Font = new Font("Arial", ClientSize.Width / 80 == 0 ? 10 : ClientSize.Width / 80);
                SearchHint.Font = new Font("Arial", ClientSize.Width / 80 == 0 ? 10 : ClientSize.Width / 80);
                SearchBTN.Font = new Font("Arial", ClientSize.Width / 80 == 0 ? 10 : ClientSize.Width / 80);
                ClientBox.Font = new Font("Arial", ClientSize.Width / 80 == 0 ? 10 : ClientSize.Width / 80);
                ProjectBox.Font = new Font("Arial", ClientSize.Width / 80 == 0 ? 10 : ClientSize.Width / 80);
                BaymentBox.Font = new Font("Arial", ClientSize.Width / 80 == 0 ? 10 : ClientSize.Width / 80);
                ValueDate.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueCost.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueProjectName.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueType.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueOFReminingUnit.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueOFCountUnit.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueClient.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueSSN.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                PhoneValue.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueBuyProjectName.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueBayClientName.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueNumberSellUnit.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueBayTypeProject.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueSellDate.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueSell.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueBuyMethod.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueTransferNumber.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                ValueReceiverPerson.Font = new Font("Arial", ClientSize.Width / 110 == 0 ? 10 : ClientSize.Width / 110);
                FilterSearchCompo.Size = new Size((int)(ClientSize.Width / 4), ClientSize.Height / 20);
                FilterSearchCompo.Location = new Point((int)(ClientSize.Width / 35), ClientSize.Height / 25);
                SearchHint.Location = new Point((int)(ClientSize.Width / 3), ClientSize.Height / 25);
                SearchBTN.Location = new Point((int)(ClientSize.Width / 1.6), ClientSize.Height / 10);
                SearchBTN.Size = new Size((int)(ClientSize.Width / 20), ClientSize.Height / 20);
                ClientBox.Size = new Size((int)(ClientSize.Width / 1.1), ClientSize.Height / 3);
                ClientBox.Location = new Point((int)(ClientSize.Width / 35), ClientSize.Height / 6);
                ProjectBox.Size = new Size((int)(ClientSize.Width / 1.1), (int)(ClientSize.Height / 3.5));
                ProjectBox.Location = new Point((int)(ClientSize.Width / 35), ClientSize.Height / 6);
                BaymentBox.Size = new Size((int)(ClientSize.Width / 1.1), ClientSize.Height / 3);
                BaymentBox.Location = new Point((int)(ClientSize.Width / 35), ClientSize.Height / 6);

                LoadingBar.Location = new Point((int)(ClientSize.Width / 2.3), ClientSize.Height / 2);
                LoadingBar.Size = new Size((int)(ClientSize.Width / 6), ClientSize.Height / 20);
    

                // project
                ProjectTitle.Location = new Point((int)(ClientBox.Width / 1.2), ClientBox.Height / 6);
                ValueProjectName.Location = new Point((int)(ClientBox.Width / 1.2), (int)(ClientBox.Height / 3.2));

                CostTitle.Location = new Point((int)(ClientBox.Width / 1.8), (int)(ClientBox.Height / 6));
                ValueCost.Location = new Point((int)(ClientBox.Width / 1.8), (int)(ClientBox.Height / 3.2));

                BuyDate.Location = new Point((int)(ClientBox.Width / 2.9), (int)(ClientBox.Height / 6));
                ValueDate.Location = new Point((int)(ClientBox.Width / 2.9), (int)(ClientBox.Height / 3.2));

                TypeTitle.Location = new Point((int)(ClientBox.Width / 7.5), (int)(ClientBox.Height / 6));
                ValueType.Location = new Point((int)(ClientBox.Width / 7.5), (int)(ClientBox.Height / 3.2));

                CountUnitTitle.Location = new Point((int)(ClientBox.Width / 1.2), (int)(ClientBox.Height / 2));
                ValueOFCountUnit.Location = new Point((int)(ClientBox.Width / 1.25), (int)(ClientBox.Height / 1.9));

                ReminingUnitTitle.Location = new Point((int)(ClientBox.Width / 1.31), (int)(ClientBox.Height / 1.5));
                ValueOFReminingUnit.Location = new Point((int)(ClientBox.Width / 1.37), (int)(ClientBox.Height / 1.45));

                // client
                ClientName.Location = new Point((int)(ClientBox.Width / 1.2), ClientBox.Height / 6);
                ValueClient.Location = new Point((int)(ClientBox.Width / 1.2), (int)(ClientBox.Height / 3.2));

                SSNTitle.Location = new Point((int)(ClientBox.Width / 1.6), (int)(ClientBox.Height / 6));
                ValueSSN.Location = new Point((int)(ClientBox.Width / 1.6), (int)(ClientBox.Height / 3.2));

                ClientPhone.Location = new Point((int)(ClientBox.Width / 2.5), (int)(ClientBox.Height / 6));
                PhoneValue.Location = new Point((int)(ClientBox.Width / 2.5), (int)(ClientBox.Height / 3.2));
                PhoneValue.Size = new Size((int)(ClientSize.Width / 8), (int)(ClientSize.Height / 8));

                // buy operation
                BuyProjectName.Location = new Point((int)(BaymentBox.Width / 1.2), BaymentBox.Height / 6);
                ValueBuyProjectName.Location = new Point((int)(BaymentBox.Width / 1.2), (int)(BaymentBox.Height / 3.2));

                BayClientName.Location = new Point((int)(ClientBox.Width / 2.9), (int)(ClientBox.Height / 6));
                ValueBayClientName.Location = new Point((int)(ClientBox.Width / 2.9), (int)(ClientBox.Height / 3.2));

                SellTitle.Location = new Point((int)(BaymentBox.Width / 1.8), (int)(BaymentBox.Height / 6));
                ValueSell.Location = new Point((int)(BaymentBox.Width / 1.8), (int)(BaymentBox.Height / 3.2));

                BayTypeProject.Location = new Point((int)(BaymentBox.Width / 7.5), (int)(BaymentBox.Height / 6));
                ValueBayTypeProject.Location = new Point((int)(BaymentBox.Width / 7.5), (int)(BaymentBox.Height / 3.2));

                NumberSellUnit.Location = new Point((int)(BaymentBox.Width / 1.2), (int)(BaymentBox.Height / 2));
                ValueNumberSellUnit.Location = new Point((int)(BaymentBox.Width / 1.25), (int)(BaymentBox.Height / 1.9));

                SellDate.Location = new Point((int)(BaymentBox.Width / 1.14), (int)(BaymentBox.Height / 1.5));
                ValueSellDate.Location = new Point((int)(BaymentBox.Width / 1.4), (int)(BaymentBox.Height / 1.45));

                BuyMethod.Location = new Point((int)(BaymentBox.Width / 1.8), (int)(BaymentBox.Height / 2));
                ValueBuyMethod.Location = new Point((int)(BaymentBox.Width / 1.8), (int)(BaymentBox.Height / 1.6));

                TransferNumber.Location = new Point((int)(ClientBox.Width / 2.9), (int)(ClientBox.Height / 2));
                ValueTransferNumber.Location = new Point((int)(ClientBox.Width / 2.9), (int)(ClientBox.Height / 1.6));

                ReceiverPerson.Location = new Point((int)(BaymentBox.Width / 7.5), (int)(BaymentBox.Height / 2));
                ValueReceiverPerson.Location = new Point((int)(BaymentBox.Width / 7.5), (int)(BaymentBox.Height / 1.6));

            };
        }

        private void Search_Load(object sender, EventArgs e)
        {
            
        }

        private void FilterSearchCompo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterSearchCompo.SelectedIndex == 0)
            {
                SearchHint.Text = "البحث عن طريق: اسم المشروع";
            }
            else if (FilterSearchCompo.SelectedIndex == 1)
            {
                SearchHint.Text = "البحث عن طريق: رقم الهوية";
            }
            if (FilterSearchCompo.SelectedIndex == 2)
            {
                SearchHint.Text = "البحث عن طريق: اسم المشروع المباع";
            }
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            if (FilterSearchCompo.SelectedIndex == -1)
            {
                MessageBox.Show("اختر نوع البحث");
            }
            else if (SearchTextBox.Text.Length == 0)
            {
                MessageBox.Show("أدخل ما تبحث عنه");
            }
            else if (FilterSearchCompo.SelectedIndex == 0 && !SearchTextBox.Text.All(char.IsLetter))
            {
                MessageBox.Show("ادخل اسم المشروع بدون أرقام");
            }
            else if (FilterSearchCompo.SelectedIndex == 2 && !SearchTextBox.Text.All(char.IsLetter))
            {
                MessageBox.Show("ادخل اسم المشروع المباع بدون أرقام");
            }
            else if (FilterSearchCompo.SelectedIndex == 1 && !SearchTextBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("ادخل رقم الهوية عن طريق أرقام و ليس حروف");
            }
            else 
            {
                if (FilterSearchCompo.SelectedIndex == 0) 
                {
                    ClientBox.Visible = false;
                    BaymentBox.Visible = false;
                    ProjectBox.Visible = false;
                    LoadingBar.Visible = true;
                    var data = (from p in context.Projects
                                where p.ProjectName.Contains(SearchTextBox.Text.Trim())
                                select p).FirstOrDefault();
                    if (data != null)
                    {   
                        ProjectBox.Visible = true;
                        ValueDate.Text = data.ProjectDateOfBought.ToString();    
                        ValueProjectName.Text = data.ProjectName.ToString();
                        ValueCost.Text = data.ProjectCost.ToString();
                        ValueType.Text = data.ProjectType == 0 ? "برج" :
                                         data.ProjectType == 1 ? "أرض" :
                                         data.ProjectType == 2 ? "قطعة أرض" :
                                         "محل";
                        ValueOFCountUnit.Text = data.NumberOfUnitsOfProject.ToString();
                        ValueOFReminingUnit.Text = data.NumberOfRemainingUnitsOfProject.ToString();
                        LoadingBar.Visible = false;
                    }
                    if (data == null) 
                    {
                        LoadingBar.Visible = false;
                        MessageBox.Show("لا يوجد مشروع بهذا الاسم");
                    }
                    
                }
                else if (FilterSearchCompo.SelectedIndex == 1)
                {
                    ClientBox.Visible = false;
                    BaymentBox.Visible = false;
                    ProjectBox.Visible = false;
                    LoadingBar.Visible = true;
                    PhoneValue.Items.Clear();
                    var data = (from c in context.Clients
                                where c.SSN == SearchTextBox.Text.Trim()
                                select c).FirstOrDefault();
                    var phone = (from p in context.PhoneNumbers
                                where p.ClientID == data.ClientID
                                select p).ToList();
                    if (data != null)
                    {
                        ClientBox.Visible = true;
                        ValueSSN.Text = data.SSN;
                        ValueClient.Text = data.ClientName;
                        foreach (var item in phone)
                        {
                            PhoneValue.Items.Add(item.ClientPhoneNumber);
                        }
                        LoadingBar.Visible = false;
                    }
                    if (data == null)
                    {
                        LoadingBar.Visible = false;
                        MessageBox.Show("لا يوجد عميل بهذا الاسم");
                    }
                }
                else if (FilterSearchCompo.SelectedIndex == 2)
                {
                    ClientBox.Visible = false;
                    BaymentBox.Visible = false;
                    ProjectBox.Visible = false;
                    LoadingBar.Visible = true;
                    var data = (from b in context.BuyOperations
                                from p in context.Projects
                                from c in context.Clients
                                where p.ProjectName.Contains(SearchTextBox.Text.Trim()) &&
                                      b.ProjectID == p.ProjectID && c.ClientID == b.ClientID
                                select new 
                                { b.SellValue, b.SellDate, b.TotalOrPartial, 
                                  b.NumberOfSelledUnit, p.ProjectName, 
                                  c.ClientName, b.BuyMethod, b.NumberofTransfer, b.ReceverPerson }
                                ).FirstOrDefault();
                    if (data != null)
                    {
                        BaymentBox.Visible = true;
                        ValueBuyProjectName.Text = data.ProjectName;
                        ValueBayClientName.Text = data.ClientName;
                        ValueSell.Text = data.SellValue.ToString();
                        ValueBayTypeProject.Text = data.TotalOrPartial ? "كامل" : "جزئى";
                        ValueNumberSellUnit.Text = data.NumberOfSelledUnit.ToString();
                        ValueSellDate.Text = data.SellDate.ToString();
                        ValueBuyMethod.Text = data.BuyMethod;
                        ValueTransferNumber.Text = data.NumberofTransfer;
                        ValueReceiverPerson.Text = data.ReceverPerson;
                        LoadingBar.Visible = false;
                    }
                    if (data == null)
                    {
                        LoadingBar.Visible = false;
                        MessageBox.Show("لا يوجد عملية بيع تابعه لمشروع بهذا الاسم");
                    }
                }
            }
        }
    }
}
