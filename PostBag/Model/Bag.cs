using System;
using System.Collections.Generic;
using System.Text;

namespace PostBag.Model
{
    class Bag
    {
        public List<Consignment> Deliveries { get; } = new List<Consignment>();
        public List<IValuable> Valuables { get; } = new List<IValuable>();

        public void Add(Consignment item)
        {
            Deliveries.Add(item);
            if (item is IValuable)
            {
                Valuables.Add((item as IValuable));
            }
        }

        public void Add(PostalOrder item)
        {
            Valuables.Add(item);
        }
    }
}
