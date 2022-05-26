using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citalMedic_desk.controlador
{
    static class CleanUp
    {
        public static void limpiarCajas(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }
            }
        }

        public static void limpiarCajas(Control control, GroupBox Gb)//  limpia el contenido de un textBox & reubicar el ComboBox
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }
            }

            //Para textbox contenidos en un GroupBox
            foreach (var gb in Gb.Controls)
            {
                if (gb is TextBox)
                {
                    ((TextBox)gb).Clear();
                }
                else if (gb is ComboBox)
                {
                    ((ComboBox)gb).SelectedIndex = 0;
                }
            }
        }
    }
}
