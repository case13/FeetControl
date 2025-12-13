using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetControl.Domain.Entities
{
    public class Workshop : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Document { get; set; }      // CNPJ ou CPF
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        // Multiempresa
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null!;
    }
}
