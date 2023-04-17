using System.Threading.Tasks;

namespace Task__1
{
    internal class Program
    {
        static void Main(string[] args)
        {  //246 
            int choose = Solutions.Choose();
            switch (choose)
            {
                case 1: Solutions.Task1("Taskin serti-->  4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir.");
                    break;
                case 2: Solutions.Task2("Taskin serti--> 3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir.");
                    break;
                case 3: Solutions.Task3("Taskin serti--> 5 reqemli eded verilib. Bu ededin evvel  18 % sonra ise 3 % tap.");
                    break;
                case 4: Solutions.Task4("Taskin serti--> 3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;");
                    break;
                case 5: Solutions.Task5("Taskin serti--> 4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap.");
                    break;
                case 6: Solutions.Task6("Taskin serti--> 4 reqemli eded verilib. Bu ededin evvel 20%-ni ,  sonra ise cavabin 10% tap.  Alinan  cavabin kvadratini tap.");
                    break;
                case 7: Solutions.Task7("Taskin serti--> 2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap.");
                    break;
                case 8: Solutions.Task8("Taskin serti-->  2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.\r\n   I ededin 4%-ni tap. \r\n   Sonra II ededin 9% ni tap. \r\n   Sonra Cavalari toplayib 10 %ni tap.");
                    break;
                case 9: Solutions.Task9("Taskin serti--> 3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.");
                    break;
                case 10:Solutions.Task10("Taskin serti--> 3 dene 4 reqemli eded verilib.  I ededin 1%-ni, II ededin 2% , III ededin 3 % tap. \r\n    Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7% faizini gel");
                    break;
            }
            //while (true)
            //{
            //    Console.WriteLine("Salam .Task 1de 10 tapsiriq var !");
            //    Console.WriteLine();
            //    Console.WriteLine(1 + "." + "ci Tapsiriq");
            //    Console.WriteLine(2 + "." + "ci Tapsiriq");
            //    Console.WriteLine(3 + "." + "cu Tapsiriq");
            //    Console.WriteLine(4 + "." + "cu Tapsiriq");
            //    Console.WriteLine(5 + "." + "ci Tapsiriq");
            //    Console.WriteLine(6 + "." + "ci Tapsiriq");
            //    Console.WriteLine(7 + "." + "ci Tapsiriq");
            //    Console.WriteLine(8 + "." + "ci Tapsiriq");
            //    Console.WriteLine(9 + "." + "cu Tapsiriq");
            //    Console.WriteLine(10 + "." + "cu Tapsiriq");
            //    Console.WriteLine();
            //    Console.WriteLine("Qeyd: Yalniz sececeyiniz tapsirigin nomresini daxil etmekle onu hell ede bilersiz!");
            //    Console.WriteLine();
            //    Console.Write("Secdiyiniz Tapsirigin nomresini daxil edin ----->>");
            //    int reqem = int.Parse(Console.ReadLine());
            //    Console.WriteLine();

            //    if (reqem == 1)
            //    {
            //        Console.WriteLine("4 reqemli eded verilib.");
            //        Console.WriteLine("Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir.");
            //        Console.Write("Isdenilen ededi daxil et --->>");
            //        double daxil = double.Parse(7 + Console.ReadLine() + 8);
            //        Console.WriteLine();
            //        Console.WriteLine($"NETICE -->> {daxil}");
            //    }

            //    else if (reqem == 2)
            //    {
            //        Console.WriteLine("3 reqemli eded verilib.");
            //        Console.WriteLine("Bu ededin axirina hemin ededdin ozunu yapishdir.");
            //        Console.Write("Isdenilen ededi daxil et --->>");
            //        string daxil1 = Console.ReadLine();
            //        double daxil2 = double.Parse(daxil1 + daxil1);
            //        Console.WriteLine($"NETICE -->> {daxil2}");
            //    }
            //    else if (reqem == 3)
            //    {
            //        Console.WriteLine("5 reqemli eded verilib.");
            //        Console.WriteLine("Bu ededin evvel  18 % sonra ise 3 % tap.");
            //        Console.Write("Isdenilen ededi daxil et --->>");
            //        double daxil3 = double.Parse(Console.ReadLine());
            //        Console.WriteLine($"Daxil edilen ededin 18 faizi -->" + (daxil3 * 18) / 100);
            //        Console.WriteLine($"Daxil edilen ededin 3 faizi -->" + (daxil3 * 3) / 100);
            //    }

            //    else if (reqem == 4)
            //    {
            //        Console.WriteLine("3 reqemli eded verilib.");
            //        Console.WriteLine("Bu ededin axirina 7 artir.");
            //        Console.WriteLine("Sonra cavabin 7% tap.");
            //        Console.Write("Isdenilen ededi daxil et --->>");
            //        double daxil4 = double.Parse(Console.ReadLine() + 7);
            //        Console.WriteLine($"NETICE -->> {daxil4}" + "      -------------->>>  " + $"Neticenin 7 faizi --> " + (daxil4 * 7) / 100);
            //    }

            //    else if (reqem == 5)
            //    {
            //        Console.WriteLine("4 reqemli eded verilib.");
            //        Console.WriteLine("Bu ededin evveline 4 reqemi");
            //        Console.WriteLine("Axirina ise 44 ededini artir.");
            //        Console.WriteLine("Alinan cavabin 44 % tap.");
            //        Console.Write("Isdenilen ededi daxil et --->>");
            //        double daxil5 = double.Parse(4 + Console.ReadLine() + 44);
            //        Console.WriteLine($"NETICE -->> {daxil5}" + "      -------------->>>  " + $"Neticenin 44 faizi --> " + (daxil5 * 44) / 100);
            //    }

            //    else if (reqem == 6)
            //    {
            //        Console.WriteLine("4 reqemli eded verilib.");
            //        Console.WriteLine("Bu ededin evvel 20%-ni");
            //        Console.WriteLine("Sonra ise cavabin 10% tap. ");
            //        Console.WriteLine("Alinan  cavabin kvadratini tap.");
            //        Console.Write("Isdenilen ededi daxil et --->>");
            //        double daxil6 = double.Parse(Console.ReadLine());
            //        double hes = (daxil6 * 20) / 100;
            //        Console.WriteLine($"Daxil edilen ededin 20 faizi -->  " + hes);
            //        double hes1 = (hes * 10) / 100;
            //        Console.WriteLine($"Alinan cavabin 10 faizi -->" + hes1);
            //        Console.WriteLine("Kvadrati ise ----->>  " + Math.Pow(hes1, 2));

            //    }

            //    else if (reqem == 7)
            //    {
            //        Console.WriteLine("2 dene 5 reqemli eded verilib.");
            //        Console.WriteLine("Bu ededleri toplayib.");
            //        Console.WriteLine("Alinan cavabin evveline ve axirina 5 artir.");
            //        Console.WriteLine("Neticenin 5 % tap");
            //        double hess = 0;
            //        for (int i = 1; i <= 2; i++)
            //        {
            //            Console.Write($"{i}.ci isdenilen ededi daxil et --->>");
            //            double daxil7 = double.Parse(Console.ReadLine());
            //            hess += daxil7;
            //        }
            //        Console.WriteLine("Toplam:" + hess);
            //        double hess1 = Convert.ToDouble(("5" + hess + "5"));
            //        Console.WriteLine("Evveline ve sonuna reqem artirdiqdan sonra:" + hess1);
            //        Console.WriteLine($"Neticenin 5 faizi --> " + (hess1 * 5) / 100);

            //    }

            //    else if (reqem == 8)
            //    {
            //        Console.WriteLine("2 dene eded verilib.");
            //        Console.WriteLine("I eded 4 reqemli II eded 7 reqemlidir.");
            //        Console.WriteLine(" I ededin 4%-ni tap.");
            //        Console.WriteLine("Sonra II ededin 9% ni tap.");
            //        Console.WriteLine("Sonra Cavalari toplayib 10 %ni tap. ");
            //        double cem = 0;
            //        for (int a = 1; a <= 2; a++)
            //        {

            //            if (a == 1)
            //            {
            //                Console.Write($"{a}.ci isdenilen ededi daxil et --->>");
            //                double daxil8 = double.Parse(Console.ReadLine());
            //                double hesa = (daxil8 * 4) / 100;
            //                Console.WriteLine($"{a}.ci ededin 4% i --->>" + hesa);
            //                cem += hesa;
            //            }

            //            else if (a != 1)
            //            {
            //                Console.Write($"{a}.ci isdenilen ededi daxil et --->>");
            //                double daxil9 = double.Parse(Console.ReadLine());
            //                double hesa11 = (daxil9 * 9) / 100;
            //                Console.WriteLine($"{a}.ci ededin 9% i --->>" + hesa11);
            //                cem += hesa11;
            //            }

            //        }

            //        Console.WriteLine("TOPLAM ---->>" + cem);
            //        Console.WriteLine("Toplamdan alinan cavabin 10% i --->>" + (cem * 10) / 100);
            //    }

            //    else if (reqem == 9)
            //    {
            //        Console.WriteLine("3 dene 6 reqemli eded verilib.");
            //        Console.WriteLine("Her birinin 10 faizini tapib neticeleri topla.");
            //        Console.WriteLine("Alinan cavabin 10% tap.");


            //        double toplam = 0;
            //        for (int y = 1; y <= 3; y++)
            //        {
            //            if (y == 1)
            //            {
            //                Console.Write($"{y}.ci isdenilen ededi daxil et --->>");
            //                double daxil12 = double.Parse(Console.ReadLine());
            //                double hesaa = (daxil12 * 10) / 100;
            //                Console.WriteLine($"{y}.ci ededin 10 i --->>" + hesaa);
            //                toplam += hesaa;
            //            }


            //            else if (y == 2)
            //            {
            //                Console.Write($"{y}.ci isdenilen ededi daxil et --->>");
            //                double daxil13 = double.Parse(Console.ReadLine());
            //                double hesa14 = (daxil13 * 10) / 100;
            //                Console.WriteLine($"{y}.ci ededin 10% i --->>" + hesa14);
            //                toplam += hesa14;
            //            }
            //            else if (y == 3)
            //            {
            //                Console.Write($"{y}.ci isdenilen ededi daxil et --->>");
            //                double daxil15 = double.Parse(Console.ReadLine());
            //                double hesa15 = (daxil15 * 10) / 100;
            //                Console.WriteLine($"{y}.cu ededin 10% i --->>" + hesa15);
            //                toplam += hesa15;
            //            }


            //        }
            //        Console.WriteLine("TOPLAM ---->>" + toplam);
            //        Console.WriteLine("Toplamdan alinan cavabin 10% i --->>" + (toplam * 10) / 100);
            //    }
            //    else if (reqem == 10)
            //    {
            //        Console.WriteLine("3 dene 4 reqemli eded verilib.");
            //        Console.WriteLine("I ededin 1%-ni");
            //        Console.WriteLine("II ededin 2%");
            //        Console.WriteLine("III ededin 3 % tap.");
            //        Console.WriteLine("Neticeleri bir birinden cix.");
            //        Console.WriteLine("Alinan cavabin ustune III ededin 7% faizini gel.");
            //        double cix = 0, top = 0;
            //        for (int y = 1; y <= 3; y++)
            //        {
            //            if (y == 1)
            //            {
            //                Console.Write($"{y}.ci isdenilen ededi daxil et --->>");
            //                double daxil16 = double.Parse(Console.ReadLine());
            //                double hesaaa = (daxil16 * 1) / 100;
            //                Console.WriteLine($"{y}.ci ededin 1% i --->>" + hesaaa);
            //                cix -= hesaaa;
            //                top += daxil16;
            //            }


            //            else if (y == 2)
            //            {
            //                Console.Write($"{y}.ci isdenilen ededi daxil et --->>");
            //                double daxil17 = double.Parse(Console.ReadLine());
            //                double hesa21 = (daxil17 * 2) / 100;
            //                Console.WriteLine($"{y}.ci ededin 2% i --->>" + hesa21);
            //                cix -= hesa21;
            //                top += daxil17;
            //            }
            //            else if (y == 3)
            //            {
            //                Console.Write($"{y}.cu isdenilen ededi daxil et --->>");
            //                double daxil18 = double.Parse(Console.ReadLine());
            //                double hesa19 = (daxil18 * 3) / 100;
            //                Console.WriteLine($"{y}.cu ededin 3% i --->>" + hesa19);
            //                cix -= hesa19;
            //                top += daxil18;
            //            }


            //        }
            //        Console.WriteLine("3 ededin faizlerini tapdiqdan ve bir birinden cixdiqdan sonra ferqi ---->> " + cix);
            //        double cv = (top * 7) / 100;
            //        Console.WriteLine(" 3 ededin faizlerinin ferqinin uzerine 3 ededin ceminin 7 faizini  daxil et. Netice -->>" + (cv + cix));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Qeyd edilmis xanalardan hec birini secmediz!");
            //    }

            //}
        }
    }
}
