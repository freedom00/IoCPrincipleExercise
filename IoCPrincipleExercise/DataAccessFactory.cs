namespace IoCPrincipleExercise
{
    //implement IoC (Inversion of Control) using Factory Pattern
    internal class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }
}
