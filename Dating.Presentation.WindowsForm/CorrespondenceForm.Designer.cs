
namespace Dating.Presentation.WindowsForm
{
    partial class CorrespondenceForm
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
            this._correspondenceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _correspondenceLabel
            // 
            this._correspondenceLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this._correspondenceLabel.Location = new System.Drawing.Point(-5, -3);
            this._correspondenceLabel.Name = "_correspondenceLabel";
            this._correspondenceLabel.Size = new System.Drawing.Size(811, 45);
            this._correspondenceLabel.TabIndex = 0;
            this._correspondenceLabel.Text = "Dialog Box";
            this._correspondenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CorrespondenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._correspondenceLabel);
            this.Name = "CorrespondenceForm";
            this.Text = "CorrespondenceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _correspondenceLabel;
    }
}