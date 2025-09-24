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
            txtDominio = new TextBox();
            txtAñoFabricacion = new TextBox();
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
            lyt1 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numFabricacion).BeginInit();
            SuspendLayout();
            // 
            // txtDominio
            // 
            txtDominio.Location = new Point(148, 51);
            txtDominio.Name = "txtDominio";
            txtDominio.Size = new Size(100, 23);
            txtDominio.TabIndex = 0;
            // 
            // txtAñoFabricacion
            // 
            txtAñoFabricacion.Location = new Point(148, 80);
            txtAñoFabricacion.Name = "txtAñoFabricacion";
            txtAñoFabricacion.Size = new Size(100, 23);
            txtAñoFabricacion.TabIndex = 1;
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
            numFabricacion.Location = new Point(148, 109);
            numFabricacion.Name = "numFabricacion";
            numFabricacion.Size = new Size(120, 23);
            numFabricacion.TabIndex = 8;
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
            lblEstadísticas.Location = new Point(46, 161);
            lblEstadísticas.Name = "lblEstadísticas";
            lblEstadísticas.Size = new Size(89, 21);
            lblEstadísticas.TabIndex = 10;
            lblEstadísticas.Text = "Estadísticas";
            // 
            // lblCantidadTurnos
            // 
            lblCantidadTurnos.AutoSize = true;
            lblCantidadTurnos.Font = new Font("Nirmala UI", 9F);
            lblCantidadTurnos.Location = new Point(47, 201);
            lblCantidadTurnos.Name = "lblCantidadTurnos";
            lblCantidadTurnos.Size = new Size(108, 15);
            lblCantidadTurnos.TabIndex = 11;
            lblCantidadTurnos.Text = "Cantidad de turnos";
            // 
            // lblAñoMasAntiguo
            // 
            lblAñoMasAntiguo.AutoSize = true;
            lblAñoMasAntiguo.Font = new Font("Nirmala UI", 9F);
            lblAñoMasAntiguo.Location = new Point(47, 231);
            lblAñoMasAntiguo.Name = "lblAñoMasAntiguo";
            lblAñoMasAntiguo.Size = new Size(117, 15);
            lblAñoMasAntiguo.TabIndex = 12;
            lblAñoMasAntiguo.Text = "Año del más antiguo";
            // 
            // lblCantDominios
            // 
            lblCantDominios.AutoSize = true;
            lblCantDominios.Font = new Font("Nirmala UI", 9F);
            lblCantDominios.Location = new Point(47, 260);
            lblCantDominios.Name = "lblCantDominios";
            lblCantDominios.Size = new Size(212, 15);
            lblCantDominios.TabIndex = 13;
            lblCantDominios.Text = "Cantidad con dominios de 6 caracteres";
            // 
            // txtCantidadTurnos
            // 
            txtCantidadTurnos.Location = new Point(267, 193);
            txtCantidadTurnos.Name = "txtCantidadTurnos";
            txtCantidadTurnos.Size = new Size(100, 23);
            txtCantidadTurnos.TabIndex = 14;
            // 
            // txtAñoMasAntiguo
            // 
            txtAñoMasAntiguo.Location = new Point(267, 224);
            txtAñoMasAntiguo.Name = "txtAñoMasAntiguo";
            txtAñoMasAntiguo.Size = new Size(100, 23);
            txtAñoMasAntiguo.TabIndex = 15;
            // 
            // txtCantidadConDominios
            // 
            txtCantidadConDominios.Location = new Point(267, 255);
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
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Tan;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Nirmala UI", 11.25F);
            btnConsultar.Location = new Point(419, 223);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(86, 33);
            btnConsultar.TabIndex = 19;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // lyt1
            // 
            lyt1.BackColor = Color.BlanchedAlmond;
            lyt1.Location = new Point(30, 34);
            lyt1.Name = "lyt1";
            lyt1.Size = new Size(283, 119);
            lyt1.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.BlanchedAlmond;
            flowLayoutPanel1.Location = new Point(30, 172);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(375, 136);
            flowLayoutPanel1.TabIndex = 21;
            // 
            // frmAutoTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(541, 343);
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
            Controls.Add(txtAñoFabricacion);
            Controls.Add(txtDominio);
            Controls.Add(lyt1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAutoTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAutoTest";
            ((System.ComponentModel.ISupportInitialize)numFabricacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDominio;
        private TextBox txtAñoFabricacion;
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
        private FlowLayoutPanel lyt1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}