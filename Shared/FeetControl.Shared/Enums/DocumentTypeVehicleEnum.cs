using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetControl.Shared.Enums
{
    public enum DocumentTypeVehicleEnum
    {
        [Display(Name = "Licenciamento (CRLV)")]
        Licensing = 1,

        [Display(Name = "IPVA")]
        IPVA = 2,

        [Display(Name = "Seguro")]
        Insurance = 3,

        [Display(Name = "Vistoria")]
        Inspection = 4,

        [Display(Name = "Outro")]
        Other = 99
    }
}
