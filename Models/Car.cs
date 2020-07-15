using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace DZ_CAR.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public Color Color { get; set; }
        public Kuzov Kuzov { get; set; }
        public double Power { get; set; }
    }
}
