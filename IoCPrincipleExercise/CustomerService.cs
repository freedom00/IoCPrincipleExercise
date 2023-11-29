namespace IoCPrincipleExercise
{
    internal class CustomerService
    {
        CustomerBusinessLogic _customerBusinessLogic;
        public CustomerService()
        {
            //constructor injection
            //_customerBusinessLogic = new CustomerBusinessLogic(new CustomerDataAccess());

            //property injection
            //_customerBusinessLogic = new CustomerBusinessLogic();
            //_customerBusinessLogic.CustomerDataAccess = new CustomerDataAccess();

            //method injection
            _customerBusinessLogic = new CustomerBusinessLogic();
            _customerBusinessLogic.SetDependency(new CustomerDataAccess());
        }

        public string GetCustomerName(int id)
        {
            return _customerBusinessLogic.GetCustomerName(id);
        }
    }
}
