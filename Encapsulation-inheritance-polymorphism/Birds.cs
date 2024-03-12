using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_polymorphism
{
    public class Pelican : Bird
    {
        public double BeakLength { get; set; }

        public Pelican(string name, double weight, int age, double wingSpan, double beakLength)
            : base(name, weight, age, wingSpan)
        {
            BeakLength = beakLength;
        }
    }

    public class Flamingo : Bird
    {
        public string LegColor { get; set; }

        public Flamingo(string name, double weight, int age, double wingSpan, string legColor)
            : base(name, weight, age, wingSpan)
        {
            LegColor = legColor;
        }
    }

    public class Swan : Bird
    {
        public double NeckLength { get; set; }

        public Swan(string name, double weight, int age, double wingSpan, double neckLength)
            : base(name, weight, age, wingSpan)
        {
            NeckLength = neckLength;
        }
    }
}