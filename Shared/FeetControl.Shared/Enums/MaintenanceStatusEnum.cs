using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetControl.Shared.Enums
{
    public enum MaintenanceStatusEnum
    {
        [Display(Name = "Aberta")]
        Open = 1,
        [Display(Name = "Em andamento")]
        InProgress = 2,
        [Display(Name = "Concluída")]
        Completed = 3,
        [Display(Name = "Cancelada")]
        Canceled = 4
    }
}
