using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using citalMedic_desk.modelo;

namespace citalMedic_desk.controlador
{
    public class ClsFormulario
    {
        public void insertPaciente(string text1, string text2, Byte id_docP, string text3, DateTime fecha, string text4, string text5, string text6)
        {
            using (citalMedicEntities1 bd = new citalMedicEntities1())
            {
                bd.sp_insertPaciente(text1, text2, id_docP, text3, fecha, text4, text5, text6);
            }
        }

        public void insertMedico(string text1, string text2, byte id_docM, string text3, string text4, string text5)
        {
            using (citalMedicEntities1 bd = new citalMedicEntities1())
            {
                bd.sp_insertMedic(text1, text2, id_docM, text3, text4, text5);
            }
        }

        public IList<documento> getDates_cbox()
        {
            using (citalMedicEntities1 bd = new citalMedicEntities1())
            {
                var tipoDoc = bd.documento.OrderBy(x => x.tipo).ToList();
                return tipoDoc;
            }
        }
    }
}
