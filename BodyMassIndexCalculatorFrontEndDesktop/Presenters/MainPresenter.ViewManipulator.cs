using BodyMassIndexCalculatorFrontEndDesktop.Constants;
using BodyMassIndexCalculatorFrontEndDesktop.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyMassIndexCalculatorFrontEndDesktop.Presenters
{
    public partial class MainPresenter
    {
        /// <summary>
        /// Add events to controls
        /// </summary>
        private void AddEventsToControl()
        {
            this.view.btnCalculate.Click += BtnCalculate_Click;
            this.view.txtNuHeight.KeyPress += textBox_KeyPressValidateIfIsFloat;
            this.view.txtNuMass.KeyPress += textBox_KeyPressValidateIfIsFloat;
        }

        private void textBox_KeyPressValidateIfIsFloat(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (this.ValidateControls())
            {
                float nuBMI = this.CalculateBMI(Convert.ToSingle(this.view.txtNuMass.Text), Convert.ToSingle(this.view.txtNuHeight.Text.Replace('.', ',')));
                BodyMassIndex bodyMassIndex = this.GetBodyMassIndex(nuBMI);
                
                this.SetLblResult(nuBMI, bodyMassIndex);
            }
        }


        /// <summary>
        /// Set lblResult text and color by Body Mass Index
        /// </summary>
        /// <param name="pNuBMI"></param>
        /// <param name="pBodyMassIndex"></param>
        private void SetLblResult(float pNuBMI, BodyMassIndex pBodyMassIndex)
        {
            this.view.lblResult.Text = $"Your BMI is {pNuBMI}.\nYou are {pBodyMassIndex}.";

            switch (pBodyMassIndex)
            {
                case (BodyMassIndex.Underweight):
                    this.view.lblResult.ForeColor = Color.Blue;
                    break;
                case (BodyMassIndex.Normal):
                    this.view.lblResult.ForeColor = Color.Green;
                    break;
                case (BodyMassIndex.Overweigth):
                    this.view.lblResult.ForeColor = Color.Gold;
                    break;
                case (BodyMassIndex.Obese):
                    this.view.lblResult.ForeColor = Color.Orange;
                    break;
                default: // BodyMassIndex.ExtremellyObese
                    this.view.lblResult.ForeColor = Color.Red;
                    break;
            }

        }

        /// <summary>
        /// Control validation
        /// </summary>
        /// <returns></returns>
        public bool ValidateControls()
        {
            string message = string.Empty;

            if (string.IsNullOrEmpty(this.view.txtNuMass.Text))
            {
                message += string.Format(MessageConstant.msgRequiredValue, "Mass");
            }

            if (string.IsNullOrEmpty(this.view.txtNuHeight.Text))
            {
                message += (string.IsNullOrEmpty(message)) ? string.Empty : "\r\n";
                message += string.Format(MessageConstant.msgRequiredValue, "Height");
            }

            if (!string.IsNullOrEmpty(message))
            {
                System.Windows.Forms.MessageBox.Show(message, "Validation", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }
    }
}
