using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class AltaModificacionJugador : Form
    {
        int indiceJugador;

        public AltaModificacionJugador(int indiceAModificar)
        {
            InitializeComponent();
            this.indiceJugador = TrucoArg.DevolverIndiceJugador(indiceAModificar);
            OcultarDatosJugador();
        }
        private void OcultarDatosJugador()
        {
            tbx_id.Visible = false;
            if (indiceJugador > -1)
            {
                lbl_id.Visible = true;
                tbx_id.Visible = true;
                tbx_id.Text = TrucoArg.listaDeJugadores[indiceJugador].Id.ToString();
                tbx_nombre.Text = TrucoArg.listaDeJugadores[indiceJugador].Nombre;
                tbx_apellido.Text = TrucoArg.listaDeJugadores[indiceJugador].Apellido;
                dtm_fechaNac.Value = TrucoArg.listaDeJugadores[indiceJugador].FechaNacimiento;
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Jugador auxJugador;
            string nombre = this.tbx_nombre.Text.Trim();
            string apellido = this.tbx_apellido.Text.Trim();
            DateTime fechaDeNacimiento = this.dtm_fechaNac.Value.Date;
            if (ValidarDatos(nombre, apellido, fechaDeNacimiento) == 3)
            {
                AccesoBaseDeDatos accesoJugador = new AccesoBaseDeDatos();
                if (this.indiceJugador == -1)
                {
                    try
                    {
                        auxJugador = new Jugador(nombre, apellido, fechaDeNacimiento, 0, 0);
                        accesoJugador.AgregarJugador(auxJugador);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch
                    {
                        // evento mostrar error en form principal
                    }
                    finally
                    {
                        this.Close();
                    }
                }
                else
                {
                    try
                    {
                        auxJugador = new Jugador(TrucoArg.listaDeJugadores[indiceJugador].Id, nombre, apellido, fechaDeNacimiento, TrucoArg.listaDeJugadores[indiceJugador].PuntajePartida, TrucoArg.listaDeJugadores[indiceJugador].PartidasGanadas);
                        accesoJugador.ModificarJugador(auxJugador);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch
                    {
                        // evento mostrar error en form principal
                    }
                    finally
                    {
                        this.Close();
                    }
                }
            }
        }

        private int ValidarDatos(string nombre, string apellido, DateTime fechaDeNacimiento)
        {
            int retorno = 0;

            if (Validar.ValidarStringSoloLetras(nombre) == null)
            {
                this.btn_errorNombre.Visible = true;
                retorno -= 1;
            }
            else
            {
                this.btn_errorNombre.Visible = false;
                retorno += 1;
            }
            if (Validar.ValidarStringSoloLetras(apellido) == null)
            {
                this.btn_errorApellido.Visible = true;
                retorno -= 1;
            }
            else
            {
                this.btn_errorApellido.Visible = false;
                retorno += 1;
            }
            if (DateTime.Now.Year - fechaDeNacimiento.Year < 18)
            {
                this.btn_errorFechaNac.Visible = true;
                retorno -= 1;
            }
            else
            {
                this.btn_errorFechaNac.Visible = false;
                retorno += 1;
            }
            return retorno;
        }
        private void btn_errorNombre_MouseHover_1(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorNombre, "¡Reingrese el nombre!");
        }
        private void btn_errorApellido_MouseHover_1(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorApellido, "¡Reingrese el apellido!");
        }
        private void btn_errorFechaNac_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorFechaNac, "El Usuario debe ser mayor de edad");
        }
    }
}
