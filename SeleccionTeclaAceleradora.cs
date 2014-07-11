using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PruebasPuertoSerie {
    public partial class SeleccionTeclaAceleradora : Form {

        //Teclas aceleradoras
        #region Teclas aceleradoras
        private static String codigoTeclaActivarDTR;
        private static String codigoTeclaActivarRTS;
        private static bool controlDTR;
        private static bool altDTR;
        private static bool controlRTS;
        private static bool altRTS;
        #endregion
        KeysConverter keysConverter = new KeysConverter();
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SeleccionTeclaAceleradora"/> class.
        /// </summary>
        public SeleccionTeclaAceleradora() {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the SeleccionTeclaAceleradora control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void SeleccionTeclaAceleradora_Load(object sender, EventArgs e) {
            
            this.comboTeclasDTR.SelectedIndex = 0;
            this.comboTeclasRTS.SelectedIndex = 0;

            if(codigoTeclaActivarDTR != null){
                this.comboTeclasDTR.SelectedItem = codigoTeclaActivarDTR;
            }
            if(codigoTeclaActivarRTS != null){
                this.comboTeclasRTS.SelectedItem = codigoTeclaActivarRTS;
            }

            chkControlDTR.Checked = controlDTR;
            chkAltDTR.Checked = altDTR;
            chkControlRTS.Checked = controlRTS;
            chkAltRTS.Checked = altRTS;
        }

        /// <summary>
        /// Handles the Click event of the btnCancelar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnAsignarTecla control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnAsignarTecla_Click(object sender, EventArgs e) {
            
            Keys teclaSeleccionadaDTR = (Keys)keysConverter.ConvertFromString(this.comboTeclasDTR.SelectedItem.ToString());
            KeyEventArgs keysEventArgsDTR = new KeyEventArgs(teclaSeleccionadaDTR);
            Keys teclaSeleccionadaRTS = (Keys)keysConverter.ConvertFromString(this.comboTeclasRTS.SelectedItem.ToString());
            KeyEventArgs keysEventArgsRTS = new KeyEventArgs(teclaSeleccionadaRTS);

            codigoTeclaActivarDTR = keysEventArgsDTR.KeyData.ToString();
            codigoTeclaActivarRTS = keysEventArgsRTS.KeyData.ToString();
            
            controlDTR = chkControlDTR.Checked;
            altDTR = chkAltDTR.Checked;
            controlRTS = chkControlRTS.Checked;
            altRTS = chkAltRTS.Checked;

            FormularioPrincipal.setActivarDTR(keysEventArgsDTR, controlDTR, altDTR);
            FormularioPrincipal.setActivarRTS(keysEventArgsRTS, controlRTS, altRTS);
            this.Close();
        }
    }
}