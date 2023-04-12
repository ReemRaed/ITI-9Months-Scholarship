using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.RegularExpressions;
using WebApplication1.Models;

namespace WebApplication1.Filters
{
    public class validateTypeAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var car = context.ActionArguments["car"] as Car;
            var regex = new Regex("^(Electric| Gas| Diesel | Hybrid)$",
                RegexOptions.IgnoreCase,
                TimeSpan.FromSeconds(2));
            if (car is  null || !regex.IsMatch(car.Type))
            {
                context.ModelState.AddModelError("Type","Type not valid");
                context.Result = new BadRequestObjectResult(context.ModelState);
            }


        }
    }
}
