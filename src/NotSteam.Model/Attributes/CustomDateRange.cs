using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Model.Attributes
{
    public class CustomDateRange : ValidationAttribute
    {
        private DateTime Min { get; set; }
        private DateTime Max { get; set; }

        public CustomDateRange()
        {
            Min = DateTime.SpecifyKind(new DateTime(1900, 1, 1), DateTimeKind.Utc);
            Max = DateTime.UtcNow;
        }

        public override string FormatErrorMessage(string name)
        {
            return $"{name} je ograničen od {Min} do {Max}.";
        }

        public override bool IsValid(object value)
        {
            if (value is DateTime)
            {
                var currDate = (DateTime)value;

                return currDate >= Min && currDate <= Max;
            }

            return false;
        }
    }
}
