namespace pryZarateSP3
{
    partial class frmAutoTest
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
            txtNumeroTurno = new TextBox();
            txtDominio = new TextBox();
            label1 = new Label();
            lblRegistroTurnos = new Label();
            lblDominio = new Label();
            lblNumeroTurno = new Label();
            numFabricacion = new NumericUpDown();
            lblAñoFabricacion = new Label();
            lblEstadísticas = new Label();
            lblCantidadTurnos = new Label();
            lblAñoMasAntiguo = new Label();
            lblCantDominios = new Label();
            txtCantidadTurnos = new TextBox();
            txtAñoMasAntiguo = new TextBox();
            txtCantidadConDominios = new TextBox();
            btnRegistrar = new Button();
            btnSalir = new Button();
            btnConsultar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTitular = new Label();
            txtTitular = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numFabricacion).BeginInit();
            SuspendLayout();
            // 
            // txtNumeroTurno
            // 
            txtNumeroTurno.Location = new Point(148, 51);
            txtNumeroTurno.MaxLength = 5;
            txtNumeroTurno.Name = "txtNumeroTurno";
            txtNumeroTurno.Size = new Size(100, 23);
            txtNumeroTurno.TabIndex = 0;
            txtNumeroTurno.KeyPress += txtNumeroTurno_KeyPress;
            // 
            // txtDominio
            // 
            txtDominio.Location = new Point(148, 81);
            txtDominio.MaxLength = 7;
            txtDominio.Name = "txtDominio";
            txtDominio.Size = new Size(100, 23);
            txtDominio.TabIndex = 1;
            txtDominio.KeyPress += txtDominio_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 59);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // lblRegistroTurnos
            // 
            lblRegistroTurnos.AutoSize = true;
            lblRegistroTurnos.Font = new Font("Nirmala UI", 12F);
            lblRegistroTurnos.Location = new Point(43, 24);
            lblRegistroTurnos.Name = "lblRegistroTurnos";
            lblRegistroTurnos.Size = new Size(138, 21);
            lblRegistroTurnos.TabIndex = 4;
            lblRegistroTurnos.Text = "Registro de turnos";
            // 
            // lblDominio
            // 
            lblDominio.AutoSize = true;
            lblDominio.Font = new Font("Nirmala UI", 9F);
            lblDominio.Location = new Point(43, 88);
            lblDominio.Name = "lblDominio";
            lblDominio.Size = new Size(53, 15);
            lblDominio.TabIndex = 6;
            lblDominio.Text = "Dominio";
            // 
            // lblNumeroTurno
            // 
            lblNumeroTurno.AutoSize = true;
            lblNumeroTurno.Font = new Font("Nirmala UI", 9F);
            lblNumeroTurno.Location = new Point(43, 59);
            lblNumeroTurno.Name = "lblNumeroTurno";
            lblNumeroTurno.Size = new Size(99, 15);
            lblNumeroTurno.TabIndex = 7;
            lblNumeroTurno.Text = "Número de turno";
            // 
            // numFabricacion
            // 
            numFabricacion.Location = new Point(148, 112);
            numFabricacion.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numFabricacion.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            numFabricacion.Name = "numFabricacion";
            numFabricacion.Size = new Size(120, 23);
            numFabricacion.TabIndex = 8;
            numFabricacion.Value = new decimal(new int[] { 1950, 0, 0, 0 });
            // 
            // lblAñoFabricacion
            // 
            lblAñoFabricacion.AutoSize = true;
            lblAñoFabricacion.Font = new Font("Nirmala UI", 9F);
            lblAñoFabricacion.Location = new Point(43, 117);
            lblAñoFabricacion.Name = "lblAñoFabricacion";
            lblAñoFabricacion.Size = new Size(91, 15);
            lblAñoFabricacion.TabIndex = 9;
            lblAñoFabricacion.Text = "Año fabricación";
            // 
            // lblEstadísticas
            // 
            lblEstadísticas.AutoSize = true;
            lblEstadísticas.Font = new Font("Nirmala UI", 12F);
            lblEstadísticas.Location = new Point(46, 207);
            lblEstadísticas.Name = "lblEstadísticas";
            lblEstadísticas.Size = new Size(89, 21);
            lblEstadísticas.TabIndex = 10;
            lblEstadísticas.Text = "Estadísticas";
            // 
            // lblCantidadTurnos
            // 
            lblCantidadTurnos.AutoSize = true;
            lblCantidadTurnos.Font = new Font("Nirmala UI", 9F);
            lblCantidadTurnos.Location = new Point(47, 247);
            lblCantidadTurnos.Name = "lblCantidadTurnos";
            lblCantidadTurnos.Size = new Size(108, 15);
            lblCantidadTurnos.TabIndex = 11;
            lblCantidadTurnos.Text = "Cantidad de turnos";
            // 
            // lblAñoMasAntiguo
            // 
            lblAñoMasAntiguo.AutoSize = true;
            lblAñoMasAntiguo.Font = new Font("Nirmala UI", 9F);
            lblAñoMasAntiguo.Location = new Point(47, 277);
            lblAñoMasAntiguo.Name = "lblAñoMasAntiguo";
            lblAñoMasAntiguo.Size = new Size(117, 15);
            lblAñoMasAntiguo.TabIndex = 12;
            lblAñoMasAntiguo.Text = "Año del más antiguo";
            // 
            // lblCantDominios
            // 
            lblCantDominios.AutoSize = true;
            lblCantDominios.Font = new Font("Nirmala UI", 9F);
            lblCantDominios.Location = new Point(47, 306);
            lblCantDominios.Name = "lblCantDominios";
            lblCantDominios.Size = new Size(212, 15);
            lblCantDominios.TabIndex = 13;
            lblCantDominios.Text = "Cantidad con dominios de 6 caracteres";
            // 
            // txtCantidadTurnos
            // 
            txtCantidadTurnos.Enabled = false;
            txtCantidadTurnos.Location = new Point(267, 239);
            txtCantidadTurnos.Name = "txtCantidadTurnos";
            txtCantidadTurnos.Size = new Size(100, 23);
            txtCantidadTurnos.TabIndex = 14;
            // 
            // txtAñoMasAntiguo
            // 
            txtAñoMasAntiguo.Enabled = false;
            txtAñoMasAntiguo.Location = new Point(267, 270);
            txtAñoMasAntiguo.Name = "txtAñoMasAntiguo";
            txtAñoMasAntiguo.Size = new Size(100, 23);
            txtAñoMasAntiguo.TabIndex = 15;
            // 
            // txtCantidadConDominios
            // 
            txtCantidadConDominios.Enabled = false;
            txtCantidadConDominios.Location = new Point(267, 301);
            txtCantidadConDominios.Name = "txtCantidadConDominios";
            txtCantidadConDominios.Size = new Size(100, 23);
            txtCantidadConDominios.TabIndex = 16;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Tan;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Nirmala UI", 11.25F);
            btnRegistrar.Location = new Point(340, 51);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(86, 33);
            btnRegistrar.TabIndex = 17;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.AntiqueWhite;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Nirmala UI", 11.25F);
            btnSalir.Location = new Point(340, 92);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 33);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Tan;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Nirmala UI", 11.25F);
            btnConsultar.Location = new Point(419, 269);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(86, 33);
            btnConsultar.TabIndex = 19;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.BlanchedAlmond;
            flowLayoutPanel1.Location = new Point(30, 218);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(375, 129);
            flowLayoutPanel1.TabIndex = 21;
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("Nirmala UI", 9F);
            lblTitular.Location = new Point(44, 148);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(41, 15);
            lblTitular.TabIndex = 23;
            lblTitular.Text = "Titular";
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(147, 142);
            txtTitular.MaxLength = 30;
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(100, 23);
            txtTitular.TabIndex = 22;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.BlanchedAlmond;
            flowLayoutPanel2.Location = new Point(30, 37);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(281, 146);
            flowLayoutPanel2.TabIndex = 22;
            // 
            // frmAutoTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(661, 470);
            Controls.Add(lblTitular);
            Controls.Add(txtTitular);
            Controls.Add(btnConsultar);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCantidadConDominios);
            Controls.Add(txtAñoMasAntiguo);
            Controls.Add(txtCantidadTurnos);
            Controls.Add(lblCantDominios);
            Controls.Add(lblAñoMasAntiguo);
            Controls.Add(lblCantidadTurnos);
            Controls.Add(lblEstadísticas);
            Controls.Add(lblAñoFabricacion);
            Controls.Add(numFabricacion);
            Controls.Add(lblNumeroTurno);
            Controls.Add(lblDominio);
            Controls.Add(lblRegistroTurnos);
            Controls.Add(label1);
            Controls.Add(txtDominio);
            Controls.Add(txtNumeroTurno);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAutoTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAutoTest";
            Load += frmAutoTest_Load;
            ((System.ComponentModel.ISupportInitialize)numFabricacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeroTurno;
        private TextBox txtDominio;
        private Label label1;
        private Label lblRegistroTurnos;
        private Label lblDominio;
        private Label lblNumeroTurno;
        private NumericUpDown numFabricacion;
        private Label lblAñoFabricacion;
        private Label lblEstadísticas;
        private Label lblCantidadTurnos;
        private Label lblAñoMasAntiguo;
        private Label lblCantDominios;
        private TextBox txtCantidadTurnos;
        private TextBox txtAñoMasAntiguo;
        private TextBox txtCantidadConDominios;
        private Button btnRegistrar;
        private Button btnSalir;
        private Button btnConsultar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTitular;
        private TextBox txtTitular;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}