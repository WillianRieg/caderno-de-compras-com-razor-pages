using System;
using System.ComponentModel.DataAnnotations;

namespace RIEG.Compras.Caderno.Pages.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }

        public Urgency Urgency { get; set; }

        public Decimal? Quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime InsertDate { get; set; }
     
    }
}
