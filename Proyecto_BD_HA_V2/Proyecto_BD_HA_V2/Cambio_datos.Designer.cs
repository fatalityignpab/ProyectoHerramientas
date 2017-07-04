namespace Proyecto_BD_HA_V2
{
    partial class Cambio_datos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cambio_datos));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboTalla = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 59;
            this.label3.Text = "Cambio de un registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(122, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 57;
            this.label1.Text = "Cambio";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Neuropol", 14.25F, System.Drawing.FontStyle.Italic);
            this.button2.Location = new System.Drawing.Point(479, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 157;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Neuropol", 14.25F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(33, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 156;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPrecio
            // 
            this.textPrecio.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Italic);
            this.textPrecio.Location = new System.Drawing.Point(176, 235);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(453, 23);
            this.textPrecio.TabIndex = 124;
            this.textPrecio.Validated += new System.EventHandler(this.textPrecio_Validated);
            // 
            // textStock
            // 
            this.textStock.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Italic);
            this.textStock.Location = new System.Drawing.Point(174, 264);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(453, 23);
            this.textStock.TabIndex = 123;
            this.textStock.Validated += new System.EventHandler(this.textBoxcosto_Validated);
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Italic);
            this.textNombre.Location = new System.Drawing.Point(176, 175);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(453, 23);
            this.textNombre.TabIndex = 122;
            this.textNombre.Validated += new System.EventHandler(this.textBoxpieza_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Neuropol", 14.25F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(30, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 120;
            this.label11.Text = "Stock *";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Neuropol", 14.25F, System.Drawing.FontStyle.Italic);
            this.label12.Location = new System.Drawing.Point(30, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 119;
            this.label12.Text = "Precio *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Neuropol", 14.25F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(30, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 118;
            this.label10.Text = "Talla *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Neuropol", 14.25F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(30, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 117;
            this.label8.Text = "Nombre *";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Neuropol", 14.25F, System.Drawing.FontStyle.Italic);
            this.button3.Location = new System.Drawing.Point(267, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 159;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // comboTalla
            // 
            this.comboTalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTalla.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Italic);
            this.comboTalla.FormattingEnabled = true;
            this.comboTalla.Items.AddRange(new object[] {
            "Extra Chico",
            "Chico",
            "Mediano",
            "Grande",
            "Extra Grande"});
            this.comboTalla.Location = new System.Drawing.Point(174, 205);
            this.comboTalla.Name = "comboTalla";
            this.comboTalla.Size = new System.Drawing.Size(455, 25);
            this.comboTalla.TabIndex = 160;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 53);
            this.label2.TabIndex = 161;
            this.label2.Text = "THE DARK UNIFORMS";
            // 
            // Cambio_datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTalla);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textStock);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cambio_datos";
            this.Text = "The Dark Uniforms - Cambio_datos";
            this.Load += new System.EventHandler(this.Cambio_datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ComboBox comboTalla;
        private System.Windows.Forms.Label label2;
    }
}