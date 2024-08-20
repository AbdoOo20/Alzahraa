using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using System.Dynamic;


namespace DBOfAlzahraaProject
{
    [Table("Client")]
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientID { get; set; }

        private string _ssn;
        [RegularExpression(@"^\d{14}$", ErrorMessage = "SSN must be a 14-digit number.")]
        [Required(ErrorMessage = "SSN is required")]
        [StringLength(14, ErrorMessage = "SSN must be exactly 14 digits")]
        public string SSN
        {
            get { return _ssn; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _ssn = value;
                else
                    _ssn = "00000000000000";
            }
        }

        private string _clientName;

        [Required,StringLength(40)]
        public string ClientName
        {
            get { return _clientName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _clientName = value;
                else _clientName = "N/A";
            }
        }

        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
        public virtual ICollection<BuyOperation> BuyOperations { get; set; }

    }
}
