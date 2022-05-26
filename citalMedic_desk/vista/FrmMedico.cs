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
    public partial class FrmMedico : Form
    {
        ClsFormulario _clsFormulario = new ClsFormulario();
        private Byte id_docM { get; set; }
        bool bandera = false;
        public FrmMedico()
        {
            InitializeComponent();
        }

        private void FrmMedico_Load(object sender, EventArgs e)
        {
            loadCbox();
        }

        private void loadCbox()
        {
            cbx_medic.DataSource = _clsFormulario.getDates_cbox();
            cbx_medic.DisplayMember = "tipo";
            cbx_medic.ValueMember = "id";
            bandera = true;
        }

        private void cbx_medic_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bandera)
            {
                var id = cbx_medic.SelectedValue.ToString();
                lblTipoDoc.Text = id;
                id_docM = Byte.Parse(id);
            }
        }

        private void btnGuardar_medic_Click(object sender, EventArgs e)
        {
            _clsFormulario.insertMedico(txtNameM.Text, txtApellidoM.Text, id_docM, txtNumberDoc_m.Text, txtCorreoM.Text, txtEspecialidad_medic.Text);
            CleanUp.limpiarCajas(this);
            MessageBox.Show("Guardado con éxito", "guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
