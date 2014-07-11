namespace PruebasPuertoSerie {
    partial class FormularioPrincipal {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.comboPuertosSerieDisponibles = new System.Windows.Forms.ComboBox();
            this.etiquetaPuertosSerieDisponibles = new System.Windows.Forms.Label();
            this.PuertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.etiquetaEstadoPuerto = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.marcoControles = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBitsPorSegundo = new System.Windows.Forms.ComboBox();
            this.cboBitsDeDatos = new System.Windows.Forms.ComboBox();
            this.cboParidad = new System.Windows.Forms.ComboBox();
            this.cboBitsParada = new System.Windows.Forms.ComboBox();
            this.cboControlFlujo = new System.Windows.Forms.ComboBox();
            this.marcoEstadoPines = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnConfigurarTeclasAceleradoras = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.chkMantenerRTS = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.chkMantenerDTR = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.estadoRTS = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.estadoDTR = new System.Windows.Forms.Label();
            this.estadoRING = new System.Windows.Forms.Label();
            this.estadoDCD = new System.Windows.Forms.Label();
            this.estadoDSR = new System.Windows.Forms.Label();
            this.estadoCTS = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.marcoConexion = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.marcoControles.SuspendLayout();
            this.marcoEstadoPines.SuspendLayout();
            this.marcoConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboPuertosSerieDisponibles
            // 
            this.comboPuertosSerieDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPuertosSerieDisponibles.FormattingEnabled = true;
            this.comboPuertosSerieDisponibles.Location = new System.Drawing.Point(194, 20);
            this.comboPuertosSerieDisponibles.Name = "comboPuertosSerieDisponibles";
            this.comboPuertosSerieDisponibles.Size = new System.Drawing.Size(89, 21);
            this.comboPuertosSerieDisponibles.Sorted = true;
            this.comboPuertosSerieDisponibles.TabIndex = 1;
            // 
            // etiquetaPuertosSerieDisponibles
            // 
            this.etiquetaPuertosSerieDisponibles.AutoSize = true;
            this.etiquetaPuertosSerieDisponibles.Location = new System.Drawing.Point(62, 23);
            this.etiquetaPuertosSerieDisponibles.Name = "etiquetaPuertosSerieDisponibles";
            this.etiquetaPuertosSerieDisponibles.Size = new System.Drawing.Size(126, 13);
            this.etiquetaPuertosSerieDisponibles.TabIndex = 0;
            this.etiquetaPuertosSerieDisponibles.Text = "Puertos serie disponibles:";
            // 
            // PuertoSerie
            // 
            this.PuertoSerie.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerie_DataReceived);
            this.PuertoSerie.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.PuertoSerie_PinChanged);
            // 
            // etiquetaEstadoPuerto
            // 
            this.etiquetaEstadoPuerto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.etiquetaEstadoPuerto.AutoSize = true;
            this.etiquetaEstadoPuerto.Location = new System.Drawing.Point(0, 608);
            this.etiquetaEstadoPuerto.Name = "etiquetaEstadoPuerto";
            this.etiquetaEstadoPuerto.Size = new System.Drawing.Size(0, 13);
            this.etiquetaEstadoPuerto.TabIndex = 4;
            this.etiquetaEstadoPuerto.MouseHover += new System.EventHandler(this.etiquetaEstadoPuerto_MouseHover);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(116, 19);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(131, 25);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "&Conectar";
            this.toolTip1.SetToolTip(this.btnConectar, "Conectarse al puerto serie seleccionado");
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboPuertosSerieDisponibles);
            this.groupBox1.Controls.Add(this.etiquetaPuertosSerieDisponibles);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puerto";
            // 
            // marcoControles
            // 
            this.marcoControles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.marcoControles.Controls.Add(this.label5);
            this.marcoControles.Controls.Add(this.label4);
            this.marcoControles.Controls.Add(this.label3);
            this.marcoControles.Controls.Add(this.label2);
            this.marcoControles.Controls.Add(this.label1);
            this.marcoControles.Controls.Add(this.cboBitsPorSegundo);
            this.marcoControles.Controls.Add(this.cboBitsDeDatos);
            this.marcoControles.Controls.Add(this.cboParidad);
            this.marcoControles.Controls.Add(this.cboBitsParada);
            this.marcoControles.Controls.Add(this.cboControlFlujo);
            this.marcoControles.Location = new System.Drawing.Point(7, 65);
            this.marcoControles.Margin = new System.Windows.Forms.Padding(5);
            this.marcoControles.Name = "marcoControles";
            this.marcoControles.Size = new System.Drawing.Size(362, 165);
            this.marcoControles.TabIndex = 1;
            this.marcoControles.TabStop = false;
            this.marcoControles.Text = "Configuración del puerto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Control de flujo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bits de parada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Paridad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bits de datos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bits por segundo:";
            // 
            // cboBitsPorSegundo
            // 
            this.cboBitsPorSegundo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBitsPorSegundo.FormattingEnabled = true;
            this.cboBitsPorSegundo.Items.AddRange(new object[] {
            "75",
            "110",
            "134",
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.cboBitsPorSegundo.Location = new System.Drawing.Point(118, 20);
            this.cboBitsPorSegundo.MaxDropDownItems = 18;
            this.cboBitsPorSegundo.Name = "cboBitsPorSegundo";
            this.cboBitsPorSegundo.Size = new System.Drawing.Size(158, 21);
            this.cboBitsPorSegundo.TabIndex = 1;
            // 
            // cboBitsDeDatos
            // 
            this.cboBitsDeDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBitsDeDatos.FormattingEnabled = true;
            this.cboBitsDeDatos.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cboBitsDeDatos.Location = new System.Drawing.Point(118, 47);
            this.cboBitsDeDatos.Name = "cboBitsDeDatos";
            this.cboBitsDeDatos.Size = new System.Drawing.Size(158, 21);
            this.cboBitsDeDatos.Sorted = true;
            this.cboBitsDeDatos.TabIndex = 3;
            // 
            // cboParidad
            // 
            this.cboParidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParidad.FormattingEnabled = true;
            this.cboParidad.Items.AddRange(new object[] {
            "Par",
            "Impar",
            "Ninguno",
            "Marca",
            "Espacio"});
            this.cboParidad.Location = new System.Drawing.Point(118, 74);
            this.cboParidad.Name = "cboParidad";
            this.cboParidad.Size = new System.Drawing.Size(158, 21);
            this.cboParidad.TabIndex = 5;
            // 
            // cboBitsParada
            // 
            this.cboBitsParada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBitsParada.FormattingEnabled = true;
            this.cboBitsParada.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cboBitsParada.Location = new System.Drawing.Point(118, 101);
            this.cboBitsParada.Name = "cboBitsParada";
            this.cboBitsParada.Size = new System.Drawing.Size(158, 21);
            this.cboBitsParada.Sorted = true;
            this.cboBitsParada.TabIndex = 7;
            // 
            // cboControlFlujo
            // 
            this.cboControlFlujo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboControlFlujo.FormattingEnabled = true;
            this.cboControlFlujo.Items.AddRange(new object[] {
            "Ninguno",
            "Xon / Xoff",
            "Hardware",
            "Xon / Xoff + Hardware"});
            this.cboControlFlujo.Location = new System.Drawing.Point(118, 128);
            this.cboControlFlujo.Name = "cboControlFlujo";
            this.cboControlFlujo.Size = new System.Drawing.Size(158, 21);
            this.cboControlFlujo.TabIndex = 9;
            // 
            // marcoEstadoPines
            // 
            this.marcoEstadoPines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.marcoEstadoPines.Controls.Add(this.label25);
            this.marcoEstadoPines.Controls.Add(this.label26);
            this.marcoEstadoPines.Controls.Add(this.btnConfigurarTeclasAceleradoras);
            this.marcoEstadoPines.Controls.Add(this.label21);
            this.marcoEstadoPines.Controls.Add(this.chkMantenerRTS);
            this.marcoEstadoPines.Controls.Add(this.label22);
            this.marcoEstadoPines.Controls.Add(this.chkMantenerDTR);
            this.marcoEstadoPines.Controls.Add(this.label24);
            this.marcoEstadoPines.Controls.Add(this.estadoRTS);
            this.marcoEstadoPines.Controls.Add(this.label23);
            this.marcoEstadoPines.Controls.Add(this.estadoDTR);
            this.marcoEstadoPines.Controls.Add(this.estadoRING);
            this.marcoEstadoPines.Controls.Add(this.estadoDCD);
            this.marcoEstadoPines.Controls.Add(this.estadoDSR);
            this.marcoEstadoPines.Controls.Add(this.estadoCTS);
            this.marcoEstadoPines.Controls.Add(this.label20);
            this.marcoEstadoPines.Controls.Add(this.label19);
            this.marcoEstadoPines.Controls.Add(this.label18);
            this.marcoEstadoPines.Controls.Add(this.label17);
            this.marcoEstadoPines.Controls.Add(this.label16);
            this.marcoEstadoPines.Controls.Add(this.label15);
            this.marcoEstadoPines.Controls.Add(this.label14);
            this.marcoEstadoPines.Controls.Add(this.label13);
            this.marcoEstadoPines.Controls.Add(this.label12);
            this.marcoEstadoPines.Controls.Add(this.label11);
            this.marcoEstadoPines.Controls.Add(this.label10);
            this.marcoEstadoPines.Controls.Add(this.label9);
            this.marcoEstadoPines.Controls.Add(this.label8);
            this.marcoEstadoPines.Controls.Add(this.label7);
            this.marcoEstadoPines.Controls.Add(this.label6);
            this.marcoEstadoPines.Location = new System.Drawing.Point(7, 300);
            this.marcoEstadoPines.Margin = new System.Windows.Forms.Padding(5);
            this.marcoEstadoPines.Name = "marcoEstadoPines";
            this.marcoEstadoPines.Size = new System.Drawing.Size(362, 298);
            this.marcoEstadoPines.TabIndex = 3;
            this.marcoEstadoPines.TabStop = false;
            this.marcoEstadoPines.Text = "Estado de pines";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(52, 258);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(111, 12);
            this.label25.TabIndex = 28;
            this.label25.Text = "Estado de señal: activada";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(52, 275);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(126, 12);
            this.label26.TabIndex = 29;
            this.label26.Text = "Estado de señal: desactivada";
            // 
            // btnConfigurarTeclasAceleradoras
            // 
            this.btnConfigurarTeclasAceleradoras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigurarTeclasAceleradoras.Image = ((System.Drawing.Image)(resources.GetObject("btnConfigurarTeclasAceleradoras.Image")));
            this.btnConfigurarTeclasAceleradoras.Location = new System.Drawing.Point(323, 173);
            this.btnConfigurarTeclasAceleradoras.Name = "btnConfigurarTeclasAceleradoras";
            this.btnConfigurarTeclasAceleradoras.Size = new System.Drawing.Size(29, 49);
            this.btnConfigurarTeclasAceleradoras.TabIndex = 22;
            this.btnConfigurarTeclasAceleradoras.TabStop = false;
            this.toolTip1.SetToolTip(this.btnConfigurarTeclasAceleradoras, "Configurar teclas aceleradoras");
            this.btnConfigurarTeclasAceleradoras.UseVisualStyleBackColor = true;
            this.btnConfigurarTeclasAceleradoras.Click += new System.EventHandler(this.btnConfigurarTeclaDTR_Click);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Location = new System.Drawing.Point(21, 243);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 10);
            this.label21.TabIndex = 24;
            // 
            // chkMantenerRTS
            // 
            this.chkMantenerRTS.AutoSize = true;
            this.chkMantenerRTS.Location = new System.Drawing.Point(291, 208);
            this.chkMantenerRTS.Name = "chkMantenerRTS";
            this.chkMantenerRTS.Size = new System.Drawing.Size(15, 14);
            this.chkMantenerRTS.TabIndex = 23;
            this.toolTip1.SetToolTip(this.chkMantenerRTS, "Mantener activada la señal RTS");
            this.chkMantenerRTS.UseVisualStyleBackColor = true;
            this.chkMantenerRTS.CheckedChanged += new System.EventHandler(this.chkMantenerRTS_CheckedChanged);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Red;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Location = new System.Drawing.Point(22, 277);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 10);
            this.label22.TabIndex = 25;
            // 
            // chkMantenerDTR
            // 
            this.chkMantenerDTR.AutoSize = true;
            this.chkMantenerDTR.Location = new System.Drawing.Point(291, 177);
            this.chkMantenerDTR.Name = "chkMantenerDTR";
            this.chkMantenerDTR.Size = new System.Drawing.Size(15, 14);
            this.chkMantenerDTR.TabIndex = 21;
            this.toolTip1.SetToolTip(this.chkMantenerDTR, "Mantener activada la señal DTR");
            this.chkMantenerDTR.UseVisualStyleBackColor = true;
            this.chkMantenerDTR.CheckedChanged += new System.EventHandler(this.chkMantenerDTR_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(52, 241);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(124, 12);
            this.label24.TabIndex = 27;
            this.label24.Text = "Estado de señal desconocido";
            // 
            // estadoRTS
            // 
            this.estadoRTS.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.estadoRTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estadoRTS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estadoRTS.Location = new System.Drawing.Point(191, 209);
            this.estadoRTS.Name = "estadoRTS";
            this.estadoRTS.Size = new System.Drawing.Size(85, 13);
            this.estadoRTS.TabIndex = 20;
            this.estadoRTS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.estadoRTS_MouseDown);
            this.estadoRTS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.estadoRTS_MouseUp);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.GreenYellow;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Location = new System.Drawing.Point(22, 260);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 10);
            this.label23.TabIndex = 26;
            // 
            // estadoDTR
            // 
            this.estadoDTR.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.estadoDTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estadoDTR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estadoDTR.Location = new System.Drawing.Point(191, 177);
            this.estadoDTR.Name = "estadoDTR";
            this.estadoDTR.Size = new System.Drawing.Size(85, 13);
            this.estadoDTR.TabIndex = 17;
            this.estadoDTR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.estadoDTR_MouseDown);
            this.estadoDTR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.estadoDTR_MouseUp);
            // 
            // estadoRING
            // 
            this.estadoRING.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.estadoRING.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estadoRING.Location = new System.Drawing.Point(191, 145);
            this.estadoRING.Name = "estadoRING";
            this.estadoRING.Size = new System.Drawing.Size(85, 13);
            this.estadoRING.TabIndex = 14;
            // 
            // estadoDCD
            // 
            this.estadoDCD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.estadoDCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estadoDCD.Location = new System.Drawing.Point(191, 113);
            this.estadoDCD.Name = "estadoDCD";
            this.estadoDCD.Size = new System.Drawing.Size(85, 13);
            this.estadoDCD.TabIndex = 11;
            // 
            // estadoDSR
            // 
            this.estadoDSR.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.estadoDSR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estadoDSR.Location = new System.Drawing.Point(191, 81);
            this.estadoDSR.Name = "estadoDSR";
            this.estadoDSR.Size = new System.Drawing.Size(85, 13);
            this.estadoDSR.TabIndex = 8;
            // 
            // estadoCTS
            // 
            this.estadoCTS.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.estadoCTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estadoCTS.Location = new System.Drawing.Point(191, 49);
            this.estadoCTS.Name = "estadoCTS";
            this.estadoCTS.Size = new System.Drawing.Size(85, 13);
            this.estadoCTS.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(102, 209);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Salida";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(102, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Salida";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(101, 145);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Entrada";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(101, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Entrada";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(101, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Entrada";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(101, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Entrada";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(206, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 14);
            this.label14.TabIndex = 2;
            this.label14.Text = "Estado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(109, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 14);
            this.label13.TabIndex = 1;
            this.label13.Text = "E/S";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 14);
            this.label12.TabIndex = 0;
            this.label12.Text = "Señal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "RTS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "DTR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "RING";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "DCD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "DSR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "CTS";
            // 
            // marcoConexion
            // 
            this.marcoConexion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.marcoConexion.Controls.Add(this.btnConectar);
            this.marcoConexion.Location = new System.Drawing.Point(7, 238);
            this.marcoConexion.Margin = new System.Windows.Forms.Padding(5);
            this.marcoConexion.Name = "marcoConexion";
            this.marcoConexion.Size = new System.Drawing.Size(362, 53);
            this.marcoConexion.TabIndex = 2;
            this.marcoConexion.TabStop = false;
            this.marcoConexion.Text = "Control de conexión";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 621);
            this.Controls.Add(this.marcoControles);
            this.Controls.Add(this.marcoConexion);
            this.Controls.Add(this.marcoEstadoPines);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.etiquetaEstadoPuerto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pruebas Puerto Serie";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormularioPrincipal_KeyUp);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioPrincipal_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormularioPrincipal_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.marcoControles.ResumeLayout(false);
            this.marcoControles.PerformLayout();
            this.marcoEstadoPines.ResumeLayout(false);
            this.marcoEstadoPines.PerformLayout();
            this.marcoConexion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPuertosSerieDisponibles;
        private System.Windows.Forms.Label etiquetaPuertosSerieDisponibles;
        private System.IO.Ports.SerialPort PuertoSerie;
        private System.Windows.Forms.Label etiquetaEstadoPuerto;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox marcoControles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboControlFlujo;
        private System.Windows.Forms.ComboBox cboBitsParada;
        private System.Windows.Forms.ComboBox cboParidad;
        private System.Windows.Forms.ComboBox cboBitsDeDatos;
        private System.Windows.Forms.ComboBox cboBitsPorSegundo;
        private System.Windows.Forms.GroupBox marcoEstadoPines;
        private System.Windows.Forms.GroupBox marcoConexion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label estadoRTS;
        private System.Windows.Forms.Label estadoDTR;
        private System.Windows.Forms.Label estadoRING;
        private System.Windows.Forms.Label estadoDCD;
        private System.Windows.Forms.Label estadoDSR;
        private System.Windows.Forms.Label estadoCTS;
        private System.Windows.Forms.CheckBox chkMantenerRTS;
        private System.Windows.Forms.CheckBox chkMantenerDTR;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnConfigurarTeclasAceleradoras;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
    }
}

