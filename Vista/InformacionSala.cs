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
    public partial class InformacionSala : Form
    {
        int indiceSala;
        int idJugadorUno;
        int idJugadorDos;
        public InformacionSala(int indiceSala, int idJugadorUno, int idJugadorDos)
        {
            InitializeComponent();
            this.indiceSala = indiceSala;
            TrucoArg.salas[indiceSala].VentanaActiva = true;
            this.idJugadorUno = idJugadorUno;
            this.idJugadorDos = idJugadorDos;
        }
        private void InformacionSala_Load(object sender, EventArgs e)
        {
            Task.Run(() => ActualizarListBox());
            lbl_numeroSala.Text = $"Sala {indiceSala+1}";
        }

        private void ActualizarListBox()
        {
            Thread.Sleep(500);
            while (true)
            {
                List<string> listahistorial = TrucoArg.salas[indiceSala].Historial.ToList();
                if (this.rchx_historialPartida.InvokeRequired)
                {
                    this.rchx_historialPartida.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.rchx_historialPartida.Clear();
                        foreach (string item in listahistorial)
                        {
                            this.rchx_historialPartida.Text += item;
                            this.rchx_historialPartida.Text += "\n";
                        }
                    });
                }
                if (TrucoArg.salas[indiceSala].PartidaFinalizada == true)
                {
                    if (this.btn_finalizarPartida.InvokeRequired)
                    {
                        this.btn_finalizarPartida.BeginInvoke((MethodInvoker)delegate ()
                        {
                            btn_finalizarPartida.Enabled = true;
                        });
                    }
                    return;
                }
                Thread.Sleep(5000);
            }
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (TrucoArg.salas[indiceSala] != null)
            {
                TrucoArg.salas[indiceSala].VentanaActiva = false;
            }
            this.Close();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            TrucoArg.tokenTareas[indiceSala].Cancel();
            btn_cancelar.Enabled = false;
        }

        private void btn_finalizarPartida_Click(object sender, EventArgs e)
        {
            TrucoArg.ModificarJugadorPorId(TrucoArg.salas[indiceSala].IdJugadorUno);
            TrucoArg.ModificarJugadorPorId(TrucoArg.salas[indiceSala].IdJugadorDos);
            TrucoArg.salas[indiceSala] = null;
            this.Close();
        }
    }
}
