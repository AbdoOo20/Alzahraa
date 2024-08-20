using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DBOfAlzahraaProject
{
    public class Notification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int NotificationID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateTime { get; set; }
    }
}
