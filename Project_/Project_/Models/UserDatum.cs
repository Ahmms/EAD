using System;
using System.Collections.Generic;

namespace Project_.Models
{
    public partial class UserDatum: Entity
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? SName { get; set; }
        public string? Mail { get; set; }
        public string? Pswd { get; set; }
        public string? Gend { get; set; }
        public string? Number { get; set; }
    }
}
