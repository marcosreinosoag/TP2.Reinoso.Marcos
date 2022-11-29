namespace Vista
{
    partial class Loguin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loguin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txb_clave = new System.Windows.Forms.TextBox();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.lbl_titulo2 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_admin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-455, -58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1328, 579);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txb_clave
            // 
            this.txb_clave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_clave.Location = new System.Drawing.Point(236, 223);
            this.txb_clave.Name = "txb_clave";
            this.txb_clave.PasswordChar = '*';
            this.txb_clave.PlaceholderText = "Ingrese Contraseña";
            this.txb_clave.Size = new System.Drawing.Size(403, 23);
            this.txb_clave.TabIndex = 11;
            // 
            // txb_usuario
            // 
            this.txb_usuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_usuario.Location = new System.Drawing.Point(236, 157);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.PlaceholderText = "Ingrese Usuario";
            this.txb_usuario.Size = new System.Drawing.Size(403, 23);
            this.txb_usuario.TabIndex = 10;
            // 
            // lbl_titulo2
            // 
            this.lbl_titulo2.AutoSize = true;
            this.lbl_titulo2.BackColor = System.Drawing.Color.Black;
            this.lbl_titulo2.Font = new System.Drawing.Font("Yellowtail", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo2.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_titulo2.Location = new System.Drawing.Point(473, 44);
            this.lbl_titulo2.Name = "lbl_titulo2";
            this.lbl_titulo2.Size = new System.Drawing.Size(123, 61);
            this.lbl_titulo2.TabIndex = 9;
            this.lbl_titulo2.Text = "ARG";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Black;
            this.lbl_titulo.Font = new System.Drawing.Font("Yellowtail", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_titulo.Location = new System.Drawing.Point(293, 44);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(188, 61);
            this.lbl_titulo.TabIndex = 8;
            this.lbl_titulo.Text = "TRUCO";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(179, 325);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(161, 35);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ingresar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_ingresar.Location = new System.Drawing.Point(577, 325);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(161, 35);
            this.btn_ingresar.TabIndex = 6;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(398, 258);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 15);
            this.lbl_error.TabIndex = 12;
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_admin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_admin.ForeColor = System.Drawing.Color.Gold;
            this.btn_admin.Location = new System.Drawing.Point(398, 286);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(102, 27);
            this.btn_admin.TabIndex = 13;
            this.btn_admin.Text = "Administrador";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // Loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(854, 500);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.txb_clave);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.lbl_titulo2);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loguin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txb_clave;
        private TextBox txb_usuario;
        private Label lbl_titulo2;
        private Label lbl_titulo;
        private Button btn_salir;
        private Button btn_ingresar;
        private Label lbl_error;
        private Button btn_admin;
    }
}