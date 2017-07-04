namespace Proyecto_BD_HA_V2
{
    partial class Pantalla_Enviar
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_Enviar));
            this.Button1 = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.rtbMensaje = new System.Windows.Forms.RichTextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbCorreo = new System.Windows.Forms.ComboBox();
            this.cmbCorreoCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbServidor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(480, 112);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(43, 23);
            this.Button1.TabIndex = 25;
            this.Button1.Text = ".....";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(90, 114);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(384, 20);
            this.txtRutaArchivo.TabIndex = 24;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label5.Location = new System.Drawing.Point(7, 118);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(77, 18);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "Adjuntar:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(397, 39);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(126, 20);
            this.txtPassword.TabIndex = 22;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label4.Location = new System.Drawing.Point(289, 38);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(98, 18);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Contraseña:";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEnviar.BackgroundImage = global::Proyecto_BD_HA_V2.Properties.Resources.enviar;
            this.BtnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEnviar.FlatAppearance.BorderSize = 0;
            this.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.Location = new System.Drawing.Point(245, 284);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(98, 37);
            this.BtnEnviar.TabIndex = 20;
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // rtbMensaje
            // 
            this.rtbMensaje.Location = new System.Drawing.Point(58, 155);
            this.rtbMensaje.Name = "rtbMensaje";
            this.rtbMensaje.Size = new System.Drawing.Size(464, 118);
            this.rtbMensaje.TabIndex = 19;
            this.rtbMensaje.Text = "ESTIMADO CLIENTE, UNIFORMES UPIICSIANOS ENVÍO SU FACTURA, GRACIAS POR SU PREFEREN" +
    "CIA.";
            this.rtbMensaje.TextChanged += new System.EventHandler(this.rtbMensaje_TextChanged);
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(90, 88);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(183, 20);
            this.txtAsunto.TabIndex = 18;
            this.txtAsunto.Text = "FACTURA";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label3.Location = new System.Drawing.Point(20, 88);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 18);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Asunto:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label2.Location = new System.Drawing.Point(36, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 18);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Para:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label1.Location = new System.Drawing.Point(51, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(33, 18);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "De:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbCorreo
            // 
            this.cmbCorreo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCorreo.FormattingEnabled = true;
            this.cmbCorreo.Location = new System.Drawing.Point(90, 35);
            this.cmbCorreo.Name = "cmbCorreo";
            this.cmbCorreo.Size = new System.Drawing.Size(183, 21);
            this.cmbCorreo.TabIndex = 26;
            // 
            // cmbCorreoCliente
            // 
            this.cmbCorreoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCorreoCliente.FormattingEnabled = true;
            this.cmbCorreoCliente.Location = new System.Drawing.Point(90, 62);
            this.cmbCorreoCliente.Name = "cmbCorreoCliente";
            this.cmbCorreoCliente.Size = new System.Drawing.Size(183, 21);
            this.cmbCorreoCliente.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(289, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Servidor:";
            // 
            // cmbServidor
            // 
            this.cmbServidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServidor.FormattingEnabled = true;
            this.cmbServidor.Items.AddRange(new object[] {
            "Hotmail",
            "Gmail",
            "Yahoo"});
            this.cmbServidor.Location = new System.Drawing.Point(397, 65);
            this.cmbServidor.Name = "cmbServidor";
            this.cmbServidor.Size = new System.Drawing.Size(126, 21);
            this.cmbServidor.TabIndex = 29;
            // 
            // Pantalla_Enviar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = global::Proyecto_BD_HA_V2.Properties.Resources.Gray_minimalist_wallpaper_1280x800;
            this.ClientSize = new System.Drawing.Size(566, 333);
            this.Controls.Add(this.cmbServidor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCorreoCliente);
            this.Controls.Add(this.cmbCorreo);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.rtbMensaje);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pantalla_Enviar";
            this.Text = "The Dark Uniforms - Enviar Correo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtRutaArchivo;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button BtnEnviar;
        internal System.Windows.Forms.RichTextBox rtbMensaje;
        internal System.Windows.Forms.TextBox txtAsunto;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbCorreo;
        private System.Windows.Forms.ComboBox cmbCorreoCliente;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbServidor;
    }
}

