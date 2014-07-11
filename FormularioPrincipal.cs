#region Definiciones de namespaces
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
#endregion

namespace PruebasPuertoSerie
{

    public partial class FormularioPrincipal : Form {

        //Teclas aceleradoras
        #region Teclas aceleradoras
        private static KeyEventArgs codigoTeclaActivarDTR;
        private static KeyEventArgs codigoTeclaActivarRTS;
        private static bool controlDTR;
        private static bool altDTR;
        private static bool controlRTS;
        private static bool altRTS;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="FormularioPrincipal"/> class.
        /// </summary>
        public FormularioPrincipal() {
            InitializeComponent();

            PuertoSerie.PinChanged += new SerialPinChangedEventHandler(PuertoSerie_PinChanged);
            PuertoSerie.DataReceived += new SerialDataReceivedEventHandler(PuertoSerie_DataReceived);
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e) {
            #region Inicializacion GUI
            String[] Ports = System.IO.Ports.SerialPort.GetPortNames();

            this.comboPuertosSerieDisponibles.Items.AddRange(Ports);
            
            if(this.comboPuertosSerieDisponibles.Items.Count > 0)                
                this.comboPuertosSerieDisponibles.SelectedIndex = 0;
            else{
                MessageBox.Show(this, "No se han encontrado puertos serie COM instalados en el sistema.\nPor favor, instale un puerto COM y reinicie esta aplicación.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                actualizarEstadoControles();
                this.etiquetaEstadoPuerto.Text = "ATENCIÓN: No hay puertos COM instalados en el sistema.";
                }
            
            this.cboBitsPorSegundo.SelectedIndex = 11;
            this.cboBitsDeDatos.SelectedIndex = 3;
            this.cboParidad.SelectedIndex = 2;
            this.cboBitsParada.SelectedIndex = 0;
            this.cboControlFlujo.SelectedIndex = 0;
            this.marcoEstadoPines.Enabled = PuertoSerie.IsOpen;
            #endregion
        }

        /// <summary>
        /// Handles the Click event of the btnConectar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnConectar_Click(object sender, EventArgs e) {
            if(!PuertoSerie.IsOpen){
                PuertoSerie.PortName = this.comboPuertosSerieDisponibles.SelectedItem.ToString();
                PuertoSerie.BaudRate = Convert.ToInt32(this.cboBitsPorSegundo.SelectedItem);
                PuertoSerie.DataBits = Convert.ToInt32(this.cboBitsDeDatos.SelectedItem);

                switch(this.cboParidad.SelectedIndex){
                    case 0:
                        PuertoSerie.Parity = System.IO.Ports.Parity.Even;
                        break;
                    case 1:
                        PuertoSerie.Parity = System.IO.Ports.Parity.Odd;
                        break;
                    case 2:
                        PuertoSerie.Parity = System.IO.Ports.Parity.None;
                        break;
                    case 3:
                        PuertoSerie.Parity = System.IO.Ports.Parity.Mark;
                        break;
                    case 4:
                        PuertoSerie.Parity = System.IO.Ports.Parity.Space;
                        break;
                }

                switch(this.cboBitsParada.SelectedIndex){
                    case 0:
                        PuertoSerie.StopBits = System.IO.Ports.StopBits.One;
                        break;
                    case 1:
                        PuertoSerie.StopBits = System.IO.Ports.StopBits.OnePointFive;
                        break;
                    case 2:
                        PuertoSerie.StopBits = System.IO.Ports.StopBits.Two;
                        break;
                }

                switch(this.cboControlFlujo.SelectedIndex){
                    case 0:
                        PuertoSerie.Handshake = System.IO.Ports.Handshake.None;
                        break;
                    case 1:
                        PuertoSerie.Handshake = System.IO.Ports.Handshake.XOnXOff;
                        break;
                    case 2:
                        PuertoSerie.Handshake = System.IO.Ports.Handshake.RequestToSend;
                        break;
                    case 3:
                        PuertoSerie.Handshake = System.IO.Ports.Handshake.RequestToSendXOnXOff;
                        break;
                }


                PuertoSerie.DtrEnable = false;
                PuertoSerie.RtsEnable = false;
                
                try{
                    PuertoSerie.Open();
                    actualizarEstadoControles();
                    }
                catch(Exception exc){
                    MessageBox.Show("Se ha producido un error al intentar conectarse al puerto " + PuertoSerie.PortName + "\n\nDescripción: " + exc.Message, "Error de conexión");
                                    }

                this.etiquetaEstadoPuerto.Text = "Puerto actual: " + PuertoSerie.PortName + " - Conectado: " + PuertoSerie.IsOpen.ToString();
            }
            else{
                PuertoSerie.Close();
                this.etiquetaEstadoPuerto.Text = "Puerto actual: " + PuertoSerie.PortName + " - Conectado: " + PuertoSerie.IsOpen.ToString();  
                }
            
            actualizarEstadoControles();
            this.Focus();
        }

