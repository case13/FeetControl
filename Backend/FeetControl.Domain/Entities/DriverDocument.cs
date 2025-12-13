using FeetControl.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetControl.Domain.Entities
{
    public class DriverDocument : BaseEntity
    {
        public int DriverId { get; set; }
        public Driver Driver { get; set; } = null!;

        public DocumentTypeDriverEnum DocumentType { get; set; }

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
