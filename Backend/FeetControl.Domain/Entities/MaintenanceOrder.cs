using FeetControl.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetControl.Domain.Entities
{
    public class MaintenanceOrder : BaseEntity
    {
        // Vehicle
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; } = null!;

        // Workshop (optional)
        public int? WorkshopId { get; set; }
        public Workshop? Workshop { get; set; }

        // Dates
        public DateTime EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }

        // Mileage
        public int MileageAtEntry { get; set; }
        public int? MileageAtExit { get; set; }

        // Status
        public MaintenanceStatusEnum Status { get; set; } = MaintenanceStatusEnum.Open;

        // Financial
        public decimal TotalCost { get; set; }

        // Notes
        public string? Notes { get; set; }

        // Multi-company
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null!;

        // Items
        public ICollection<MaintenanceItem>? Items { get; set; }
    }
}
