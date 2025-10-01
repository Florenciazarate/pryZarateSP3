using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryZarateSP3
{
    public partial class frmAutoTest : Form
    {
        public frmAutoTest()
        {
            InitializeComponent();
        }
        public struct TURNO
        {
            public int NumeroTurno;
            public string Dominio;
            public int AñoFabricacion;
            public string Titular;
        };
        const int MAX = 50;
        public TURNO[] turnos;
        public int Cantidad = 0;
        private void inicializarInterfaz()
        {
            limpiarControles();
            txtCantidadConDominios.Clear();
            txtCantidadTurnos.Clear();
            txtAñoMasAntiguo.Clear();
        }
        private void limpiarControles()
        {
            txtNumeroTurno.Clear();
            txtTitular.Clear();
            numFabricacion.Value = 2021;
            txtDominio.Clear();
        }
        private void frmAutoTest_Load(object sender, EventArgs e)
        {
            turnos = new TURNO[MAX];
            Cantidad = 0;
            inicializarInterfaz();
        }
        private void txtNumeroTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private bool ValidarDatos()
        {
            bool resultado = false;
            if (txtNumeroTurno.Text != "" && txtDominio.Text != "" && txtTitular.Text != "")
            {
                if (txtDominio.Text.Length >= 6)
                {
                    if (!BuscarTurno(int.Parse(txtNumeroTurno.Text)))
                    {
                        resultado = true;
                    }
                    else
                    {
                        MessageBox.Show("El Número de Turno ingresado ya existe",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El Dominio debe tener 6 o 7 caracteres",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los datos faltantes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }
        private bool BuscarTurno(int numero)
        {
            bool existe = false;
            int pos = 0;

            while (pos < Cantidad)
            {

                if (numero == turnos[pos].NumeroTurno)
                {
                    existe = true;
                    break;
                }
                pos++;
            }
            return existe;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                turnos[Cantidad].NumeroTurno = int.Parse(txtNumeroTurno.Text);
                turnos[Cantidad].Dominio = txtDominio.Text;
                turnos[Cantidad].AñoFabricacion =
                int.Parse(numFabricacion.Value.ToString());
                turnos[Cantidad].Titular = txtTitular.Text;
                Cantidad++;
                if (Cantidad == MAX)
                {
                    MessageBox.Show("Se completó la capacidad de carga de datos",
                    "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnRegistrar.Enabled = false;
                    limpiarControles();
                }
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            {
                txtCantidadTurnos.Text = Cantidad.ToString();
                int menor = int.MaxValue;
                int pos;
                for (pos = 0; pos < Cantidad; pos++)
                {
                    if (turnos[pos].AñoFabricacion < menor)
                    {
                        menor = turnos[pos].AñoFabricacion;
                    }
                }
                txtAñoMasAntiguo.Text = menor.ToString();
                int contador = 0;
                for (pos = 0; pos < Cantidad; pos++)
                {
                    if (turnos[pos].Dominio.Length == 6)
                    {
                        contador++;
                    }
                }
                txtCantidadConDominios.Text = contador.ToString();

            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close  ();
        }
    }
}

