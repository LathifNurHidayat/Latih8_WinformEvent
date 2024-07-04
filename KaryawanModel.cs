using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih8_WinformEvent
{
    public class KaryawanModel
    {
        

        public KaryawanModel (string nik, string nama, DateTime tglLahir, string gender, string alamat, string job)
        {
             NIK = nik;
             Nama = nama;
            TglLahir = tglLahir;
            Gender = gender;
            Alamat = alamat;
            Job = job;
        }
        public string NIK { get; set; }
        public string Nama {  get; set; }
        public DateTime TglLahir { get; set; }
        public string Gender { get; set; }
        public string Alamat { get; set; }
        public string Job { get; set; }
    }
}
