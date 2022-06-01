
namespace citalMedic_desk.vista
{
    partial class FrmPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar_paci = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameP = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreoP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccionP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCiudadP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumberDoc_p = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_paci = new System.Windows.Forms.ComboBox();
            this.lblTipo_doc = new System.Windows.Forms.Label();
            this.dtpPaciente = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Añadir Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 52);
            this.label1.TabIndex = 15;
            this.label1.Text = "citalMedic";
            // 
            // btnGuardar_paci
            // 
            this.btnGuardar_paci.Location = new System.Drawing.Point(434, 540);
            this.btnGuardar_paci.Name = "btnGuardar_paci";
            this.btnGuardar_paci.Size = new System.Drawing.Size(88, 39);
            this.btnGuardar_paci.TabIndex = 17;
            this.btnGuardar_paci.Text = "Guardar";
            this.btnGuardar_paci.UseVisualStyleBackColor = true;
            this.btnGuardar_paci.Click += new System.EventHandler(this.btnGuardar_paci_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // txtNameP
            // 
            this.txtNameP.Location = new System.Drawing.Point(42, 154);
            this.txtNameP.MaxLength = 20;
            this.txtNameP.Name = "txtNameP";
            this.txtNameP.Size = new System.Drawing.Size(269, 26);
            this.txtNameP.TabIndex = 19;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(42, 218);
            this.txtApellidoP.MaxLength = 20;
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(269, 26);
            this.txtApellidoP.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Apellido";
            // 
            // txtCorreoP
            // 
            this.txtCorreoP.Location = new System.Drawing.Point(42, 361);
            this.txtCorreoP.MaxLength = 40;
            this.txtCorreoP.Name = "txtCorreoP";
            this.txtCorreoP.Size = new System.Drawing.Size(269, 26);
            this.txtCorreoP.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Correo";
            // 
            // txtDireccionP
            // 
            this.txtDireccionP.Location = new System.Drawing.Point(42, 432);
            this.txtDireccionP.MaxLength = 40;
            this.txtDireccionP.Name = "txtDireccionP";
            this.txtDireccionP.Size = new System.Drawing.Size(269, 26);
            this.txtDireccionP.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Dirección";
            // 
            // txtCiudadP
            // 
            this.txtCiudadP.Location = new System.Drawing.Point(42, 504);
            this.txtCiudadP.MaxLength = 20;
            this.txtCiudadP.Name = "txtCiudadP";
            this.txtCiudadP.Size = new System.Drawing.Size(269, 26);
            this.txtCiudadP.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ciudad";
            // 
            // txtNumberDoc_p
            // 
            this.txtNumberDoc_p.Location = new System.Drawing.Point(42, 290);
            this.txtNumberDoc_p.MaxLength = 10;
            this.txtNumberDoc_p.Name = "txtNumberDoc_p";
            this.txtNumberDoc_p.Size = new System.Drawing.Size(269, 26);
            this.txtNumberDoc_p.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "N° documento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tipo";
            // 
            // cbx_paci
            // 
            this.cbx_paci.FormattingEnabled = true;
            this.cbx_paci.Location = new System.Drawing.Point(373, 288);
            this.cbx_paci.Name = "cbx_paci";
            this.cbx_paci.Size = new System.Drawing.Size(125, 28);
            this.cbx_paci.TabIndex = 31;
            this.cbx_paci.SelectedValueChanged += new System.EventHandler(this.cbx_paci_SelectedValueChanged);
            // 
            // lblTipo_doc
            // 
            this.lblTipo_doc.AutoSize = true;
            this.lblTipo_doc.Location = new System.Drawing.Point(459, 267);
            this.lblTipo_doc.Name = "lblTipo_doc";
            this.lblTipo_doc.Size = new System.Drawing.Size(45, 20);
            this.lblTipo_doc.TabIndex = 32;
            this.lblTipo_doc.Text = "####";
            // 
            // dtpPaciente
            // 
            this.dtpPaciente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaciente.Location = new System.Drawing.Point(319, 55);
            this.dtpPaciente.Name = "dtpPaciente";
            this.dtpPaciente.Size = new System.Drawing.Size(179, 26);
            this.dtpPaciente.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Nacimiento";
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 591);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpPaciente);
            this.Controls.Add(this.lblTipo_doc);
            this.Controls.Add(this.cbx_paci);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumberDoc_p);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCiudadP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccionP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCorreoP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar_paci);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "FrmPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaciente";
            this.Load += new System.EventHandler(this.FrmPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar_paci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameP;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreoP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccionP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCiudadP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumberDoc_p;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_paci;
        private System.Windows.Forms.Label lblTipo_doc;
        private System.Windows.Forms.DateTimePicker dtpPaciente;
        private System.Windows.Forms.Label label11;
    }
}