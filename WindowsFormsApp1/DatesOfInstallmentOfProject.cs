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
    [Table("DatesOfInstallmentOfProject")]
    public class DatesOfInstallmentOfProject
    {
        public DatesOfInstallmentOfProject()
        {
            IsInstallmentPaidForProject = false;
        }

        [Key, Column(Order = 0), ForeignKey("InstallmentOfProject")]
        public int InstallmentIDOfProject { get; set; }
        public  InstallmentOfProject InstallmentOfProject { get; set; }

        private DateTime _dateOfInstallmentOfProject;
        [Key, Column(Order = 1,TypeName ="date"), Required]
        public DateTime DateOfInstallmentOfProject
        {
            get { return _dateOfInstallmentOfProject; }
            set
            {
                if (value >= DateTime.Now)
                    _dateOfInstallmentOfProject = value;
                else _dateOfInstallmentOfProject = DateTime.Now;
            }
        }

        [Column(TypeName = "bit")]
        public bool IsInstallmentPaidForProject { get; set; }

        private int _valueofInstallmentOfProject;
        public int ValueofInstallmentOfProject
        {
            get { return _valueofInstallmentOfProject; }
            set
            {
                if (value > 0)
                    _valueofInstallmentOfProject = value;
                else _valueofInstallmentOfProject = 0;
            }
        }
    }
}
