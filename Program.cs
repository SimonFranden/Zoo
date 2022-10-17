//Labb 6 Simon Frändén (net22)
using System.Drawing;
using System.Reflection;
using System.Xml.Linq;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pig pig1 = new("Greta", 2015, "Rosa", "Hona", "Äpplen", false);
            Moose moose1 = new("Helge", 2010, "Brun", "Hane", "Gräs", 12);
            Dog dog1 = new("Snobben", 2015, "Brun", "Hane", "Hundmat", true);
            Bulldog bulldog1 = new("Helge", 2010, "Brun", "Hane", "Gräs", false, true);

            pig1.MakeSound();
            moose1.MakeSound();
            dog1.MakeSound();
            bulldog1.MakeSound();
        }
    }

    class Animal
    {
        public string Name{get;} = "unknown";
        public int BirthYear{get;} = 0;
        public string Color{get;} = "unknown";
        public string Gender{get;} = "unknown";
        public string Food { get; } = "unknown";

        public Animal(string name, int birthYear, string color, string gender, string food)
        {
            Name = name;
            BirthYear = birthYear;
            Color = color;
            Gender = gender;
            Food = food;
            
        }

        public void Eat()
        {
            Console.WriteLine("*Djuret " + Name + " äter " + Food + "*");
        }
        public void Sleep()
        {
            Console.WriteLine("*Djuret " + Name + " sover*");
        }
        public void Run()
        {
            Console.WriteLine("*Djuret " + Name + " springer*");
        }
        
        public int GetAge()
        {
            int age = DateTime.Now.Year - BirthYear;
            return age;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Namn: {Name}\nÅlder: {GetAge()}\nFärg: {Color}\nFöda: {Food}");
        }
    }

    class Pig : Animal
    {
        bool isSpotted = false;
        
        public Pig(string name, int birthYear, string color, string gender, string food, bool isSpotted) : base(name, birthYear, color, gender, food)
        {
            this.isSpotted = isSpotted;
            
        }

        public void MakeSound()
        {
            Console.WriteLine("*Nöff Nöff*");
        }

        public new void GetInfo()
        {
            Console.WriteLine($"Namn: {Name}\nÅlder: {GetAge()}\nFärg: {Color}\nFöda: {Food}\nÄr fläckig: {isSpotted}");
        }
        public void Scream()
        {
            Console.WriteLine("*Reeeeeh*");
        }
    }

    class Moose : Animal
    {
        int antlersPoints = 0;
        public Moose(string name, int birthYear, string color, string gender, string food, int antlersPoints) : base(name, birthYear, color, gender, food)
        {
            this.antlersPoints = antlersPoints;
        }

        public void MakeSound()
        {
            Console.WriteLine("*ööoouh*");
        }

        public new void GetInfo()
        {
            Console.WriteLine($"Namn: {Name}\nÅlder: {GetAge()}\nFärg: {Color}\nFöda: {Food}\nTaggar: {antlersPoints}");
        }
        public void Fight()
        {
            Console.WriteLine("*Börjar stångas med en annan älg*");
        }
    }

    class Dog : Animal
    {
        bool isTame = false;
        public Dog(string name, int birthYear, string color, string gender, string food, bool isTame) : base(name, birthYear, color, gender, food)
        {
            this.isTame = isTame;
        }

        public void MakeSound()
        {
            Console.WriteLine("*Woof*");
        }

        public new void GetInfo()
        {
            Console.WriteLine($"Namn: {Name}\nÅlder: {GetAge()}\nFärg: {Color}\nFöda: {Food}\nÄr tam: {isTame}");
        }
        public void Snarl()
        {
            Console.WriteLine("*Grrr*");
        }
    }

    class Bulldog : Dog
    {
        bool needsOperation = false;
        public Bulldog(string name, int birthYear, string color, string gender, string food, bool isTame, bool needsOperation) : base(name, birthYear, color, gender, food, isTame)
        {
            this.needsOperation = needsOperation;
        }

        public void Drool()
        {
            Console.WriteLine("*Drooling*");
        }
    }

    class Saintbernard : Dog
    {
        bool isRescueDog = false;
        public Saintbernard(string name, int birthYear, string color, string gender, string food, bool isTame, bool isRescueDog) : base(name, birthYear, color, gender, food, isTame)
        {
            this.isRescueDog = isRescueDog;
        }

        void Jump()
        {
            Console.WriteLine("*Jumps*");
        }
    }

}