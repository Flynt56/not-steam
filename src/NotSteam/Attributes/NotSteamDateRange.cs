using System;
using System.ComponentModel.DataAnnotations;

namespace NotSteam.Attributes
{
    public class NotSteamDateRange : RangeAttribute
    {
        public NotSteamDateRange(int startYearOffset)
          : base(typeof(DateTime),
                  DateTime.Now.AddYears(startYearOffset).ToShortDateString(),
                  DateTime.Now.ToShortDateString())
        { }

        public NotSteamDateRange() : this(-100)
        {}

        public override string FormatErrorMessage(string name)
        {
            return $"{name} restricted between {Minimum} and {Maximum}!";
        }
    }
}