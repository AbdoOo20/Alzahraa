using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBOfAlzahraaProject
{
    [Table("InstallmentOfProject")]
    public class InstallmentOfProject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InstallmentIDOfProject { get; set; }

        private int _numberOfInstallmentsOfProject;
        [Required]
        public int NumberOfInstallmentsOfProject
        {
            get { return _numberOfInstallmentsOfProject; }
            set
            {
                if (value > 0)
                    _numberOfInstallmentsOfProject = value;
                else _numberOfInstallmentsOfProject = 0;
            }
        }
        private int _numberOfRemainingInstallmentOfProject;

        public int NumberOfRemainingInstallmentOfProject
        {
            get { return _numberOfRemainingInstallmentOfProject; }
            set
            {
                if (value > 0)
                    _numberOfRemainingInstallmentOfProject = value;
                else _numberOfRemainingInstallmentOfProject = 0;
            }
        }

        [ForeignKey("Project")]
        public int ProjectID { get; set; }
        public Project Project { get; set; }

        public virtual ICollection<DatesOfInstallmentOfProject> DatesOfInstallmentOfProjects { get; set; }
    }
}
