using _2021_03_05_01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_03_05_01.CRUD
{
    class CRUDNilai
    {
        public static SiakdDbContext siakadDb;
        public void tambahDataNilai(Nilai nilai)
        {
            int hasil = 0;
            try
            {
                siakadDb = new SiakdDbContext();
                var listNilai = siakadDb.TableNilai.ToList();
                bool cekDataNIM = siakadDb.TableNilai.Any(x => x.Nim == nilai.Nim);
                bool cekDataMK = siakadDb.TableNilai.Any(x => x.KodeMk == nilai.KodeMk);
                bool cekDataSemester = siakadDb.TableNilai.Any(x => x.KodeSemester == nilai.KodeSemester);

                if ((cekDataNIM == true && cekDataMK == true) && cekDataSemester == true)
                {
                    Console.WriteLine("Data nilai sudah ada dalam table Nilai");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    siakadDb.TableNilai.Add(nilai);
                    hasil = siakadDb.SaveChanges();
                }

                if (hasil > 0)
                {
                    Console.WriteLine("Data nilai berhasil disimpan");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ada Error. Pesan Error : " + ex.Message);
            }
        }
        public void hapusDataNilai(string NIM, string kodeMK, string kodeSemester)
        {
            siakadDb = new SiakdDbContext();
            var listNilai = siakadDb.TableNilai.ToList();
            var cekDataNIM = listNilai.Find(x => x.Nim == NIM);
            var cekDataMK = listNilai.Find(x => x.KodeMk == kodeMK);
            var cekDataSemester = listNilai.Find(x => x.KodeSemester == kodeSemester);

            if ((cekDataNIM != null && cekDataMK != null) && cekDataSemester != null)
            {
                siakadDb.TableNilai.Remove(cekDataNIM);
                siakadDb.SaveChanges();
                Console.WriteLine("Data berhasil dihapus!");
            }
            else
            {
                Console.WriteLine("Data nilai tidak ada dalam table Nilai");
                Console.ReadKey();
                return;
            }


        }
        public void editDataNilai(Nilai nilai)
        {
            siakadDb = new SiakdDbContext();
            var listNilai = siakadDb.TableNilai.ToList();
            var cekDataNIM = listNilai.Find(x => x.Nim == nilai.Nim);
            var cekDataMK = listNilai.Find(x => x.KodeMk == nilai.KodeMk);
            var cekDataSemester = listNilai.Find(x => x.KodeSemester == nilai.KodeSemester);
            if ((cekDataNIM != null && cekDataMK != null) && cekDataSemester != null)
            {
                cekDataNIM.NilaiAngka = nilai.NilaiAngka;
                cekDataNIM.NilaiHuruf = nilai.NilaiHuruf;
                siakadDb.SaveChanges();
                Console.WriteLine("Data Berhasil Diedit");
            }
            else
            {
                Console.WriteLine("Data nilai tidak ada dalam tabel Nilai");
                Console.ReadKey();
                return;
            }
        }
    }
}
