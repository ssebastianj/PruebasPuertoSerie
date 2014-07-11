namespace PruebasPuertoSerie {
    partial class SeleccionTeclaAceleradora {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null))
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
        private void InitializeComponent() {
            this.comboTeclasDTR = new System.Windows.Forms.ComboBox();
            this.etiquetaInformacionUso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsignarTecla = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAltDTR = new System.Windows.Forms.CheckBox();
            this.chkControlDTR = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAltRTS = new System.Windows.Forms.CheckBox();
            this.chkControlRTS = new System.Windows.Forms.CheckBox();
            this.comboTeclasRTS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboTeclasDTR
            // 
            this.comboTeclasDTR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTeclasDTR.FormattingEnabled = true;
            this.comboTeclasDTR.Items.AddRange(new object[] {
            "None",
            "LButton",
            "RButton",
            "Cancel",
            "MButton",
            "XButton1",
            "XButton2",
            "Back",
            "LineFeed",
            "Clear",
            "Return",
            "ShiftKey",
            "Menu",
            "Pause",
            "Capital",
            "CapsLock",
            "Space",
            "Prior",
            "PageUp",
            "Next",
            "PageDown",
            "End",
            "Home",
            "Left",
            "Up",
            "Right",
            "Down",
            "Select",
            "Print",
            "Execute",
            "Snapshot",
            "PrintScreen",
            "Insert",
            "Delete",
            "Help",
            "D0",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5",
            "D6",
            "D7",
            "D8",
            "D9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "LWin",
            "RWin",
            "NumPad0",
            "NumPad1",
            "NumPad2",
            "NumPad3",
            "NumPad4",
            "NumPad5",
            "NumPad6",
            "NumPad7",
            "NumPad8",
            "NumPad9",
            "Multiply",
            "Add",
            "Separator",
            "Subtract",
            "Decimal",
            "Divide",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "F13",
            "F14",
            "F15",
            "F16",
            "F17",
            "F18",
            "F19",
            "F20",
            "F21",
            "F22",
            "F23",
            "F24",
            "NumLock",
            "Scroll",
            "LShiftKey",
            "RShiftKey",
            "LControlKey",
            "RControlKey",
            "LMenu",
            "RMenu",
            "BrowserBack",
            "BrowserForward",
            "BrowserRefresh",
            "BrowserStop",
            "BrowserSearch",
            "BrowserFavorites",
            "BrowserHome",
            "VolumeMute",
            "VolumeDown",
            "VolumeUp",
            "MediaNextTrack",
            "MediaPreviousTrack",
            "MediaStop",
            "MediaPlayPause",
            "LaunchMail",
            "SelectMedia",
            "ProcessKey",
            "Attn",
            "Crsel",
            "Exsel",
            "EraseEof",
            "Play",
            "Zoom",
            "OemClear",
            "Shift",
            "Control"});
            this.comboTeclasDTR.Location = new System.Drawing.Point(58, 24);
            this.comboTeclasDTR.Name = "comboTeclasDTR";
            this.comboTeclasDTR.Size = new System.Drawing.Size(174, 21);
            this.comboTeclasDTR.TabIndex = 1;
            // 
            // etiquetaInformacionUso
            // 
            this.etiquetaInformacionUso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.etiquetaInformacionUso.AutoSize = true;
            this.etiquetaInformacionUso.Location = new System.Drawing.Point(12, 9);
            this.etiquetaInformacionUso.Name = "etiquetaInformacionUso";
            this.etiquetaInformacionUso.Size = new System.Drawing.Size(211, 13);
            this.etiquetaInformacionUso.TabIndex = 0;
            this.etiquetaInformacionUso.Text = "Seleccione la tecla que activar cada señal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tecla:";
            // 
            // btnAsignarTecla
            // 
            this.btnAsignarTecla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignarTecla.Location = new System.Drawing.Point(95, 222);
            this.btnAsignarTecla.Name = "btnAsignarTecla";
            this.btnAsignarTecla.Size = new System.Drawing.Size(85, 23);
            this.btnAsignarTecla.TabIndex = 3;
            this.btnAsignarTecla.Text = "&Aceptar";
            this.btnAsignarTecla.UseVisualStyleBackColor = true;
            this.btnAsignarTecla.Click += new System.EventHandler(this.btnAsignarTecla_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(182, 222);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Ca&ncelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkAltDTR);
            this.groupBox1.Controls.Add(this.chkControlDTR);
            this.groupBox1.Controls.Add(this.comboTeclasDTR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Señal DTR";
            // 
            // chkAltDTR
            // 
            this.chkAltDTR.AutoSize = true;
            this.chkAltDTR.Location = new System.Drawing.Point(123, 60);
            this.chkAltDTR.Name = "chkAltDTR";
            this.chkAltDTR.Size = new System.Drawing.Size(38, 17);
            this.chkAltDTR.TabIndex = 3;
            this.chkAltDTR.Text = "Alt";
            this.chkAltDTR.UseVisualStyleBackColor = true;
            // 
            // chkControlDTR
            // 
            this.chkControlDTR.AutoSize = true;
            this.chkControlDTR.Location = new System.Drawing.Point(58, 60);
            this.chkControlDTR.Name = "chkControlDTR";
            this.chkControlDTR.Size = new System.Drawing.Size(59, 17);
            this.chkControlDTR.TabIndex = 2;
            this.chkControlDTR.Text = "Control";
            this.chkControlDTR.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkAltRTS);
            this.groupBox2.Controls.Add(this.chkControlRTS);
            this.groupBox2.Controls.Add(this.comboTeclasRTS);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 88);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Señal RTS";
            // 
            // chkAltRTS
            // 
            this.chkAltRTS.AutoSize = true;
            this.chkAltRTS.Location = new System.Drawing.Point(121, 59);
            this.chkAltRTS.Name = "chkAltRTS";
            this.chkAltRTS.Size = new System.Drawing.Size(38, 17);
            this.chkAltRTS.TabIndex = 6;
            this.chkAltRTS.Text = "Alt";
            this.chkAltRTS.UseVisualStyleBackColor = true;
            // 
            // chkControlRTS
            // 
            this.chkControlRTS.AutoSize = true;
            this.chkControlRTS.Location = new System.Drawing.Point(56, 59);
            this.chkControlRTS.Name = "chkControlRTS";
            this.chkControlRTS.Size = new System.Drawing.Size(59, 17);
            this.chkControlRTS.TabIndex = 5;
            this.chkControlRTS.Text = "Control";
            this.chkControlRTS.UseVisualStyleBackColor = true;
            // 
            // comboTeclasRTS
            // 
            this.comboTeclasRTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTeclasRTS.FormattingEnabled = true;
            this.comboTeclasRTS.Items.AddRange(new object[] {
            "None",
            "LButton",
            "RButton",
            "Cancel",
            "MButton",
            "XButton1",
            "XButton2",
            "Back",
            "LineFeed",
            "Clear",
            "Return",
            "ShiftKey",
            "Menu",
            "Pause",
            "Capital",
            "CapsLock",
            "Space",
            "Prior",
            "PageUp",
            "Next",
            "PageDown",
            "End",
            "Home",
            "Left",
            "Up",
            "Right",
            "Down",
            "Select",
            "Print",
            "Execute",
            "Snapshot",
            "PrintScreen",
            "Insert",
            "Delete",
            "Help",
            "D0",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5",
            "D6",
            "D7",
            "D8",
            "D9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "LWin",
            "RWin",
            "NumPad0",
            "NumPad1",
            "NumPad2",
            "NumPad3",
            "NumPad4",
            "NumPad5",
            "NumPad6",
            "NumPad7",
            "NumPad8",
            "NumPad9",
            "Multiply",
            "Add",
            "Separator",
            "Subtract",
            "Decimal",
            "Divide",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "F13",
            "F14",
            "F15",
            "F16",
            "F17",
            "F18",
            "F19",
            "F20",
            "F21",
            "F22",
            "F23",
            "F24",
            "NumLock",
            "Scroll",
            "LShiftKey",
            "RShiftKey",
            "LControlKey",
            "RControlKey",
            "LMenu",
            "RMenu",
            "BrowserBack",
            "BrowserForward",
            "BrowserRefresh",
            "BrowserStop",
            "BrowserSearch",
            "BrowserFavorites",
            "BrowserHome",
            "VolumeMute",
            "VolumeDown",
            "VolumeUp",
            "MediaNextTrack",
            "MediaPreviousTrack",
            "MediaStop",
            "MediaPlayPause",
            "LaunchMail",
            "SelectMedia",
            "ProcessKey",
            "Attn",
            "Crsel",
            "Exsel",
            "EraseEof",
            "Play",
            "Zoom",
            "OemClear",
            "Shift",
            "Control"});
            this.comboTeclasRTS.Location = new System.Drawing.Point(58, 21);
            this.comboTeclasRTS.Name = "comboTeclasRTS";
            this.comboTeclasRTS.Size = new System.Drawing.Size(174, 21);
            this.comboTeclasRTS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tecla:";
            // 
            // SeleccionTeclaAceleradora
            // 
            this.AcceptButton = this.btnAsignarTecla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(266, 245);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAsignarTecla);
            this.Controls.Add(this.etiquetaInformacionUso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeleccionTeclaAceleradora";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar tecla aceleradora";
            this.Load += new System.EventHandler(this.SeleccionTeclaAceleradora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTeclasDTR;
        private System.Windows.Forms.Label etiquetaInformacionUso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsignarTecla;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboTeclasRTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAltDTR;
        private System.Windows.Forms.CheckBox chkControlDTR;
        private System.Windows.Forms.CheckBox chkAltRTS;
        private System.Windows.Forms.CheckBox chkControlRTS;
    }
}