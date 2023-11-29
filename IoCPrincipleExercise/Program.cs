namespace IoCPrincipleExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(new CustomerService().GetCustomerName(0));

            //constructor injection
            Driver driver1 = new Driver(new Ford());
            driver1.RunCar();

            //property injection
            Driver driver2 = new Driver();
            driver2.Car = new BMW();
            driver2.RunCar();

            //method injection
            Driver driver3 = new Driver();
            driver3.UserCar(new Audi());
            driver3.RunCar();
        }
    }
}
