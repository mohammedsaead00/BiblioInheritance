using System;
using System.Globalization;

namespace BiblioInheritance
{
    class Periodical : Resource
    {
        public string Period
        {
            get; set;
        }
        public Periodical(string title, string category, string period) : base(title, category)
        {
            this.Period = period;
        }
        public override void UpdateStatus()
        {
            if (Status == "Available")
        Status = "In-use";
    else
        Status = "Available";

        }
    }
}