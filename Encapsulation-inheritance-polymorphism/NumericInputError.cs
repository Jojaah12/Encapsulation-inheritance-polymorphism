using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_polymorphism
{
    public class NumericInputError : UseError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field";
        }
    }
}
