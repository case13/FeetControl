using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetControl.Domain.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? TradeName { get; set; }        
        public string? Document { get; set; }         
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string StatusCompany { get; set; } = "Ativa"; // Ex: Ativa, Inativa, Suspensa, etc.  
        public ICollection<User>? Users { get; set; }
    }
}
