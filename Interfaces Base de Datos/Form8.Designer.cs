namespace Interfaces_Base_de_Datos
{
    partial class frmActualizar
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
            System.Windows.Forms.Label label3;
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCódigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.checkBoxNombre = new System.Windows.Forms.CheckBox();
            this.checkBoxPrecio = new System.Windows.Forms.CheckBox();
            this.checkBoxUnidad = new System.Windows.Forms.CheckBox();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(444, 343);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(121, 52);
            this.btnRegresar.TabIndex = 40;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(444, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 52);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(444, 199);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(121, 52);
            this.btnIngresar.TabIndex = 38;
            this.btnIngresar.Text = "Actualizar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtUnidad
            // 
            this.txtUnidad.Enabled = false;
            this.txtUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidad.Location = new System.Drawing.Point(235, 274);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(170, 28);
            this.txtUnidad.TabIndex = 35;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(235, 226);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(170, 28);
            this.txtPrecio.TabIndex = 34;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(235, 178);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 28);
            this.txtNombre.TabIndex = 33;
            // 
            // txtCódigo
            // 
            this.txtCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCódigo.Location = new System.Drawing.Point(235, 130);
            this.txtCódigo.Name = "txtCódigo";
            this.txtCódigo.Size = new System.Drawing.Size(170, 28);
            this.txtCódigo.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Actualizar Producto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(444, 115);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 52);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // checkBoxNombre
            // 
            this.checkBoxNombre.AutoSize = true;
            this.checkBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNombre.Location = new System.Drawing.Point(51, 176);
            this.checkBoxNombre.Name = "checkBoxNombre";
            this.checkBoxNombre.Size = new System.Drawing.Size(101, 28);
            this.checkBoxNombre.TabIndex = 42;
            this.checkBoxNombre.Text = "Nombre";
            this.checkBoxNombre.UseVisualStyleBackColor = true;
            this.checkBoxNombre.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxPrecio
            // 
            this.checkBoxPrecio.AutoSize = true;
            this.checkBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPrecio.Location = new System.Drawing.Point(51, 226);
            this.checkBoxPrecio.Name = "checkBoxPrecio";
            this.checkBoxPrecio.Size = new System.Drawing.Size(86, 28);
            this.checkBoxPrecio.TabIndex = 43;
            this.checkBoxPrecio.Text = "Precio";
            this.checkBoxPrecio.UseVisualStyleBackColor = true;
            this.checkBoxPrecio.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxUnidad
            // 
            this.checkBoxUnidad.AutoSize = true;
            this.checkBoxUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUnidad.Location = new System.Drawing.Point(51, 276);
            this.checkBoxUnidad.Name = "checkBoxUnidad";
            this.checkBoxUnidad.Size = new System.Drawing.Size(92, 28);
            this.checkBoxUnidad.TabIndex = 44;
            this.checkBoxUnidad.Text = "Unidad";
            this.checkBoxUnidad.UseVisualStyleBackColor = true;
            this.checkBoxUnidad.CheckedChanged += new System.EventHandler(this.checkBoxUnidad_CheckedChanged);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(32, 73);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(533, 20);
            label3.TabIndex = 47;
            label3.Text = "Ingrese lo el código del productos para buscar y actualizar el producto";
            // 
            // frmActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 413);
            this.Controls.Add(label3);
            this.Controls.Add(this.checkBoxUnidad);
            this.Controls.Add(this.checkBoxPrecio);
            this.Controls.Add(this.checkBoxNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCódigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmActualizar";
            this.Text = "Actualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCódigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox checkBoxNombre;
        private System.Windows.Forms.CheckBox checkBoxPrecio;
        private System.Windows.Forms.CheckBox checkBoxUnidad;
    }
}