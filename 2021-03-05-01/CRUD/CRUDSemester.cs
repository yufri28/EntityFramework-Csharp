using _2021_03_05_01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_03_05_01.CRUD
{
    class CRUDSemester
    {
        public static SiakdDbContext siakadDb;
        public void tambahDataSemester(Semester semester)
        {
            int hasil = 0;
            try
            {
                siakadDb = new SiakdDbContext();
                var listSemester= siakadDb.TableSemester.ToList();
                bool cekData = siakadDb.TableSemester.Any(x => x.KodeSemester == semester.KodeSemester);

                if (cekData == true)
                {
                    Console.WriteLine("Kode Semester {0} sudah ada pada table Semester", semester.KodeSemester);

                    Console.ReadKey();

                    return;
                }
                else
                {
                    siakadDb.TableSemester.Add(semester);
                    hasil = siakadDb.SaveChanges();
                }

                if (hasil > 0)
                {
                    Console.WriteLine("Data semester berhasil disimpan");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ada Error. Pesan Error : " + ex.Message);
            }
        }
        public void hapusDataSemester(string kodeSemester)
        {
            siakadDb = new SiakdDbContext();
            var listSemester = siakadDb.TableSemester.ToList();
            var cekData = listSemester.Find(x => x.KodeSemester == kodeSemester);

            if (cekData != null)
            {
                siakadDb.TableSemester.Remove(cekData);
                siakadDb.SaveChanges();
                Console.WriteLine("Data berhasil dihapus!");
            }
            else
            {
                Console.WriteLine("Nim {0} tidak ada dalam table semester", kodeSemester);
                Console.ReadKey();
                return;
            }


        }
        public void editDataSemester(Semester semester)
        {
            siakadDb = new SiakdDbContext();
            var listSemester = siakadDb.TableSemester.ToList();
            var cekData = listSemester.Find(x => x.KodeSemester == semester.KodeSemester);

            if (cekData != null)
            {
                cekData.NamaSemester = semester.NamaSemester;
                cekData.TahunAjaran = semester.TahunAjaran;
                siakadDb.SaveChanges();
                Console.WriteLine("Data Berhasil Diedit");
            }
            else
            {
                Console.WriteLine("Kode Semester {0} tidak ada dalam tabel semester", semester.KodeSemester);
                Console.ReadKey();
                return;
            }
        }
    }
}
