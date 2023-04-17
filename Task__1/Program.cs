using System.Threading.Tasks;

namespace Task__1
{
    internal class Program
    {
        static void Main(string[] args)
        {  
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
                case 10:Solutions.Task10("Taskin serti--> 3 dene 4 reqemli eded verilib.  I ededin 1%-ni, II ededin 2% , III ededin 3 % tap. Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7% faizini gel.");
                    break;
            }           
        }
    }
}
