using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Test.Models
{
   
        [Table("masters")]
        public class masters
        {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public int Index1 { get; set; }
            public string Value { get; set; }


        }

    
}