
namespace presentacion
{
    partial class formArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formArticulo));
            this.label1 = new System.Windows.Forms.Label();
            this.codigoArt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.cBMarcas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBCategorias = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pBMarca = new System.Windows.Forms.PictureBox();
            this.tBUrlImage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Precio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMasMarca = new System.Windows.Forms.Button();
            this.btnMasCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Articulo:";
            // 
            // codigoArt
            // 
            this.codigoArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoArt.Location = new System.Drawing.Point(13, 30);
            this.codigoArt.Name = "codigoArt";
            this.codigoArt.Size = new System.Drawing.Size(171, 21);
            this.codigoArt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(13, 81);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(171, 21);
            this.nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion:";
            // 
            // descripcion
            // 
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(13, 139);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(171, 21);
            this.descripcion.TabIndex = 5;
            // 
            // cBMarcas
            // 
            this.cBMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMarcas.FormattingEnabled = true;
            this.cBMarcas.Location = new System.Drawing.Point(16, 193);
            this.cBMarcas.Name = "cBMarcas";
            this.cBMarcas.Size = new System.Drawing.Size(168, 21);
            this.cBMarcas.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Marcas";
            // 
            // cBCategorias
            // 
            this.cBCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCategorias.FormattingEnabled = true;
            this.cBCategorias.Location = new System.Drawing.Point(16, 252);
            this.cBCategorias.Name = "cBCategorias";
            this.cBCategorias.Size = new System.Drawing.Size(168, 21);
            this.cBCategorias.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categorias";
            // 
            // pBMarca
            // 
            this.pBMarca.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pBMarca.ErrorImage")));
            this.pBMarca.Location = new System.Drawing.Point(258, 30);
            this.pBMarca.Name = "pBMarca";
            this.pBMarca.Size = new System.Drawing.Size(222, 192);
            this.pBMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMarca.TabIndex = 10;
            this.pBMarca.TabStop = false;
            // 
            // tBUrlImage
            // 
            this.tBUrlImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBUrlImage.Location = new System.Drawing.Point(16, 306);
            this.tBUrlImage.Name = "tBUrlImage";
            this.tBUrlImage.Size = new System.Drawing.Size(171, 21);
            this.tBUrlImage.TabIndex = 12;
            this.tBUrlImage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBUrlImage_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "URL Imagen";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(258, 299);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAceptar.Size = new System.Drawing.Size(109, 37);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(373, 299);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelar.Size = new System.Drawing.Size(109, 37);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Precio
            // 
            this.Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.Location = new System.Drawing.Point(258, 252);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(84, 21);
            this.Precio.TabIndex = 15;
            this.Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Precio_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(255, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Precio:";
            // 
            // btnMasMarca
            // 
            this.btnMasMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasMarca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMasMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasMarca.ForeColor = System.Drawing.Color.Black;
            this.btnMasMarca.Location = new System.Drawing.Point(190, 193);
            this.btnMasMarca.Name = "btnMasMarca";
            this.btnMasMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMasMarca.Size = new System.Drawing.Size(21, 21);
            this.btnMasMarca.TabIndex = 17;
            this.btnMasMarca.Text = "+";
            this.btnMasMarca.UseVisualStyleBackColor = true;
            this.btnMasMarca.Click += new System.EventHandler(this.btnMasMarca_Click);
            // 
            // btnMasCategoria
            // 
            this.btnMasCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMasCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnMasCategoria.Location = new System.Drawing.Point(190, 253);
            this.btnMasCategoria.Name = "btnMasCategoria";
            this.btnMasCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMasCategoria.Size = new System.Drawing.Size(21, 21);
            this.btnMasCategoria.TabIndex = 18;
            this.btnMasCategoria.Text = "+";
            this.btnMasCategoria.UseVisualStyleBackColor = true;
            this.btnMasCategoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // formArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(528, 363);
            this.Controls.Add(this.btnMasCategoria);
            this.Controls.Add(this.btnMasMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tBUrlImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pBMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBCategorias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBMarcas);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigoArt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.agregarArticulo_FormClosing);
            this.Load += new System.EventHandler(this.agregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.ComboBox cBMarcas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBCategorias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pBMarca;
        private System.Windows.Forms.TextBox tBUrlImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMasMarca;
        private System.Windows.Forms.Button btnMasCategoria;
    }
}