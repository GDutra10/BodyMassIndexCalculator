
namespace BodyMassIndexCalculatorFrontEndDesktop.Views
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtNuHeight = new System.Windows.Forms.TextBox();
            this.txtNuMass = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblMass = new System.Windows.Forms.Label();
            this.lblMeter = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pbBMI = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBMI)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.pnlForm);
            this.pnlMain.Controls.Add(this.pnlImage);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(784, 361);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.Controls.Add(this.btnCalculate);
            this.pnlForm.Controls.Add(this.txtNuHeight);
            this.pnlForm.Controls.Add(this.txtNuMass);
            this.pnlForm.Controls.Add(this.lblHeight);
            this.pnlForm.Controls.Add(this.lblResult);
            this.pnlForm.Controls.Add(this.lblMass);
            this.pnlForm.Controls.Add(this.lblMeter);
            this.pnlForm.Controls.Add(this.lblKg);
            this.pnlForm.Location = new System.Drawing.Point(11, 53);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(167, 295);
            this.pnlForm.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(4, 54);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(157, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Compute BMI";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // txtNuHeight
            // 
            this.txtNuHeight.Location = new System.Drawing.Point(87, 25);
            this.txtNuHeight.MaxLength = 4;
            this.txtNuHeight.Name = "txtNuHeight";
            this.txtNuHeight.Size = new System.Drawing.Size(50, 23);
            this.txtNuHeight.TabIndex = 1;
            // 
            // txtNuMass
            // 
            this.txtNuMass.Location = new System.Drawing.Point(4, 25);
            this.txtNuMass.MaxLength = 4;
            this.txtNuMass.Name = "txtNuMass";
            this.txtNuMass.Size = new System.Drawing.Size(50, 23);
            this.txtNuMass.TabIndex = 0;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(85, 7);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(49, 15);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(4, 80);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(70, 15);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "lblResult";
            // 
            // lblMass
            // 
            this.lblMass.AutoSize = true;
            this.lblMass.Location = new System.Drawing.Point(4, 7);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(35, 15);
            this.lblMass.TabIndex = 3;
            this.lblMass.Text = "Mass";
            // 
            // lblMeter
            // 
            this.lblMeter.AutoSize = true;
            this.lblMeter.Location = new System.Drawing.Point(140, 28);
            this.lblMeter.Name = "lblMeter";
            this.lblMeter.Size = new System.Drawing.Size(14, 15);
            this.lblMeter.TabIndex = 5;
            this.lblMeter.Text = "m";
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(60, 28);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(21, 15);
            this.lblKg.TabIndex = 4;
            this.lblKg.Text = "kg";
            // 
            // pnlImage
            // 
            this.pnlImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImage.Controls.Add(this.pbBMI);
            this.pnlImage.Location = new System.Drawing.Point(182, 53);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(591, 295);
            this.pnlImage.TabIndex = 8;
            // 
            // pbBMI
            // 
            this.pbBMI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBMI.Image = ((System.Drawing.Image)(resources.GetObject("pbBMI.Image")));
            this.pbBMI.Location = new System.Drawing.Point(-1, -1);
            this.pbBMI.Name = "pbBMI";
            this.pbBMI.Size = new System.Drawing.Size(591, 295);
            this.pbBMI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBMI.TabIndex = 0;
            this.pbBMI.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(176, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(431, 34);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "BODY MASS INDEX CALCULATOR";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBMI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblMeter;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtNuMass;
        private System.Windows.Forms.TextBox txtNuHeight;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox pbBMI;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Button btnCalculate;
    }
}