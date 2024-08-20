using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DBOfAlzahraaProject
{
    [Table("DatesOfInstallment")]
    public class DatesOfInstallment
    {
        public DatesOfInstallment()
        {
            IsInstallmentPaidForClient=false;
        }

        [Key, Column(Order = 0), ForeignKey("Installment")]
        public int InstallmentID { get; set; }
        public virtual Installment Installment { get; set; }

        private DateTime _dateOfInstallment;
        [Key, Column(Order = 1,TypeName ="date"), Required]
        public DateTime DateOfInstallment
        {
            get { return _dateOfInstallment; }
            set
            {
                if (value >= DateTime.Now)
                    _dateOfInstallment = value;
                else _dateOfInstallment = DateTime.Now;
            }
        }

        [Column(TypeName = "bit")]
        public bool IsInstallmentPaidForClient { get; set; }

        private int _valueofInstallment;
        public int ValueofInstallment
        {
            get { return _valueofInstallment; }
            set
            {
                if (value > 0)
                    _valueofInstallment = value;
                else _valueofInstallment = 0;
            }
        }
    }
}
