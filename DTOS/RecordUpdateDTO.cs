using Test.Models;
using System.ComponentModel.DataAnnotations;

namespace Test.DTOS
{
    public class RecordUpdateDTO
    {
        
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        [Range(1, 99)]
        public int Age { get; set; }
        [Required]
        [Range(0, 3)]
        public HouseEnum House { get; set; }
    }
}