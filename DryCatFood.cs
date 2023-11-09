using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class DryCatFood : CatFood
    {
        public double WeightPounds { get; set; }

        public DryCatFood(double weightpounds) : base("Cat Food", 2.99m, 1, "Cat Food", false)
        {
            WeightPounds = weightpounds;
        }

    }
}
