using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Web_Service.Models
{
    public class Student
    {
        [Key]
        public long Id { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Carrera { get; set; }
        public int CreditosAprobados { get; set; }
        public decimal Indice { get; set; }
        public string CondicionAcademica { get; set; }
        public DateTime FechaIngreso { get; set; }

    }
}
