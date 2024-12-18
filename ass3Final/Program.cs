using System;

namespace ass3Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo
            #region value type casting 

            #region Implicit casting - safe casting 
            //int x = 5;           // 4 bytes
            //long y =/*(long)*/x; // 8 bytes
            //Console.WriteLine(y);
            #endregion

            #region Explicit casting - unsafe casting

            //ex01

            //long x = 1010101010101010; // 8 bytes
            //int y ;                 // 4 bytes
            //checked  // unchecked el3aks
            //{
            //    y = (int)x; //runtime error
            //}
            //Console.WriteLine(y); //overflow (ay rkm w elslam)

            //ex02

            //int x = 88;
            //double y =/*(double)*/ x; // (implicit cating) double hold arkam 3adia w fraction 3ady so no need to casting

            //double x = 88.88;
            //int y =(int) x;  //(explicit casting)
            //Console.WriteLine(y);

            #endregion


            #region parse [convert from string to any datatype]
            //Console.WriteLine("enter data user");
            //Console.Write("enter name :");
            //string name =Console.ReadLine();
            ////"22"=>22
            //Console.Write("enter age :");
            //int age =int.Parse(Console.ReadLine());
            ////"2500.5"=>2500.5
            //Console.Write("enter salary :");
            //double salary =double.Parse(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine(" Name: " + name + " Age: " + age + " salary: " + salary );

            #endregion

            #region convert [convert any dataType to any dataType]

            //Console.WriteLine("enter data user");
            //Console.Write("enter name :");
            //string name = Console.ReadLine();
            ////"22"=>22
            //Console.Write("enter age :");
            //int age = Convert.ToInt32(Console.ReadLine());
            ////"2500.5"=>2500.5
            //Console.Write("enter salary :");
            //double salary = Convert.ToDouble(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine(" Name: " + name + " Age: " + age + " salary: " + salary);

            #endregion

            #region opertators


            #region unary operators[++,-- ]
            //int x = 5;
            ////++x //prefix
            ////x++  //postfix
            //Console.WriteLine(++x);
            //Console.WriteLine(x++);

            //x--; //postfix
            //--x; //prefix
            //Console.WriteLine(x);
            #endregion

            #region binary operators[+,-,*,/,% ]

            //int sum, sub, mul, div, mod;
            //int A = 10;
            //int B = 5;

            //sum = A + B;
            //sub = A - B;
            //mul = B * A;
            //div = A / B;
            //mod = A % B;



            #endregion

            #region assignment operators
            //int x = 5;
            //x += 10; //x=x+10
            //x -= 10;
            //x *= 10;
            //x /= 10;
            //x %= 10;
            #endregion


            #region Relational Operators
            //int a = 5;
            //int b = 10;

            //Console.WriteLine(a != b);
            #endregion

            #region Logical Operators[short circuit]


            // Console.WriteLine( !true);

            //Console.WriteLine(true&&false);
            //true && true =>true
            //true && false =>false
            //false && true =>false
            //false && false =>false

            //Console.WriteLine(true or false);
            //true || true =>true
            //true || false =>true
            //false || true =>true
            //false || false =>false


            #endregion

            #region bitwise Operators[long circuit]


            // Console.WriteLine( !true);

            //Console.WriteLine(true & false);
            //true & true =>true
            //true & false =>false
            //false & true =>false
            //false & false =>false

            //Console.WriteLine(true or false);
            //true |true =>true
            //true | false =>true
            //false | true =>true
            //false | false =>false


            #endregion

            #region trnery Operators[conditional operator]
            //variable = condition ?true : false
            //int x = 4;
            //string message = x > 4 ? "X greater than 4 " : "x less than 4";
            //Console.WriteLine(message);
            //#endregion
            #endregion
            #endregion

            #region operators priorty

            /*
             1- unary operators[prefix  ++a]
            2-(+ - *)
            3-* / %
            4- + - 
            */

            //int a = 20;
            //int b = 15;
            //int c = 10;
            //int d = 5;
            //int result;
            //result = (a + b) * c - d;
            //result = a++ * c; //20*10=200 and then change value of a to 21

            #endregion

            #region string formating 

            //equation : x+y=result
            //equation :5+10=15
            //int x = 5;
            //int y = 10;
            //int result=x+y;
            //Console.WriteLine("equation : " + x + "+" + y);

            //string => immutable datatype
            //string name ="ahmed";
            //name = "ali";
            //"equation :"
            //"equation :"+x
            //"equation :"+x+"+"

            #endregion
            //so solution will be: composite formate , string interpolation


            #region 1. composite formate
            //string message = string.Format("equation :{0}+{1}={2}", x, y, result);
            //Console.WriteLine(message);
            ////or
            //Console.WriteLine("equation :{0}+{1}={2}", x, y, result);
            #endregion

            #region 2.string interpolation
            ////$=>string manipulation
            //Console.WriteLine($"equation:{x}+{y}={result}");

            #endregion



            #region conditional statment
            #region EX01
            //1=>jan
            //2=>feb
            //3=>march
            //other=>ivalid

            //int monthnumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter month");
            //if (monthnumber == 1)
            //{
            //    Console.WriteLine("month is jan ");
            //}

            //else if (monthnumber == 2)
            //{
            //    Console.WriteLine("month is feb ");
            //}
            //else if (monthnumber == 3)
            //{
            //    Console.WriteLine("month is march ");
            //}
            //else
            //{
            //    Console.WriteLine("month is invalid ");
            //}


            //jumbing table --- created in numeric switch not in string
            //switch (monthnumber)
            //{
            //    case 1:
            //        Console.WriteLine("month is jan ");
            //        break;
            //    case 2:
            //        Console.WriteLine("month is feb ");
            //        break;
            //    case 3:
            //        Console.WriteLine("month is march ");
            //        break;
            //    default:
            //        Console.WriteLine("month is invalid ");
            //        break;
            //}
            #endregion

            #region EX02
            //string name = Console.ReadLine();
            //if(name=="mostafa")
            //{
            //    Console.WriteLine("hello mostafa");
            //}
            //else if (name == "aliaa" ||name="Aliaa")
            //{
            //    Console.WriteLine("hello aliaa");
            //}
            //else if (name == "ahmed")
            //{
            //    Console.WriteLine("hello ahmed");
            //}


            //switch (name)
            //{
            //    case "mostafa":
            //        Console.WriteLine("hello mostafa");
            //        break;
            //    case "aliaa":
            //        Console.WriteLine("hello aliaa");
            //        break;
            //    case "ahmed":
            //        Console.WriteLine("hello ahmed");
            //        break;
            //}



            #endregion


            #endregion

            #region goTo
            //Console.WriteLine("enter option");
            //int option = int.Parse(Console.ReadLine());
            ////3000 =>option 01,option 02 ,option 03
            ////2000 => option 01, option 02
            ////1000=>option 01


            //switch (option)
            //{
            //    case 3000:
            //        Console.WriteLine("option 03");
            //        goto case 2000;

            //    case 2000:
            //        Console.WriteLine("option 02");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("option 01");
            //        break;

            //}
            #endregion

            #region Evaluation switch in c#

            #region c# 06
            //Console.WriteLine("enter age");
            //int age = int.Parse(Console.ReadLine());
            //switch (age)
            //{
            //    case > 22:
            //        Console.WriteLine("age greater than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("age less than 22");
            //        break;
            //    default:
            //        Console.WriteLine("age equal 22");
            //        break;
            //}

            #endregion

            #region c#07
            //object obj = new object();
            //obj = "mostafa";
            //obj = 10;
            //obj = true;
            //switch (obj)
            //{
            //    case int number when number > 10 && number < 5:
            //        Console.WriteLine($"number{number} int");
            //        break;
            //    case string name:
            //        Console.WriteLine($"{name} is string");
            //        break;
            //    case bool flag:
            //        Console.WriteLine($"{flag}is bool");
            //        break;
            //}

            #endregion

            #region c# 08
            #region ex01
            //int opt = 1;
            //string message = opt switch
            //{
            //    1 => "opt 01",
            //    2 => "opt 02",
            //    3 => "opt 03",
            //    _ => "Invalid"
            //};
            //Console.WriteLine(message);
            #endregion

            #region ex02

            //employee e01 = new employee();
            //e01.age = 20;
            //e01.ID = 10;
            //e01.name = "ahmed";
            //string mess = e01 switch
            //{
            //    //property pattern //can check on all property or one of them
            //    { ID: 10, name: "alaa", age: 20 } => "alaa",   
            //    { ID: 10, name: "ahmed", age: 20 } => "ahmed",
            //    { ID: 20, name: "mona", age: 22 } => "mona"
            //};
            //string mess = e01 switch
            //{
            //    //property pattern //can check on all property or one of them
            //    { age:> 22 and <25 } => "alaa",
            //    { age:25 or 23} => "ahmed",
            //    { age: 20  } => "mona"
            //};
            //Console.WriteLine(mess);

            #endregion


            #endregion


            #endregion


            #endregion

            #endregion
            #region assigmnent 
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("Enter the number");
            //int x = int.Parse(Console.ReadLine());
            //if (x % 3 == 0 && x % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}

            //else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion

            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.WriteLine("Enter the number");
            //int x = int.Parse(Console.ReadLine());
            //if (x>0)
            //{
            //    Console.WriteLine("positive");
            //}
            //else if(x<0)
            //{
            //    Console.WriteLine("negative");
            //}

            #endregion

            #region  3 - Write a program that takes 3 integers from the user then prints the max element and the min element.

            //Console.WriteLine("Enter the first number");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the third number");
            //int z = int.Parse(Console.ReadLine());

            //if(x>y && x > z)
            //{
            //    Console.WriteLine($"{x} is max");
            //    if (y > z )
            //    {
            //        Console.WriteLine($"{z} is min");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{y} is min");
            //    }

            //}
            //else if (y>x && y>z)
            //{
            //    Console.WriteLine($"{y} is max");
            //    if (x > z)
            //    {
            //        Console.WriteLine($"{z} is min");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{x} is min");
            //    }
            //}
            //else if (z > x && z > y)
            //{
            //    Console.WriteLine($"{z} is max");
            //    if (x > y)
            //    {
            //        Console.WriteLine($"{y} is min");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{x} is min");

            //    }
            //}


            #endregion

            #region  4 - Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.WriteLine("Enter the first number");
            //int x = int.Parse(Console.ReadLine());
            //if (x % 2 == 0)
            //{
            //    Console.WriteLine($"{x} is even");

            //}
            //else
            //{
            //    Console.WriteLine($"{x} is odd");
            //}





            #endregion

            #region Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).


            //Console.WriteLine("Enter the character ");
            //string x = Console.ReadLine();
            //if(x=="a" || x == "e" || x == "i" || x == "o" || x == "u")
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant"); 
            //}

            #endregion

            #region 7- Write a program that allows the user to insert an integer then  print a multiplication table up to 12.

            //Console.WriteLine("Enter the integer ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n ");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{x}*{i}={x * i}");
            //}

            #endregion

            #region 9- Write a program that takes two integers then prints the power

            //first answer
            //Console.WriteLine("Enter the first integer ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second integer ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n");

            //Console.WriteLine(Math.Pow(x,y));

            //second answer 
            //Console.WriteLine("Enter the first integer ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second integer ");
            //int y = int.Parse(Console.ReadLine());
            //int result = 1;
            //Console.WriteLine("\n");
            //if (y > 0)
            //{
            //    for (int i = 1; i <= y; ++i)
            //    {
            //        result *= x;
            //    }
            //}
            //else if (y < 0)
            //{
            //    for (int i = -1; i >= y; --i)
            //    {
            //        result /= x;
            //    }
            //}
            //Console.WriteLine(result);
            #endregion

            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Console.WriteLine("Enter the 1st subject ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the 2sd subject ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the 3d subject ");
            //int z = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the fourth subject ");
            //int e = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the fifth subject ");
            //int d = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n");

            //int total=x+y+z+e+d;
            //Console.WriteLine($"Total is {total}");
            //int average=total/5;
            //Console.WriteLine($"average is {average}");
            //int percentage=((average)*100)/100;
            //Console.WriteLine($"percentage is {percentage}");


            #endregion

            #region 11- Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("Enter the Month ");
            //int month = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n");

            //switch (month)  
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.Write("Month has 31 days. \n"); 
            //        break;
            //    case 2:
            //        Console.Write("The 2nd month is February and has 28 days. \n");  
            //        Console.Write("In leap years, February has 29 days.\n");  
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.Write("Month has 30 days. \n");  
            //        break;
            //    default:
            //        Console.Write("Invalid Month number.\nPlease try again ....\n"); 
            //        break;
            //}


            //another solution
            //Console.WriteLine("Enter the Month ");
            //int month = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n");
            //if (month==1|| month==3||month==5 ||month==7 || month == 8 || month == 10 || month == 12)
            //{
            //    Console.Write("Month has 31 days. \n");
            //}
            //else if (month == 4 || month == 6 || month == 9 || month == 11)
            //{
            //    Console.Write("Month has 30 days. \n");
            //}
            //else if(month == 2)
            //{
            //    Console.Write("The 2nd month is February and has 28 days. \n");
            //}

            #endregion

                #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.???

                //Console.WriteLine("Enter the x1 ");
                //int x1 = int.Parse(Console.ReadLine());
                //Console.WriteLine("Enter the y1 ");
                //int y1 = int.Parse(Console.ReadLine());
                //Console.WriteLine("Enter x2 ");
                //int x2 = int.Parse(Console.ReadLine());
                //Console.WriteLine("Enter y2");
                //int y2 = int.Parse(Console.ReadLine());
                //Console.WriteLine("Enter x3 ");
                //int x3 = int.Parse(Console.ReadLine());
                //Console.WriteLine("Enter y3 ");
                //int y3 = int.Parse(Console.ReadLine());
                //Console.WriteLine("\n");


                //if ((y3 - y2) * (x2 - x1) == (y2 - y1) * (x3 - x2))
                //    Console.WriteLine("Yes");
                //else
                //    Console.WriteLine("No");

                #endregion

                #region Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
                //  -If the worker completes the job within 2 to 3 hours, they are considered highly efficient.

                //- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
                //- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
                //- If the worker takes more than 5 hours, they are required to leave the company.
                //To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

                //Console.WriteLine("enter work hours");
                //double workHours = Convert.ToDouble(Console.ReadLine());

                //if (workHours >= 2 && workHours <= 3)
                //{
                //    Console.WriteLine("the worker work highly efficient");
                //}
                //else if (workHours > 3 && workHours <= 4)
                //{
                //    Console.WriteLine(" they are instructed to increase their speed.");

                //}
                //else if (workHours > 4 && workHours <= 5)
                //{
                //    Console.WriteLine(" they are provided with training to enhance their speed.");

                //}
                //else if (workHours > 5 )
                //{
                //    Console.WriteLine(" they are required to leave the company.");

                //}

                #endregion



                #region 21- Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

                //int num1 = 5;
                //int num2 = 30 ;

                //num2 = num1;
                //num1 = 70;
                //num2 = 100;

                //Console.WriteLine(num1);   
                //Console.WriteLine(num2);  
                //at the first num2 =5
                //then num1=70
                //num2=100
                // so the final result num1=70 and num2=100
                #endregion




                #region 22- Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

                //object obj1 = new object();
                //object obj2 = new object();
                //obj1 = obj2;
                //Console.WriteLine(obj1.GetHashCode());
                //Console.WriteLine(obj2.GetHashCode());

                //so we reassigned obj1 it will be obj2 


                #endregion


                #region 23- Which of the following statements is correct about the C#.NET code snippet given below?

                //int d;
                //d = Convert.ToInt32(!(30 < 20)); //(!(0))=1
                //Console.WriteLine(d);

                //A value 1 will be assigned to d.

                #endregion

                #region 24- Which of the following is the correct output for the C# code given below?


                //Console.WriteLine(13 / 2 + " " + 13 % 2);
                //6 1

                #endregion

                #region 25- What will be the output of the C# code given below?


                // int num = 1, z = 5;


                // if (!(num <= 0)) //!0
                //     Console.WriteLine(++num + z++ + " " + ++z);//2+5+""+7              
                //else
                //     Console.WriteLine(--num + z-- + " " + --z);
                //d)7 7

                #endregion

                #endregion

        }
    }
}

      