        /// <summary>
        /// Handles the FormClosing event of the FormularioPrincipal control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> instance containing the event data.</param>
        private void FormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
            if(PuertoSerie.IsOpen){
                PuertoSerie.Close();
            }
        }

        /// <summary>
        /// Handles the PinChanged event of the PuertoSerie control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.IO.Ports.SerialPinChangedEventArgs"/> instance containing the event data.</param>
        private void PuertoSerie_PinChanged(object sender, System.IO.Ports.SerialPinChangedEventArgs e) {
            if(PuertoSerie.CtsHolding){
                estadoCTS.Invoke(new EventHandler(delegate {
                    estadoCTS.BackColor = Color.GreenYellow;}));                
            }else{
                estadoCTS.Invoke(new EventHandler(delegate {
                    estadoCTS.BackColor = Color.Red;
                }));
                 }

            if(PuertoSerie.DsrHolding){
                estadoDSR.Invoke(new EventHandler(delegate {
                    estadoDSR.BackColor = Color.GreenYellow;
                }));
            }else{
                    estadoDSR.Invoke(new EventHandler(delegate {
                        estadoDSR.BackColor = Color.Red;
                    }));
                 }

            if(PuertoSerie.CDHolding){
                estadoDCD.Invoke(new EventHandler(delegate {
                    estadoDCD.BackColor = Color.GreenYellow;
                }));
            }else{
                    estadoDCD.Invoke(new EventHandler(delegate 
                        {
                        estadoDCD.BackColor = Color.Red;
                        }));
                 }

            if(e.EventType == SerialPinChange.Ring){
                estadoRING.Invoke(new EventHandler(delegate {
                    estadoRING.BackColor = Color.GreenYellow;
                }));
            }else{
                estadoRING.Invoke(new EventHandler(delegate {
                    estadoRING.BackColor = Color.Red;
                }));
                 }
        }

