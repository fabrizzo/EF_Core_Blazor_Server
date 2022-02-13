using System;
using System.Collections.Generic;

#nullable disable

namespace EF_Core_Blazor_Server
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public int? PersonId { get; set; }
        public int ProductNum { get; set; }
        public int SellPont { get; set; }
        public DateTime DateSell { get; set; }
        public string Purchase { get; set; }

        public virtual User Person { get; set; }
    }
}
