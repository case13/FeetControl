using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetControl.Shared.Enums
{
    public enum MaintenanceItemTypeEnum
    {
        [Display(Name = "Serviço")]
        Service = 1,

        [Display(Name = "Peça")]
        Part = 2
    }
}
