using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DBOfAlzahraaProject
{
    [Table("BuyOperation")]
    public class BuyOperation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BuyOperationID { get; set; }

        private int _sellValue;
        public int SellValue
        {
            get { return _sellValue; }
            set { if (value > 0)
                    _sellValue = value;
                else
                    _sellValue = 0;
            }
        }

        
        private DateTime _sellDate;
        [Required]
        [Column(TypeName = "date")]
        public DateTime SellDate
        {
            get { return _sellDate; }
            set
            {
                if (value >= DateTime.Now)
                    _sellDate = value;
                else
                    _sellDate = DateTime.Now;
            }
        }

        [Column(TypeName = "bit")]
        public bool TotalOrPartial { get; set; }


        private int _numberOfSelledUnit;
        public int NumberOfSelledUnit
        {
            get { return _numberOfSelledUnit; }
            set { if (value > 0)
                    _numberOfSelledUnit = value;
                else _numberOfSelledUnit = 0;
            }
        }


        private string _buyMethod;
        [StringLength(30)]
        public string BuyMethod
        {
            get { return _buyMethod; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _buyMethod = value;
                else _buyMethod = null;
            }
        }

        private string _numberofTransfer;
        [StringLength(30)]
        public string NumberofTransfer
        {
            get { return _numberofTransfer; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _numberofTransfer = value;
                else _numberofTransfer = null;
            }
        }


        private string _receverPerson;
        [Required]
        [StringLength(30)]
        public string ReceverPerson
        {
            get { return _receverPerson; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _receverPerson = value;
                else _receverPerson = null;
            }
        }
        [ForeignKey("Project")]
        public int ProjectID { get; set; }

        public virtual Project Project { get; set; }

        [ForeignKey("Client")]
        public int ClientID { get; set; }

        public virtual Client Client { get; set; }

    }
}
