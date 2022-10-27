namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car()
            {
                Make = "Ford",
                Model = "Expedition",
                Year = 2015
            };
            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);
        }
    }
}
