using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyMassIndexCalculatorFrontEndDesktop.Interfaces
{
    public interface IMain
    {
        TextBox txtNuMass { get; }
        TextBox txtNuHeight { get; }
        Button btnCalculate { get; }
        Label lblResult { get; }
    }
}
