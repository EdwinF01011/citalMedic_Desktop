//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace citalMedic_desk.modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class paciente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Nullable<byte> id_documento { get; set; }
        public string numero_doc { get; set; }
        public Nullable<System.DateTime> fecha_natal { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
    }
}
