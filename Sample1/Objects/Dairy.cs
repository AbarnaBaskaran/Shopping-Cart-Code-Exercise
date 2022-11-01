using Sample1.Enums;
using Sample1.Factory;
using Sample1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1.Objects
{
    public class Dairy : Product
    {
        /// <summary>
        /// Initialize constructor
        /// </summary>
       public Dairy()
        {
            this.Type = TypeOfProduct.Dairy;
        }
    }
}
