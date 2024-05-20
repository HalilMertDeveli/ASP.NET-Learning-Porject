using System.Collections.Generic;

namespace middleware_edit.Models
{
    public static class CustomerContext
    {
        public static List<CustomerModel> Customers = new List<CustomerModel>
        {
            new CustomerModel(){Id = 1,FirstName  ="HT",LastName="T",Age = 22},
            new CustomerModel(){Id = 2,FirstName  ="HMD",LastName="SS",Age = 24},
            new CustomerModel(){Id = 3,FirstName  ="F",LastName="C",Age = 24},
        };
    }
}
