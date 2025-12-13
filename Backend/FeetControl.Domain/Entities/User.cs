using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetControl.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;

        public string? Phone { get; set; }

        // Multiempresa simples — usuário pertence a uma empresa
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null!;
    }
}
