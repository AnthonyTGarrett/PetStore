using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public static class ProductLogicExtensions
    {
        public static bool HasLeash(this IProductLogic target)
        {
            if (target.GetAllProducts().Count() == 0)
            {
                return false;
            }
            else
            {
                return false;
            }
            
        }

        public static bool GetLeash(this IProductLogic target)
        {
            return _dogLeash.ContainsKey(name);
        }

        public static bool hasFood(this IProductLogic target)
        {
            return _catfood.ContainsKey(name);
        }

        public static bool hasFood()
        {
            return _catfood.Count != 0;
        }
    }
}
