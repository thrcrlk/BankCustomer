using System;
using System.Collections.Generic;
using System.Text;

namespace BankCustomer1
{
    class CustomerManager
    {
        string ad;
        int Id;
        int BankId;
        int Balance;
        int i=0;
        public void Ekle(Customer[] x)
        {

            for (i = 0; i <=5; i++)
            {
                if (x[i].Name != null) { }
                else if (x[i].Name != null & i == 5) { Console.WriteLine("Banka Hesap Hafızası Dolu");break; }
                else 
                {
                    Console.WriteLine("Musteri kimlik numarasını giriniz");
                    Id = Convert.ToInt32(Console.ReadLine());
                    x[i].IdNo = Id;
                    Console.WriteLine("Musteri adını girini");
                    ad = Console.ReadLine();
                    x[i].Name = ad;
                    Console.WriteLine("Banka hesap numarasını giriniz");
                    BankId = Convert.ToInt32(Console.ReadLine());
                    x[i].BankAccountId = BankId;
                    Console.WriteLine("Musteri bakiyesini giriniz");
                    Balance = Convert.ToInt32(Console.ReadLine());
                    x[i].Balance = Balance; ; 
                    break; 
                }
            }

            
        }
        public void Sil(Customer[] x)
        {
            Console.WriteLine("Musteri Id sini giriniz\n");
            Id = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <=5; i++)
            {
                if (x[i].IdNo != Id&i==5) { Console.WriteLine("Musteri Id si tanımlı değil\n"); }
                else if (x[i].IdNo== Id)
                {
                    x[i].IdNo = Convert.ToInt32(null);
                    x[i].Name = null;
                    x[i].BankAccountId = Convert.ToInt32(null);
                    x[i].Balance = Convert.ToInt32(null);
                    Console.WriteLine("Musteri Silme İşlemi Başarılıdır\n");break;
                }
            }


        }

        public void Listele(Customer[] x)
        {
            foreach (Customer Musteri in x)
            {
                if (Musteri.Name != null)
                {
                    Console.WriteLine("------" + "Musteri " + Musteri.IdNo + "------\n");
                    Console.WriteLine(Musteri.IdNo);
                    Console.WriteLine(Musteri.Name);
                    Console.WriteLine(Musteri.BankAccountId);
                    Console.WriteLine(Musteri.Balance);
                    Console.WriteLine("------------------------------------\n");
               
                }
                else { }
            }


        }

    }
}
