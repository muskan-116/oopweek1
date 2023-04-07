using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class Program
    {
        static void Main(string[] args)
        {
            task20();
        }
        static void task1()
        {
            Console.Write("Hello world!!!");
            Console.Write("Hello world!!!!");
            Console.ReadKey();
        }
        static void task2()
        {
            Console.WriteLine("Hello world!!!");
            Console.WriteLine("Hello world!!!!");
            Console.ReadKey();

        }
        static void task3()
        {
            int variable = 7;
            Console.WriteLine("value :");
            Console.Write(variable);
            Console.ReadKey();

        }
        static void task4()
        {
            string line = "i am string";
            Console.WriteLine("string :");
            Console.Write(line);
            Console.ReadKey();

        }
        static void task5()
        {
            char ch = 'a';
            Console.WriteLine("character :");
            Console.Write(ch);
            Console.ReadKey();

        }
        static void task6()
        {
            float variable = 7.25F;
            Console.WriteLine("float :");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void task7()
        {
            Console.WriteLine("enter string:");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            Console.ReadKey();
        }
        static void task8()
        {
            Console.WriteLine("you have inputed :");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            Console.WriteLine("the number is :");
            Console.WriteLine(num);
            Console.ReadKey();
        }
        static void task9()
        {
            Console.WriteLine("you have inputed :");
            string input = Console.ReadLine();
            float num = float.Parse(input);
            Console.WriteLine("the number is :");
            Console.WriteLine(num);
            Console.ReadKey();
        }
        static void task10()
        {
            Console.WriteLine("enter length :");
            string input = Console.ReadLine();
            float lenght = float.Parse(input);
            float area = lenght * lenght;
            Console.WriteLine("area of square :");
            Console.WriteLine(area);
            Console.ReadKey();

        }
        static void task11()
        {
            Console.WriteLine("enter your marks:");
            string input = Console.ReadLine();
            float marks = float.Parse(input);
            if (marks > 50)
            {
                Console.WriteLine("you are passed!!");
            }
            else
            {
                Console.WriteLine("you are failed!!");
            }
            Console.ReadKey();
        }
        static void task12()
        {
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Welcome Jack!");
            }
            Console.ReadKey();
        }
        static void task14()
        {
            int sum = 0;
            int num;
            do
            {
                Console.Write("entered number :");

                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            while (num != -1);
            {
                sum = sum + 1;
                Console.WriteLine("sum of number {0}:", sum);

                Console.ReadKey();

            }


        }
        static void task15()
        {
            int[] number = new int[3];
            for (int idx = 0; idx < 3; idx++)
            {
                Console.Write("enter number :{0}", idx);
                number[idx] = int.Parse(Console.ReadLine());

            }
            int largest = -1;
            for (int idx = 0; idx < 3; idx++)
            {
                if (number[idx] > largest)
                {
                    largest = number[idx];
                }
            }
            Console.WriteLine("largest number is :{0}", largest);
            Console.ReadKey();
        }
        static void task16()
        {
            int age;
            int priceW;
            int priceT;
            int money=0;
            int sum = 0;
            int total;
            int result;
            int count = 0;
            int count1 = 0 ;
            Console.Write("enter age of lilly:");
            age = int.Parse(Console.ReadLine());
            Console.Write("enter price of washing machine:");
            priceW = int.Parse(Console.ReadLine());
            Console.Write("enter price of `toy:");
            priceT = int.Parse(Console.ReadLine());

            for (int x= 2;x<=age; x=x+2)
            {
                money = money + 10;
                sum = sum + money;
                count1++;

            }
            
            for(int idx =1;idx<=age;idx=idx+2)
            {
                
    
                count++;
               
            }
            priceT = priceT * count;
            
            total = priceT + sum - count1;
            

            if (priceW < total)
            {
                result = total - priceW;
                Console.WriteLine("enough money!!!{0}",result);
            }
            else if(priceW > total)
            {
                result =  priceW - total;
                Console.WriteLine(" not enough money!!!{0}",result);
            }
            Console.ReadKey();

        }
        static void task17()
        {
            int num1, num2;
            Console.Write("enter number 1:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("enter number 2:");
            num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("sum {0}",sum);
            Console.ReadKey();
        }
        static void task18()
        {
            string path =" G:\\oopweek1\\week1\\week1\\data.txt";
            if(File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine())!=null)
                    {
                    Console.WriteLine(record);
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("no exists");
            }
            Console.ReadKey();
        }
        static void task19()
        {
            string path = " G:\\oopweek1\\week1\\week1\\data.txt";
            StreamWriter fileVariable = new StreamWriter(path,true);
            fileVariable.WriteLine("hello");
            fileVariable.Flush();
            fileVariable.Close();
            Console.ReadKey();
        }
        static void task20()
        {
            string path = " G:\\oopweek1\\week1\\week1\\data.txt";
            string[] name = new string[5];
            string[] password = new string[5];
            int option;
            do
            {
                readDATA(path, name, password);
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("ENTER NAME :");
                    string n = Console.ReadLine();
                    Console.WriteLine("ENTER Password :");
                    string p = Console.ReadLine();
                    signIN(n, p, name, password);
                }
                else if (option == 2)
                {
                    Console.WriteLine("ENTER NEW NAME");
                    string n = Console.ReadLine();
                    Console.WriteLine("ENTER NEW PASSWORD");
                    string p = Console.ReadLine();
                    signUP(path, n, p);


                }
            }
            while (option < 3);
            Console.ReadKey();
        }
       static  int menu()
        {
            int option;
            Console.WriteLine("1.Sign in");
            Console.WriteLine("2.Sign up");
            Console.WriteLine("3.Enter option");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static string getParse(string record, int field)
        {
            int count = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    count++;
                }
                else if (count == field)
                {
                    item = item + record[x];
                }
                
            }
            return item;
        }
            static void readDATA(string path, string[] name, string[] password)
            {
                int x = 0;
                if (File.Exists(path))
                {
                    StreamReader fileVariable = new StreamReader(path);
                    string record;
                    while ((record = fileVariable.ReadLine()) != null)
                    {
                        name[x] = getParse(record, 1);
                        password[x] = getParse(record, 2);
                        x++;
                        if(x>=5)
                        {
                            break;
                        }


                    }
                    fileVariable.Close();
                }
                else
                {
                    Console.WriteLine("No Exists!!!");
                }

            }
            static void signIN(string n,string p,string[] name,string[] password)
            {
                bool flag = false;
                for (int x = 0; x < 5; x++)
                {
                
                    if (n == name[x] && p == password[x])
                    {
                        Console.WriteLine("VALID USER!!");
      
                    flag = true;
                    }
                }
                    if(flag == false)
                    {
                        Console.WriteLine("INVALID USER!!");
                      
                    }
                Console.ReadKey();
                
            }
            static void signUP(string path,string n,string p)           
            {
                StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
            file.Flush();
              file.Close();

            }
        static void task21()
        {

        }

    }

}
