
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Models.Attributes
{
    public class CustomMaxStringLength : StringLengthAttribute
    {
        public CustomMaxStringLength(int maximumLength) : base(maximumLength)
        { }

        public override string FormatErrorMessage(string name)
        {
            return $"\"{name}\" je ograničen na {MaximumLength} znakova!";
        }
    }
}

