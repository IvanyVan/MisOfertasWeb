//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MisOfertasFinal.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPRESA
    {
        public EMPRESA()
        {
            this.TIENDA = new HashSet<TIENDA>();
        }
    
        public decimal ID_EMPRESA { get; set; }
        public string NOMBRE_EMPRESA { get; set; }
        public string RUT_EMPRESA { get; set; }
        public string GIRO { get; set; }
    
        public virtual ICollection<TIENDA> TIENDA { get; set; }
    }
}