﻿namespace Proyecto_BD_HA_V2
{
    partial class CambioUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioUsuario));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPuesto = new System.Windows.Forms.ComboBox();
            this.textoPassword = new System.Windows.Forms.TextBox();
            this.textoAlias = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Neuropol", 14.25F, System.Drawing.FontStyle.Italic);
            this.button3.Location = new System.Drawing.Point(267, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 177;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Neuropol", 14.25F, System.Drawing.FontStyle.Italic);
            this.button2.Location = new System.Drawing.Point(479, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 176;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Neuropol", 14.25F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(33, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 175;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 163;
            this.label3.Text = "Cambio de un registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(96, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 161;
            this.label1.Text = "Cambio";
            // 
            // comboPuesto
            // 
            this.comboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPuesto.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Italic);
            this.comboPuesto.FormattingEnabled = true;
            this.comboPuesto.Items.AddRange(new object[] {
            "Gerente",
            "Almacenista",
            "Vendedor"});
            this.comboPuesto.Location = new System.Drawing.Point(239, 235);
            this.comboPuesto.Name = "comboPuesto";
            this.comboPuesto.Size = new System.Drawing.Size(364, 25);
            this.comboPuesto.TabIndex = 185;
            // 
            // textoPassword
            // 
            this.textoPassword.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Italic);
            this.textoPassword.Location = new System.Drawing.Point(239, 204);
            this.textoPassword.Name = "textoPassword";
            this.textoPassword.PasswordChar = '*';
            this.textoPassword.Size = new System.Drawing.Size(364, 23);
            this.textoPassword.TabIndex = 184;
            // 
            // textoAlias
            // 
            this.textoAlias.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Italic);
            this.textoAlias.Location = new System.Drawing.Point(239, 174);
            this.textoAlias.Name = "textoAlias";
            this.textoAlias.Size = new System.Drawing.Size(364, 23);
            this.textoAlias.TabIndex = 183;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Neuropol", 14.25F, System.Drawing.FontStyle.Italic);
            this.label12.Location = new System.Drawing.Point(81, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 182;
            this.label12.Text = "Puesto *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Neuropol", 14.25F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(81, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 181;
            this.label10.Text = "Password *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Neuropol", 14.25F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(81, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 180;
            this.label8.Text = "Alias *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Neuropol", 14.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(81, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 179;
            this.label9.Text = "Nombre *";
            // 
            // textoNombre
            // 
            this.textoNombre.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Italic);
            this.textoNombre.Location = new System.Drawing.Point(239, 145);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(364, 23);
            this.textoNombre.TabIndex = 178;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 53);
            this.label2.TabIndex = 206;
            this.label2.Text = "THE DARK UNIFORMS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Neuropol", 14.25F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(87, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 207;
            this.label4.Text = "Correo *";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Italic);
            this.txtCorreo.Location = new System.Drawing.Point(239, 269);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(364, 23);
            this.txtCorreo.TabIndex = 208;
            // 
            // CambioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPuesto);
            this.Controls.Add(this.textoPassword);
            this.Controls.Add(this.textoAlias);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CambioUsuario";
            this.Text = "The Dark Uniforms - Cambio Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPuesto;
        private System.Windows.Forms.TextBox textoPassword;
        private System.Windows.Forms.TextBox textoAlias;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textoNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
    }
}