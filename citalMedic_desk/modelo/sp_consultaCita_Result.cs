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
    
    public partial class sp_consultaCita_Result
    {
        public byte id { get; set; }
        public Nullable<System.DateTime> fecha_cita { get; set; }
        public string Medico { get; set; }
        public string Paciente { get; set; }
        public string Cédula { get; set; }
        public string correo { get; set; }
    }
}
