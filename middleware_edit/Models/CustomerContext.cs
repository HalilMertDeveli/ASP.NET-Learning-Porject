using System.Collections.Generic;

namespace middleware_edit.Models
{
    public static class CustomerContext
    {
        public static List<CustomerModel> customerModelList = new List<CustomerModel>
        {
            new CustomerModel(){CustomerId = 1,FirstName  ="Yusuf",LastName="Erduran",Age = 24},
            new CustomerModel(){CustomerId = 2,FirstName  ="HMD",LastName="SS",Age = 24},
            new CustomerModel(){CustomerId = 3,FirstName  ="HMD",LastName="SS",Age = 24},
        };
    }
}
