using BodyMassIndexCalculatorFrontEndDesktop.Interfaces;
using BodyMassIndexCalculatorFrontEndDesktop.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyMassIndexCalculatorFrontEndDesktop.Views
{
    public partial class FrmMain : Form, IMain
    {
        MainPresenter presenter;

        public FrmMain()
        {
            InitializeComponent();
            this.presenter = new MainPresenter(this);
        }

        #region Interface

        TextBox IMain.txtNuMass => this.txtNuMass;

        TextBox IMain.txtNuHeight => this.txtNuHeight;

        Button IMain.btnCalculate => this.btnCalculate;

        Label IMain.lblResult => this.lblResult;

        #endregion

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }


    }
}
