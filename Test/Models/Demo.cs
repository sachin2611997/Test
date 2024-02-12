using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Models

{
    [Table("SCR_DEMO")]
    public class Demo
    {
          
        [Key]
        public string P_ID { get; set; }
        public string FNAME { get; set; } 
        public string MNAME{ get; set; } 
        public string LNAME { get; set; }
        public int? AGE { get; set; }
        public string SEX { get; set; }
        [Display(Name = "Education")]
        public int? EDU_ID { get; set; }
        [Display(Name = "Marital Status")]
        public int? MAR_ID { get; set; }
        [Display(Name = "Religion")]
        public int? REL_ID { get; set; }
        [Display(Name = "Occupation")]
        public int? OCC_ID { get; set; }
        public string ADDRESS { get; set; } 
        public int? PINCODE { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? REC_DATE { get; set; }
        
        public int? PHC { get; set; }

        public int? DISTRICT { get; set; }


    }
}