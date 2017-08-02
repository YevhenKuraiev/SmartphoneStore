using System.Collections.Generic;

namespace SmartphoneStore.DAL.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public IEnumerable<CartLine> Lines { get; set; }
        public bool Shipped { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
