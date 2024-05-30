using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using middleware_edit.Models;
using System.Linq;

namespace middleware_edit.Filters
{
    public class ValidFirstName:ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext context)
        {

            var dictionary = context.ActionArguments.FirstOrDefault(I => I.Key == "customer");

            var customer = dictionary.Value as Customer;

            if (customer.FirstName == "HMD")
            {
                context.Result = new RedirectResult("/File/List");
            }

            base.OnActionExecuting(context);
        }

    }
}
