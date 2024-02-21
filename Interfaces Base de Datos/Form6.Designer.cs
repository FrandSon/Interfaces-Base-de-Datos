namespace Interfaces_Base_de_Datos
{
    partial class frmConsultarConParámetro
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtParámetroParaConsultar = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxNumeros = new System.Windows.Forms.ComboBox();
            this.txtParametroNumero = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label2.Location = new System.Drawing.Point(36, 84);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(156, 17);
            label2.TabIndex = 46;
            label2.Text = "Ingrese lo que contiene";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(36, 186);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(212, 17);
            label1.TabIndex = 52;
            label1.Text = "Ingrese el número y la condición";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label4.Location = new System.Drawing.Point(21, 60);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 16);
            label4.TabIndex = 57;
            label4.Text = "Texto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label5.Location = new System.Drawing.Point(21, 160);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(69, 16);
            label5.TabIndex = 58;
            label5.Text = "Números";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegresar.Location = new System.Drawing.Point(256, 197);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(74, 34);
            this.btnRegresar.TabIndex = 49;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtParámetroParaConsultar
            // 
            this.txtParámetroParaConsultar.Enabled = false;
            this.txtParámetroParaConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParámetroParaConsultar.Location = new System.Drawing.Point(39, 113);
            this.txtParámetroParaConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.txtParámetroParaConsultar.Name = "txtParámetroParaConsultar";
            this.txtParámetroParaConsultar.Size = new System.Drawing.Size(169, 24);
            this.txtParámetroParaConsultar.TabIndex = 48;
            this.txtParámetroParaConsultar.TextChanged += new System.EventHandler(this.txtParámetroParaConsultar_TextChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultar.Location = new System.Drawing.Point(256, 124);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(74, 34);
            this.btnConsultar.TabIndex = 47;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(83, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Consultar Producto";
            //this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxNumeros
            // 
            this.comboBoxNumeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.comboBoxNumeros.Enabled = false;
            this.comboBoxNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNumeros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBoxNumeros.FormattingEnabled = true;
            this.comboBoxNumeros.Items.AddRange(new object[] {
            "igual",
            "mayor que",
            "menor que",
            "mayor o igual que",
            "menor o igual que"});
            this.comboBoxNumeros.Location = new System.Drawing.Point(66, 254);
            this.comboBoxNumeros.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNumeros.Name = "comboBoxNumeros";
            this.comboBoxNumeros.Size = new System.Drawing.Size(124, 21);
            this.comboBoxNumeros.TabIndex = 51;
            this.comboBoxNumeros.Text = "Condición";
            // 
            // txtParametroNumero
            // 
            this.txtParametroNumero.Enabled = false;
            this.txtParametroNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametroNumero.Location = new System.Drawing.Point(39, 217);
            this.txtParametroNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtParametroNumero.Name = "txtParametroNumero";
            this.txtParametroNumero.Size = new System.Drawing.Size(169, 24);
            this.txtParametroNumero.TabIndex = 53;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(256, 160);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 34);
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmConsultarConParámetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(355, 334);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtParametroNumero);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBoxNumeros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtParámetroParaConsultar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsultarConParámetro";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.frmConsultarConParámetro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtParámetroParaConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxNumeros;
        private System.Windows.Forms.TextBox txtParametroNumero;
        private System.Windows.Forms.Button btnCancelar;
    }
}