using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetControl.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        // Identificação
        public string Plate { get; set; } = null!;
        public string? Renavam { get; set; }
        public string? Chassis { get; set; }

        // Dados gerais
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int YearManufacture { get; set; }
        public int YearModel { get; set; }
        public string? Color { get; set; }

        // Operação
        public string? FuelType { get; set; }
        public int CurrentMileage { get; set; }

        // Multiempresa
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null!;
    }
}
