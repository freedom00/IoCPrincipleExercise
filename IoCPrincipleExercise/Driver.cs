namespace IoCPrincipleExercise
{
    internal class Driver
    {
        private ICar _car;

        public ICar Car { get { return _car; } set { _car = value; } }

        public Driver() { }

        public Driver(ICar car)
        {
            _car = car;
        }

        public void UserCar(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile", _car.GetType().Name, _car.Run());
        }
    }
}
