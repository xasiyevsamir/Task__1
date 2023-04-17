using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task__1
{
    internal class Solutions
    {
        public static int Choose()
        {
            int number;
            l1: Console.Write("Task 1 de 10 tapsiriq var siz hansina baxmaq isdeyirsiz: ");
            if (!int.TryParse(Console.ReadLine(), out number)|| number<=0||number>=11)
            {
                Console.Clear();
                Console.WriteLine("Yalniz 1 ile 10 arasinda secim ede bilersiz !");

                goto l1;
            }
            Console.Clear() ;
            Console.Write($"Siz {number} taski secdiz !");
            return number;
        }
        static int HowManyDigits(int digits)
        {  int number;
            l1: Console.Write("Eded daxil edin: ");
            if (!int.TryParse(Console.ReadLine(),out number)||(int)Math.Log10(number)+1!=digits)
            {
                Console.WriteLine($"Yalniz {digits} reqemli eded daxil edin !");
                goto l1;
            }
            return number;
        }
        // Task 1--> 4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir.
        public static void Task1(string text)
        {  Console.WriteLine(text);
           int number= HowManyDigits(4);
            number = 70000 + number;
            number = number * 10 + 8;
            Console.WriteLine($"Netice:{number}");
        }
        //Task 2--> 3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir.
        public static void Task2(string text)
        { Console.WriteLine(text);
          int number= HowManyDigits(3);
            number=number*1000 + number;
            Console.WriteLine($"Netice:{number}");
        }
        //Task 3--> 5 reqemli eded verilib. Bu ededin evvel  18 % sonra ise 3 % tap.
        public static void Task3(string text)
        {   Console.WriteLine(text);
            double number = HowManyDigits(5), number1;
            number1 = 1.00*(number * 18) / 100;
            Console.WriteLine($"18 faizi: {number1}");
            number = 1.00 * (number * 3) / 100;
            Console.WriteLine($"3 faizi: {number}");
        }
        // Task 4--> 3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap.
        public static void Task4(string text)
        { Console.WriteLine(text);
            int number = HowManyDigits(3);
            double number1;
            number = number * 10 + 7;
            Console.WriteLine($"7 artirdiqdan sonra:{number}");
            number1 = 1.00*(number * 7) / 100;
            Console.WriteLine($"7 faizi: {number1}");
        }
        // Task 5--> 4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap.
        public static void Task5(string text)
        {   Console.WriteLine(text);
            int number = HowManyDigits(4);
            number = 40000 + number;
            Console.WriteLine($"4 reqemi elave edildi:{number}");
            number = number * 100 + 44;
            Console.WriteLine($"44 reqemi elave edildi:{number}");
            double number1=1.00*(number * 44) / 100;
            Console.WriteLine($"44 faizi:{number1}");
        }
        // Task 6--> 4 reqemli eded verilib. Bu ededin evvel 20%-ni ,  sonra ise cavabin 10% tap.  Alinan  cavabin kvadratini tap.
        public static void Task6(string text)
        {   Console.WriteLine(text);
            int number = HowManyDigits(4);
            double number1 = 1.00 * (number * 20) / 100;
            Console.WriteLine($"20 faizi:{number1}");
            number1 =1.00*( number1 * 10) / 100;
            Console.WriteLine($"Cavabin 10 faizi:{number1}");
            number1 = Math.Pow(number1,2);
            Console.WriteLine($"Kvadrati: {number1}");           
        }
        //Task 7 --> 2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap.
        public static void Task7(string text)
        {  Console.WriteLine(text);
            int number, number1, len, pow;
            number= HowManyDigits(5);
            number1= HowManyDigits(5);
            number=number+number1;
            Console.WriteLine($"Topladiqda: {number}");
            len = (int)Math.Log10(number)+1;
            pow=(int)Math.Pow(10,len);
            number = 5 * pow + number;
            number = number * 10 + 5;
            Console.WriteLine($" 5 reqemi artirdiqdan sonra :{number}");
            double number2=1.00*(number*5)/ 100;
            Console.WriteLine($"Netice: {number2}");
        }
        /*Task 7 -->  2 dene eded verilib. 
        I eded 4 reqemli II eded 7 reqemlidir.
        I ededin 4%-ni tap.
        Sonra II ededin 9% ni tap. 
        Sonra Cavalari toplayib 10 %ni tap. */
        public static void Task8(string text)
        {  Console.WriteLine(text);
            double number, number1;
            number= HowManyDigits(4);
            number1= HowManyDigits(7);
            number = 1.00 * (number * 4) / 100;
            Console.WriteLine($"1 ededin 4 faizi:{number}");
            number1 = 1.00*(number1*9)/100;
            Console.WriteLine($"2 ededin 9 faizi:{number1}");
            number =number+ number1;
            Console.WriteLine($"Cem: {number}");
            number = 1.00 * (number * 10) / 100;
            Console.WriteLine($"Netice:{number}");
        }
        // Task 9--> 3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.
        public static void Task9(string text)
        {   Console.WriteLine(text);
            int number, number1, number2; 
            number= HowManyDigits(6);       
            number1= HowManyDigits(6);      
            number2= HowManyDigits(6);      
            number=number+ number1+ number2;
            Console.WriteLine($"Cemi: {number}");
            double number3=1.00*(number*10)/100;
            Console.WriteLine($"Netice: {number3}");
        }
        /* Task 9--> 3 dene 4 reqemli eded verilib. 
         * I ededin 1%-ni, 
         * II ededin 2% ,
         * III ededin 3 % tap. 
          Neticeleri bir birinden cix. 
         Alinan cavabin ustune III ededin 7% faizini gel*/
        public static void Task10(string text)
        {   Console.WriteLine(text);
            double number, number1,number2,number3;
            number= HowManyDigits(4);
            number1= HowManyDigits(4);
            number2= HowManyDigits(4);
            number=1.00*(number*1)/100;
            number1=1.00*(number1*2)/100;
            number3=1.00*( number2*7)/100;
            number2=1.00*(number2*3)/100;
            Console.WriteLine($"1 ededin 1 faizi: {number}");
            Console.WriteLine($"2 ededin 2 faizi: {number1}");
            Console.WriteLine($"3 ededin 3 faizi: {number2}");
            number=number-number1- number2;
            Console.WriteLine($"Cixdiqdan sonra:{number}");
            Console.WriteLine($"3 ededin 7 faizi:{number3}");
            number = number + number3;
            Console.WriteLine($"Netice: {number}");
        }

    }
}
