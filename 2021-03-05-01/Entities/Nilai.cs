using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2021_03_05_01.Entities
{
    [Table(name: "Nilai")]
    public class Nilai
    {
        [Key]
        [Column(Order = 1)]
        public string Nim { get; set; } //Key-1
        [Key]
        [Column(Order = 2)]
        public string KodeMk { get; set; } //Key-2
        [Key]
        [Column(Order = 3)]
        public string KodeSemester { get; set; } //Key-3
        public double NilaiAngka { get; set; }
        public string NilaiHuruf { get; set; }
    }
}