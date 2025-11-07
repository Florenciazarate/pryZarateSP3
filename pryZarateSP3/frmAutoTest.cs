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
                if (txtDominio.Text.Length >= 6 && txtDominio.Text.Length <= 7)
                {
                    int año = (int)numFabricacion.Value;
                    int añoActual = DateTime.Now.Year;
                    if (año < 1950 || año > añoActual)
                    {
                        MessageBox.Show($"El año de fabricación debe estar entre 1950 y {añoActual}.",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (txtNumeroTurno.Text.Length > 5)
                    {
                        MessageBox.Show("El número de turno no puede tener más de 5 dígitos.",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
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
            if (txtTitular.Text.Length < 2)
            {
                MessageBox.Show("El titular debe tener al menos 2 caracteres.",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            {
                {
                    if (Cantidad >= MAX)
                    {
                        MessageBox.Show("Se alcanzó el máximo de 50 turnos registrados.",
                        "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (ValidarDatos())
                    {
                        turnos[Cantidad].NumeroTurno = int.Parse(txtNumeroTurno.Text);
                        turnos[Cantidad].Dominio = txtDominio.Text;
                        turnos[Cantidad].AñoFabricacion = int.Parse(numFabricacion.Value.ToString());
                        turnos[Cantidad].Titular = txtTitular.Text;
                        Cantidad++;
                        txtCantidadTurnos.Enabled = true;
                        txtAñoMasAntiguo.Enabled = true;
                        txtCantidadConDominios.Enabled = true;
                        if (Cantidad == MAX)
                        {
                            MessageBox.Show("Se completó la capacidad de carga de datos",
                            "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            btnRegistrar.Enabled = false;
                            limpiarControles();
                        }
                        else
                        {
                            MessageBox.Show("Se registró turno Nº " + Cantidad);
                            limpiarControles();

                        }

                    }
                }
            }
        }

        private void txtTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }
      }
    }



