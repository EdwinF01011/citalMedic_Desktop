
namespace citalMedic_desk.vista
{
    partial class FrmMedico
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
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cbx_medic = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumberDoc_m = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEspecialidad_medic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreoM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar_medic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Añadir Médico";
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
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(461, 274);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(45, 20);
            this.lblTipoDoc.TabIndex = 47;
            this.lblTipoDoc.Text = "####";
            // 
            // cbx_medic
            // 
            this.cbx_medic.FormattingEnabled = true;
            this.cbx_medic.Location = new System.Drawing.Point(375, 295);
            this.cbx_medic.Name = "cbx_medic";
            this.cbx_medic.Size = new System.Drawing.Size(125, 28);
            this.cbx_medic.TabIndex = 46;
            this.cbx_medic.SelectedValueChanged += new System.EventHandler(this.cbx_medic_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Tipo";
            // 
            // txtNumberDoc_m
            // 
            this.txtNumberDoc_m.Location = new System.Drawing.Point(44, 297);
            this.txtNumberDoc_m.MaxLength = 10;
            this.txtNumberDoc_m.Name = "txtNumberDoc_m";
            this.txtNumberDoc_m.Size = new System.Drawing.Size(269, 26);
            this.txtNumberDoc_m.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "N° documento";
            // 
            // txtEspecialidad_medic
            // 
            this.txtEspecialidad_medic.Location = new System.Drawing.Point(44, 439);
            this.txtEspecialidad_medic.MaxLength = 20;
            this.txtEspecialidad_medic.Name = "txtEspecialidad_medic";
            this.txtEspecialidad_medic.Size = new System.Drawing.Size(269, 26);
            this.txtEspecialidad_medic.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Especialidad";
            // 
            // txtCorreoM
            // 
            this.txtCorreoM.Location = new System.Drawing.Point(44, 368);
            this.txtCorreoM.MaxLength = 40;
            this.txtCorreoM.Name = "txtCorreoM";
            this.txtCorreoM.Size = new System.Drawing.Size(269, 26);
            this.txtCorreoM.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Correo";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(44, 225);
            this.txtApellidoM.MaxLength = 20;
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(269, 26);
            this.txtApellidoM.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Apellido";
            // 
            // txtNameM
            // 
            this.txtNameM.Location = new System.Drawing.Point(44, 161);
            this.txtNameM.MaxLength = 20;
            this.txtNameM.Name = "txtNameM";
            this.txtNameM.Size = new System.Drawing.Size(269, 26);
            this.txtNameM.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre";
            // 
            // btnGuardar_medic
            // 
            this.btnGuardar_medic.Location = new System.Drawing.Point(418, 510);
            this.btnGuardar_medic.Name = "btnGuardar_medic";
            this.btnGuardar_medic.Size = new System.Drawing.Size(88, 59);
            this.btnGuardar_medic.TabIndex = 48;
            this.btnGuardar_medic.Text = "Guardar";
            this.btnGuardar_medic.UseVisualStyleBackColor = true;
            this.btnGuardar_medic.Click += new System.EventHandler(this.btnGuardar_medic_Click);
            // 
            // FrmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 591);
            this.Controls.Add(this.btnGuardar_medic);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.cbx_medic);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumberDoc_m);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEspecialidad_medic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCorreoM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "FrmMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMedico";
            this.Load += new System.EventHandler(this.FrmMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cbx_medic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumberDoc_m;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEspecialidad_medic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorreoM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar_medic;
    }
}