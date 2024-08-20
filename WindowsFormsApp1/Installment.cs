using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DBOfAlzahraaProject
{
    [Table("Installment")]
    public class Installment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InstallmentID { get; set; }

        private int _numberOfInstallments;
        [Required]
        public int NumberOfInstallments
        {
            get { return _numberOfInstallments; }
            set
            {
                if (value > 0)
                    _numberOfInstallments = value;
                else _numberOfInstallments = 0;
            }
        }
        private int _numberOfRemainingInstallment;

        public int NumberOfRemainingInstallment {
            get { return _numberOfRemainingInstallment; }
            set
            {
                if (value > 0)
                    _numberOfRemainingInstallment = value;
                else _numberOfRemainingInstallment = 0;
            }
        }

        [ForeignKey("BuyOperation")]
        public int BuyOperationID { get; set; }
        public virtual BuyOperation BuyOperation { get; set; }

        public virtual ICollection<DatesOfInstallment> DatesOfInstallments { get; set; }
    }
}
