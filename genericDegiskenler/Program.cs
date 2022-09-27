using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericDegiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = { 100, 200, 300, 250, 75 };
            foreach (var item in sayilar)
            {
                Console.WriteLine("Sayı: " + item);
            }
            Console.WriteLine("*********************************");

            //ArrayList tip korumalı değildir.

            ArrayList sayilar2=new ArrayList();
            Console.WriteLine("Yeni Sayi: ");
            int sayi =Convert.ToInt32(Console.ReadLine());
            sayilar2.Add(sayi);
            sayilar2.Add(100);
            sayilar2.Add(500);
            sayilar2.RemoveAt(1);
            sayilar2.Add("Elma");
            foreach (var item in sayilar2)
            {
                Console.WriteLine(item);
            }

            //List tip korumalıdır.

            Console.WriteLine("*********************************");
            List<object> sayilar3 = new List<object>();
            sayilar3.Add(255);
            sayilar3.Add(1235);
            foreach (var item in sayilar3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*********************************");
            List<personel> pList = new List<personel>();    

            personel p1=new personel();
            p1.ad = "Mustafa";
            p1.soyad = "Taşkıran";
            p1.id =1;
            pList.Add(p1);

            personel p2 = new personel();
            p2.ad = "Elif"; 
            p2.soyad = "Koşucu";
            p2.id =2;
            pList.Add(p2);
            foreach (var item in pList)
            {
                Console.WriteLine(item.ad);
            }


            Console.ReadLine();

        }
    }
}
