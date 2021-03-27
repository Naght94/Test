using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Record
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string LastName { get; set; }
        [MaxLength(2)]
        public int Age { get; set; }
        public string House { get; set; }
    }
}