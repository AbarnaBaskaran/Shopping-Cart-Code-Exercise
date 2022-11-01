using Sample1.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1.Interfaces
{
    public interface IObjectInterface
    {
        Product WithDescription(string description);
        Product WithUnitPrice(decimal unitPrice);
        Product WithQuantity(int quantity);
        Product WithWeight(decimal weight);

    }
}
