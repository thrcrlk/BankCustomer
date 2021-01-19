using System;

namespace BankCustomer1
{
    class Program
    {
           


        static void Main(string[] args)
        { 
            //Müşteri Tanımlama Kısmı
            CustomerManager MusteriYonetim = new CustomerManager();
            Customer musteri1 = new Customer();
            musteri1.IdNo = 1;
            musteri1.Name = "Ahmet Yılmaz";
            musteri1.BankAccountId = 001;
            musteri1.Balance = 1000;

            Customer musteri2 = new Customer();
            musteri2.IdNo = 2;
            musteri2.Name = "Hasan Diyarlı";
            musteri2.BankAccountId = 002;
            musteri2.Balance = 20000;

            Customer musteri3 = new Customer();
            musteri3.IdNo = 3;
            musteri3.Name = "Semih Yücel";
            musteri3.BankAccountId = 003;
            musteri3.Balance = 1000000;

            //Boş müşteri değişkenleri
            Customer musteri4 = new Customer(); 
            Customer musteri5 = new Customer();
            Customer musteri6 = new Customer();

            Customer[] musteri = new Customer[] { musteri1,musteri2,musteri3,musteri4,musteri5,musteri6 };
           

            while(true)
            {
                Console.WriteLine("Hangi İşlemi Gerçekleştirmek İstersiniz?\n");
                Console.WriteLine("1-Yeni Müşteri Tanımla \n2-Kayıtlı Müşteriyi Sil \n3-Kayıtlı Müşterileri Listele \n4-Çık \n");

            Tekrar:
                int islem = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (islem)
                {
                    case 1: MusteriYonetim.Ekle(musteri);break;
                    case 2: MusteriYonetim.Sil(musteri); break;
                    case 3: MusteriYonetim.Listele(musteri); break;
                    case 4: break;
                    default:
                        Console.WriteLine("Tanımsız Giriş Yaptını Lütfen Tekrar Gerçekleştirmek İstediğiniz İşlemin Numarasını Giriniz\n");
                        goto Tekrar;
                        break;
                }

                if (islem == 4) { break; } //while döngüsünü kırmak için
            }
        }
    }
}
