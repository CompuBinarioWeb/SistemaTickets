namespace Tickets
{
    partial class Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigoCli = new System.Windows.Forms.Label();
            this.btnBuscarCS = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnNuevoS = new System.Windows.Forms.Button();
            this.btnGrabarS = new System.Windows.Forms.Button();
            this.dtFechaS = new System.Windows.Forms.DateTimePicker();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.txtCorreoS = new System.Windows.Forms.TextBox();
            this.txtNombresS = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgSoporte = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.txtBuscarC = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(439, 24);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(83, 56);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "S0";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(172, 33);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(125, 33);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Soporte";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.lblCodigoCli);
            this.groupBox1.Controls.Add(this.btnBuscarCS);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.btnNuevoS);
            this.groupBox1.Controls.Add(this.btnGrabarS);
            this.groupBox1.Controls.Add(this.dtFechaS);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.txtCorreoS);
            this.groupBox1.Controls.Add(this.txtNombresS);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 654);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crud Clientes";
            // 
            // lblCodigoCli
            // 
            this.lblCodigoCli.AutoSize = true;
            this.lblCodigoCli.ForeColor = System.Drawing.Color.Red;
            this.lblCodigoCli.Location = new System.Drawing.Point(109, 36);
            this.lblCodigoCli.Name = "lblCodigoCli";
            this.lblCodigoCli.Size = new System.Drawing.Size(24, 19);
            this.lblCodigoCli.TabIndex = 23;
            this.lblCodigoCli.Text = "...";
            // 
            // btnBuscarCS
            // 
            this.btnBuscarCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBuscarCS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCS.Image = global::Tickets.Properties.Resources.obrero;
            this.btnBuscarCS.Location = new System.Drawing.Point(22, 36);
            this.btnBuscarCS.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCS.Name = "btnBuscarCS";
            this.btnBuscarCS.Size = new System.Drawing.Size(80, 77);
            this.btnBuscarCS.TabIndex = 18;
            this.btnBuscarCS.UseVisualStyleBackColor = false;
            this.btnBuscarCS.Click += new System.EventHandler(this.btnBuscarCS_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(111, 206);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(292, 162);
            this.txtDescripcion.TabIndex = 17;
            this.txtDescripcion.Text = "";
            // 
            // btnNuevoS
            // 
            this.btnNuevoS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNuevoS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoS.Image = global::Tickets.Properties.Resources.nuevo;
            this.btnNuevoS.Location = new System.Drawing.Point(88, 556);
            this.btnNuevoS.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoS.Name = "btnNuevoS";
            this.btnNuevoS.Size = new System.Drawing.Size(233, 87);
            this.btnNuevoS.TabIndex = 16;
            this.btnNuevoS.UseVisualStyleBackColor = false;
            this.btnNuevoS.Click += new System.EventHandler(this.btnNuevoS_Click);
            // 
            // btnGrabarS
            // 
            this.btnGrabarS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGrabarS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabarS.Image = global::Tickets.Properties.Resources.guardar1;
            this.btnGrabarS.Location = new System.Drawing.Point(88, 461);
            this.btnGrabarS.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabarS.Name = "btnGrabarS";
            this.btnGrabarS.Size = new System.Drawing.Size(233, 87);
            this.btnGrabarS.TabIndex = 15;
            this.btnGrabarS.UseVisualStyleBackColor = false;
            this.btnGrabarS.Click += new System.EventHandler(this.btnGrabarS_Click);
            // 
            // dtFechaS
            // 
            this.dtFechaS.Enabled = false;
            this.dtFechaS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaS.Location = new System.Drawing.Point(111, 400);
            this.dtFechaS.Name = "dtFechaS";
            this.dtFechaS.Size = new System.Drawing.Size(292, 27);
            this.dtFechaS.TabIndex = 14;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Tickets.Properties.Resources.software;
            this.pictureBox6.Location = new System.Drawing.Point(22, 376);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(80, 77);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Tickets.Properties.Resources.bloc;
            this.pictureBox8.Location = new System.Drawing.Point(22, 206);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(80, 162);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Tickets.Properties.Resources.email;
            this.pictureBox9.Location = new System.Drawing.Point(22, 121);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(80, 77);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 6;
            this.pictureBox9.TabStop = false;
            // 
            // txtCorreoS
            // 
            this.txtCorreoS.Enabled = false;
            this.txtCorreoS.Location = new System.Drawing.Point(111, 145);
            this.txtCorreoS.Margin = new System.Windows.Forms.Padding(5);
            this.txtCorreoS.Name = "txtCorreoS";
            this.txtCorreoS.Size = new System.Drawing.Size(292, 27);
            this.txtCorreoS.TabIndex = 5;
            // 
            // txtNombresS
            // 
            this.txtNombresS.Enabled = false;
            this.txtNombresS.Location = new System.Drawing.Point(111, 60);
            this.txtNombresS.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombresS.Name = "txtNombresS";
            this.txtNombresS.Size = new System.Drawing.Size(292, 27);
            this.txtNombresS.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 33);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(160, 33);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Instalacion";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.lblCodigo);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(441, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 87);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.lblCantidad);
            this.groupBox3.Controls.Add(this.dgSoporte);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.txtBuscarC);
            this.groupBox3.Location = new System.Drawing.Point(441, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(822, 561);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Soporte Tecnico";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(461, 494);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 40);
            this.button2.TabIndex = 75;
            this.button2.Text = "Exportar a Excel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(778, 524);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(21, 24);
            this.lblCantidad.TabIndex = 73;
            this.lblCantidad.Text = "0";
            // 
            // dgSoporte
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSoporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSoporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgSoporte.EnableHeadersVisualStyles = false;
            this.dgSoporte.Location = new System.Drawing.Point(6, 25);
            this.dgSoporte.Name = "dgSoporte";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSoporte.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSoporte.RowTemplate.Height = 24;
            this.dgSoporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSoporte.Size = new System.Drawing.Size(812, 445);
            this.dgSoporte.TabIndex = 71;
            this.dgSoporte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSoporte_CellClick);
            this.dgSoporte.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgSoporte_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.ActiveLinkColor = System.Drawing.Color.DarkOliveGreen;
            this.Column1.HeaderText = "Realizado";
            this.Column1.LinkColor = System.Drawing.Color.Green;
            this.Column1.Name = "Column1";
            this.Column1.Text = "Realizado";
            this.Column1.ToolTipText = "Realizado";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.VisitedLinkColor = System.Drawing.Color.Green;
            this.Column1.Width = 75;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tickets.Properties.Resources.investigacion1;
            this.pictureBox1.Location = new System.Drawing.Point(8, 482);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 73);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(266, 494);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 23);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Correo";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(94, 494);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(101, 23);
            this.radioButton4.TabIndex = 21;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Nombres";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // txtBuscarC
            // 
            this.txtBuscarC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarC.Location = new System.Drawing.Point(96, 525);
            this.txtBuscarC.Margin = new System.Windows.Forms.Padding(5);
            this.txtBuscarC.Name = "txtBuscarC";
            this.txtBuscarC.Size = new System.Drawing.Size(255, 27);
            this.txtBuscarC.TabIndex = 23;
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.Image = global::Tickets.Properties.Resources.lapiz;
            this.btneditar.Location = new System.Drawing.Point(88, 461);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(233, 87);
            this.btneditar.TabIndex = 24;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1275, 674);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets de Atencion - CompuBinario Soporte";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGrabarS;
        private System.Windows.Forms.DateTimePicker dtFechaS;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox txtCorreoS;
        private System.Windows.Forms.TextBox txtNombresS;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Button btnBuscarCS;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCodigoCli;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox txtBuscarC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNuevoS;
        private System.Windows.Forms.DataGridView dgSoporte;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.Button btneditar;
    }
}