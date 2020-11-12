using nyolcadik_tok4cz.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyolcadik_tok4cz.Entities
{
   public class CarFactory : IToyFactory
    {
        public Color CarColor { get; set; }

        public Toy CreateNew()
        {
            return new Car(CarColor);
        }
    }
}
