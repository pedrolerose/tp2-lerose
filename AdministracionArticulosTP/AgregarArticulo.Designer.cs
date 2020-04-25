namespace AdministracionArticulosTP
{
    partial class AgregarArticulo
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.LabelMarca = new System.Windows.Forms.Label();
            this.LabelCategoria = new System.Windows.Forms.Label();
            this.ComboMarca = new System.Windows.Forms.ComboBox();
            this.ComboCategoria = new System.Windows.Forms.ComboBox();
            this.LabelImagen = new System.Windows.Forms.Label();
            this.LabelPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(274, 48);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(234, 26);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(687, 51);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(274, 125);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(646, 26);
            this.txtDescripcion.TabIndex = 2;
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.AutoSize = true;
            this.LabelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodigo.Location = new System.Drawing.Point(69, 52);
            this.LabelCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(183, 25);
            this.LabelCodigo.TabIndex = 3;
            this.LabelCodigo.Text = "Codigo de Articulo :";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombre.Location = new System.Drawing.Point(566, 52);
            this.LabelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(92, 25);
            this.LabelNombre.TabIndex = 4;
            this.LabelNombre.Text = "Nombre :";
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescripcion.Location = new System.Drawing.Point(69, 126);
            this.LabelDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(125, 25);
            this.LabelDescripcion.TabIndex = 5;
            this.LabelDescripcion.Text = "Descripcion :";
            // 
            // LabelMarca
            // 
            this.LabelMarca.AutoSize = true;
            this.LabelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMarca.Location = new System.Drawing.Point(69, 197);
            this.LabelMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMarca.Name = "LabelMarca";
            this.LabelMarca.Size = new System.Drawing.Size(78, 25);
            this.LabelMarca.TabIndex = 6;
            this.LabelMarca.Text = "Marca :";
            // 
            // LabelCategoria
            // 
            this.LabelCategoria.AutoSize = true;
            this.LabelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCategoria.Location = new System.Drawing.Point(566, 197);
            this.LabelCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCategoria.Name = "LabelCategoria";
            this.LabelCategoria.Size = new System.Drawing.Size(108, 25);
            this.LabelCategoria.TabIndex = 7;
            this.LabelCategoria.Text = "Categoria :";
            // 
            // ComboMarca
            // 
            this.ComboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMarca.FormattingEnabled = true;
            this.ComboMarca.Location = new System.Drawing.Point(274, 195);
            this.ComboMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboMarca.Name = "ComboMarca";
            this.ComboMarca.Size = new System.Drawing.Size(234, 28);
            this.ComboMarca.TabIndex = 8;
            // 
            // ComboCategoria
            // 
            this.ComboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCategoria.FormattingEnabled = true;
            this.ComboCategoria.Location = new System.Drawing.Point(687, 195);
            this.ComboCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboCategoria.Name = "ComboCategoria";
            this.ComboCategoria.Size = new System.Drawing.Size(234, 28);
            this.ComboCategoria.TabIndex = 9;
            // 
            // LabelImagen
            // 
            this.LabelImagen.AutoSize = true;
            this.LabelImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelImagen.Location = new System.Drawing.Point(69, 275);
            this.LabelImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelImagen.Name = "LabelImagen";
            this.LabelImagen.Size = new System.Drawing.Size(88, 25);
            this.LabelImagen.TabIndex = 10;
            this.LabelImagen.Text = "Imagen :";
            // 
            // LabelPrecio
            // 
            this.LabelPrecio.AutoSize = true;
            this.LabelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrecio.Location = new System.Drawing.Point(566, 275);
            this.LabelPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPrecio.Name = "LabelPrecio";
            this.LabelPrecio.Size = new System.Drawing.Size(78, 25);
            this.LabelPrecio.TabIndex = 11;
            this.LabelPrecio.Text = "Precio :";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(687, 274);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(234, 26);
            this.txtPrecio.TabIndex = 12;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(42, 332);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(186, 49);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(570, 332);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(324, 49);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtImagen
            // 
            this.txtImagen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtImagen.Location = new System.Drawing.Point(274, 275);
            this.txtImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(234, 26);
            this.txtImagen.TabIndex = 15;
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 408);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.LabelPrecio);
            this.Controls.Add(this.LabelImagen);
            this.Controls.Add(this.ComboCategoria);
            this.Controls.Add(this.ComboMarca);
            this.Controls.Add(this.LabelCategoria);
            this.Controls.Add(this.LabelMarca);
            this.Controls.Add(this.LabelDescripcion);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.LabelCodigo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulos";
            this.Load += new System.EventHandler(this.AgregarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label LabelCodigo;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label LabelDescripcion;
        private System.Windows.Forms.Label LabelMarca;
        private System.Windows.Forms.Label LabelCategoria;
        private System.Windows.Forms.ComboBox ComboMarca;
        private System.Windows.Forms.ComboBox ComboCategoria;
        private System.Windows.Forms.Label LabelImagen;
        private System.Windows.Forms.Label LabelPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtImagen;
    }
}