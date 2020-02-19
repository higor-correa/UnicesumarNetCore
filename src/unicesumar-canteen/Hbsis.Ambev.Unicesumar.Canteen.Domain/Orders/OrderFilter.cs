using System;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders
{
    public class OrderFilter
    {
        public string ClientName { get; set; }
        public DateTime? InitialDate { get; set; }
        public DateTime? FinalDate { get; set; }
    }
}
