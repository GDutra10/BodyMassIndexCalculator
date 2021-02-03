using BodyMassIndexCalculatorFrontEndDesktop.Enums;
using BodyMassIndexCalculatorFrontEndDesktop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexCalculatorFrontEndDesktop.Presenters
{
    public partial class MainPresenter
    {

        private IMain view { get; set; }

        public MainPresenter(IMain pView)
        {
            this.view = pView;
            this.InitializePresenter();
        }

        private void InitializePresenter()
        {
            this.view.lblResult.Text = string.Empty;
            
            this.AddEventsToControl();
        }

        /// <summary>
        /// Calculate the Body Mass Index
        /// </summary>
        /// <param name="pNuMass"></param>
        /// <param name="pNuHeight"></param>
        /// <returns></returns>
        public float CalculateBMI(float pNuMass, float pNuHeight)
        {
            return pNuMass / (pNuHeight * pNuHeight);
        }

        /// <summary>
        /// Get the Body Mass Index
        /// </summary>
        /// <param name="pNuBMI"></param>
        /// <returns></returns>
        public BodyMassIndex GetBodyMassIndex(float pNuBMI)
        {
            switch (pNuBMI)
            {
                case var expression when pNuBMI < 18.5:
                    return BodyMassIndex.Underweight;
                case var expression when pNuBMI >= 18.5 && pNuBMI <= 24.99:
                    return BodyMassIndex.Normal;
                case var expression when pNuBMI >= 25 && pNuBMI <= 29.99:
                    return BodyMassIndex.Overweigth;
                case var expression when pNuBMI >= 30 && pNuBMI <= 34.99:
                    return BodyMassIndex.Obese;
                default:
                    return BodyMassIndex.ExtremelyObese;
            }
        }

    }
}
