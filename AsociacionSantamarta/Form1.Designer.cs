namespace AsociacionSantamarta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnbuscar;
            this.txtidpersona = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.dgvpersonas = new System.Windows.Forms.DataGridView();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnCompDni = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonas)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtidpersona
            // 
            this.txtidpersona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidpersona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtidpersona.Location = new System.Drawing.Point(73, 151);
            this.txtidpersona.Margin = new System.Windows.Forms.Padding(4);
            this.txtidpersona.Name = "txtidpersona";
            this.txtidpersona.Size = new System.Drawing.Size(132, 26);
            this.txtidpersona.TabIndex = 0;
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Location = new System.Drawing.Point(73, 234);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(217, 26);
            this.txtnombre.TabIndex = 1;
            // 
            // txtapellido
            // 
            this.txtapellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtapellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapellido.Location = new System.Drawing.Point(73, 312);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(217, 26);
            this.txtapellido.TabIndex = 2;
            // 
            // txtdni
            // 
            this.txtdni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdni.Location = new System.Drawing.Point(73, 381);
            this.txtdni.Margin = new System.Windows.Forms.Padding(4);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(217, 26);
            this.txtdni.TabIndex = 3;
            // 
            // dgvpersonas
            // 
            this.dgvpersonas.AllowUserToAddRows = false;
            this.dgvpersonas.AllowUserToDeleteRows = false;
            this.dgvpersonas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvpersonas.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvpersonas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvpersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpersonas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvpersonas.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvpersonas.Location = new System.Drawing.Point(298, 83);
            this.dgvpersonas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvpersonas.Name = "dgvpersonas";
            this.dgvpersonas.ReadOnly = true;
            this.dgvpersonas.Size = new System.Drawing.Size(588, 463);
            this.dgvpersonas.TabIndex = 4;
            this.dgvpersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpersonas_CellClick);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Location = new System.Drawing.Point(56, 426);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(100, 88);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "Guardar Nuevo";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.Location = new System.Drawing.Point(190, 426);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(100, 88);
            this.btneditar.TabIndex = 6;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Location = new System.Drawing.Point(123, 522);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(100, 88);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Identificación Fester";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre Fester";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "D.N.I";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 45);
            this.label5.TabIndex = 12;
            this.label5.Text = "Artillería Cristiana";
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Location = new System.Drawing.Point(728, 579);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(111, 99);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "Salir de la aplicación";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 764);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 24);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(164, 19);
            this.toolStripStatusLabel1.Text = "Componentes creados:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(914, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(114, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // btnCompDni
            // 
            this.btnCompDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompDni.Location = new System.Drawing.Point(611, 579);
            this.btnCompDni.Name = "btnCompDni";
            this.btnCompDni.Size = new System.Drawing.Size(111, 99);
            this.btnCompDni.TabIndex = 17;
            this.btnCompDni.Text = "Comprobar DNI";
            this.btnCompDni.UseVisualStyleBackColor = true;
            this.btnCompDni.Click += new System.EventHandler(this.btnCompDni_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 22);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "IDENTI_FESTER";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(162, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 22);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.Text = "Nombre";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.Turquoise;
            this.txtbuscar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbuscar.Location = new System.Drawing.Point(5, 61);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(234, 26);
            this.txtbuscar.TabIndex = 20;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = System.Drawing.Color.SeaGreen;
            btnbuscar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnbuscar.ForeColor = System.Drawing.Color.DarkBlue;
            btnbuscar.Location = new System.Drawing.Point(24, 93);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new System.Drawing.Size(206, 68);
            btnbuscar.TabIndex = 21;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtbuscar);
            this.groupBox1.Controls.Add(btnbuscar);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(353, 562);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 173);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupo de Búsqueda";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fecha y hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 788);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCompDni);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgvpersonas);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtidpersona);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociación Santa Marta. Base de datos Artillería Cristiana";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonas)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidpersona;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.DataGridView dgvpersonas;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btnCompDni;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}

