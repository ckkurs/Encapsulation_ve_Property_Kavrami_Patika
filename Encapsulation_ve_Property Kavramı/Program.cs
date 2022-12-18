using System;

namespace Encapsulation_ve_Property_Kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci=new ogrenci();
            ogrenci.Isim="Ayşe";
            ogrenci.Soyisim="Yılmaz";
            ogrenci.OgrenciNo=293;
            ogrenci.Sinif=3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifDusur();
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci ogrenci1=new ogrenci("Deniz","Arda",256,1);
            ogrenci.SinifDusur();
            ogrenci.SinifDusur();
            ogrenci.OgrenciBilgileriniGetir();


            
        }
    }

    class ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string  Isim 
        { 
            get { return isim;} 
            set { isim = value; }
        }

        

        //get:ismi return ediyor.
        //set:isme bir value atıyo


        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        {
             get => sinif;
             set 
             {
                 if(value <= 1)
                 {
                    Console.WriteLine("Sınıf En Az 1 olabilir.");
                    sinif=1;
                 }
                 else
                 {
                     sinif=value;
                 }
                 
             }
         
         }

        public ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }


        public ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***** Ögrenci Bilgileri *****");
            Console.WriteLine("Öğrenci Adı  :{0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı   :{0}",this.Soyisim);
            Console.WriteLine("Öğrenci No   :{0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı   :{0}",this.Sinif);

        }

        public void SinifAtlat()
        {
            this.Sinif=this.Sinif+1;
        }

        public void SinifDusur()
        {
            this.Sinif=this.Sinif-1;
        }

       
    }
}          

