using Sample1.Factory;
using Sample1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1.Objects
{
    public class Meat : Product
    {
        /// <summary>
        /// Initialize constructor
        /// </summary>
        public Meat()
        {
            this.Type = Enums.TypeOfProduct.Meat;
        }
    }
}
