using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Test.Models
{
    [Table("SCR_DEMO")]
    public class test
    {
        [Key]
        public string P_ID { get; set; }
        public string FNAME { get; set; }

        public Nullable<Int32> EDU_ID { get; set; }
        public Nullable<Int32> AGE { get; set; }

      //  [DataType(DataType.Date)]
       [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public string REC_DATE { get; set; }

    }
}