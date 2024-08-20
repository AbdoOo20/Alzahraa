using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace DBOfAlzahraaProject
{
    [Table("Project")]
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }
        
        private int? _projctCost;

        public int? ProjectCost
        {
            get
            { return _projctCost; }
            set
            {
                if (value > 0)
                    _projctCost = value;
                else _projctCost = 0;
            }
        }

        private int _ProjectType;
        [Range(0, 3)]// tower = 0, land = 1 apartment = 2, shop = 3
        public int ProjectType
        {
            get { return _ProjectType; }
            set
            {
                if (value>=0 && value <= 3)
                    _ProjectType = value;
                else
                    _ProjectType = 0;
            }
        }
        
        private DateTime _projectDateOfBought;

        [Column(TypeName = "date")]
        public DateTime ProjectDateOfBought 
        {
            get { return _projectDateOfBought; }
            set
            {
                if (value >= DateTime.Now)
                    _projectDateOfBought = value;
                else _projectDateOfBought = DateTime.Now;
            }
        }

        private int _numberOfUnitsOfProject;
        public int NumberOfUnitsOfProject
        {
            get { return _numberOfUnitsOfProject; }
            set
            {
                if (value > 0)
                    _numberOfUnitsOfProject = value;
                else _numberOfUnitsOfProject = 0;
            }
        }
        
        private int _numberOfRemainingUnitsOfProject;
        public int NumberOfRemainingUnitsOfProject
        {
            get { return _numberOfRemainingUnitsOfProject; }
            set
            {
                if (value > 0)
                    _numberOfRemainingUnitsOfProject = value;
                else _numberOfRemainingUnitsOfProject = 0;
            }
        }

        private string _projectName;
        [Required, StringLength(30)]
        public string ProjectName
        {
            get { return _projectName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _projectName = value;
                else _projectName = "Project N. " + ProjectID;
            }
        }

        public virtual ICollection<BuyOperation> BuyOperations { get; set; }
    }
}
