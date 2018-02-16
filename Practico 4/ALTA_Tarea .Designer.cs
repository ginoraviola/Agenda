namespace Practico_4
{
    partial class ALTA_Tarea
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaTarea = new System.Windows.Forms.DateTimePicker();
            this.tbHora = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbActividad = new System.Windows.Forms.TextBox();
            this.btAgregarTarea = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora:";
            // 
            // dtpFechaTarea
            // 
            this.dtpFechaTarea.Location = new System.Drawing.Point(74, 41);
            this.dtpFechaTarea.Name = "dtpFechaTarea";
            this.dtpFechaTarea.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaTarea.TabIndex = 2;
            // 
            // tbHora
            // 
            this.tbHora.Location = new System.Drawing.Point(74, 74);
            this.tbHora.Mask = "00:00";
            this.tbHora.Name = "tbHora";
            this.tbHora.PromptChar = ' ';
            this.tbHora.Size = new System.Drawing.Size(55, 20);
            this.tbHora.TabIndex = 3;
            this.tbHora.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Actividad:";
            // 
            // tbActividad
            // 
            this.tbActividad.AcceptsReturn = true;
            this.tbActividad.AcceptsTab = true;
            this.tbActividad.Location = new System.Drawing.Point(88, 118);
            this.tbActividad.Multiline = true;
            this.tbActividad.Name = "tbActividad";
            this.tbActividad.Size = new System.Drawing.Size(347, 104);
            this.tbActividad.TabIndex = 5;
            // 
            // btAgregarTarea
            // 
            this.btAgregarTarea.Location = new System.Drawing.Point(360, 260);
            this.btAgregarTarea.Name = "btAgregarTarea";
            this.btAgregarTarea.Size = new System.Drawing.Size(75, 23);
            this.btAgregarTarea.TabIndex = 6;
            this.btAgregarTarea.Text = "Agregar";
            this.btAgregarTarea.UseVisualStyleBackColor = true;
            this.btAgregarTarea.Click += new System.EventHandler(this.btAgregarTarea_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(21, 260);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // ALTA_Tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 306);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAgregarTarea);
            this.Controls.Add(this.tbActividad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHora);
            this.Controls.Add(this.dtpFechaTarea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ALTA_Tarea";
            this.Text = "Nueva Tarea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaTarea;
        private System.Windows.Forms.MaskedTextBox tbHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbActividad;
        private System.Windows.Forms.Button btAgregarTarea;
        private System.Windows.Forms.Button btCancelar;
    }
}