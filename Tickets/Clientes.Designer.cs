namespace Tickets
{
    partial class Clientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtFechaC = new System.Windows.Forms.DateTimePicker();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cboSistema = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarC = new System.Windows.Forms.TextBox();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Location = new System.Drawing.Point(111, 60);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(297, 27);
            this.txtNombres.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNombres, "Nombres");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblcodigo);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btnuevo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dtFechaC);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.cboSistema);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.cboPais);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 658);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crud Clientes";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.ForeColor = System.Drawing.Color.Red;
            this.lblcodigo.Location = new System.Drawing.Point(109, 23);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(24, 19);
            this.lblcodigo.TabIndex = 22;
            this.lblcodigo.Text = "...";
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
            this.btneditar.TabIndex = 8;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnuevo
            // 
            this.btnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnuevo.Image = global::Tickets.Properties.Resources.nuevo;
            this.btnuevo.Location = new System.Drawing.Point(88, 556);
            this.btnuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(233, 87);
            this.btnuevo.TabIndex = 7;
            this.btnuevo.UseVisualStyleBackColor = false;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::Tickets.Properties.Resources.guardar1;
            this.button1.Location = new System.Drawing.Point(88, 461);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 87);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtFechaC
            // 
            this.dtFechaC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaC.Location = new System.Drawing.Point(111, 400);
            this.dtFechaC.Name = "dtFechaC";
            this.dtFechaC.Size = new System.Drawing.Size(297, 27);
            this.dtFechaC.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Tickets.Properties.Resources.calendario1;
            this.pictureBox5.Location = new System.Drawing.Point(22, 376);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(80, 77);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Fecha");
            // 
            // cboSistema
            // 
            this.cboSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSistema.FormattingEnabled = true;
            this.cboSistema.Items.AddRange(new object[] {
            "EL PRESTAMISTA",
            "COMPUPRES",
            "CARRITO DE COMPRAS",
            "EXAMENES EN LINEA",
            "BIBLIOTECAS",
            "PARKING",
            "GESTIÓN DE VENTAS Y FACTURACIÓN",
            "CONTROL DE INVENTARIO Y VENTAS",
            "SISTEMA DE VOTACION",
            "UNIVERSIDAD",
            "ASISTENCIAS",
            "SISTEMA EXPERTO",
            "SISTEMA OPERATIVO"});
            this.cboSistema.Location = new System.Drawing.Point(111, 315);
            this.cboSistema.Name = "cboSistema";
            this.cboSistema.Size = new System.Drawing.Size(297, 27);
            this.cboSistema.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cboSistema, "Sistema");
            this.cboSistema.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSistema_KeyPress);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Tickets.Properties.Resources.software;
            this.pictureBox4.Location = new System.Drawing.Point(22, 291);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Sistema");
            // 
            // cboPais
            // 
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Items.AddRange(new object[] {
            "AFGANISTAN",
            "ALBANIA",
            "ALEMANIA",
            "ANDORRA",
            "ANGOLA",
            "ANGUILLA",
            "ANTIGUA Y BARBUDA",
            "ANTILLAS HOLANDESAS",
            "ARABIA SAUDI",
            "ARGELIA",
            "ARGENTINA",
            "ARMENIA",
            "ARUBA",
            "AUSTRALIA",
            "AUSTRIA",
            "AZERBAIYAN",
            "BAHAMAS",
            "BAHREIN",
            "BANGLADESH",
            "BARBADOS",
            "BELARUS",
            "BELGICA",
            "BELICE",
            "BENIN",
            "BERMUDAS",
            "BHUTÁN",
            "BOLIVIA",
            "BOSNIA Y HERZEGOVINA",
            "BOTSWANA",
            "BRASIL",
            "BRUNEI",
            "BULGARIA",
            "BURKINA FASO",
            "BURUNDI",
            "CABO VERDE",
            "CAMBOYA",
            "CAMERUN",
            "CANADA",
            "CHAD",
            "CHILE",
            "CHINA",
            "CHIPRE",
            "COLOMBIA",
            "COMORES",
            "CONGO",
            "COREA",
            "COREA DEL NORTE ",
            "COSTA DE MARFIL",
            "COSTA RICA",
            "CROACIA",
            "CUBA",
            "DINAMARCA",
            "DJIBOUTI",
            "DOMINICA",
            "ECUADOR",
            "EGIPTO",
            "EL SALVADOR",
            "EMIRATOS ARABES UNIDOS",
            "ERITREA",
            "ESLOVENIA",
            "ESPAÑA",
            "ESTADOS UNIDOS DE AMERICA",
            "ESTONIA",
            "ETIOPIA",
            "FIJI",
            "FILIPINAS",
            "FINLANDIA",
            "FRANCIA",
            "GABON",
            "GAMBIA",
            "GEORGIA",
            "GHANA",
            "GIBRALTAR",
            "GRANADA",
            "GRECIA",
            "GROENLANDIA",
            "GUADALUPE",
            "GUAM",
            "GUATEMALA",
            "GUAYANA FRANCESA",
            "GUERNESEY",
            "GUINEA",
            "GUINEA ECUATORIAL",
            "GUINEA-BISSAU",
            "GUYANA",
            "HAITI",
            "HONDURAS",
            "HONG KONG",
            "HUNGRIA",
            "INDIA",
            "INDONESIA",
            "IRAN",
            "IRAQ",
            "IRLANDA",
            "ISLA DE MAN",
            "ISLA NORFOLK",
            "ISLANDIA",
            "ISLAS ALAND",
            "ISLAS CAIMÁN",
            "ISLAS COOK",
            "ISLAS DEL CANAL",
            "ISLAS FEROE",
            "ISLAS MALVINAS",
            "ISLAS MARIANAS DEL NORTE",
            "ISLAS MARSHALL",
            "ISLAS PITCAIRN",
            "ISLAS SALOMON",
            "ISLAS TURCAS Y CAICOS",
            "ISLAS VIRGENES BRITANICAS",
            "ISLAS VÍRGENES DE LOS ESTADOS UNIDOS",
            "ISRAEL",
            "ITALIA",
            "JAMAICA",
            "JAPON",
            "JERSEY",
            "JORDANIA",
            "KAZAJSTAN",
            "KENIA",
            "KIRGUISTAN",
            "KIRIBATI",
            "KUWAIT",
            "LAOS",
            "LESOTHO",
            "LETONIA",
            "LIBANO",
            "LIBERIA",
            "LIBIA",
            "LIECHTENSTEIN",
            "LITUANIA",
            "LUXEMBURGO",
            "MACAO",
            "MACEDONIA ",
            "MADAGASCAR",
            "MALASIA",
            "MALAWI",
            "MALDIVAS",
            "MALI",
            "MALTA",
            "MARRUECOS",
            "MARTINICA",
            "MAURICIO",
            "MAURITANIA",
            "MAYOTTE",
            "MEXICO",
            "MICRONESIA",
            "MOLDAVIA",
            "MONACO",
            "MONGOLIA",
            "MONTENEGRO",
            "MONTSERRAT",
            "MOZAMBIQUE",
            "MYANMAR",
            "NAMIBIA",
            "NAURU",
            "NEPAL",
            "NICARAGUA",
            "NIGER",
            "NIGERIA",
            "NIUE",
            "NORUEGA",
            "NUEVA CALEDONIA",
            "NUEVA ZELANDA",
            "OMAN",
            "PAISES BAJOS",
            "PAKISTAN",
            "PALAOS",
            "PALESTINA",
            "PANAMA",
            "PAPUA NUEVA GUINEA",
            "PARAGUAY",
            "PERU",
            "POLINESIA FRANCESA",
            "POLONIA",
            "PORTUGAL",
            "PUERTO RICO",
            "QATAR",
            "REINO UNIDO",
            "REP.DEMOCRATICA DEL CONGO",
            "REPUBLICA CENTROAFRICANA",
            "REPUBLICA CHECA",
            "REPUBLICA DOMINICANA",
            "REPUBLICA ESLOVACA",
            "REUNION",
            "RUANDA",
            "RUMANIA",
            "RUSIA",
            "SAHARA OCCIDENTAL",
            "SAMOA",
            "SAMOA AMERICANA",
            "SAN BARTOLOME",
            "SAN CRISTOBAL Y NIEVES",
            "SAN MARINO",
            "SAN MARTIN (PARTE FRANCESA)",
            "SAN PEDRO Y MIQUELON ",
            "SAN VICENTE Y LAS GRANADINAS",
            "SANTA HELENA",
            "SANTA LUCIA",
            "SANTA SEDE",
            "SANTO TOME Y PRINCIPE",
            "SENEGAL",
            "SERBIA",
            "SEYCHELLES",
            "SIERRA LEONA",
            "SINGAPUR",
            "SIRIA",
            "SOMALIA",
            "SRI LANKA",
            "SUDAFRICA",
            "SUDAN",
            "SUECIA",
            "SUIZA",
            "SURINAM",
            "SVALBARD Y JAN MAYEN",
            "SWAZILANDIA",
            "TADYIKISTAN",
            "TAILANDIA",
            "TANZANIA",
            "TIMOR ORIENTAL",
            "TOGO",
            "TOKELAU",
            "TONGA",
            "TRINIDAD Y TOBAGO",
            "TUNEZ",
            "TURKMENISTAN",
            "TURQUIA",
            "TUVALU",
            "UCRANIA",
            "UGANDA",
            "URUGUAY",
            "UZBEKISTAN",
            "VANUATU",
            "VENEZUELA",
            "VIETNAM",
            "WALLIS Y FORTUNA",
            "YEMEN",
            "ZAMBIA",
            "ZIMBABWE"});
            this.cboPais.Location = new System.Drawing.Point(111, 230);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(297, 27);
            this.cboPais.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cboPais, "Pais");
            this.cboPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboPais_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Tickets.Properties.Resources.mapas_y_banderas;
            this.pictureBox3.Location = new System.Drawing.Point(22, 206);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Pais");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tickets.Properties.Resources.email;
            this.pictureBox2.Location = new System.Drawing.Point(22, 121);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Correo Electronico");
            // 
            // txtCorreo
            // 
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorreo.Location = new System.Drawing.Point(111, 145);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(297, 27);
            this.txtCorreo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtCorreo, "Correo Electronico");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tickets.Properties.Resources.usuario1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Nombres");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.lblCantidad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBuscarC);
            this.groupBox2.Controls.Add(this.dgClientes);
            this.groupBox2.Location = new System.Drawing.Point(441, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 654);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Clientes";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(427, 614);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(233, 40);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar Registro";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(266, 581);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 23);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Correo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(94, 581);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 23);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nombres";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(427, 566);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Exportar a Excel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(779, 627);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(21, 24);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(667, 627);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cantidad";
            // 
            // txtBuscarC
            // 
            this.txtBuscarC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarC.Location = new System.Drawing.Point(96, 612);
            this.txtBuscarC.Margin = new System.Windows.Forms.Padding(5);
            this.txtBuscarC.Name = "txtBuscarC";
            this.txtBuscarC.Size = new System.Drawing.Size(255, 27);
            this.txtBuscarC.TabIndex = 13;
            this.txtBuscarC.TextChanged += new System.EventHandler(this.txtBuscarC_TextChanged);
            // 
            // dgClientes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.EnableHeadersVisualStyles = false;
            this.dgClientes.Location = new System.Drawing.Point(6, 22);
            this.dgClientes.Name = "dgClientes";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgClientes.RowTemplate.Height = 24;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(810, 537);
            this.dgClientes.TabIndex = 70;
            this.dgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellClick);
            this.dgClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgClientes_CellFormatting);
            this.dgClientes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgClientes_DataBindingComplete);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Tickets.Properties.Resources.investigacion1;
            this.pictureBox6.Location = new System.Drawing.Point(8, 575);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(80, 73);
            this.pictureBox6.TabIndex = 71;
            this.pictureBox6.TabStop = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1275, 674);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes - CompuBinario Soporte";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cboSistema;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DateTimePicker dtFechaC;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.TextBox txtBuscarC;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}