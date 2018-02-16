namespace Practico_4
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
            this.btAgregarTarea = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btTareasPorFecha = new System.Windows.Forms.Button();
            this.btTodasLasTareas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btEditarTarea = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // btAgregarTarea
            // 
            this.btAgregarTarea.Location = new System.Drawing.Point(307, 24);
            this.btAgregarTarea.Name = "btAgregarTarea";
            this.btAgregarTarea.Size = new System.Drawing.Size(112, 34);
            this.btAgregarTarea.TabIndex = 0;
            this.btAgregarTarea.Text = "Agregar nueva tarea";
            this.btAgregarTarea.UseVisualStyleBackColor = true;
            this.btAgregarTarea.Click += new System.EventHandler(this.btAgregarTarea_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 89);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Hora,
            this.Actividad,
            this.Estado});
            this.dgvTareas.Location = new System.Drawing.Point(307, 89);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.Size = new System.Drawing.Size(445, 162);
            this.dgvTareas.TabIndex = 2;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            this.Actividad.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btTareasPorFecha
            // 
            this.btTareasPorFecha.Location = new System.Drawing.Point(41, 263);
            this.btTareasPorFecha.Name = "btTareasPorFecha";
            this.btTareasPorFecha.Size = new System.Drawing.Size(211, 23);
            this.btTareasPorFecha.TabIndex = 3;
            this.btTareasPorFecha.Text = "Mostrar tareas del dia seleccionado";
            this.btTareasPorFecha.UseVisualStyleBackColor = true;
            this.btTareasPorFecha.Click += new System.EventHandler(this.btTareasPorFecha_Click);
            // 
            // btTodasLasTareas
            // 
            this.btTodasLasTareas.Location = new System.Drawing.Point(449, 263);
            this.btTodasLasTareas.Name = "btTodasLasTareas";
            this.btTodasLasTareas.Size = new System.Drawing.Size(139, 23);
            this.btTodasLasTareas.TabIndex = 4;
            this.btTodasLasTareas.Text = "Mostrar todas las tareas";
            this.btTodasLasTareas.UseVisualStyleBackColor = true;
            this.btTodasLasTareas.Click += new System.EventHandler(this.btTodasLasTareas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tareas de la agenda";
            // 
            // btEditarTarea
            // 
            this.btEditarTarea.Location = new System.Drawing.Point(464, 24);
            this.btEditarTarea.Name = "btEditarTarea";
            this.btEditarTarea.Size = new System.Drawing.Size(124, 34);
            this.btEditarTarea.TabIndex = 6;
            this.btEditarTarea.Text = "Editar tarea";
            this.btEditarTarea.UseVisualStyleBackColor = true;
            this.btEditarTarea.Click += new System.EventHandler(this.btEditarTarea_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(619, 24);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(119, 34);
            this.btEliminar.TabIndex = 7;
            this.btEliminar.Text = "Eliminar tarea";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bienvenido a tu Agenda Personal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditarTarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTodasLasTareas);
            this.Controls.Add(this.btTareasPorFecha);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btAgregarTarea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregarTarea;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Button btTareasPorFecha;
        private System.Windows.Forms.Button btTodasLasTareas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEditarTarea;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label2;
    }
}

