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
    public partial class FrmPaciente : Form
    {
        ClsFormulario _clsFormulario = new ClsFormulario();
        private Byte id_docP { get; set; }

        bool bandera = false;

        public FrmPaciente()
        {
            InitializeComponent();
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            loadCbox();
        }

        private void loadCbox()
        {
            cbx_paci.DataSource= _clsFormulario.getDates_cbox();
            cbx_paci.DisplayMember = "tipo";
            cbx_paci.ValueMember = "id";
            bandera = true;
        }

        private void cbx_paci_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bandera)
            {
                var id = cbx_paci.SelectedValue.ToString();
                lblTipo_doc.Text = id;
                id_docP = Byte.Parse(id);
            }
        }

        private void btnGuardar_paci_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(dtpPaciente.Value.ToString("dd/MM/yyyy"));
            //MessageBox.Show(fecha);
            _clsFormulario.insertPaciente(txtNameP.Text, txtApellidoP.Text, id_docP, txtNumberDoc_p.Text, fecha, txtCorreoP.Text, txtDireccionP.Text, txtCiudadP.Text);
            CleanUp.limpiarCajas(this);
            MessageBox.Show("Guardado con éxito","guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
