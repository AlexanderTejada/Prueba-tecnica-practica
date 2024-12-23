﻿using System.ComponentModel.DataAnnotations;

namespace Prueba_Tecnica.Modelos.Dto
{
    public class VillaDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        public string Detalle { get; set; }

        [Required]
        public double Tarifa { get; set; } // Asegúrate que aquí sea double si en la DB es double
        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }
        public string ImageUrl { get; set; }

        public string Amenidad { get; set; }
    }
}