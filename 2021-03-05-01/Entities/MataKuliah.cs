using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2021_03_05_01.Entities
{
    [Table(name: "MataKuliah")]
    public class MataKuliah
    {
        [Key]
        public string KodeMk { get; set; } //Key
        [Required]
        public string NamaMk { get; set; }
        [Range(0, 5)]
        public int JumlahSks { get; set; }
    }
}