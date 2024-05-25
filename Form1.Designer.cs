namespace Clase___Laboratorio___25_05_2024
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
            this.labelEdgar = new System.Windows.Forms.Label();
            this.dataGridView_Mostrar_datos = new System.Windows.Forms.DataGridView();
            this.button_cargar_datos = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_nombre_consola = new System.Windows.Forms.Label();
            this.label_compania = new System.Windows.Forms.Label();
            this.label_anio_lanzamiento = new System.Windows.Forms.Label();
            this.label_generacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Mostrar_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEdgar
            // 
            this.labelEdgar.AutoSize = true;
            this.labelEdgar.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdgar.Location = new System.Drawing.Point(13, 13);
            this.labelEdgar.Name = "labelEdgar";
            this.labelEdgar.Size = new System.Drawing.Size(826, 47);
            this.labelEdgar.TabIndex = 0;
            this.labelEdgar.Text = "Edgar Guillermo Chinchilla Chinchilla - 0905-23-13243";
            // 
            // dataGridView_Mostrar_datos
            // 
            this.dataGridView_Mostrar_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Mostrar_datos.Location = new System.Drawing.Point(21, 231);
            this.dataGridView_Mostrar_datos.Name = "dataGridView_Mostrar_datos";
            this.dataGridView_Mostrar_datos.Size = new System.Drawing.Size(566, 90);
            this.dataGridView_Mostrar_datos.TabIndex = 1;
            this.dataGridView_Mostrar_datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_cargar_datos
            // 
            this.button_cargar_datos.Location = new System.Drawing.Point(624, 231);
            this.button_cargar_datos.Name = "button_cargar_datos";
            this.button_cargar_datos.Size = new System.Drawing.Size(154, 90);
            this.button_cargar_datos.TabIndex = 2;
            this.button_cargar_datos.Text = "Cargar";
            this.button_cargar_datos.UseVisualStyleBackColor = true;
            this.button_cargar_datos.Click += new System.EventHandler(this.button_cargar_datos_Click);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(21, 64);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(18, 13);
            this.label_ID.TabIndex = 3;
            this.label_ID.Text = "ID";
            // 
            // label_nombre_consola
            // 
            this.label_nombre_consola.AutoSize = true;
            this.label_nombre_consola.Location = new System.Drawing.Point(21, 87);
            this.label_nombre_consola.Name = "label_nombre_consola";
            this.label_nombre_consola.Size = new System.Drawing.Size(113, 13);
            this.label_nombre_consola.TabIndex = 4;
            this.label_nombre_consola.Text = "Nombre de la consola:";
            // 
            // label_compania
            // 
            this.label_compania.AutoSize = true;
            this.label_compania.Location = new System.Drawing.Point(21, 110);
            this.label_compania.Name = "label_compania";
            this.label_compania.Size = new System.Drawing.Size(57, 13);
            this.label_compania.TabIndex = 5;
            this.label_compania.Text = "Compañia:";
            this.label_compania.Click += new System.EventHandler(this.label_compania_Click);
            // 
            // label_anio_lanzamiento
            // 
            this.label_anio_lanzamiento.AutoSize = true;
            this.label_anio_lanzamiento.Location = new System.Drawing.Point(21, 133);
            this.label_anio_lanzamiento.Name = "label_anio_lanzamiento";
            this.label_anio_lanzamiento.Size = new System.Drawing.Size(103, 13);
            this.label_anio_lanzamiento.TabIndex = 6;
            this.label_anio_lanzamiento.Text = "Año de lanzamiento:";
            // 
            // label_generacion
            // 
            this.label_generacion.AutoSize = true;
            this.label_generacion.Location = new System.Drawing.Point(21, 156);
            this.label_generacion.Name = "label_generacion";
            this.label_generacion.Size = new System.Drawing.Size(65, 13);
            this.label_generacion.TabIndex = 7;
            this.label_generacion.Text = "Generación:";
            this.label_generacion.Click += new System.EventHandler(this.label_generacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_generacion);
            this.Controls.Add(this.label_anio_lanzamiento);
            this.Controls.Add(this.label_compania);
            this.Controls.Add(this.label_nombre_consola);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.button_cargar_datos);
            this.Controls.Add(this.dataGridView_Mostrar_datos);
            this.Controls.Add(this.labelEdgar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Mostrar_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEdgar;
        private System.Windows.Forms.DataGridView dataGridView_Mostrar_datos;
        private System.Windows.Forms.Button button_cargar_datos;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_nombre_consola;
        private System.Windows.Forms.Label label_compania;
        private System.Windows.Forms.Label label_anio_lanzamiento;
        private System.Windows.Forms.Label label_generacion;
    }
}

