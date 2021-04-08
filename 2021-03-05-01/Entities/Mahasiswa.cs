using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2021_03_05_01.Entities
{
    [Table(name: "Mahasiswa")]
    public class Mahasiswa
    {
        [Key]
        public string Nim { get; set; } //Key

        [Required]
        [StringLength(100)]
        public string Nama { get; set; }

        public bool Jk { get; set; }

        [Range(2000, 2030)]
        public int Angkatan { get; set; }
        public string NoHp { get; set; }
        public string Alamat { get; set; }
    }
}