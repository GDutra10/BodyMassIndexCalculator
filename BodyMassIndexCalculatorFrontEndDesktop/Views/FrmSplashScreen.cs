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
    public partial class FrmSplashScreen : Form
    {
        Timer tmrSplashScreen;

        public FrmSplashScreen()
        {
            InitializeComponent();
            this.tmrSplashScreen = new Timer();
            this.tmrSplashScreen.Tick += TmrSplashScreen_Tick;
            this.tmrSplashScreen.Interval = 1000;
            this.tmrSplashScreen.Start();
        }

        private void TmrSplashScreen_Tick(object sender, EventArgs e)
        {
            this.progressBar.Value += 33;

            if (progressBar.Value >= 99)
            {
                this.tmrSplashScreen.Stop();
                new FrmMain().Show();
                this.Hide();
            }
        }
    }
}
