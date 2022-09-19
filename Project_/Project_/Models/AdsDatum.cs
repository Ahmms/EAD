using System;
using System.Collections.Generic;

namespace Project_.Models
{
    public partial class AdsDatum: Entity
    {
        public int Id { get; set; }
        public string? City { get; set; }
        public string? Model { get; set; }
        public string? Make { get; set; }
        public string? Variant { get; set; }
        public string? RegisterdIn { get; set; }
        public string? EColor { get; set; }
        public string? Mileage { get; set; }
        public string? Price { get; set; }
        public string? Description { get; set; }
        public string? SellerName { get; set; }
        public string? MobNumber { get; set; }
        public string? UserName { get; set; }
        public string? Image { get; set; }

    }
}
