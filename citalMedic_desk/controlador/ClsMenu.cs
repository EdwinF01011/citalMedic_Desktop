using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using citalMedic_desk.modelo;

namespace citalMedic_desk.controlador
{
    public class ClsMenu
    {
        public string prueba(bool x)
        {
            MessageBox.Show("runnnn");
            return "listo";
        }

        public IList getDoc()
        {
            using (citalMedicEntities1 bd = new citalMedicEntities1())
            {
                //var doc = (from l in bd.cita
                //           select l).ToList();

                var doc = bd.sp_consultaCita().ToList();

                return doc;



                // insert paci
                //DateTime fec = Convert.ToDateTime("22/01/1996");
                //bd.sp_insertPaciente("Knox Vasquez", "Imani Cook", 1, "1007116776", fec, "enim.non@aol.org", "P.O. Box 995, 7980 Cursus. Av.", "Termini Imerese");

                //cita
                //DateTime fecCreation = Convert.ToDateTime("05/11/2022");
                //DateTime fecCita = Convert.ToDateTime("05/02/2023");
                //TimeSpan horaCita = TimeSpan.Parse("19:54:15");
                //bd.sp_insertCita(fecCreation, fecCita, horaCita, 2, 5);



                //insert medic
                //bd.sp_insertMedic("Mccullough Marvin", "Rosendo", 2, "1001234567", "Marvin@hotmail.com", "Pediatra");


            }
        }

        public IList<paciente> GetPacientes()
        {
            using (citalMedicEntities1 bd = new citalMedicEntities1())
            {
                var paci = bd.paciente.OrderBy(x => x.nombre).ToList();
                return paci;
            }
        }

        public IList<medico> GetMedicos()
        {
            using (citalMedicEntities1 bd = new citalMedicEntities1())
            {
                var medi = bd.medico.OrderBy(x => x.nombre).ToList();
                return medi;
            }
        }

        public void setCita(DateTime fecha_creacion,DateTime fecha_cita,string hora_cita, int id_paciente, int id_medico)
        {
            TimeSpan horaCita = TimeSpan.Parse(hora_cita.ToString());
            using (citalMedicEntities1 bd = new citalMedicEntities1())
            {
                bd.sp_insertCita(fecha_creacion, fecha_cita, horaCita, id_paciente, id_medico);
            }
        }

    }
}
