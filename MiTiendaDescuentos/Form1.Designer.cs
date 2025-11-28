namespace MiTiendaDescuentos
{
    partial class Form1
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
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtPrecioFinal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblprecioFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(12, 67);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(102, 13);
            this.lblCosto.TabIndex = 0;
            this.lblCosto.Text = "Precio del producto:";
            this.lblCosto.Click += new System.EventHandler(this.lblCosto_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(109, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del producto:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 116);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(88, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo de producto";
            this.lblTipo.Click += new System.EventHandler(this.lblTipo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(164, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(164, 60);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 5;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(164, 109);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 6;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.Location = new System.Drawing.Point(164, 210);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioFinal.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 159);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblprecioFinal
            // 
            this.lblprecioFinal.AutoSize = true;
            this.lblprecioFinal.Location = new System.Drawing.Point(38, 217);
            this.lblprecioFinal.Name = "lblprecioFinal";
            this.lblprecioFinal.Size = new System.Drawing.Size(62, 13);
            this.lblprecioFinal.TabIndex = 9;
            this.lblprecioFinal.Text = "Precio final:";
            this.lblprecioFinal.Click += new System.EventHandler(this.lblprecioFinal_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtPrecioFinal);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblprecioFinal);
            this.Controls.Add(this.lblTipo);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblprecioFinal;
    }
}

