using System;
using System.Collections.Generic;

namespace FinalSis457Jhecm.Models
{
    public partial class Serie
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Sinopsis { get; set; }
        public string? Director { get; set; }
        public DateTime? FechaEstreno { get; set; }
        public bool? RegistroActivo { get; set; }
    }
}
