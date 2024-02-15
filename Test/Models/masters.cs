using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Test.Models
{
   
        [Table("MASTER")]
        public class masters
        {
            [Key]
         //   public int Id { get; set; }
            public string NAME { get; set; }
            public int INDEX { get; set; }
            public string VALUE { get; set; }


        }

    
}