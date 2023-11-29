namespace IoCPrincipleExercise
{
    //implement DIP (Dependency Inversion Principle) by creating abstraction
    internal interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }
}
