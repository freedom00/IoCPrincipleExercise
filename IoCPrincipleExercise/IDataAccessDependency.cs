namespace IoCPrincipleExercise
{
    //implement DI (Dependency Injection) by method injection
    internal interface IDataAccessDependency
    {
        void SetDependency(ICustomerDataAccess customerDataAccess);
    }
}
