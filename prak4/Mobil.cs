using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak4
{
    internal class Mobil
    {
        //fields
        private string Warna;
        private string merek;
        private string model;
        private string tahun_keluaran;
        private string kecepatan;
        private string suara;
        private string jumlah_pintu;
        private string Tampilkan_info;

        //properties
        public string warna
        {
            get 
            { 
                return Warna; 
            }
            set
            {
                Warna = value;
            }
        }

        public string merk
        {
            get
            {
                return merek;
            }
            set
            {
                merek = value;
            }
        }

        public string models
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public string year
        {
            get
            {
                return tahun_keluaran;
            }
            set
            {
                tahun_keluaran = value;
            }
        }

        public string gas
        {
            get
            {
                return kecepatan;
            }
            set
            {
                kecepatan = value;
            }
        }

        public string klakson
        {
            get
            {
                return suara;
            }
            set
            {
                suara = value;
            }
        }

        public string pintu
        {
            get
            {
                return jumlah_pintu;
            }
            set
            {
                jumlah_pintu = value;
            }
        }

        public string tampilkan_info
        {
            get
            {
                return Tampilkan_info;
            }
            set
            {
                Tampilkan_info = value;
            }
        }
  
        public void mobil()
        {
            Console.WriteLine("warna : {0}", warna);
            Console.WriteLine("merek : {0}", merk);
            Console.WriteLine("model : {0}", models);
            Console.WriteLine("tahun keluaran : {0}", year);
            Console.WriteLine($"Mobil {models}, berjalan dengan kecepatan : {gas}", gas);
            Console.WriteLine("suara klakson : {0}", klakson);
            Console.WriteLine("jumlah pintu : {0}", pintu);
            Console.WriteLine($"Mobil saya berwarna {warna}, merek {merk}, model {models}, keluaran tahun {year}, dengan jumlah pintu sebanyak {pintu}", tampilkan_info);
        }
    }
}
