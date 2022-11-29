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
    public partial class MenuSala : Form
    {
        int numeroDeSala;
        int idJugadorUno;
        int idJugadorDos;
        public MenuSala(int numeroDeSala)
        {
            InitializeComponent();
            this.numeroDeSala = numeroDeSala;
        }
        public int NumeroDeSala
        {
            get { return numeroDeSala; }
        }
        public int IdJugadorDos
        {
            get { return idJugadorDos; }
        }
        public int IdJugadorUno
        {
            get { return idJugadorUno; }
        }
        private void MenuSala_Load(object sender, EventArgs e)
        {
            lbl_sala.Text = $"Sala N° {numeroDeSala + 1}";
            idJugadorDos = -1;
            idJugadorUno = -1;
            CargarJugadores();
        }
        private void CargarJugadores()
        {
            TrucoArg.listaDeJugadores.ForEach((a) => cmb_jugadorUno.Items.Add(a.Id));
            TrucoArg.listaDeJugadores.ForEach((a) => cmb_jugadorDos.Items.Add(a.Id));
        }
        private void cmb_jugadorUno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idJugador = cmb_jugadorUno.Text;
            int id = Validar.ConvertirStringAEntero(idJugador);
            txb_nombreJ1.Text = TrucoArg.BuscarNombreJugadorPorId(id);
            txb_apellidoJ1.Text = TrucoArg.BuscarApellidoJugadorPorId(id);
            txb_partidasJ1.Text = TrucoArg.BuscarPartidasJugadorPorId(id).ToString();
            this.idJugadorUno = id;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            btn_errorJugadorUno.Visible = false;
            btn_errorJugadorDos.Visible = false;
            int errorJugadorEnPartida = 0;
            if (cmb_jugadorUno.Text != "" && cmb_jugadorDos.Text != "")
            {
                if (cmb_jugadorDos.SelectedIndex != cmb_jugadorUno.SelectedIndex)
                {
                    if (TrucoArg.VerificarJugadorEnPartida(Validar.ConvertirStringAEntero(cmb_jugadorDos.Text)))
                    {
                        errorJugadorEnPartida++;
                        btn_errorJugadorDos.Visible = true;
                    }
                    if (TrucoArg.VerificarJugadorEnPartida(Validar.ConvertirStringAEntero(cmb_jugadorUno.Text)))
                    {
                        btn_errorJugadorUno.Visible = true;
                        errorJugadorEnPartida++;
                    }
                    if (errorJugadorEnPartida == 0)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    lbl_error.Text = "No puede elegir el mismo jugador";
                }
            }
            else
            {
                lbl_error.Text = "Complete los campos de Id";
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmb_jugadorDos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idJugador = cmb_jugadorDos.Text;
            int id = Validar.ConvertirStringAEntero(idJugador);
            txb_nombreJ2.Text = TrucoArg.BuscarNombreJugadorPorId(id);
            txb_apellidoJ2.Text = TrucoArg.BuscarApellidoJugadorPorId(id);
            txb_partidasJ2.Text = TrucoArg.BuscarPartidasJugadorPorId(id).ToString();
            idJugadorDos = id;
        }

        private void btn_errorJugador_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            Button btn_generico = (Button)sender;
            toolTip1.SetToolTip(btn_generico, "¡El jugador ya esta jugado una partida!");

        }
    }
}
