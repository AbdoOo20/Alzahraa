using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBOfAlzahraaProject
{
    [Table("PhoneNumber")]
    public class PhoneNumber
    {

        [Key, Column(Order = 0), ForeignKey("Client")]
        public int ClientID { get; set; }

        private string _clientPhoneNumber;
        [Key,Column(Order =1),Required,StringLength(11)]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Phone Number must be a 11-digit number")]
        public string ClientPhoneNumber {
            get { return _clientPhoneNumber; }
            set { _clientPhoneNumber = value; }
        }

        public virtual Client Client { get; set; }
    }
}
