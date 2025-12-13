using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetControl.Shared.Enums
{
    public enum DocumentTypeDriverEnum
    {
        [Display(Name = "CNH")]
        DriverLicense = 1,

        [Display(Name = "Exame médico")]
        MedicalExam = 2,

        [Display(Name = "Exame psicológico")]
        PsychologicalExam = 3,

        [Display(Name = "Certificado de treinamento")]
        TrainingCertificate = 4,

        [Display(Name = "Outro")]
        Other = 99
    }
}
