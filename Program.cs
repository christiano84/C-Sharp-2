using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{

    public class Program
    {

        // ------ FUNCTIONS ----------
        static double GetSum(double x = 1, double y = 1)
        {
            return x + y;
        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
        
        public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }

        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach(int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine($"{name} lives in the zip code {zipCode}");
        }

        static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        }
        static double GetSum2(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);

            return dblX + dblY;
        }

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine($"The car was painted {cc} with the code {(int)cc}");
        }


        // ------ END OF FUNCTIONS ------

        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }


        static void Main(string[] args)
        {

            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            foreach (Shape s in shapes)
            {
                s.GetInfo();

                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());

                Circle testCirc = s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }

                if (s is Circle)
                {
                    Console.WriteLine("This isn't a Rectangle");
                }
            }

            object circ1 = new Circle(4);

            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrr"
            };

            grover.Sound = "Woooof";
            
            whiskers.MakeSound();
            grover.MakeSound();
            whiskers.SetAnimalIDInfo(12345, "Sally Smith");
            grover.SetAnimalIDInfo(12346, "Paul Brown");
            whiskers.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
            Console.WriteLine($"Is my animal healthy : {getHealth.HealthyWeight(11, 46)}");
            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Woooooofff",
                Sound2 = "Geerrrr"
            };
            spot.MakeSound();




            Console.WriteLine($"Area of Rectangle {ShapeMath.GetArea("rectangle", 5, 6)}");

            int? randNum = null;

            if (randNum == null) 
            {
                Console.WriteLine("randNum is null");
            }

            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum is null");
            }

            Console.WriteLine(typeof(CarColor));
            CarColor car1 = CarColor.Blue;

            PaintCar(car1);

            Console.WriteLine($"5.0 + 4.0 = {GetSum2(5.0, 4.0)}");
            Console.WriteLine($"5.0 + 4.0 = {GetSum2("5.0", "4.0")}");

            Console.WriteLine(GetSum2(y: 1));
       
    

            PrintInfo(zipCode: 15147, name: "Derek Banas");
            
            Console.WriteLine($"1+2+3 = {GetSumMore(1, 2, 3, 4)}");

           
       

            double x = 5;
            double y = 4;

            Console.WriteLine($"5 + 4 = {GetSum(x, y)}");

            int num3 = 10;
            int num4 = 20;

            Console.WriteLine($"Before Swap num1 {num3} : num2 : {num4} ");
            Swap(ref num3, ref num4);
            Console.WriteLine($"After Swap num1 {num3} : num2 : {num4} ");
        }   
    }
}
    