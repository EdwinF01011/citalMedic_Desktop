
namespace citalMedic_desk.vista
{
    partial class FrmMenu
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
            this.btnAgendar = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxMedico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxPaciente = new System.Windows.Forms.ComboBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.LblMedico = new System.Windows.Forms.Label();
            this.dataTPcita = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReloadDgv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(637, 217);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(216, 118);
            this.btnAgendar.TabIndex = 0;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(757, 71);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(63, 20);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "######";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "citalMedic";
            // 
            // cboxMedico
            // 
            this.cboxMedico.FormattingEnabled = true;
            this.cboxMedico.Location = new System.Drawing.Point(268, 300);
            this.cboxMedico.Name = "cboxMedico";
            this.cboxMedico.Size = new System.Drawing.Size(188, 28);
            this.cboxMedico.TabIndex = 3;
            this.cboxMedico.SelectedValueChanged += new System.EventHandler(this.cboxMedico_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Médico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Paciente";
            // 
            // cboxPaciente
            // 
            this.cboxPaciente.FormattingEnabled = true;
            this.cboxPaciente.Location = new System.Drawing.Point(268, 226);
            this.cboxPaciente.Name = "cboxPaciente";
            this.cboxPaciente.Size = new System.Drawing.Size(188, 28);
            this.cboxPaciente.TabIndex = 5;
            this.cboxPaciente.SelectedValueChanged += new System.EventHandler(this.cboxPaciente_SelectedValueChanged);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(104, 226);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(63, 20);
            this.lblPaciente.TabIndex = 7;
            this.lblPaciente.Text = "######";
            // 
            // LblMedico
            // 
            this.LblMedico.AutoSize = true;
            this.LblMedico.Location = new System.Drawing.Point(104, 291);
            this.LblMedico.Name = "LblMedico";
            this.LblMedico.Size = new System.Drawing.Size(63, 20);
            this.LblMedico.TabIndex = 8;
            this.LblMedico.Text = "######";
            // 
            // dataTPcita
            // 
            this.dataTPcita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataTPcita.Location = new System.Drawing.Point(565, 102);
            this.dataTPcita.Name = "dataTPcita";
            this.dataTPcita.Size = new System.Drawing.Size(324, 26);
            this.dataTPcita.TabIndex = 9;
            this.dataTPcita.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha cita";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 379);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(824, 256);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(508, 217);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(75, 44);
            this.btnPaciente.TabIndex = 12;
            this.btnPaciente.Text = "new";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Location = new System.Drawing.Point(508, 291);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(75, 44);
            this.btnMedico.TabIndex = 13;
            this.btnMedico.Text = "new";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Agenda de citas";
            // 
            // btnReloadDgv
            // 
            this.btnReloadDgv.Location = new System.Drawing.Point(814, 641);
            this.btnReloadDgv.Name = "btnReloadDgv";
            this.btnReloadDgv.Size = new System.Drawing.Size(75, 44);
            this.btnReloadDgv.TabIndex = 18;
            this.btnReloadDgv.Text = "Reload";
            this.btnReloadDgv.UseVisualStyleBackColor = true;
            this.btnReloadDgv.Click += new System.EventHandler(this.btnReloadDgv_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 725);
            this.Controls.Add(this.btnReloadDgv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataTPcita);
            this.Controls.Add(this.LblMedico);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnAgendar);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxPaciente;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label LblMedico;
        private System.Windows.Forms.DateTimePicker dataTPcita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReloadDgv;
    }
}