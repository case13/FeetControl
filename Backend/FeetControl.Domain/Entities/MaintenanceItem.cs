using FeetControl.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetControl.Domain.Entities
{
    public class MaintenanceItem : BaseEntity
    {
        // Maintenance Order
        public int MaintenanceOrderId { get; set; }
        public MaintenanceOrder MaintenanceOrder { get; set; } = null!;

        // Item type
        public MaintenanceItemTypeEnum ItemType { get; set; }   // Service or Part

        // Description
        public string Description { get; set; } = null!;

        // Financial
        public decimal Quantity { get; set; } = 1;
        public decimal UnitCost { get; set; }
        public decimal TotalCost { get; set; }

        // Warranty (for parts and/or services)
        public int? WarrantyMonths { get; set; }
        public DateTime? WarrantyEndDate { get; set; }

        // Notes
        public string? Notes { get; set; }

        // Multi-company
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null!;
    }
}
