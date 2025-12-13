using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetControl.Domain.Entities
{
    public class Driver : BaseEntity
    {
        // Dados pessoais
        public string FullName { get; set; } = null!;
        public string? Document { get; set; }          // CPF
        public DateTime? BirthDate { get; set; }

        // CNH
        public string? LicenseNumber { get; set; }
        public string? LicenseCategory { get; set; }
        public DateTime? LicenseExpirationDate { get; set; }

        // Contato
        public string? Phone { get; set; }
        public string? Email { get; set; }

        // Multiempresa
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null!;
    }
}
