
namespace Actividad2Alum
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
            this.grpInicial = new System.Windows.Forms.GroupBox();
            this.txtCantidadAlum = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.LVInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpInicial.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInicial
            // 
            this.grpInicial.Controls.Add(this.txtCantidadAlum);
            this.grpInicial.Controls.Add(this.btnCrear);
            this.grpInicial.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInicial.Location = new System.Drawing.Point(12, 12);
            this.grpInicial.Name = "grpInicial";
            this.grpInicial.Size = new System.Drawing.Size(422, 82);
            this.grpInicial.TabIndex = 0;
            this.grpInicial.TabStop = false;
            this.grpInicial.Text = "¿Cuantos alumnos hay?";
            // 
            // txtCantidadAlum
            // 
            this.txtCantidadAlum.Location = new System.Drawing.Point(17, 28);
            this.txtCantidadAlum.Name = "txtCantidadAlum";
            this.txtCantidadAlum.Size = new System.Drawing.Size(133, 25);
            this.txtCantidadAlum.TabIndex = 1;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(164, 30);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(97, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.LVInfo);
            this.grpInfo.Controls.Add(this.txtEdad);
            this.grpInfo.Controls.Add(this.txtApellidoM);
            this.grpInfo.Controls.Add(this.txtApellidoP);
            this.grpInfo.Controls.Add(this.txtNombre);
            this.grpInfo.Controls.Add(this.txtId);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.btnAgregar);
            this.grpInfo.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(12, 112);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(575, 328);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informacion del Alumno";
            this.grpInfo.Visible = false;
            // 
            // LVInfo
            // 
            this.LVInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LVInfo.HideSelection = false;
            this.LVInfo.Location = new System.Drawing.Point(17, 188);
            this.LVInfo.Name = "LVInfo";
            this.LVInfo.Size = new System.Drawing.Size(552, 134);
            this.LVInfo.TabIndex = 1;
            this.LVInfo.UseCompatibleStateImageBehavior = false;
            this.LVInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 38;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellido Paterno";
            this.columnHeader3.Width = 161;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Apellido Materno";
            this.columnHeader4.Width = 183;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(63, 157);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 25);
            this.txtEdad.TabIndex = 11;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(171, 129);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(150, 25);
            this.txtApellidoM.TabIndex = 10;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(171, 98);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(150, 25);
            this.txtApellidoP.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 25);
            this.txtNombre.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(45, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(158, 25);
            this.txtId.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido Paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(359, 121);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 33);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 466);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpInicial);
            this.Name = "Form1";
            this.Text = "Alumnos";
            this.grpInicial.ResumeLayout(false);
            this.grpInicial.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInicial;
        private System.Windows.Forms.TextBox txtCantidadAlum;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView LVInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