        /// <summary>
        /// Handles the MouseHover event of the etiquetaEstadoPuerto control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void etiquetaEstadoPuerto_MouseHover(object sender, EventArgs e) {
            if(PuertoSerie.IsOpen){
                toolTip1.SetToolTip(etiquetaEstadoPuerto, "Nombre del puerto: " + PuertoSerie.PortName
                                    + "\nConectado: " + PuertoSerie.IsOpen.ToString()
                                    + "\nBits por segundo: " + PuertoSerie.BaudRate.ToString()
                                    + "\nBits de datos: " + PuertoSerie.DataBits.ToString()
                                    + "\nParidad: " + PuertoSerie.Parity.ToString()
                                    + "\nBits de parada: " + PuertoSerie.StopBits.ToString()
                                    + "\nControl de flujo: " + PuertoSerie.Handshake.ToString()
                                    + "\nEstado de señal de interrupción: " + PuertoSerie.BreakState.ToString()
                                    + "\nBytes a leer: " + PuertoSerie.BytesToRead.ToString()
                                    + "\nBytes a escribir: " + PuertoSerie.BytesToWrite.ToString()
                                    + "\nCodificación: " + PuertoSerie.Encoding.ToString()
                                    + "\nTamaño del buffer de lectura: " + PuertoSerie.ReadBufferSize.ToString()
                                    + "\nTiempo de espera de lectura: " + PuertoSerie.ReadTimeout.ToString()
                                    + "\nTamaño del buffer de escritura: " + PuertoSerie.WriteBufferSize.ToString()
                                    + "\nTiempo de espera de escritura: " + PuertoSerie.WriteTimeout.ToString());
                                  } 
        }

        #region Estado DTR
        /// <summary>
        /// Handles the MouseDown event of the estadoDTR control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        private void estadoDTR_MouseDown(object sender, MouseEventArgs e) {
            activarSeñalPuerto("DTR");
        }

        /// <summary>
        /// Handles the MouseUp event of the estadoDTR control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        private void estadoDTR_MouseUp(object sender, MouseEventArgs e) {
            desactivarSeñalPuerto("DTR");  
        }

        /// <summary>
        /// Handles the CheckedChanged event of the chkMantenerDTR control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void chkMantenerDTR_CheckedChanged(object sender, EventArgs e) {
            //if(!this.chkMantenerDTR.Checked && PuertoSerie.DtrEnable)
            //{
            //    PuertoSerie.DtrEnable = false;
            //    this.estadoDTR.BackColor = Color.Red;
            //}
        } 
        #endregion

        #region Estado RTS
        /// <summary>
        /// Handles the MouseDown event of the estadoRTS control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        private void estadoRTS_MouseDown(object sender, MouseEventArgs e) {
            activarSeñalPuerto("RTS");
        }

        /// <summary>
        /// Handles the MouseUp event of the estadoRTS control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        private void estadoRTS_MouseUp(object sender, MouseEventArgs e) {
            desactivarSeñalPuerto("RTS");
        }

        private void chkMantenerRTS_CheckedChanged(object sender, EventArgs e) {
            //if(!this.chkMantenerRTS.Checked && PuertoSerie.RtsEnable)
            //{
            //    PuertoSerie.RtsEnable = false;
            //    this.estadoRTS.BackColor = Color.Red;
            //}
        } 
        #endregion

        /// <summary>
        /// Activar la señal pasada como parámetro.
        /// </summary>
        /// <param name="signalToActivate">The signal to activate.</param>
        private void activarSeñalPuerto(String signalToActivate) {
            if(signalToActivate.Equals("DTR")){
                if(!PuertoSerie.DtrEnable){
                    PuertoSerie.DtrEnable = true;
                    this.estadoDTR.BackColor = Color.GreenYellow;
                }
                else{
                    PuertoSerie.DtrEnable = false;
                    this.estadoDTR.BackColor = Color.Red;
                }
            }
            else if(signalToActivate.Equals("RTS")){
                if(!PuertoSerie.RtsEnable){
                    PuertoSerie.RtsEnable = true;
                    this.estadoRTS.BackColor = Color.GreenYellow;
                }
                else{
                    PuertoSerie.RtsEnable = false;
                    this.estadoRTS.BackColor = Color.Red;
                }
            }
            this.Focus();
        }

        /// <summary>
        /// Desactivar la señal pasado como parámetro.
        /// </summary>
        /// <param name="signalToDeactivate">The signal to deactivate.</param>
        private void desactivarSeñalPuerto(String signalToDeactivate) {
            if(signalToDeactivate.Equals("DTR")){
                if(!this.chkMantenerDTR.Checked){
                    PuertoSerie.DtrEnable = false;
                    this.estadoDTR.BackColor = Color.Red;
                }
            }
            else if(signalToDeactivate.Equals("RTS")){
                if(!this.chkMantenerRTS.Checked){
                    PuertoSerie.RtsEnable = false;
                    this.estadoRTS.BackColor = Color.Red;
                }
            }
            this.Focus();
        }

        /// <summary>
        /// Handles the DataReceived event of the PuertoSerie control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.IO.Ports.SerialDataReceivedEventArgs"/> instance containing the event data.</param>
        private void PuertoSerie_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            //TODO: Implementar PuertoSerie_DataReceived
        }

        /// <summary>
        /// Handles the KeyDown event of the FormularioPrincipal control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
        private void FormularioPrincipal_KeyDown(object sender, KeyEventArgs e) {
            if((codigoTeclaActivarDTR != null) && (e.KeyCode == codigoTeclaActivarDTR.KeyCode) & e.Control == controlDTR & e.Alt == altDTR){
                activarSeñalPuerto("DTR");
            }
            else if((codigoTeclaActivarRTS != null) && (e.KeyCode == codigoTeclaActivarRTS.KeyCode) & e.Control == controlRTS & e.Alt == altRTS)
            {
                activarSeñalPuerto("RTS"); 
            }
        }

        /// <summary>
        /// Handles the KeyUp event of the FormularioPrincipal control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
        private void FormularioPrincipal_KeyUp(object sender, KeyEventArgs e) {
            if((codigoTeclaActivarDTR != null) && (e.KeyCode == codigoTeclaActivarDTR.KeyCode) & e.Control == controlDTR & e.Alt == altDTR){
                desactivarSeñalPuerto("DTR");
            }
            else if((codigoTeclaActivarRTS != null) && (e.KeyCode == codigoTeclaActivarRTS.KeyCode) & e.Control == controlRTS & e.Alt == altRTS)
            {
                desactivarSeñalPuerto("RTS");
            }
        }

        /// <summary>
        /// Handles the Click event of the btnConfigurarTeclaDTR control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnConfigurarTeclaDTR_Click(object sender, EventArgs e) {
            SeleccionTeclaAceleradora STA = new SeleccionTeclaAceleradora();
            STA.ShowDialog(this);
        }

        /// <summary>
        /// Sets the activar DTR.
        /// </summary>
        /// <param name="tecla">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
        /// <param name="teclaControl">if set to <c>true</c> [tecla control].</param>
        /// <param name="teclaAlt">if set to <c>true</c> [tecla alt].</param>
        /// <param name="teclaShift">if set to <c>true</c> [tecla shift].</param>
        public static void setActivarDTR(KeyEventArgs tecla, bool teclaControl, bool teclaAlt) {
            codigoTeclaActivarDTR = tecla;
            controlDTR = teclaControl;
            altDTR = teclaAlt;            
        }

        /// <summary>
        /// Sets the activar RTS.
        /// </summary>
        /// <param name="tecla">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
        /// <param name="teclaControl">if set to <c>true</c> [tecla control].</param>
        /// <param name="teclaAlt">if set to <c>true</c> [tecla alt].</param>
        /// <param name="teclaShift">if set to <c>true</c> [tecla shift].</param>
        public static void setActivarRTS(KeyEventArgs tecla, bool teclaControl, bool teclaAlt) {
            codigoTeclaActivarRTS = tecla;
            controlRTS = teclaControl;
            altRTS = teclaAlt;
        }

        /// <summary>
        /// Actualizars the estado controles.
        /// </summary>
        private void actualizarEstadoControles() {

            if(this.comboPuertosSerieDisponibles.Items.Count > 0)
            {
                this.comboPuertosSerieDisponibles.Enabled = !PuertoSerie.IsOpen;

                this.marcoControles.Enabled = !PuertoSerie.IsOpen;

                if(!PuertoSerie.DtrEnable)
                    estadoDTR.BackColor = Color.Red;

                if(!PuertoSerie.RtsEnable)
                    estadoRTS.BackColor = Color.Red;

                if(!PuertoSerie.IsOpen) {
                    estadoCTS.BackColor = Color.FromKnownColor(KnownColor.ScrollBar);
                    estadoDCD.BackColor = Color.FromKnownColor(KnownColor.ScrollBar);
                    estadoDSR.BackColor = Color.FromKnownColor(KnownColor.ScrollBar);
                    estadoRING.BackColor = Color.FromKnownColor(KnownColor.ScrollBar);
                    estadoDTR.BackColor = Color.FromKnownColor(KnownColor.ScrollBar);
                    estadoRTS.BackColor = Color.FromKnownColor(KnownColor.ScrollBar);
                }

                this.marcoEstadoPines.Enabled = PuertoSerie.IsOpen;

                if(PuertoSerie.IsOpen) {
                    btnConectar.Text = "&Desconectar";
                    toolTip1.SetToolTip(btnConectar, "Desconectarse al puerto serie seleccionado");
                }
                else
                {
                    btnConectar.Text = "&Conectar";
                    toolTip1.SetToolTip(btnConectar, "Conectarse al puerto serie seleccionado");
                }
                 
            }
            else {
                this.marcoConexion.Enabled = false;
                this.marcoControles.Enabled = false;  
            }
        }
    }
}