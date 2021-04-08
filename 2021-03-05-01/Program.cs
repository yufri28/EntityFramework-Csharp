using _2021_03_05_01.CRUD;
using _2021_03_05_01.Entities;
using System;
using System.Linq;

namespace _2021_03_05_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("\t\tNama : Yufridon C. Luttu");
            Console.WriteLine("\t\tNIM : 1906080070\n");
            

            Console.WriteLine(" Pilihan Entititas : \n");
            Console.WriteLine(" 1. Mahasiswa ");
            Console.WriteLine(" 2. Semester ");
            Console.WriteLine(" 3. Mata Kuliah ");
            Console.WriteLine(" 4. Nilai \n");

            Console.WriteLine(" Masukan pilihan 1, 2, 3 atau 4 \n");
            Console.Write(" Pilihan : ");
            int pilihan = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if(pilihan == 1)
            {
                Console.WriteLine(" CRUD Data Mahasiswa \n");
                Console.WriteLine(" Pilihan Perintah : \n");
                Console.WriteLine(" 1. Tambah Data ");
                Console.WriteLine(" 2. Edit Data ");
                Console.WriteLine(" 3. Hapus Data \n");

                CRUDMahasiswa DataMhs = new CRUDMahasiswa();
                Mahasiswa DataMahasiswa = new Mahasiswa();
                string Nim = "";
                string Nama = "";
                bool Jk = false;
                int Angkatan = 0;
                string NoHp = "";
                string Alamat = "";

                Console.WriteLine(" Masukan pilihan 1, 2 atau 3 \n");
                Console.Write(" Perintah : ");
                int perintah = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if(perintah == 1)
                {
                    
                    Console.WriteLine(" Tambah Data \n");
                    Console.Write(" Nim : ");
                    Nim = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Nama : ");
                    Nama = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Jenis Kelamin (true = Laki-Laki & false = Perempuan) : ");
                    Jk = bool.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write(" Angkatan : ");
                    Angkatan = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write(" No Hp : ");
                    NoHp = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Alamat : ");
                    Alamat = Console.ReadLine();
                    Console.WriteLine();

                    DataMahasiswa.Nim = Nim;
                    DataMahasiswa.Nama = Nama;
                    DataMahasiswa.Jk = Jk;
                    DataMahasiswa.Angkatan = Angkatan;
                    DataMahasiswa.NoHp = NoHp;
                    DataMahasiswa.Alamat = Alamat;
                    DataMhs.tambahDataMahasiswa(DataMahasiswa);
                }
                else if (perintah == 2)
                {
                    Console.WriteLine(" Edit Data \n");
                    Console.Write(" Nim : ");
                    Nim = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Nama : ");
                    Nama = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Jenis Kelamin (true = Laki-Laki & false = Perempuan) : ");
                    Jk = bool.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write(" Angkatan : ");
                    Angkatan = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write(" No Hp : ");
                    NoHp = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Alamat : ");
                    Alamat = Console.ReadLine();
                    Console.WriteLine();
                    DataMahasiswa.Nim = Nim;
                    DataMahasiswa.Nama = Nama;
                    DataMahasiswa.Jk = Jk;
                    DataMahasiswa.Angkatan = Angkatan;
                    DataMahasiswa.NoHp = NoHp;
                    DataMahasiswa.Alamat = Alamat;
                    DataMhs.editDataMahasiswa(DataMahasiswa);
                }else if(perintah == 3)
                {
                    Console.WriteLine(" Hapus Data \n");
                    Console.Write(" Nim : ");
                    Nim = Console.ReadLine();
                    DataMhs.hapusDataMahasiswa(Nim);
                }
                else
                {
                    Console.WriteLine(" Error : 404 (Not Found) ");
                }

            }
            else if(pilihan == 2)
            {
                Console.WriteLine(" CRUD Data Semester \n");
                Console.WriteLine(" Pilihan Perintah : \n");
                Console.WriteLine(" 1. Tambah Data ");
                Console.WriteLine(" 2. Edit Data ");
                Console.WriteLine(" 3. Hapus Data \n");

                CRUDSemester DataSemester = new CRUDSemester();
                Semester dataSemester = new Semester();
                string kode_semester = "";
                string nama_semester = "";
                int tahun_ajaran = 0;

                dataSemester.KodeSemester = kode_semester;
                dataSemester.NamaSemester = nama_semester;
                dataSemester.TahunAjaran = tahun_ajaran;


                Console.WriteLine(" Masukan pilihan 1, 2 atau 3 \n");
                Console.Write(" Perintah : ");
                int perintah = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (perintah == 1)
                {

                    Console.WriteLine(" Tambah Data \n");
                    Console.Write(" Kode Semester : ");
                    kode_semester = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Nama Semester : ");
                    nama_semester = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Tahun Ajaran : ");
                    tahun_ajaran = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    

                    dataSemester.KodeSemester = kode_semester;
                    dataSemester.NamaSemester = nama_semester;
                    dataSemester.TahunAjaran = tahun_ajaran;
                    
                    DataSemester.tambahDataSemester(dataSemester);
                }
                else if (perintah == 2)
                {
                    Console.WriteLine(" Edit Data \n");
                    Console.Write(" Kode Semester : ");
                    kode_semester = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Nama Semester : ");
                    nama_semester = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Tahun Ajaran : ");
                    tahun_ajaran = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    dataSemester.KodeSemester = kode_semester;
                    dataSemester.NamaSemester = nama_semester;
                    dataSemester.TahunAjaran = tahun_ajaran;
                    DataSemester.editDataSemester(dataSemester);
                }
                else if (perintah == 3)
                {
                    Console.WriteLine(" Hapus Data \n");
                    Console.Write(" Kode Semester : ");
                    kode_semester = Console.ReadLine();
                    Console.WriteLine();
                    DataSemester.hapusDataSemester(kode_semester);
                }
                else
                {
                    Console.WriteLine(" Error : 404 (Not Found) ");
                }

            }
            else if (pilihan == 3)
            {
                Console.WriteLine(" CRUD Data Mata Kuliah \n");
                Console.WriteLine(" Pilihan Perintah : \n");
                Console.WriteLine(" 1. Tambah Data ");
                Console.WriteLine(" 2. Edit Data ");
                Console.WriteLine(" 3. Hapus Data \n");

                CRUDMataKuliah DataMataKuliah = new CRUDMataKuliah();
                MataKuliah dataMataKuliah = new MataKuliah();
                string kode_MK = "";
                string nama_MK = "";
                int jumlah_SKS = 0;

                dataMataKuliah.KodeMk = kode_MK;
                dataMataKuliah.NamaMk = nama_MK;
                dataMataKuliah.JumlahSks = jumlah_SKS;

                Console.WriteLine(" Masukan pilihan 1, 2 atau 3 \n");
                Console.Write(" Perintah : ");
                int perintah = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (perintah == 1)
                {
                    Console.WriteLine(" Tambah Data \n");
                    Console.Write(" Kode Mata Kuliah : ");
                    kode_MK = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Nama Mata Kuliah : ");
                    nama_MK = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Jumlah SKS : ");
                    jumlah_SKS = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    dataMataKuliah.KodeMk = kode_MK;
                    dataMataKuliah.NamaMk = nama_MK;
                    dataMataKuliah.JumlahSks = jumlah_SKS;
                    DataMataKuliah.tambahDataMataKuliah(dataMataKuliah);
                }
                else if (perintah == 2)
                {
                    Console.WriteLine(" Edit Data \n");
                    Console.Write(" Kode Mata Kuliah : ");
                    kode_MK = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Nama Mata Kuliah : ");
                    nama_MK = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Jumlah SKS : ");
                    jumlah_SKS = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    dataMataKuliah.KodeMk = kode_MK;
                    dataMataKuliah.NamaMk = nama_MK;
                    dataMataKuliah.JumlahSks = jumlah_SKS;
                    DataMataKuliah.editDataMataKuliah(dataMataKuliah);
                }
                else if (perintah == 3)
                {
                    Console.WriteLine(" Hapus Data \n");
                    Console.Write(" Kode Mata Kuliah : ");
                    kode_MK = Console.ReadLine();
                    Console.WriteLine();
                    DataMataKuliah.hapusDataMataKuliah(kode_MK);
                }
                else
                {
                    Console.WriteLine(" Error : 404 (Not Found) ");
                }
            }
            else if(pilihan == 4)
            {
                Console.WriteLine(" CRUD Data Nilai \n");
                Console.WriteLine(" Pilihan Perintah : \n");
                Console.WriteLine(" 1. Tambah Data ");
                Console.WriteLine(" 2. Edit Data ");
                Console.WriteLine(" 3. Hapus Data \n");

                CRUDNilai CrudNilai = new CRUDNilai();
                Nilai nilai = new Nilai();
                string Nim = "";
                string kodeMk = "";
                string kodeSemester = "";
                double nilaiAngka = 0;
                string nilaiHuruf = "";

                

                Console.WriteLine(" Masukan pilihan 1, 2 atau 3 \n");
                Console.Write(" Perintah : ");
                int perintah = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (perintah == 1)
                {
                    Console.WriteLine(" Tambah Data \n");
                    Console.Write(" NIM : ");
                    Nim = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Kode Mata Kuliah : ");
                    kodeMk = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Kode Semester : ");
                    kodeSemester = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Nilai Angka : ");
                    nilaiAngka = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write(" Nilai Huruf : ");
                    nilaiHuruf = Console.ReadLine();
                    Console.WriteLine();

                    nilai.Nim = Nim;
                    nilai.KodeMk = kodeMk;
                    nilai.KodeSemester = kodeSemester;
                    nilai.NilaiAngka = nilaiAngka;
                    nilai.NilaiHuruf = nilaiHuruf;
                    CrudNilai.tambahDataNilai(nilai);
                }
                else if(perintah == 2)
                {
                    Console.WriteLine(" Edit Data \n");
                    Console.Write(" NIM : ");
                    Nim = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Kode Mata Kuliah : ");
                    kodeMk = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Kode Semester : ");
                    kodeSemester = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Nilai Angka : ");
                    nilaiAngka = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write(" Nilai Huruf : ");
                    nilaiHuruf = Console.ReadLine();
                    Console.WriteLine();

                    nilai.Nim = Nim;
                    nilai.KodeMk = kodeMk;
                    nilai.KodeSemester = kodeSemester;
                    nilai.NilaiAngka = nilaiAngka;
                    nilai.NilaiHuruf = nilaiHuruf;
                    CrudNilai.editDataNilai(nilai);
                }
                else if (perintah == 3)
                {
                    Console.WriteLine(" Hapus Data \n");
                    Console.Write(" NIM : ");
                    Nim = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Kode Mata Kuliah : ");
                    kodeMk = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(" Kode Semester : ");
                    kodeSemester = Console.ReadLine();
                    Console.WriteLine();
                    CrudNilai.hapusDataNilai(Nim, kodeMk, kodeSemester);

                }
                else
                {
                    Console.WriteLine(" Error : 404 (Not Found) ");
                }
            }
            else
            {
                Console.WriteLine(" Error : 404 (Not Found) ");
            }
            Console.ReadKey();
        }
    }
}