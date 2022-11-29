namespace Vista
{
    partial class InformacionSala
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.rchx_historialPartida = new System.Windows.Forms.RichTextBox();
            this.btn_finalizarPartida = new System.Windows.Forms.Button();
            this.lbl_numeroSala = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(281, 385);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(228, 38);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar Sala";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(41, 385);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(208, 38);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // rchx_historialPartida
            // 
            this.rchx_historialPartida.Location = new System.Drawing.Point(41, 72);
            this.rchx_historialPartida.Name = "rchx_historialPartida";
            this.rchx_historialPartida.Size = new System.Drawing.Size(730, 287);
            this.rchx_historialPartida.TabIndex = 3;
            this.rchx_historialPartida.Text = "";
            // 
            // btn_finalizarPartida
            // 
            this.btn_finalizarPartida.Enabled = false;
            this.btn_finalizarPartida.Location = new System.Drawing.Point(543, 385);
            this.btn_finalizarPartida.Name = "btn_finalizarPartida";
            this.btn_finalizarPartida.Size = new System.Drawing.Size(228, 36);
            this.btn_finalizarPartida.TabIndex = 4;
            this.btn_finalizarPartida.Text = "Finalizar Partida";
            this.btn_finalizarPartida.UseVisualStyleBackColor = true;
            this.btn_finalizarPartida.Click += new System.EventHandler(this.btn_finalizarPartida_Click);
            // 
            // lbl_numeroSala
            // 
            this.lbl_numeroSala.AutoSize = true;
            this.lbl_numeroSala.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_numeroSala.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_numeroSala.Location = new System.Drawing.Point(21, 9);
            this.lbl_numeroSala.Name = "lbl_numeroSala";
            this.lbl_numeroSala.Size = new System.Drawing.Size(58, 23);
            this.lbl_numeroSala.TabIndex = 5;
            this.lbl_numeroSala.Text = "label1";
            // 
            // InformacionSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_numeroSala);
            this.Controls.Add(this.btn_finalizarPartida);
            this.Controls.Add(this.rchx_historialPartida);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_cancelar);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "InformacionSala";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Informacion Sala";
            this.Load += new System.EventHandler(this.InformacionSala_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Button btn_cancelar;
        private Button btn_salir;
        private RichTextBox rchx_historialPartida;
        private Button btn_finalizarPartida;
        private Label lbl_numeroSala;
    }
}