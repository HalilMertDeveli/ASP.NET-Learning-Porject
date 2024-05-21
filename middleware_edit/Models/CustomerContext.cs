using System.Collections.Generic;

namespace middleware_edit.Models
{
    public static class CustomerContext
    {
        public static List<Customer> Customers = new List<Customer>
        {
            new Customer(){Id = 1,FirstName  ="HT",LastName="T",Age = 22},
            new Customer(){Id = 2,FirstName  ="HMD",LastName="SS",Age = 24},
            new Customer(){Id = 3,FirstName  ="F",LastName="C",Age = 24},
        };
    }
}
