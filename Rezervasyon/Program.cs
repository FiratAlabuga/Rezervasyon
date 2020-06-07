
using System;
using System.Collections.Generic;

namespace Maas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oğulcan Kaya");
            Console.WriteLine("G-180100080");

            int ID;
            Console.WriteLine("Personel ID Giriniz");
            List<int> PersonelList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                ID = int.Parse(Console.ReadLine());
                PersonelList.Add(ID);  
            }

            int aranaIndex = MaasZammi(PersonelList.IndexOf(2));
            Console.WriteLine("Maaşa Zam Yapılmıştır :"+aranaIndex);

            static int MaasZammi(int id)
            {

                int MaasBaslangic = 100;

                switch (id)
                {
                    case 1:
                        MaasBaslangic += 10;
                        
                        goto case 2; 
                    case 2:
                        return MaasBaslangic * 10;
                    default:
                        return MaasBaslangic;
                }
            }
        }
    }
}
