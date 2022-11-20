using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class BuscarId : Form
    {
        int idEncontrado;
        public BuscarId()
        {
            InitializeComponent();
        }
        public int IdEncontrado
        {
            get { return idEncontrado; }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int id = Validar.ConvertirStringAEntero(this.tbx_idIngresado.Text);
            if (id > -1)
            {
                if (TrucoArg.BuscarIdJugador(id))
                {
                    this.idEncontrado = id;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    lbl_error.Text = "Id no encontrado";
                }
            }
        }
    }
}
