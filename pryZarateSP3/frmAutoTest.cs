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
    }
    }

