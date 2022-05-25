using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using citalMedic_desk.controlador;

namespace citalMedic_desk.vista
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsMenu objMenu = new ClsMenu();
            //string tt = objMenu.prueba(true);
            //lblText.Text = tt;

            dataGridView1.DataSource = objMenu.getDoc();



        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            FrmPaciente frmPaciente = new FrmPaciente();
            frmPaciente.Show();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            FrmMedico frmMedico = new FrmMedico();
            frmMedico.Show();
        }
    }
}
