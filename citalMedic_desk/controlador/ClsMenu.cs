using System;
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

        public IList<medico> getDoc()
        {
            using (citalMedicEntities1 bd = new citalMedicEntities1())
            {
                var doc = (from l in bd.medico
                           select l).ToList();

                // insert paci
                //DateTime fec = Convert.ToDateTime("22/01/1996");
                //bd.sp_insertPaciente("Knox Vasquez", "Imani Cook", 1, "1007116776", fec, "enim.non@aol.org", "P.O. Box 995, 7980 Cursus. Av.", "Termini Imerese");

                //cita
                DateTime fecCreation = Convert.ToDateTime("05/11/2022");
                DateTime fecCita = Convert.ToDateTime("05/02/2023");
                TimeSpan horaCita = TimeSpan.Parse("19:54:15");


                bd.sp_insertCita(fecCreation, fecCita, horaCita, 2, 5);

                return doc; 

                //insert medic
                //bd.sp_insertMedic("Mccullough Marvin", "Rosendo", 2, "1001234567", "Marvin@hotmail.com", "Pediatra");

                
            }
        }


    }
}
