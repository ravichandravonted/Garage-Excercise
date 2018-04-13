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
                Console.WriteLine("Enter num for choice");
                Console.WriteLine("Example 1) ");
                Console.WriteLine("0) quit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Example();
                        break;

                    case "0":
                        keeprunning = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect Input");
                        break;
                }

                Console.WriteLine("press any button to continue");
                Console.ReadLine();

            }
        }


        public void Example()
        {
            garage<vehicle> allVehciles = new garage<vehicle>(50);

            char choice = 'y';
            while (choice == 'y')
            {

                Console.WriteLine("1)-Car.");
                Console.WriteLine("2)-Bus.");
                Console.WriteLine("3)-Boat.");
                Console.WriteLine("4)-Plane.");
                Console.WriteLine("5)-Motocycle.");
                Console.WriteLine("Enter Your Choice.");
                char type = Convert.ToChar(Console.ReadLine());
                switch (type)
                {

                    case '1':
                        Console.WriteLine("How Many Cars Do you Want To Add:");

                        int length = int.Parse(Console.ReadLine());
                        for (int i = 0; i < length; i++)
                        {
                            Console.WriteLine("Enter The Car Number:");
                            string Number = Console.ReadLine();
                            Console.WriteLine("Enter The Car Color:");
                            string Color = Console.ReadLine();
                            Console.WriteLine("Enter The number Of Wheels:");
                            int Wheels = int.Parse(Console.ReadLine());
                            Console.WriteLine("Is It Parked");
                            bool Parked = Convert.ToBoolean(Console.ReadLine());
                            Console.WriteLine("Enter The Cars Type:");
                            string Type = Console.ReadLine();
                            allVehciles.Add(new Car(Number, Color, Wheels, Parked, Type));






                        }

                        Console.WriteLine("Do You Want to Add more Vehicles? (Y/N)");

                        char choice1 = Convert.ToChar(Console.ReadLine());

                        if (choice1 == 'n')
                            choice = 'n';

                        break;




                    case '2':
                        Console.WriteLine("How Many Buses Do you Want To Add:");

                        int length1 = int.Parse(Console.ReadLine());
                        for (int i = 0; i < length1; i++)
                        {
                            Console.WriteLine("Enter The bus Number:");
                            string Number = Console.ReadLine();
                            Console.WriteLine("Enter The bus Color:");
                            string Color = Console.ReadLine();
                            Console.WriteLine("Enter The number Of Wheels:");
                            int Wheels = int.Parse(Console.ReadLine());
                            Console.WriteLine("Is It Parked");
                            bool Parked = Convert.ToBoolean(Console.ReadLine());
                            Console.WriteLine("Enter The bus Seats:");
                            int Numofseat = int.Parse(Console.ReadLine());
                            allVehciles.Add(new Bus(Number, Color, Wheels, Parked, Numofseat));



                        }
                        Console.WriteLine("Do You Want to Add more Vehicles? (Y/N)");

                        char choice2 = Convert.ToChar(Console.ReadLine());

                        if (choice2 == 'n')
                            choice = 'n';



                        break;


                    case '3':
                        Console.WriteLine("How Many Boats Do you Want To Add:");

                        int length2 = int.Parse(Console.ReadLine());
                        for (int i = 0; i < length2; i++)
                        {
                            Console.WriteLine("Enter The Boat Number:");
                            string Number = Console.ReadLine();
                            Console.WriteLine("Enter The Boat Color:");
                            string Color = Console.ReadLine();
                            Console.WriteLine("Enter The number Of Wheels:");
                            int Wheels = int.Parse(Console.ReadLine());
                            Console.WriteLine("Is It Parked");
                            bool Parked = Convert.ToBoolean(Console.ReadLine());
                            Console.WriteLine("Enter The Boat Lenght:");
                            double Length = Convert.ToDouble(Console.ReadLine());

                            allVehciles.Add(new Boat(Number, Color, Wheels, Parked, Length));

                        }
                        Console.WriteLine("Do You Want to Add more Vehicles? (Y/N)");

                        char choice3 = Convert.ToChar(Console.ReadLine());

                        if (choice3 == 'n')
                            choice = 'n';

                        break;
                    case '4':
                        Console.WriteLine("How Many Planes Do you Want To Add:");

                        int length3 = int.Parse(Console.ReadLine());
                        for (int i = 0; i < length3; i++)
                        {
                            Console.WriteLine("Enter The Plane Number:");
                            string Number = Console.ReadLine();
                            Console.WriteLine("Enter The Plane Color:");
                            string Color = Console.ReadLine();
                            Console.WriteLine("Enter The number Of Wheels:");
                            int Wheels = int.Parse(Console.ReadLine());
                            Console.WriteLine("Is It Parked");
                            bool Parked = Convert.ToBoolean(Console.ReadLine());
                            Console.WriteLine("Enter The Number Of Engine:");
                            int Engine = int.Parse(Console.ReadLine());
                            allVehciles.Add(new Airplane(Number, Color, Wheels, Parked, Engine));



                        }
                        Console.WriteLine("Do You Want to Add more Vehicles? (Y/N)");

                        char choice4 = Convert.ToChar(Console.ReadLine());

                        if (choice4 == 'n')
                            choice = 'n';

                        break;
                    case '5':
                        Console.WriteLine("How Many Motocycles Do you Want To Add:");

                        int length4 = int.Parse(Console.ReadLine());
                        for (int i = 0; i < length4; i++)
                        {
                            Console.WriteLine("Enter The Motocycle Number:");
                            string Number = Console.ReadLine();
                            Console.WriteLine("Enter The Motocycle Color:");
                            string Color = Console.ReadLine();
                            Console.WriteLine("Enter The number Of Wheels:");
                            int Wheels = int.Parse(Console.ReadLine());
                            Console.WriteLine("Is It Parked");
                            bool Parked = Convert.ToBoolean(Console.ReadLine());
                            Console.WriteLine("Enter The CylinderVolume");
                            double Cvolume = Convert.ToDouble(Console.ReadLine());
                            allVehciles.Add(new Motorcycle(Number, Color, Wheels, Parked, Cvolume));



                        }
                        Console.WriteLine("Do You Want to Add more Vehicles? (Y/N)");

                        char choice5 = Convert.ToChar(Console.ReadLine());

                        if (choice5 == 'n')
                            choice = 'n';

                        break;

                    default:
                        Console.WriteLine("Incorrect Input! Try Again.");
                        break;
                }
            }
            //var garagefilter = allVehciles.Where(x =>x.park==true);




            foreach (vehicle a in  allVehciles)
            {

                Console.WriteLine(a.State());
            }

            Console.ReadLine();
            Console.WriteLine("To Unpark a Vehicle From The Garrage Press U. Else Press Any Key.");
            char f = Convert.ToChar(Console.ReadLine());

            if (f == 'u')
            {
                Console.WriteLine("enter the vehicle registration number you want to unpark from garrage:");
                string v = Console.ReadLine();

                allVehciles.Delete(v);

            }

            foreach (vehicle a in allVehciles)
            {
                if (a != null)
                    Console.WriteLine(a.State());

            }

            //var garagefilter = allVehciles.Where(x => x.Regname == v);
            //Console.WriteLine("after deletion num of vehicles present in the garrage");
            //foreach(vehicle a in  garagefilter)
            //{

            //    Console.WriteLine(a.State());
            //}
            Console.ReadLine();




            MainMenu();
            //garagefilter.Last();
        }

    }
}
