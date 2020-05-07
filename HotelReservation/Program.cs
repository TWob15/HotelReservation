using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string name, v = "", f = "", p = "", r = "", s = "";
            double room, suite = 250, queen = 150, king = 175, view = 50, fridge = 25, pet = 50, t1 = 0, gt = 0, tax = 0.055;
            int w = 0;
            bool input = false;

            WriteLine("Welcome to The Hotel.");
            WriteLine();
            Write("Please Enter your Name: ");
            name = ReadLine();
            WriteLine();
            WriteLine("Welcome {0}. There are 3 different rooms to choose from, a Suite, which is $250.00 a night. 2 Queens, which is $150.00 a night. 1 King, which is $175.00 a night.", name);
            WriteLine();
            while (s == "")

            {
                r = "";
                while (input == false)
                {
                    Write("Which type of room would you like? 1 = Suite, 2 = Queens, 3 = King: ");
                    room = Convert.ToDouble(ReadLine());
                    WriteLine();
                    switch (room)
                    {
                        case 1:
                            WriteLine("Suite");
                            input = true;
                            t1 = suite;

                            break;
                        case 2:
                            WriteLine("2 Queens");
                            input = true;
                            t1 = queen;

                            break;
                        case 3:
                            WriteLine("King");
                            input = true;
                            t1 = king;

                            break;
                        default:
                            WriteLine("Please select 1, 2 or 3.");
                            WriteLine();
                            input = false;
                            break;
                    }//closes switch
                }//closes switch while
                WriteLine();

                while (v == "")
                {
                    Write("Would you like to add an Ocean View for an extra $50.00? yes or no: ");
                    v = ReadLine();
                    if (!(v == "yes" || v == "no"))
                    {
                        WriteLine("Please Enter yes or no");
                        WriteLine();
                        v = "";
                    }
                    if (v == "yes")
                    {
                        t1 = t1 + view;

                    }
                }//closes view while
                WriteLine();
                while (f == "")
                {

                    Write("Would you like to have a fridge in the room for an extra $25.00? yes or no: ");
                    f = ReadLine();
                    if (!(f == "yes" || f == "no"))
                    {
                        WriteLine("Please Enter yes or no");
                        WriteLine();
                        f = "";
                    }
                    if (f == "yes")
                    {
                        t1 = t1 + fridge;

                    }
                }//closes fridge while
                WriteLine();
                while (p == "")
                {
                    Write("Do you have any pets? Pets are an additional $50.00. yes or no: ");
                    p = ReadLine();
                    WriteLine();
                    if (!(p == "yes" || p == "no"))
                    {
                        WriteLine("Please Enter yes or no");
                        WriteLine();
                        p = "";
                    }
                    if (p == "yes")
                    {
                        t1 = t1 + pet;

                    }
                }//closes pet while

                t1 += t1 * tax;

                while(r == "")
                {
                    w++;
                    if (w <= 2)
                    {
                        Write("{0} your total is {1:c}. Would you like to add another room? yes or no: ", name, t1);
                        r = ReadLine();
                        WriteLine();
                        if (r == "yes")
                        {
                            v = "";
                            f = "";
                            p = "";
                            s = "";
                            gt = t1 + gt;
                            input = false;
                          
                        }

                        else if (r == "no")
                        {
                            s = "no";
                            gt = t1 + gt;
                            WriteLine("Your Grand Total is {0:c}. Thank you for choosing The Hotel.", gt);
                        }

                        else
                        {
                            WriteLine("Please Enter yes or no");
                            WriteLine();
                            w--;
                            r = "";
                        }
                    }
                    else
                    {
                        if(w > 2)
                        {
                            s = "no";
                            r = "no";
                            gt = t1 + gt;
                            WriteLine("Your Grand Total is {0:c}. Thank you for choosing The Hotel.", gt);
                        }
                        else
                        {
                            s = "no";
                            r = "no";
                            WriteLine("Your Grand Total is {0:c}. Thank you for choosing The Hotel.", gt);
                        }

                    }
                    
                }
               
            }//closes main while

           
            ReadKey();

        }//closes main
    }
}
