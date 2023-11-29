namespace IoCPrincipleExercise
{
    internal class CustomerBusinessLogic : IDataAccessDependency
    {
        private ICustomerDataAccess _customerDataAccess;

        //property injection
        public ICustomerDataAccess CustomerDataAccess { get; set; }

        public CustomerBusinessLogic() { }

        //constructor injection
        public CustomerBusinessLogic(ICustomerDataAccess customerDataAccess)
        {
            _customerDataAccess = customerDataAccess;
        }

        public string GetCustomerName(int id)
        {
            return _customerDataAccess.GetCustomerName(id);
        }

        //method injection
        public void SetDependency(ICustomerDataAccess customerDataAccess)
        {
            _customerDataAccess = customerDataAccess;
        }
    }
}
