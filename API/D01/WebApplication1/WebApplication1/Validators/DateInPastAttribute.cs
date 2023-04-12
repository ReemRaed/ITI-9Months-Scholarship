using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Validators
{
    public class DateInPastAttribute:ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            DateTime? date = value as DateTime?;
          if(date is null) { return false; }
          if(date < DateTime.Now) { return false; }
          else { return true; }

        }

    }
}
