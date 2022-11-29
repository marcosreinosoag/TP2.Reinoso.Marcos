namespace Vista
{
    partial class MenuSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSala));
            this.cmb_jugadorUno = new System.Windows.Forms.ComboBox();
            this.cmb_jugadorDos = new System.Windows.Forms.ComboBox();
            this.lbl_jugadorUno = new System.Windows.Forms.Label();
            this.lbl_jugadorDos = new System.Windows.Forms.Label();
            this.lbl_sala = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_nombreJ1 = new System.Windows.Forms.Label();
            this.txb_nombreJ1 = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txb_apellidoJ1 = new System.Windows.Forms.TextBox();
            this.txb_partidasJ1 = new System.Windows.Forms.TextBox();
            this.lbl_partidasJ1 = new System.Windows.Forms.Label();
            this.lbl_nombreJ2 = new System.Windows.Forms.Label();
            this.lbl_apellidoJ2 = new System.Windows.Forms.Label();
            this.lbl_partidasJ2 = new System.Windows.Forms.Label();
            this.txb_partidasJ2 = new System.Windows.Forms.TextBox();
            this.txb_apellidoJ2 = new System.Windows.Forms.TextBox();
            this.txb_nombreJ2 = new System.Windows.Forms.TextBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_errorJugadorUno = new System.Windows.Forms.Button();
            this.btn_errorJugadorDos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_jugadorUno
            // 
            this.cmb_jugadorUno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_jugadorUno.FormattingEnabled = true;
            this.cmb_jugadorUno.Location = new System.Drawing.Point(84, 74);
            this.cmb_jugadorUno.Name = "cmb_jugadorUno";
            this.cmb_jugadorUno.Size = new System.Drawing.Size(188, 23);
            this.cmb_jugadorUno.TabIndex = 0;
            this.cmb_jugadorUno.SelectedIndexChanged += new System.EventHandler(this.cmb_jugadorUno_SelectedIndexChanged);
            // 
            // cmb_jugadorDos
            // 
            this.cmb_jugadorDos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_jugadorDos.FormattingEnabled = true;
            this.cmb_jugadorDos.Location = new System.Drawing.Point(442, 74);
            this.cmb_jugadorDos.Name = "cmb_jugadorDos";
            this.cmb_jugadorDos.Size = new System.Drawing.Size(188, 23);
            this.cmb_jugadorDos.TabIndex = 1;
            this.cmb_jugadorDos.SelectedIndexChanged += new System.EventHandler(this.cmb_jugadorDos_SelectedIndexChanged);
            // 
            // lbl_jugadorUno
            // 
            this.lbl_jugadorUno.AutoSize = true;
            this.lbl_jugadorUno.ForeColor = System.Drawing.Color.White;
            this.lbl_jugadorUno.Location = new System.Drawing.Point(16, 77);
            this.lbl_jugadorUno.Name = "lbl_jugadorUno";
            this.lbl_jugadorUno.Size = new System.Drawing.Size(58, 15);
            this.lbl_jugadorUno.TabIndex = 2;
            this.lbl_jugadorUno.Text = "Jugador 1";
            // 
            // lbl_jugadorDos
            // 
            this.lbl_jugadorDos.AutoSize = true;
            this.lbl_jugadorDos.ForeColor = System.Drawing.Color.White;
            this.lbl_jugadorDos.Location = new System.Drawing.Point(369, 77);
            this.lbl_jugadorDos.Name = "lbl_jugadorDos";
            this.lbl_jugadorDos.Size = new System.Drawing.Size(58, 15);
            this.lbl_jugadorDos.TabIndex = 3;
            this.lbl_jugadorDos.Text = "Jugador 2";
            // 
            // lbl_sala
            // 
            this.lbl_sala.AutoSize = true;
            this.lbl_sala.ForeColor = System.Drawing.Color.White;
            this.lbl_sala.Location = new System.Drawing.Point(281, 22);
            this.lbl_sala.Name = "lbl_sala";
            this.lbl_sala.Size = new System.Drawing.Size(0, 15);
            this.lbl_sala.TabIndex = 4;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(472, 265);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(141, 33);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(114, 265);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(141, 33);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_nombreJ1
            // 
            this.lbl_nombreJ1.AutoSize = true;
            this.lbl_nombreJ1.ForeColor = System.Drawing.Color.White;
            this.lbl_nombreJ1.Location = new System.Drawing.Point(16, 125);
            this.lbl_nombreJ1.Name = "lbl_nombreJ1";
            this.lbl_nombreJ1.Size = new System.Drawing.Size(54, 15);
            this.lbl_nombreJ1.TabIndex = 7;
            this.lbl_nombreJ1.Text = "Nombre:";
            // 
            // txb_nombreJ1
            // 
            this.txb_nombreJ1.Enabled = false;
            this.txb_nombreJ1.Location = new System.Drawing.Point(85, 117);
            this.txb_nombreJ1.Name = "txb_nombreJ1";
            this.txb_nombreJ1.Size = new System.Drawing.Size(185, 23);
            this.txb_nombreJ1.TabIndex = 8;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.ForeColor = System.Drawing.Color.White;
            this.lbl_apellido.Location = new System.Drawing.Point(16, 167);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(54, 15);
            this.lbl_apellido.TabIndex = 9;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // txb_apellidoJ1
            // 
            this.txb_apellidoJ1.Enabled = false;
            this.txb_apellidoJ1.Location = new System.Drawing.Point(85, 161);
            this.txb_apellidoJ1.Name = "txb_apellidoJ1";
            this.txb_apellidoJ1.Size = new System.Drawing.Size(185, 23);
            this.txb_apellidoJ1.TabIndex = 10;
            // 
            // txb_partidasJ1
            // 
            this.txb_partidasJ1.Enabled = false;
            this.txb_partidasJ1.Location = new System.Drawing.Point(139, 201);
            this.txb_partidasJ1.Name = "txb_partidasJ1";
            this.txb_partidasJ1.Size = new System.Drawing.Size(131, 23);
            this.txb_partidasJ1.TabIndex = 11;
            // 
            // lbl_partidasJ1
            // 
            this.lbl_partidasJ1.AutoSize = true;
            this.lbl_partidasJ1.ForeColor = System.Drawing.Color.White;
            this.lbl_partidasJ1.Location = new System.Drawing.Point(16, 209);
            this.lbl_partidasJ1.Name = "lbl_partidasJ1";
            this.lbl_partidasJ1.Size = new System.Drawing.Size(97, 15);
            this.lbl_partidasJ1.TabIndex = 12;
            this.lbl_partidasJ1.Text = "Partidas Ganadas";
            // 
            // lbl_nombreJ2
            // 
            this.lbl_nombreJ2.AutoSize = true;
            this.lbl_nombreJ2.ForeColor = System.Drawing.Color.White;
            this.lbl_nombreJ2.Location = new System.Drawing.Point(382, 120);
            this.lbl_nombreJ2.Name = "lbl_nombreJ2";
            this.lbl_nombreJ2.Size = new System.Drawing.Size(54, 15);
            this.lbl_nombreJ2.TabIndex = 13;
            this.lbl_nombreJ2.Text = "Nombre:";
            // 
            // lbl_apellidoJ2
            // 
            this.lbl_apellidoJ2.AutoSize = true;
            this.lbl_apellidoJ2.ForeColor = System.Drawing.Color.White;
            this.lbl_apellidoJ2.Location = new System.Drawing.Point(382, 164);
            this.lbl_apellidoJ2.Name = "lbl_apellidoJ2";
            this.lbl_apellidoJ2.Size = new System.Drawing.Size(54, 15);
            this.lbl_apellidoJ2.TabIndex = 14;
            this.lbl_apellidoJ2.Text = "Apellido:";
            // 
            // lbl_partidasJ2
            // 
            this.lbl_partidasJ2.AutoSize = true;
            this.lbl_partidasJ2.ForeColor = System.Drawing.Color.White;
            this.lbl_partidasJ2.Location = new System.Drawing.Point(382, 204);
            this.lbl_partidasJ2.Name = "lbl_partidasJ2";
            this.lbl_partidasJ2.Size = new System.Drawing.Size(97, 15);
            this.lbl_partidasJ2.TabIndex = 15;
            this.lbl_partidasJ2.Text = "Partidas Ganadas";
            // 
            // txb_partidasJ2
            // 
            this.txb_partidasJ2.Enabled = false;
            this.txb_partidasJ2.Location = new System.Drawing.Point(501, 201);
            this.txb_partidasJ2.Name = "txb_partidasJ2";
            this.txb_partidasJ2.Size = new System.Drawing.Size(130, 23);
            this.txb_partidasJ2.TabIndex = 16;
            // 
            // txb_apellidoJ2
            // 
            this.txb_apellidoJ2.Enabled = false;
            this.txb_apellidoJ2.Location = new System.Drawing.Point(446, 161);
            this.txb_apellidoJ2.Name = "txb_apellidoJ2";
            this.txb_apellidoJ2.Size = new System.Drawing.Size(185, 23);
            this.txb_apellidoJ2.TabIndex = 17;
            // 
            // txb_nombreJ2
            // 
            this.txb_nombreJ2.Enabled = false;
            this.txb_nombreJ2.Location = new System.Drawing.Point(446, 117);
            this.txb_nombreJ2.Name = "txb_nombreJ2";
            this.txb_nombreJ2.Size = new System.Drawing.Size(185, 23);
            this.txb_nombreJ2.TabIndex = 18;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(292, 240);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 15);
            this.lbl_error.TabIndex = 19;
            // 
            // btn_errorJugadorUno
            // 
            this.btn_errorJugadorUno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorJugadorUno.BackColor = System.Drawing.Color.Black;
            this.btn_errorJugadorUno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorJugadorUno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorJugadorUno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorJugadorUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorJugadorUno.ForeColor = System.Drawing.Color.Black;
            this.btn_errorJugadorUno.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorJugadorUno.Image")));
            this.btn_errorJugadorUno.Location = new System.Drawing.Point(281, 68);
            this.btn_errorJugadorUno.Name = "btn_errorJugadorUno";
            this.btn_errorJugadorUno.Size = new System.Drawing.Size(27, 33);
            this.btn_errorJugadorUno.TabIndex = 53;
            this.btn_errorJugadorUno.UseVisualStyleBackColor = false;
            this.btn_errorJugadorUno.Visible = false;
            this.btn_errorJugadorUno.MouseHover += new System.EventHandler(this.btn_errorJugador_MouseHover);
            // 
            // btn_errorJugadorDos
            // 
            this.btn_errorJugadorDos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorJugadorDos.BackColor = System.Drawing.Color.Black;
            this.btn_errorJugadorDos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_errorJugadorDos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_errorJugadorDos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_errorJugadorDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorJugadorDos.ForeColor = System.Drawing.Color.Black;
            this.btn_errorJugadorDos.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorJugadorDos.Image")));
            this.btn_errorJugadorDos.Location = new System.Drawing.Point(645, 68);
            this.btn_errorJugadorDos.Name = "btn_errorJugadorDos";
            this.btn_errorJugadorDos.Size = new System.Drawing.Size(27, 33);
            this.btn_errorJugadorDos.TabIndex = 54;
            this.btn_errorJugadorDos.UseVisualStyleBackColor = false;
            this.btn_errorJugadorDos.Visible = false;
            this.btn_errorJugadorDos.MouseHover += new System.EventHandler(this.btn_errorJugador_MouseHover);
            // 
            // MenuSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 331);
            this.ControlBox = false;
            this.Controls.Add(this.btn_errorJugadorDos);
            this.Controls.Add(this.btn_errorJugadorUno);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.txb_nombreJ2);
            this.Controls.Add(this.txb_apellidoJ2);
            this.Controls.Add(this.txb_partidasJ2);
            this.Controls.Add(this.lbl_partidasJ2);
            this.Controls.Add(this.lbl_apellidoJ2);
            this.Controls.Add(this.lbl_nombreJ2);
            this.Controls.Add(this.lbl_partidasJ1);
            this.Controls.Add(this.txb_partidasJ1);
            this.Controls.Add(this.txb_apellidoJ1);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.txb_nombreJ1);
            this.Controls.Add(this.lbl_nombreJ1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_sala);
            this.Controls.Add(this.lbl_jugadorDos);
            this.Controls.Add(this.lbl_jugadorUno);
            this.Controls.Add(this.cmb_jugadorDos);
            this.Controls.Add(this.cmb_jugadorUno);
            this.Name = "MenuSala";
            this.Text = "Menu Sala";
            this.Load += new System.EventHandler(this.MenuSala_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_jugadorUno;
        private ComboBox cmb_jugadorDos;
        private Label lbl_jugadorUno;
        private Label lbl_jugadorDos;
        private Label lbl_sala;
        private Button btn_aceptar;
        private Button btn_cancelar;
        private Label lbl_nombreJ1;
        private TextBox txb_nombreJ1;
        private Label lbl_apellido;
        private TextBox txb_apellidoJ1;
        private TextBox txb_partidasJ1;
        private Label lbl_partidasJ1;
        private Label lbl_nombreJ2;
        private Label lbl_apellidoJ2;
        private Label lbl_partidasJ2;
        private TextBox txb_partidasJ2;
        private TextBox txb_apellidoJ2;
        private TextBox txb_nombreJ2;
        private Label lbl_error;
        private Button btn_errorJugadorUno;
        private Button btn_errorJugadorDos;
    }
}