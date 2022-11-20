using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu_Principal : Form
    {
        Button[]? botones;

        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            CargarBotones();
            lbx_partidas.Visible = false;
            TrucoArg.CargarListaDeJugadores();
            Task tarea = Task.Run(() => EstadoSalas(botones));
            Archivos.Escribir($"REGISTRO INGRESO: {DateTime.Now}", "Historial");
        }

        private void CargarBotones()
        {
            botones = new Button[6];
            botones[0] = btn_sala1;
            botones[1] = btn_sala2;
            botones[2] = btn_sala3;
            botones[3] = btn_sala4;
            botones[4] = btn_sala5;
            botones[5] = btn_sala6;
        }

        private void EstadoSalas(Button[]? botones)
        {
            if (botones != null)
            {
                while (true)
                {
                    Sala[] salas = TrucoArg.salas;
                    for (int i = 0; i < salas.Length; i++)
                    {
                        if (salas[i] != null)
                        {
                            if (salas[i].PartidaFinalizada)
                            {
                                if (salas[i] != null && salas[i].PartidaCancelada == true)
                                {
                                    botones[i].BackColor = Color.Yellow;
                                }
                                else if (salas[i] != null)
                                {
                                    botones[i].BackColor = Color.Blue;
                                }
                            }
                            else if (salas[i] != null)
                            {
                                botones[i].BackColor = Color.Green;
                            }
                        }
                        else
                        {
                            botones[i].BackColor = Color.Gray;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = TrucoArg.BuscarSalaDisponible();
            if (indice != -1)
            {
                MenuSala frm_menuSala = new MenuSala(indice);
                DialogResult resultado = frm_menuSala.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    CancellationTokenSource cts = new CancellationTokenSource();
                    int indiceSala = frm_menuSala.NumeroDeSala;
                    int indiceJugadorUno = TrucoArg.DevolverIndiceJugador(frm_menuSala.IdJugadorUno);
                    int indiceJugadorDos = TrucoArg.DevolverIndiceJugador(frm_menuSala.IdJugadorDos);
                    Jugador jugadorUno = TrucoArg.listaDeJugadores[indiceJugadorUno];
                    Jugador jugadorDos = TrucoArg.listaDeJugadores[indiceJugadorDos];
                    Sala salaAsignada = new Sala(jugadorUno, jugadorDos, indiceSala);
                    TrucoArg.salas[indiceSala] = salaAsignada;
                    TrucoArg.tokenTareas[indiceSala] = cts;
                    salaAsignada.PartidaTerminada += InformacionPartida;
                    Task.Run(() => salaAsignada.CrearSala(cts.Token));
                    MostrarFormularioSala(indiceSala, frm_menuSala.IdJugadorUno, frm_menuSala.IdJugadorDos);
                }
            }
            else
            {
                MessageBox.Show("Todas las salas entan ocupadas, intente nuevamente mas tarde");
            }
        }
        private void InformacionPartida(string descripcionPartida)
        {
            MessageBox.Show($"{descripcionPartida}");
        }
        private void MostrarFormularioSala(int indiceSala, int IdJugadorUno, int IdJugadorDos)
        {
            if (TrucoArg.salas[indiceSala] != null)
            {
                if (TrucoArg.salas[indiceSala].VentanaActiva == false)
                {
                    InformacionSala frm_sala = new InformacionSala(indiceSala, IdJugadorUno, IdJugadorDos);
                    frm_sala.Show();
                }
            }
        }

        private void jugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbx_salas.Visible = false;
            btn_crearSala.Visible = false;
            lbx_partidas.Visible = false;
            dtg_jugadores.Visible = true;
            dtg_jugadores.DataSource = TrucoArg.listaDeJugadores;

        }
        private void crearJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaModificacionJugador frm_altaJugador = new AltaModificacionJugador(-1);
            DialogResult resultado = frm_altaJugador.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Jugador Creado Correctamente");
                TrucoArg.CargarListaDeJugadores();
                dtg_jugadores.DataSource = TrucoArg.listaDeJugadores;
            }
        }
        private void modificarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarId frm_buscarId = new BuscarId();
            DialogResult resultadoModificacion = frm_buscarId.ShowDialog();
            if (resultadoModificacion == DialogResult.OK)
            {
                AltaModificacionJugador frm_modificarJugador = new AltaModificacionJugador(frm_buscarId.IdEncontrado);
                DialogResult resultadoAlta = frm_modificarJugador.ShowDialog();
                if (resultadoAlta == DialogResult.OK)
                {
                    MessageBox.Show("Jugador Modificado Correctamente");
                    TrucoArg.CargarListaDeJugadores();
                    dtg_jugadores.DataSource = TrucoArg.listaDeJugadores;
                }
            }
        }
        private void eliminarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccesoBaseDeDatos bDJugador = new AccesoBaseDeDatos();
            BuscarId frm_buscarId = new BuscarId();
            DialogResult resultadoModificacion = frm_buscarId.ShowDialog();
            if (resultadoModificacion == DialogResult.OK)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                int indice = TrucoArg.DevolverIndiceJugador(frm_buscarId.IdEncontrado);
                DialogResult resultado = MessageBox.Show($"Esta seguro que desea eliminar al jugador {TrucoArg.listaDeJugadores[indice].Nombre} {TrucoArg.listaDeJugadores[indice].Apellido}?", "a", buttons);
                if (resultado == DialogResult.Yes)
                {
                    bDJugador.EliminarJugador(TrucoArg.listaDeJugadores[indice]);
                    TrucoArg.CargarListaDeJugadores();
                }
            }
        }

        private void btn_sala1_Click(object sender, EventArgs e)
        {
            Button botonAux = (Button)sender;
            switch (botonAux.Text)
            {
                case "Sala 1":
                    cargarMesas(botonAux);
                    break;
                case "Sala 2":
                    cargarMesas(botonAux);
                    break;
                case "Sala 3":
                    cargarMesas(botonAux);
                    break;
                case "Sala 4":
                    cargarMesas(botonAux);
                    break;
                case "Sala 5":
                    cargarMesas(botonAux);
                    break;
                case "Sala 6":
                    cargarMesas(botonAux);
                    break;
            }
        }
        private void cargarMesas(Button botonAux)
        {
            int indiceDeSala;
            int.TryParse(botonAux.Text.Substring(5, 1), out indiceDeSala);
            if (TrucoArg.salas[indiceDeSala - 1] != null)
            {
                MostrarFormularioSala(indiceDeSala - 1, 0, 0);//veeeer
            }
            else
            {
                MessageBox.Show("La Sala esta vacia");
            }
        }

        private void salasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gbx_salas.Visible = true;
            btn_crearSala.Visible = true;
            dtg_jugadores.Visible = false;
            lbx_partidas.Visible = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Archivos.Escribir($"REGISTRO DE SALIDA: {DateTime.Now}", "Historial");
            Application.Exit();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gbx_salas.Visible = false;
            dtg_jugadores.Visible = false;
            btn_crearSala.Visible = false;
            lbx_partidas.Visible = true;
            AccesoBaseDeDatos bdPartidas = new AccesoBaseDeDatos();
            List<string> historialPartidas = bdPartidas.ObtenerPartidas();
            foreach (string item in historialPartidas)
            {
                lbx_partidas.Items.Add(item);
            }
        }
    }
}

