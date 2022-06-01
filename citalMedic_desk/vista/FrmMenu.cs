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
        ClsMenu objMenu = new ClsMenu();
        public DateTime fec_creacion { get; set; }
        private DateTime fec_cita { get; set; }
        private string hora_creacion { get; set; }
        Byte banderaNum = 0;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objMenu.getDoc();
            loadCbox();
            btnAgendar.Enabled = false;
        }

        public void loadCbox()
        {
            cboxPaciente.DataSource = objMenu.GetPacientes();
            cboxPaciente.DisplayMember = "numero_doc";
            cboxPaciente.ValueMember = "id";
            if (cboxPaciente.Items.Count > 1)
            {
                cboxPaciente.SelectedIndex = -1;
            }

            cboxMedico.DataSource = objMenu.GetMedicos();
            cboxMedico.DisplayMember = "nombre";
            cboxMedico.ValueMember = "id";
            if (cboxMedico.Items.Count > 1)
            {
                cboxMedico.SelectedIndex = -1;
            }
        }

        // BOTONES
        private void button1_Click(object sender, EventArgs e)
        {
            insertCita();
        }

        private void btnReloadDgv_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objMenu.getDoc();
            loadCbox();
            lblText.Text = "";
            btnAgendar.Enabled = false;
            banderaNum = 8;
        }

        //  BOTONES PARA ABRIR FORMS DE REGISTRO
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

        //  SELECCIONAR ITEM COMBOBOX
        private void cboxPaciente_SelectedValueChanged(object sender, EventArgs e)
        {
            lblPaciente.Text = cboxPaciente.Text;
            enableButton();
        }

        private void cboxMedico_SelectedValueChanged(object sender, EventArgs e)
        {
            LblMedico.Text = cboxMedico.Text;
            enableButton();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblText.Text = "";
            lblText.Text = dataTPcita.Value.ToString("dd/MM/yyyy");
            //  PARA PASAR POR PARÁMETROS
            fec_creacion = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            hora_creacion = DateTime.Now.ToString("h:mm:ss");//tt
            fec_cita = Convert.ToDateTime(dataTPcita.Value.ToString("dd/MM/yyyy"));
            enableButton();
        }

        private void insertCita()
        {
            if (banderaNum >= 11)
            {
                objMenu.setCita(fec_creacion, fec_cita, hora_creacion, int.Parse(cboxPaciente.SelectedValue.ToString()), int.Parse(cboxMedico.SelectedValue.ToString()));
                MessageBox.Show("guardado con éxito", "guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void enableButton()
        {// para habilitar el botón de agendar
            banderaNum++;
            if (banderaNum >= 11)
            {
                btnAgendar.Enabled = true;
            }
        }
    }
}
