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
            public int AnioFabricacion;
            public string Titular;
        };
        const int MAX = 50;
        public TURNO[] turnos;
        public int Cantidad = 0;

        private void frmAutoTest_Load(object sender, EventArgs e)
        {

        }
    }
}
