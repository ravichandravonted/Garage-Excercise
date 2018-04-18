using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Garage
{
    public class UI
    {

        public void MainMenu()
        {
            bool keeprunning = true;

            while (keeprunning)
            {
                Console.Clear();

                Console.WriteLine("1)-To Create a New Garage");
                Console.WriteLine("0)-Quit");
                Console.WriteLine("*****************************");
                Console.WriteLine("Enter num for choice");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateGarage();
                        break;

                    case "0":
                        keeprunning = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect Input");
                        break;
                }



            }
        }


        public void CreateGarage()
        {
            Console.Clear();
            Console.WriteLine("How Many Vehicles Do You Want To Add:");
            int number;

            bool choose = int.TryParse(Console.ReadLine(), out number);


            if (choose)
            {
                garage<vehicle> allVehciles = new garage<vehicle>(number);



                string choice = "+";
                while (choice == "+")
                {
                    Console.Clear();
                    Console.WriteLine("1)-Car.");
                    Console.WriteLine("2)-Bus.");
                    Console.WriteLine("3)-Boat.");
                    Console.WriteLine("4)-Plane.");
                    Console.WriteLine("5)-Motocycle.");
                    Console.WriteLine("***************");
                    Console.WriteLine("Enter Your Choice.");
                    string type = Console.ReadLine();
                    switch (type)
                    {

                        case "1":
                            Console.Clear();
                            Console.WriteLine("How Many Cars Do you Want To Add:");

                            int length;
                            bool result = int.TryParse(Console.ReadLine(), out length);


                            if (result)
                            {
                                for (int i = 0; i < length; i++)
                                {
                                    Console.WriteLine("Enter The Car Number:");
                                    string Number = Console.ReadLine();
                                    Console.WriteLine("Enter The Car Color:");
                                    string Color = Console.ReadLine();
                                    int Wheels;
                                    do
                                    {
                                        Console.WriteLine("Enter The number Of Wheels:");

                                        bool input = int.TryParse(Console.ReadLine(), out Wheels);
                                        if (input)
                                            break;
                                        else
                                        {
                                            Console.WriteLine("Incorrect Input! Try Again.");
                                            continue;
                                        }

                                    } while (true);

                                    bool Parked;
                                    do
                                    {
                                        Console.WriteLine("Is It Parked: (True/False)");
                                        bool input = bool.TryParse(Console.ReadLine(), out Parked);

                                        if (input)
                                            break;
                                        else
                                        {
                                            Console.WriteLine("Incorrect Input! Try Again.");
                                            continue;
                                        }

                                    } while (true);
                                    Console.WriteLine("Enter The Cars Type:");
                                    string Type = Console.ReadLine();

                                    allVehciles.Prak(new Car(Number, Color, Wheels, Parked, Type));

                                }
                            }


                            else
                            {
                                Console.WriteLine("Incorrect Input! Try Again.");
                                continue;
                            }



                            Console.WriteLine("To Add more Vehicles please Press +. Or Press any key to Continue. ");

                            string choice1 = Console.ReadLine();

                            if (choice1 != "+")
                                choice = "n";

                            break;




                        case "2":
                            Console.Clear();
                            Console.WriteLine("How Many Buses Do you Want To Add:");

                            int length1;
                            bool result1 = int.TryParse(Console.ReadLine(), out length1);

                            if (result1)
                            {
                                for (int i = 0; i < length1; i++)
                                {
                                    Console.WriteLine("Enter The bus Number:");
                                    string Number = Console.ReadLine();
                                    Console.WriteLine("Enter The bus Color:");
                                    string Color = Console.ReadLine();
                                    int Wheels;
                                    do
                                    {
                                        Console.WriteLine("Enter The number Of Wheels:");

                                        bool input = int.TryParse(Console.ReadLine(), out Wheels);
                                        if (input)
                                            break;
                                        else
                                        {
                                            Console.WriteLine("Incorrect Input! Try Again.");
                                            continue;
                                        }

                                    } while (true);
                                    bool Parked;
                                    do
                                    {
                                        Console.WriteLine("Is It Parked: (True/False)");
                                        bool input = bool.TryParse(Console.ReadLine(), out Parked);

                                        if (input)
                                            break;
                                        else
                                        {
                                            Console.WriteLine("Incorrect Input! Try Again.");
                                            continue;
                                        }

                                    } while (true);
                                    int Numofseat;
                                    do
                                    {
                                        Console.WriteLine("Enter The bus Seats:");

                                        bool input = int.TryParse(Console.ReadLine(), out Numofseat);
                                        if (input)
                                            break;
                                        else
                                        {
                                            Console.WriteLine("Incorrect Input! Try Again.");
                                            continue;
                                        }
                                    } while (true);


                                    allVehciles.Prak(new Bus(Number, Color, Wheels, Parked, Numofseat));

                                }
                            }

                            else
                            {
                                Console.WriteLine("Incorrect Input! Try Again.");
                                continue;
                            }

                            Console.WriteLine("To Add more Vehicles please Press +. Or Press any key to Continue. ");

                            string choice2 = Console.ReadLine();

                            if (choice2 != "+")
                                choice = "n";



                            break;


                        case "3":
                            Console.Clear();
                            Console.WriteLine("How Many Boats Do you Want To Add:");

                            int length2;
                            bool result2 = int.TryParse(Console.ReadLine(), out length2);

                            if (result2)
                            {
                                for (int i = 0; i < length2; i++)
                                {
                                    Console.WriteLine("Enter The Boat Number:");
                                    string Number = Console.ReadLine();
                                    Console.WriteLine("Enter The Boat Color:");
                                    string Color = Console.ReadLine();
                                    int Wheels;
                                    do
                                    {
                                        Console.WriteLine("Enter The number Of Wheels:");

                                        bool input = int.TryParse(Console.ReadLine(), out Wheels);
                                        if (input)
                                            break;
                                        else
                                        {
                                            Console.WriteLine("Incorrect Input! Try Again.");
                                            continue;
                                        }

                                    } while (true);

                                    bool Parked;
                                    do
                                    {
                                        Console.WriteLine("Is It Parked: (True/False)");
                                        bool input = bool.TryParse(Console.ReadLine(), out Parked);

                                        if (input)
                                            break;
                                        else
                                        {
                                            Console.WriteLine("Incorrect Input! Try Again.");
                                            continue;
                                        }

                                    } while (true);


                                    double Length;
                                    do
                                    {
                                        Console.WriteLine("Enter The Boat Lenght:");
                                        bool input = double.TryParse(Console.ReadLine(), out Length);
                                        if (input)
                                            break;
                                        else
                                        {
                                            Console.WriteLine("Incorrect Input! Try Again.");
                                            continue;
                                        }
                                    } while (true);




                                    allVehciles.Prak(new Boat(Number, Color, Wheels, Parked, Length));

                                }
                            }

                            else
                            {
                                Console.WriteLine("Incorrect Input! Try Again.");
                                continue;
                            }

                            Console.WriteLine("To Add more Vehicles please Press +. Or Press any key to Continue. ");

                            string choice3 = Console.ReadLine();

                            if (choice3 != "+")
                                choice = "n";

                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("How Many Planes Do you Want To Add:");

                            int length3;
                            bool result3 = int.TryParse(Console.ReadLine(), out length3);

                            if (result3)
                            {
                                for (int i = 0; i < length3; i++)
                                {
                                    Console.WriteLine("Enter The Plane Number:");
                                    string Number = Console.ReadLine();
                                    Console.WriteLine("Enter The Plane Color:");
                                    string Color = Console.ReadLine();
                                    int Wheels;
                                    do
                                    {
                                        Console.WriteLine("Enter The number Of Wheels:");

                                        bool input = int.TryParse(Console.ReadLine(), out Wheels);
                                        if (input)
                                            break;
                                        else
                                        {
                                            Console.WriteLine("Incorrect Input! Try Again.");
                                            continue;
                                        }

                                    } while (true);
                                    bool Parked;
                                    do
                                    {
                                        Console.WriteLine("Is It Parked: (True/False)");
                                        bool input = bool.TryParse(Console.ReadLine(), out Parked);

                                        if (input)
                                            break;
                                        else
                                        {
                                            Console.WriteLine("Incorrect Input! Try Again.");
                                            continue;
                                        }

                                    } while (true);
                                    int Engine;
                                    do
                                    {
                                        Console.WriteLine("Enter The Number Of Engine:");
                                        bool input = int.TryParse(Console.ReadLine(), out Engine);

                                        if (input)
                                            break;
                                        else
                                        {
                                            Console.WriteLine("Incorrect Input! Try Again.");
                                            continue;
                                        }

                                    } while (true);

                                    allVehciles.Prak(new Airplane(Number, Color, Wheels, Parked, Engine));



                                }
                            }

                            else
                            {
                                Console.WriteLine("Incorrect Input! Try Again.");
                                continue;
                            }

                            Console.WriteLine("To Add more Vehicles please Press +. Or Press any key to Continue. ");

                            string choice4 = Console.ReadLine();

                            if (choice4 != "+")
                                choice = "n";

                            break;
                        case "5":
                            Console.Clear();
                            Console.WriteLine("How Many Motocycles Do you Want To Add:");

                            int length4;
                            bool result4 = int.TryParse(Console.ReadLine(), out length4);

                            if (result4)
                            {
                                for (int i = 0; i < length4; i++)
                                {
                                    Console.WriteLine("Enter The Motocycle Number:");
                                    string Number = Console.ReadLine();
                                    Console.WriteLine("Enter The Motocycle Color:");
                                    string Color = Console.ReadLine();
                                    int Wheels;
                                    do
                                    {
                                        Console.WriteLine("Enter The number Of Wheels:");

                                        bool input = int.TryParse(Console.ReadLine(), out Wheels);
                                        if (input)
                                            break;
                                        else
                                        {
                                            Console.WriteLine("Incorrect Input! Try Again.");
                                            continue;
                                        }

                                    } while (true);
                                    bool Parked;
                                    do
                                    {
                                        Console.WriteLine("Is It Parked: (True/False)");
                                        bool input = bool.TryParse(Console.ReadLine(), out Parked);

                                        if (input)
                                            break;
                                        else
                                        {
                                            Console.WriteLine("Incorrect Input! Try Again.");
                                            continue;
                                        }

                                    } while (true);
                                    double Cvolume;
                                    do
                                    {
                                        Console.WriteLine("Enter The CylinderVolume");
                                        bool input = double.TryParse(Console.ReadLine(), out Cvolume);
                                        if (input)
                                            break;
                                        else
                                        {
                                            Console.WriteLine("Incorrect Input! Try Again.");
                                            continue;
                                        }
                                    } while (true);

                                    allVehciles.Prak(new Motorcycle(Number, Color, Wheels, Parked, Cvolume));

                                }
                            }

                            else
                            {
                                Console.WriteLine("Incorrect Input! Try Again.");
                                continue;
                            }

                            Console.WriteLine("To Add more Vehicles please Press +. Or Press any key to Continue. ");

                            string choice5 = Console.ReadLine();

                            if (choice5 != "+")
                                choice = "n";

                            break;

                        default:
                            Console.WriteLine("Incorrect Input! Try Again.");
                            break;
                    }
                }
                //var garagefilter = allVehciles.Where(x =>x.park==true);



                //    foreach (vehicle a in garagefilter)
                //    {

                //         Console.WriteLine(a.State());
                //    }

                Console.Clear();

                foreach (vehicle a in allVehciles)
                {

                    Console.WriteLine(a.State());

                }
                Console.WriteLine("**********************************************************************************");
                while (true)
                {

                    Console.WriteLine("To Unpark a Vehicle from garrage Press U. Else Press Any Key.");
                    string f = Console.ReadLine();

                    if (f == "u")
                    {
                        Console.WriteLine("enter the vehicle registration number you want to unpark from garrage:");
                        string input = Console.ReadLine();



                        allVehciles.UnPark(input);
                        continue;


                    }

                    else
                        Console.Clear();
                    foreach (vehicle a in allVehciles)
                    {
                        if (a != null)
                        {


                            Console.WriteLine(a.State());
                            Console.WriteLine("**********************************************************************************");
                        }
                    }
                    break;

                }

                //
                Console.WriteLine();



                while (true)
                {
                    Console.Clear();
                    foreach (vehicle a in allVehciles)
                    {
                        if (a != null)
                            Console.WriteLine(a.State());

                    }

                    Console.WriteLine();
                    Console.WriteLine("**********************************************************************************");
                    Console.WriteLine("To Find a Vehicle in the garrage Press F. Else Press Any Key.");
                    string f = Console.ReadLine();
                    if (f == "f")
                    {
                        Console.WriteLine("Enter The Vehicle Type:  ");
                        string Vtype = Console.ReadLine();
                        Console.WriteLine("Enter The Regisration Number:");
                        string Rnumber = Console.ReadLine();


                        Console.WriteLine();
                        Console.WriteLine();
                        //try
                        //{
                        bool found = false;
                        foreach (vehicle a in allVehciles.Where(x => x.GetType().Name == Vtype && x.Regname == Rnumber))
                        {
                            if (a.GetType().Name == Vtype && a.Regname == Rnumber)
                            {
                                Console.WriteLine(a.State());
                                Console.ReadLine();
                                found = true;
                            }
                            //else if (a.GetType().Name != Vtype || a.Regname != Rnumber)
                            //{
                            //    found = false;
                            //}
                        }
                        //}
                        //catch(Exception e)
                        //{
                        //Console.WriteLine("no more items in the collection list");
                        //}
                        if (!found)

                        {
                            Console.WriteLine("Not Found! Try Again.");

                            Console.ReadLine();
                        }
                        continue;
                    }

                    else
                        Console.Clear();
                    foreach (vehicle a in allVehciles)
                    {
                        if (a != null)
                            Console.WriteLine(a.State());

                    }
                    break;


                }






                //allVehciles.UnParkall();
                //foreach (vehicle a in allVehciles)
                //{
                //    if (a != null)
                //        Console.WriteLine(a.State());

                //    else
                //        MainMenu();

                //}



            }
            else
            {
                Console.WriteLine("Incorrect Input! Try Again.");
            }


            MainMenu();

            //garagefilter.Last();
        }

    }
}
