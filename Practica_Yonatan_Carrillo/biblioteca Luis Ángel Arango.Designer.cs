namespace Practica_Yonatan_Carrillo
{
    partial class biblioteca_Luis_Ángel_Arango
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
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStripReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInformacion = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.comBGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombre_libro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.TxtIndentificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvDatos
            // 
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Location = new System.Drawing.Point(32, 232);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.Size = new System.Drawing.Size(633, 263);
            this.DgvDatos.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripReportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuStripReportes
            // 
            this.MenuStripReportes.Name = "MenuStripReportes";
            this.MenuStripReportes.Size = new System.Drawing.Size(65, 20);
            this.MenuStripReportes.Text = "Reportes";
            this.MenuStripReportes.Click += new System.EventHandler(this.MenuStripReportes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // groupBoxInformacion
            // 
            this.groupBoxInformacion.Controls.Add(this.radioButtonFemenino);
            this.groupBoxInformacion.Controls.Add(this.radioButtonMasculino);
            this.groupBoxInformacion.Controls.Add(this.BtnSalir);
            this.groupBoxInformacion.Controls.Add(this.BtnEliminar);
            this.groupBoxInformacion.Controls.Add(this.BtnRegistrar);
            this.groupBoxInformacion.Controls.Add(this.comBGenero);
            this.groupBoxInformacion.Controls.Add(this.label5);
            this.groupBoxInformacion.Controls.Add(this.TxtNombre_libro);
            this.groupBoxInformacion.Controls.Add(this.label4);
            this.groupBoxInformacion.Controls.Add(this.DateTime);
            this.groupBoxInformacion.Controls.Add(this.TxtIndentificacion);
            this.groupBoxInformacion.Controls.Add(this.label3);
            this.groupBoxInformacion.Controls.Add(this.label2);
            this.groupBoxInformacion.Controls.Add(this.TxtNombre);
            this.groupBoxInformacion.Controls.Add(this.label1);
            this.groupBoxInformacion.Location = new System.Drawing.Point(12, 36);
            this.groupBoxInformacion.Name = "groupBoxInformacion";
            this.groupBoxInformacion.Size = new System.Drawing.Size(709, 190);
            this.groupBoxInformacion.TabIndex = 3;
            this.groupBoxInformacion.TabStop = false;
            this.groupBoxInformacion.Text = "Datos biblioteca";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(343, 149);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 15;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(246, 149);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 14;
            this.BtnEliminar.Text = "&Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(150, 149);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 13;
            this.BtnRegistrar.Text = "&Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // comBGenero
            // 
            this.comBGenero.FormattingEnabled = true;
            this.comBGenero.Items.AddRange(new object[] {
            "Novela de terror",
            "Novela erótica",
            "Ciencia ficción",
            "Novela romántica",
            "Novela negra",
            "Novela histórica",
            "Biografías",
            "autoayuda",
            "poesía",
            "Literatura infantil",
            "Drama",
            "Ciencia Ficción",
            ""});
            this.comBGenero.Location = new System.Drawing.Point(55, 89);
            this.comBGenero.Name = "comBGenero";
            this.comBGenero.Size = new System.Drawing.Size(134, 21);
            this.comBGenero.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Genero";
            // 
            // TxtNombre_libro
            // 
            this.TxtNombre_libro.Location = new System.Drawing.Point(302, 89);
            this.TxtNombre_libro.Name = "TxtNombre_libro";
            this.TxtNombre_libro.Size = new System.Drawing.Size(134, 20);
            this.TxtNombre_libro.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre del Libro";
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(475, 31);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(221, 20);
            this.DateTime.TabIndex = 7;
            // 
            // TxtIndentificacion
            // 
            this.TxtIndentificacion.Location = new System.Drawing.Point(302, 32);
            this.TxtIndentificacion.Name = "TxtIndentificacion";
            this.TxtIndentificacion.Size = new System.Drawing.Size(134, 20);
            this.TxtIndentificacion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(55, 32);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(134, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(490, 102);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 16;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.Location = new System.Drawing.Point(582, 102);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(71, 17);
            this.radioButtonFemenino.TabIndex = 17;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = true;
            // 
            // biblioteca_Luis_Ángel_Arango
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 500);
            this.Controls.Add(this.groupBoxInformacion);
            this.Controls.Add(this.DgvDatos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "biblioteca_Luis_Ángel_Arango";
            this.Text = "biblioteca_Luis_Ángel_Arango";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxInformacion.ResumeLayout(false);
            this.groupBoxInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStripReportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxInformacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIndentificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombre_libro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.ComboBox comBGenero;
        private System.Windows.Forms.RadioButton radioButtonFemenino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
    }
}