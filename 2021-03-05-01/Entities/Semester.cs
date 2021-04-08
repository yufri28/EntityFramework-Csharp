using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2021_03_05_01.Entities
{
    [Table(name:"Semester")]
    public class Semester
    {
        [Key]
        public string KodeSemester { get; set; } //Key
        [Required]
        public string NamaSemester { get; set; }
        [Range(2000, 2030)]
        public int TahunAjaran { get; set; }
    }
}