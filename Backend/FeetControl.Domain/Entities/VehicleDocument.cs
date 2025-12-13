using FeetControl.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetControl.Domain.Entities
{
    public class VehicleDocument : BaseEntity
    {
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; } = null!;

        public DocumentTypeVehicleEnum DocumentType { get; set; }

        public string? DocumentNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public string Status { get; set; } = "Active";
        public string? Notes { get; set; }
        public string? FilePath { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; } = null!;
    }
}
