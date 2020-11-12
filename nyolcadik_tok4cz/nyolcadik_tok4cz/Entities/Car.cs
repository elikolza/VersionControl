using nyolcadik_tok4cz.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyolcadik_tok4cz.Entities
{
    public class Car : Toy
    {
        private Color carColor;

        public Car(Color carColor)
        {
            this.carColor = carColor;
        }

        protected override void DrawImage(Graphics g)
        {
            Image imageFile = Image.FromFile("Images/car.png");
            g.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }
    }
}
