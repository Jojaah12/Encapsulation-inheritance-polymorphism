using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_polymorphism
{
    public class TextInputError : UseError
    {
        public override string UEMessage()
        {
            return "You tried to use a text inoput iun a numeric only field";
        }
    }
}
