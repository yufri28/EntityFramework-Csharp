using _2021_03_05_01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_03_05_01
{
    class CRUDMahasiswa
    {
        public static SiakdDbContext siakadDb;
        public void tambahDataMahasiswa(Mahasiswa mahasiswa)
        {
            int hasil = 0;
            try
            {
                siakadDb = new SiakdDbContext();

                var listMahasiswa = siakadDb.TableMahasiswa.ToList();

                bool cekData = siakadDb.TableMahasiswa.Any(x => x.Nim == mahasiswa.Nim);

                if (cekData == true)
                {
                    Console.WriteLine("Nim {0} sudah ada pada table mahasiswa", mahasiswa.Nim);
                    Console.ReadKey();
                    return;
                }
                else
                {   
                    siakadDb.TableMahasiswa.Add(mahasiswa);
                    hasil = siakadDb.SaveChanges();
                }

                if (hasil > 0)
                {
                    Console.WriteLine("Data berhasil disimpan");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ada Error. Pesan Error : " + ex.Message);
            }
        }
        public void hapusDataMahasiswa(string nim)
        {
            siakadDb = new SiakdDbContext();
            var listMahasiswa = siakadDb.TableMahasiswa.ToList();
            var cekData = listMahasiswa.Find(x => x.Nim == nim);

            if (cekData != null)
            {
                siakadDb.TableMahasiswa.Remove(cekData);
                siakadDb.SaveChanges();
                Console.WriteLine("Data berhasil dihapus!");
            }
            else 
            {
                Console.WriteLine("Nim {0} tidak ada dalam table mahasiswa", nim);
                Console.ReadKey();
                return;
            }
           

        }
        public void editDataMahasiswa(Mahasiswa mahasiswa)
        {
            siakadDb = new SiakdDbContext();
            var listMahasiswa = siakadDb.TableMahasiswa.ToList();
            var cekData = listMahasiswa.Find(x => x.Nim == mahasiswa.Nim);

            if(cekData != null)
            {
                cekData.Nama = mahasiswa.Nama;
                cekData.Jk = mahasiswa.Jk;
                cekData.Angkatan = mahasiswa.Angkatan;
                cekData.NoHp = mahasiswa.NoHp;
                cekData.Alamat = mahasiswa.Alamat;

                siakadDb.SaveChanges();
                Console.WriteLine("Data Berhasil Diedit");
            }
            else
            {
                Console.WriteLine("Nim {0} tidak ada dalam tabel mahasiswa", mahasiswa.Nim);
                Console.ReadKey();
                return;
            }
        }
    }
}
