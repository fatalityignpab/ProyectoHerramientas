namespace Proyecto_BD_HA_V2
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textoCant = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnVenProd = new System.Windows.Forms.Button();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.textProducto = new System.Windows.Forms.TextBox();
            this.btnVenderProducto = new System.Windows.Forms.Button();
            this.btnVicProd = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 93;
            this.button2.Text = "Terminar Venta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 92;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 89;
            this.label3.Text = "Registro de Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(118, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 26);
            this.label1.TabIndex = 87;
            this.label1.Text = "Venta de Productos";
            // 
            // textoCant
            // 
            this.textoCant.Location = new System.Drawing.Point(172, 230);
            this.textoCant.Name = "textoCant";
            this.textoCant.Size = new System.Drawing.Size(101, 20);
            this.textoCant.TabIndex = 86;
            this.textoCant.Validated += new System.EventHandler(this.textoCant_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(62, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 82;
            this.label12.Text = "Cantidad *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 80;
            this.label8.Text = "ID Producto *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 95;
            this.label4.Text = "ID Cliente *";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(172, 148);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(101, 21);
            this.comboBoxCliente.TabIndex = 96;
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(172, 198);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(101, 21);
            this.comboBoxProducto.TabIndex = 97;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 50);
            this.button3.TabIndex = 98;
            this.button3.Text = "Ver BD Clientes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(356, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 50);
            this.button4.TabIndex = 99;
            this.button4.Text = "Ver BD Productos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnVenProd
            // 
            this.btnVenProd.Location = new System.Drawing.Point(555, 148);
            this.btnVenProd.Name = "btnVenProd";
            this.btnVenProd.Size = new System.Drawing.Size(108, 21);
            this.btnVenProd.TabIndex = 101;
            this.btnVenProd.Text = "Seleccionar Cliente";
            this.btnVenProd.UseVisualStyleBackColor = true;
            this.btnVenProd.Click += new System.EventHandler(this.btnVenProd_Click);
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(290, 148);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(241, 20);
            this.textCliente.TabIndex = 102;
            // 
            // textProducto
            // 
            this.textProducto.Location = new System.Drawing.Point(290, 197);
            this.textProducto.Multiline = true;
            this.textProducto.Name = "textProducto";
            this.textProducto.Size = new System.Drawing.Size(241, 73);
            this.textProducto.TabIndex = 103;
            // 
            // btnVenderProducto
            // 
            this.btnVenderProducto.Location = new System.Drawing.Point(555, 226);
            this.btnVenderProducto.Name = "btnVenderProducto";
            this.btnVenderProducto.Size = new System.Drawing.Size(108, 44);
            this.btnVenderProducto.TabIndex = 104;
            this.btnVenderProducto.Text = "Vender Producto";
            this.btnVenderProducto.UseVisualStyleBackColor = true;
            this.btnVenderProducto.Click += new System.EventHandler(this.btnVenderProducto_Click);
            // 
            // btnVicProd
            // 
            this.btnVicProd.Location = new System.Drawing.Point(555, 197);
            this.btnVicProd.Name = "btnVicProd";
            this.btnVicProd.Size = new System.Drawing.Size(108, 21);
            this.btnVicProd.TabIndex = 105;
            this.btnVicProd.Text = "Visualizar Producto";
            this.btnVicProd.UseVisualStyleBackColor = true;
            this.btnVicProd.Click += new System.EventHandler(this.btnVicProd_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 106;
            this.label5.Text = "ID Factura *";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textFactura
            // 
            this.textFactura.Location = new System.Drawing.Point(315, 107);
            this.textFactura.Name = "textFactura";
            this.textFactura.Size = new System.Drawing.Size(136, 20);
            this.textFactura.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 53);
            this.label2.TabIndex = 207;
            this.label2.Text = "THE DARK UNIFORMS";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVicProd);
            this.Controls.Add(this.btnVenderProducto);
            this.Controls.Add(this.textProducto);
            this.Controls.Add(this.textCliente);
            this.Controls.Add(this.btnVenProd);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxProducto);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoCant);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoCant;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnVenProd;
        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.TextBox textProducto;
        private System.Windows.Forms.Button btnVenderProducto;
        private System.Windows.Forms.Button btnVicProd;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox textFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}