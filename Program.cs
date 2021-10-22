using System;
using System.Text;

namespace Calculatortest
{
    public class Program
    {


        static void Main(string[] args)
        {
            //Shows a menu until the program is exited
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            double userInput1, userInput2;
            string userInput;
            bool myBool1, myBool2;
            StringBuilder strB = new();
            Console.Clear();
            Console.WriteLine("Välkommen att använda miniräknarfunktionen:");
            Console.WriteLine("\nVälj räknesätt: ");
            Console.WriteLine("1 för +) - Addition");
            Console.WriteLine("2 för -) - Subtraktion");
            Console.WriteLine("3 för *) - Multiplikation");
            Console.WriteLine("4 för /) - Division");
            Console.WriteLine("5 för k) - Kvadraten (x^2)");
            Console.WriteLine("6 för r) - Kvadratroten");
            Console.WriteLine("7 för att Avsluta");
            bool menu = int.TryParse(Console.ReadLine(), out int userCT);
            if (menu == false)
            {
                Console.WriteLine("Du måste skriva siffran som representerar ditt valda räknesätt!");
                return true;
            }
            if (userCT == 7)
            {
                return false;
            }


            double res;
            switch (userCT)
            {
                #region 1 Addition
                case 1:
                    {
                        Console.WriteLine("Skriv in dina tal du vill addera med kommatecken emellan " +
                            "och tryck sedan enter:\n");
                        userInput = Console.ReadLine();
                        string[] arr = userInput.Split();
                        if (arr.Length == 2)
                        {
                            myBool1 = double.TryParse(arr[0], out userInput1);
                            myBool2 = double.TryParse(arr[1], out userInput2);
                            if (myBool1 && myBool2)
                            {
                                res = Addition(userInput1, userInput2);

                                Console.WriteLine(userInput1 + " + " + userInput2 + " = " + res);
                                Console.ReadLine();

                            }
                            else
                            {
                                Console.WriteLine("Du måste skriva in tal att addera!");
                            }

                        }
                        else
                        {
                            res = Addition(arr);
                            Console.WriteLine("Summan av dina tal = " + res);
                        }




                        Console.ReadLine();
                        return true;
                    }


                #endregion

                #region 2 Subtraktion
                case 2:
                    {
                        Console.WriteLine("Skriv in dina tal du vill addera med kommatecken emellan " +
                            "och tryck sedan enter:\n");
                        userInput = Console.ReadLine();
                        string[] arr = userInput.Split();
                        if (arr.Length == 2)
                        {
                            myBool1 = double.TryParse(arr[0], out userInput1);
                            myBool2 = double.TryParse(arr[1], out userInput2);
                            if (myBool1 && myBool2)
                            {
                                res = Subtraction(userInput1, userInput2);

                                Console.WriteLine(userInput1 + " - " + userInput2 + " = " + res);
                                Console.ReadLine();

                            }
                            else
                            {
                                Console.WriteLine("Du måste skriva in tal att subtrahera!");
                            }

                        }
                        else
                        {
                            res = Subtraction(arr);
                            Console.WriteLine("Summan av dina tal efter subtraction = " + res);
                        }




                        Console.ReadLine();
                        return true;

                    }

                #endregion

                #region 3 Multiplikation
                case 3:
                    {
                        Console.WriteLine("Skriv in ditt första tal och tryck enter:\n");
                        userInput1 = GetNumberFromUser();
                        Console.WriteLine("\nSkriv in ditt andra tal och tryck enter:");
                        userInput2 = GetNumberFromUser();
                        res = Multiplication(userInput1, userInput2);
                        Console.WriteLine(userInput1 + " * " + userInput2 + " = " + res);
                        Console.ReadLine();
                        return true;
                    }

                #endregion

                #region 4 Division
                case 4:
                    {
                        Console.WriteLine("Skriv in ditt första tal och tryck enter:\n");
                        userInput1 = GetNumberFromUser();
                        Console.WriteLine("\nSkriv in ditt andra tal och tryck enter:");
                        userInput2 = GetNumberFromUser();
                                                
                        

                            res = Division(userInput1, userInput2);
                            Console.WriteLine(userInput1 + " / " + userInput2 + " = " + res);
                            Console.ReadLine();
                       



                        return true;
                    }

                #endregion

                #region 5 Kvadraten (x^2)
                case 5:
                    {
                        Console.WriteLine("Skriv in ditt tal och tryck enter:\n");
                        userInput1 = GetNumberFromUser();
                        var res1 = Pow2(userInput1);
                        Console.WriteLine("Kvadraten av " + userInput1 + " = " + res1);
                        Console.ReadLine();
                        return true;
                    }

                #endregion

                #region 6 Kvadratroten
                case 6:
                    {
                        Console.WriteLine("Skriv in ditt första tal och tryck enter:\n");
                        userInput1 = GetNumberFromUser();
                        var res1 = Sqrroot(userInput1);
                        Console.WriteLine("Kvadratroten av " + userInput1 + " = " + res1);
                        Console.ReadLine();
                        return true;
                    }


                #endregion 

                default:
                    return true;
            }



        }

        private static Exception DivideByZeroException()
        {
            throw new NotImplementedException();
        }

        public static double Sqrroot(double userInput)
        {
            var result = Math.Sqrt(userInput);
            return result;
        }

        public static double Pow2(double userInput)
        {
            var result = Math.Pow(userInput, 2);
            return result;
        }

        public static double Division(double userInput1, double userInput2)
        {
            
                double res = userInput1 / userInput2;
                return res;
            
        }

        public static double Multiplication(double userInput1, double userInput2)
        {
            var result = userInput1 * userInput2;
            return result;
        }

        public static double Subtraction(double userInput1, double userInput2)
        {
            var result = userInput1 - userInput2;
            return result;
        }
        public static double Subtraction(string[] arr)
        {
            bool myBool1;
            double myDouble;
            double firstNum = double.Parse(arr[0]);
            var res = firstNum;
            for (int i = 1; i < arr.Length; i++)
            {
                myBool1 = double.TryParse(arr[i], out myDouble);
                if (myBool1)
                {
                    res -= myDouble;
                }
            }
            return res;
        }

        public static double Addition(double userInput1, double userInput2)
        {
            return userInput1 + userInput2;
        }

        public static double Addition(string[] arr)
        {
            bool myBool1 = true;
            double res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                myBool1 = double.TryParse(arr[i], out double myDouble);
                if (myBool1)
                {
                    res += myDouble;
                }
            }
            return res;
        }

        public static double GetNumberFromUser()
        {
            double userInput = 0;
            bool succeeded = false;
            while (!succeeded)
            {
                succeeded = double.TryParse(Console.ReadLine(), out userInput);
            }
            return userInput;
        }

    }
}
