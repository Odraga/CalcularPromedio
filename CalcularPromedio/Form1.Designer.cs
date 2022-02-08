
namespace CalcularPromedio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCDerecho = new System.Windows.Forms.Button();
            this.btnCIzquierda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalculoPromedios = new System.Windows.Forms.TextBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.lbPromedios = new System.Windows.Forms.ListBox();
            this.lblDerechosAutor = new System.Windows.Forms.Label();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.lblPromedioTotal = new System.Windows.Forms.Label();
            this.txtPromedioTotal = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.lbCalificaciones = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.btnCDerecho);
            this.panel1.Controls.Add(this.btnCIzquierda);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCalculoPromedios);
            this.panel1.Controls.Add(this.btnTransferir);
            this.panel1.Controls.Add(this.lbPromedios);
            this.panel1.Controls.Add(this.lblDerechosAutor);
            this.panel1.Controls.Add(this.lblCalificacion);
            this.panel1.Controls.Add(this.lblCredito);
            this.panel1.Controls.Add(this.lblPromedioTotal);
            this.panel1.Controls.Add(this.txtPromedioTotal);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtNota);
            this.panel1.Controls.Add(this.txtCredito);
            this.panel1.Controls.Add(this.lbCalificaciones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 318);
            this.panel1.TabIndex = 0;
            // 
            // btnCDerecho
            // 
            this.btnCDerecho.Location = new System.Drawing.Point(122, 107);
            this.btnCDerecho.Name = "btnCDerecho";
            this.btnCDerecho.Size = new System.Drawing.Size(40, 23);
            this.btnCDerecho.TabIndex = 15;
            this.btnCDerecho.Text = "C";
            this.btnCDerecho.UseVisualStyleBackColor = true;
            this.btnCDerecho.Click += new System.EventHandler(this.btnCDerecho_Click);
            // 
            // btnCIzquierda
            // 
            this.btnCIzquierda.Location = new System.Drawing.Point(12, 107);
            this.btnCIzquierda.Name = "btnCIzquierda";
            this.btnCIzquierda.Size = new System.Drawing.Size(40, 23);
            this.btnCIzquierda.TabIndex = 14;
            this.btnCIzquierda.Text = "C";
            this.btnCIzquierda.UseVisualStyleBackColor = true;
            this.btnCIzquierda.Click += new System.EventHandler(this.btnCIzquierda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Promedio";
            // 
            // txtCalculoPromedios
            // 
            this.txtCalculoPromedios.Location = new System.Drawing.Point(122, 263);
            this.txtCalculoPromedios.Name = "txtCalculoPromedios";
            this.txtCalculoPromedios.ReadOnly = true;
            this.txtCalculoPromedios.Size = new System.Drawing.Size(40, 20);
            this.txtCalculoPromedios.TabIndex = 12;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(58, 166);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(58, 23);
            this.btnTransferir.TabIndex = 11;
            this.btnTransferir.Text = "->";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // lbPromedios
            // 
            this.lbPromedios.FormattingEnabled = true;
            this.lbPromedios.Location = new System.Drawing.Point(122, 136);
            this.lbPromedios.Name = "lbPromedios";
            this.lbPromedios.Size = new System.Drawing.Size(40, 108);
            this.lbPromedios.TabIndex = 10;
            // 
            // lblDerechosAutor
            // 
            this.lblDerechosAutor.AutoSize = true;
            this.lblDerechosAutor.Location = new System.Drawing.Point(42, 296);
            this.lblDerechosAutor.Name = "lblDerechosAutor";
            this.lblDerechosAutor.Size = new System.Drawing.Size(86, 13);
            this.lblDerechosAutor.TabIndex = 9;
            this.lblDerechosAutor.Text = "® 2020 - Odraga";
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(25, 26);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(125, 13);
            this.lblCalificacion.TabIndex = 8;
            this.lblCalificacion.Text = "Calificacion de la Materia";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(35, 65);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(104, 13);
            this.lblCredito.TabIndex = 7;
            this.lblCredito.Text = "Credito de la Materia";
            // 
            // lblPromedioTotal
            // 
            this.lblPromedioTotal.AutoSize = true;
            this.lblPromedioTotal.Location = new System.Drawing.Point(9, 247);
            this.lblPromedioTotal.Name = "lblPromedioTotal";
            this.lblPromedioTotal.Size = new System.Drawing.Size(51, 13);
            this.lblPromedioTotal.TabIndex = 6;
            this.lblPromedioTotal.Text = "Promedio";
            // 
            // txtPromedioTotal
            // 
            this.txtPromedioTotal.Location = new System.Drawing.Point(12, 263);
            this.txtPromedioTotal.Name = "txtPromedioTotal";
            this.txtPromedioTotal.ReadOnly = true;
            this.txtPromedioTotal.Size = new System.Drawing.Size(40, 20);
            this.txtPromedioTotal.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(58, 195);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(58, 20);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "CE";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(58, 107);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(58, 20);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(38, 42);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 2;
            this.txtNota.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(38, 81);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(100, 20);
            this.txtCredito.TabIndex = 1;
            // 
            // lbCalificaciones
            // 
            this.lbCalificaciones.FormattingEnabled = true;
            this.lbCalificaciones.Location = new System.Drawing.Point(12, 136);
            this.lbCalificaciones.Name = "lbCalificaciones";
            this.lbCalificaciones.Size = new System.Drawing.Size(40, 108);
            this.lbCalificaciones.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(174, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "tsBtnAyuda";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 318);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Promedio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label lblPromedioTotal;
        private System.Windows.Forms.TextBox txtPromedioTotal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblDerechosAutor;
        private System.Windows.Forms.ListBox lbCalificaciones;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.ListBox lbPromedios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalculoPromedios;
        private System.Windows.Forms.Button btnCDerecho;
        private System.Windows.Forms.Button btnCIzquierda;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

