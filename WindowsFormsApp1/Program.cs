
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBOfAlzahraaProject;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*ProjectDBContext context = new ProjectDBContext();
            Project newProject = new Project() 
            {
                NumberOfRemainingUnitsOfProject = 4,
                NumberOfUnitsOfProject = 7,
                ProjectCost = 3000000,
                ProjectDateOfBought = DateTime.Now,
                ProjectName = "Elzahraa",
                ProjectType = 1,
            };
            context.Projects.Add(newProject);
            context.SaveChanges();
            Client newClient = new Client()
            {
                ClientName = "Elmstreh",
                SSN = "12345671234567",
            };
            context.Clients.Add(newClient);
            context.SaveChanges();
            PhoneNumber newPhone = new PhoneNumber()
            {
                ClientPhoneNumber = "01018754602",
                ClientID = 1,
            };
            context.PhoneNumbers.Add(newPhone);
            context.SaveChanges();
            BuyOperation newBuy = new BuyOperation()
            {
                BuyMethod = "Cash",
                NumberOfSelledUnit = 25,
                NumberofTransfer = "12345678909876",
                ReceverPerson = "Hamo",
                SellDate = DateTime.Now,
                SellValue = 1000000,
                TotalOrPartial = true,
                ClientID = 1,
                ProjectID = 1,
            };
            context.BuyOperations.Add(newBuy);
            context.SaveChanges();*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Search());
        }
    }
}
