using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Attributes
{
    public class CustomDateRange : RangeAttribute
    {
        public CustomDateRange()
          : base(typeof(DateTime),
                  DateTime.SpecifyKind(new DateTime(1900, 1, 1), DateTimeKind.Utc).ToShortDateString(),
                  DateTime.UtcNow.ToShortDateString())
        { }

        public override string FormatErrorMessage(string name)
        {
            return $"{name} restricted from {Minimum} to {Maximum}!";
        }
    }
}
