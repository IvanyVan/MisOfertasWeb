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
    
    public partial class COMUNA
    {
        public COMUNA()
        {
            this.TIENDA = new HashSet<TIENDA>();
            this.USUARIO = new HashSet<USUARIO>();
        }
    
        public decimal ID_COMUNA { get; set; }
        public string NOMBRE_COMUNA { get; set; }
        public decimal REGION_ID_REGION { get; set; }
    
        public virtual REGION REGION { get; set; }
        public virtual ICollection<TIENDA> TIENDA { get; set; }
        public virtual ICollection<USUARIO> USUARIO { get; set; }
    }
}
