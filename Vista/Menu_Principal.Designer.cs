namespace Vista
{
    partial class Menu_Principal
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
            this.btn_crearSala = new System.Windows.Forms.Button();
            this.btn_sala1 = new System.Windows.Forms.Button();
            this.mtp_menu = new System.Windows.Forms.MenuStrip();
            this.salasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_sala2 = new System.Windows.Forms.Button();
            this.btn_sala3 = new System.Windows.Forms.Button();
            this.btn_sala4 = new System.Windows.Forms.Button();
            this.btn_sala5 = new System.Windows.Forms.Button();
            this.btn_sala6 = new System.Windows.Forms.Button();
            this.gbx_salas = new System.Windows.Forms.GroupBox();
            this.dtg_jugadores = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.mtp_menu.SuspendLayout();
            this.gbx_salas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_jugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crearSala
            // 
            this.btn_crearSala.Location = new System.Drawing.Point(600, 44);
            this.btn_crearSala.Name = "btn_crearSala";
            this.btn_crearSala.Size = new System.Drawing.Size(166, 41);
            this.btn_crearSala.TabIndex = 0;
            this.btn_crearSala.Text = "Crear Sala";
            this.btn_crearSala.UseVisualStyleBackColor = true;
            this.btn_crearSala.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sala1
            // 
            this.btn_sala1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sala1.ForeColor = System.Drawing.Color.Black;
            this.btn_sala1.Location = new System.Drawing.Point(43, 33);
            this.btn_sala1.Name = "btn_sala1";
            this.btn_sala1.Size = new System.Drawing.Size(82, 31);
            this.btn_sala1.TabIndex = 1;
            this.btn_sala1.Text = "Sala 1";
            this.btn_sala1.UseVisualStyleBackColor = true;
            this.btn_sala1.Click += new System.EventHandler(this.btn_sala1_Click);
            // 
            // mtp_menu
            // 
            this.mtp_menu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtp_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salasToolStripMenuItem1,
            this.jugadoresToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            this.mtp_menu.Location = new System.Drawing.Point(0, 0);
            this.mtp_menu.Name = "mtp_menu";
            this.mtp_menu.Size = new System.Drawing.Size(800, 24);
            this.mtp_menu.TabIndex = 3;
            this.mtp_menu.Text = "menuStrip1";
            // 
            // salasToolStripMenuItem1
            // 
            this.salasToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.salasToolStripMenuItem1.Name = "salasToolStripMenuItem1";
            this.salasToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.salasToolStripMenuItem1.Text = "Salas";
            this.salasToolStripMenuItem1.Click += new System.EventHandler(this.salasToolStripMenuItem1_Click);
            // 
            // jugadoresToolStripMenuItem
            // 
            this.jugadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearJugadorToolStripMenuItem,
            this.modificarJugadorToolStripMenuItem,
            this.eliminarJugadorToolStripMenuItem});
            this.jugadoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.jugadoresToolStripMenuItem.Name = "jugadoresToolStripMenuItem";
            this.jugadoresToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.jugadoresToolStripMenuItem.Text = "Jugadores";
            this.jugadoresToolStripMenuItem.Click += new System.EventHandler(this.jugadoresToolStripMenuItem_Click);
            // 
            // crearJugadorToolStripMenuItem
            // 
            this.crearJugadorToolStripMenuItem.Name = "crearJugadorToolStripMenuItem";
            this.crearJugadorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.crearJugadorToolStripMenuItem.Text = "Crear Jugador";
            this.crearJugadorToolStripMenuItem.Click += new System.EventHandler(this.crearJugadorToolStripMenuItem_Click);
            // 
            // modificarJugadorToolStripMenuItem
            // 
            this.modificarJugadorToolStripMenuItem.Name = "modificarJugadorToolStripMenuItem";
            this.modificarJugadorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.modificarJugadorToolStripMenuItem.Text = "Modificar Jugador";
            this.modificarJugadorToolStripMenuItem.Click += new System.EventHandler(this.modificarJugadorToolStripMenuItem_Click);
            // 
            // eliminarJugadorToolStripMenuItem
            // 
            this.eliminarJugadorToolStripMenuItem.Name = "eliminarJugadorToolStripMenuItem";
            this.eliminarJugadorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.eliminarJugadorToolStripMenuItem.Text = "Eliminar Jugador";
            this.eliminarJugadorToolStripMenuItem.Click += new System.EventHandler(this.eliminarJugadorToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jugadoresToolStripMenuItem1,
            this.salasToolStripMenuItem});
            this.estadisticasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // jugadoresToolStripMenuItem1
            // 
            this.jugadoresToolStripMenuItem1.Name = "jugadoresToolStripMenuItem1";
            this.jugadoresToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.jugadoresToolStripMenuItem1.Text = "Jugadores";
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.salasToolStripMenuItem.Text = "Salas";
            // 
            // btn_sala2
            // 
            this.btn_sala2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sala2.ForeColor = System.Drawing.Color.Black;
            this.btn_sala2.Location = new System.Drawing.Point(199, 33);
            this.btn_sala2.Name = "btn_sala2";
            this.btn_sala2.Size = new System.Drawing.Size(82, 32);
            this.btn_sala2.TabIndex = 4;
            this.btn_sala2.Text = "Sala 2";
            this.btn_sala2.UseVisualStyleBackColor = true;
            this.btn_sala2.Click += new System.EventHandler(this.btn_sala1_Click);
            // 
            // btn_sala3
            // 
            this.btn_sala3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sala3.ForeColor = System.Drawing.Color.Black;
            this.btn_sala3.Location = new System.Drawing.Point(43, 118);
            this.btn_sala3.Name = "btn_sala3";
            this.btn_sala3.Size = new System.Drawing.Size(82, 32);
            this.btn_sala3.TabIndex = 5;
            this.btn_sala3.Text = "Sala 3";
            this.btn_sala3.UseVisualStyleBackColor = true;
            this.btn_sala3.Click += new System.EventHandler(this.btn_sala1_Click);
            // 
            // btn_sala4
            // 
            this.btn_sala4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sala4.ForeColor = System.Drawing.Color.Black;
            this.btn_sala4.Location = new System.Drawing.Point(199, 118);
            this.btn_sala4.Name = "btn_sala4";
            this.btn_sala4.Size = new System.Drawing.Size(82, 32);
            this.btn_sala4.TabIndex = 6;
            this.btn_sala4.Text = "Sala 4";
            this.btn_sala4.UseVisualStyleBackColor = true;
            this.btn_sala4.Click += new System.EventHandler(this.btn_sala1_Click);
            // 
            // btn_sala5
            // 
            this.btn_sala5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sala5.ForeColor = System.Drawing.Color.Black;
            this.btn_sala5.Location = new System.Drawing.Point(43, 212);
            this.btn_sala5.Name = "btn_sala5";
            this.btn_sala5.Size = new System.Drawing.Size(82, 32);
            this.btn_sala5.TabIndex = 7;
            this.btn_sala5.Text = "Sala 5";
            this.btn_sala5.UseVisualStyleBackColor = true;
            this.btn_sala5.Click += new System.EventHandler(this.btn_sala1_Click);
            // 
            // btn_sala6
            // 
            this.btn_sala6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sala6.ForeColor = System.Drawing.Color.Black;
            this.btn_sala6.Location = new System.Drawing.Point(206, 212);
            this.btn_sala6.Name = "btn_sala6";
            this.btn_sala6.Size = new System.Drawing.Size(75, 32);
            this.btn_sala6.TabIndex = 8;
            this.btn_sala6.Text = "Sala 6";
            this.btn_sala6.UseVisualStyleBackColor = true;
            this.btn_sala6.Click += new System.EventHandler(this.btn_sala1_Click);
            // 
            // gbx_salas
            // 
            this.gbx_salas.Controls.Add(this.btn_sala6);
            this.gbx_salas.Controls.Add(this.btn_sala5);
            this.gbx_salas.Controls.Add(this.btn_sala4);
            this.gbx_salas.Controls.Add(this.btn_sala3);
            this.gbx_salas.Controls.Add(this.btn_sala2);
            this.gbx_salas.Controls.Add(this.btn_sala1);
            this.gbx_salas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbx_salas.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gbx_salas.Location = new System.Drawing.Point(12, 97);
            this.gbx_salas.Name = "gbx_salas";
            this.gbx_salas.Size = new System.Drawing.Size(336, 288);
            this.gbx_salas.TabIndex = 9;
            this.gbx_salas.TabStop = false;
            this.gbx_salas.Text = "Salas";
            // 
            // dtg_jugadores
            // 
            this.dtg_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_jugadores.Location = new System.Drawing.Point(394, 104);
            this.dtg_jugadores.Name = "dtg_jugadores";
            this.dtg_jugadores.RowTemplate.Height = 25;
            this.dtg_jugadores.Size = new System.Drawing.Size(372, 281);
            this.dtg_jugadores.TabIndex = 10;
            this.dtg_jugadores.Visible = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_salir.Location = new System.Drawing.Point(12, 411);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(173, 38);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dtg_jugadores);
            this.Controls.Add(this.gbx_salas);
            this.Controls.Add(this.btn_crearSala);
            this.Controls.Add(this.mtp_menu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.mtp_menu;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.mtp_menu.ResumeLayout(false);
            this.mtp_menu.PerformLayout();
            this.gbx_salas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_jugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_crearSala;
        private Button btn_sala1;
        private MenuStrip mtp_menu;
        private ToolStripMenuItem salasToolStripMenuItem1;
        private ToolStripMenuItem jugadoresToolStripMenuItem;
        private ToolStripMenuItem crearJugadorToolStripMenuItem;
        private ToolStripMenuItem modificarJugadorToolStripMenuItem;
        private ToolStripMenuItem eliminarJugadorToolStripMenuItem;
        private ToolStripMenuItem estadisticasToolStripMenuItem;
        private ToolStripMenuItem jugadoresToolStripMenuItem1;
        private ToolStripMenuItem salasToolStripMenuItem;
        private Button btn_sala2;
        private Button btn_sala3;
        private Button btn_sala4;
        private Button btn_sala5;
        private Button btn_sala6;
        private GroupBox gbx_salas;
        private DataGridView dtg_jugadores;
        private Button btn_salir;
    }
}