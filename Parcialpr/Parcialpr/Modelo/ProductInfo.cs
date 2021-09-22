using System;
using System.Collections.Generic;
using System.Text;

namespace Parcialpr
{
    public class ProductInfo
    {
        public String TipoMaterial { get; set; }
        public String NombreMaterial { get; set; }
        public String UnidadesDisponibles { get; set; }

        public ProductInfo(string tipoMaterial, string nombreMaterial, string unidadesDisponibles)
        {
            TipoMaterial = tipoMaterial;
            NombreMaterial = nombreMaterial;
            UnidadesDisponibles = unidadesDisponibles;
        }
    }
}
