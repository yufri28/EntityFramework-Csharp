using _2021_03_05_01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_03_05_01.CRUD
{
    class CRUDMataKuliah
    {
        public static SiakdDbContext siakadDb;
        public void tambahDataMataKuliah(MataKuliah mataKuliah)
        {
            int hasil = 0;
            try
            {
                siakadDb = new SiakdDbContext();
                var listMataKuliah = siakadDb.TableMataKuliah.ToList();
                bool cekData = siakadDb.TableMataKuliah.Any(x => x.KodeMk == mataKuliah.KodeMk);

                if (cekData == true)
                {
                    Console.WriteLine("Kode Mata kuliah {0} sudah ada pada tabel Mata Kuliah", mataKuliah.KodeMk);
                    Console.ReadKey();
                    return;
                }
                else
                {
                    siakadDb.TableMataKuliah.Add(mataKuliah);
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
        public void hapusDataMataKuliah(string kodeMataKuliah)
        {
            siakadDb = new SiakdDbContext();
            var listMataKuliah = siakadDb.TableMataKuliah.ToList();
            var cekData = listMataKuliah.Find(x => x.KodeMk == kodeMataKuliah);

            if (cekData != null)
            {
                siakadDb.TableMataKuliah.Remove(cekData);
                siakadDb.SaveChanges();
                Console.WriteLine("Data berhasil dihapus!");
            }
            else
            {
                Console.WriteLine("Kode Mata Kuliah {0} tidak ada dalam table Mata Kuliah", kodeMataKuliah);
                Console.ReadKey();
                return;
            }


        }
        public void editDataMataKuliah(MataKuliah mataKuliah)
        {
            siakadDb = new SiakdDbContext();
            var listMataKuliah = siakadDb.TableMataKuliah.ToList();
            var cekData = listMataKuliah.Find(x => x.KodeMk == mataKuliah.KodeMk);

            if (cekData != null)
            {
                cekData.NamaMk = mataKuliah.NamaMk;
                cekData.JumlahSks = mataKuliah.JumlahSks;
                siakadDb.SaveChanges();
                Console.WriteLine("Data Berhasil Diedit");
            }
            else
            {
                Console.WriteLine("Kode Mata Kuliah {0} tidak ada dalam table Mata Kuliah", mataKuliah.KodeMk);
                Console.ReadKey();
                return;
            }
        }
    }
}
