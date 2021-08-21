
namespace Dating.Presentation.WindowsForm
{
    partial class SearchForm
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
            this._searchFormLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this._ageSearchLabel = new System.Windows.Forms.Label();
            this._toSearchLabel = new System.Windows.Forms.Label();
            this._citySearchLabel = new System.Windows.Forms.Label();
            this._firstNameSearchLabel = new System.Windows.Forms.Label();
            this._sexSearchLabel = new System.Windows.Forms.Label();
            this._orientationSearchLabel = new System.Windows.Forms.Label();
            this._searchButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _searchFormLabel
            // 
            this._searchFormLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this._searchFormLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._searchFormLabel.Location = new System.Drawing.Point(0, 0);
            this._searchFormLabel.Name = "_searchFormLabel";
            this._searchFormLabel.Size = new System.Drawing.Size(801, 78);
            this._searchFormLabel.TabIndex = 0;
            this._searchFormLabel.Text = "Search";
            this._searchFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 27);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(387, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 27);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 258);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 27);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 27);
            this.textBox4.TabIndex = 4;
            // 
            // _ageSearchLabel
            // 
            this._ageSearchLabel.AutoSize = true;
            this._ageSearchLabel.Location = new System.Drawing.Point(23, 192);
            this._ageSearchLabel.Name = "_ageSearchLabel";
            this._ageSearchLabel.Size = new System.Drawing.Size(90, 20);
            this._ageSearchLabel.TabIndex = 5;
            this._ageSearchLabel.Text = "Age     From";
            // 
            // _toSearchLabel
            // 
            this._toSearchLabel.AutoSize = true;
            this._toSearchLabel.Location = new System.Drawing.Point(323, 190);
            this._toSearchLabel.Name = "_toSearchLabel";
            this._toSearchLabel.Size = new System.Drawing.Size(25, 20);
            this._toSearchLabel.TabIndex = 6;
            this._toSearchLabel.Text = "To";
            // 
            // _citySearchLabel
            // 
            this._citySearchLabel.AutoSize = true;
            this._citySearchLabel.Location = new System.Drawing.Point(23, 261);
            this._citySearchLabel.Name = "_citySearchLabel";
            this._citySearchLabel.Size = new System.Drawing.Size(34, 20);
            this._citySearchLabel.TabIndex = 7;
            this._citySearchLabel.Text = "City";
            // 
            // _firstNameSearchLabel
            // 
            this._firstNameSearchLabel.AutoSize = true;
            this._firstNameSearchLabel.Location = new System.Drawing.Point(23, 133);
            this._firstNameSearchLabel.Name = "_firstNameSearchLabel";
            this._firstNameSearchLabel.Size = new System.Drawing.Size(80, 20);
            this._firstNameSearchLabel.TabIndex = 8;
            this._firstNameSearchLabel.Text = "First Name";
            // 
            // _sexSearchLabel
            // 
            this._sexSearchLabel.AutoSize = true;
            this._sexSearchLabel.Location = new System.Drawing.Point(23, 326);
            this._sexSearchLabel.Name = "_sexSearchLabel";
            this._sexSearchLabel.Size = new System.Drawing.Size(32, 20);
            this._sexSearchLabel.TabIndex = 11;
            this._sexSearchLabel.Text = "Sex";
            // 
            // _orientationSearchLabel
            // 
            this._orientationSearchLabel.AutoSize = true;
            this._orientationSearchLabel.Location = new System.Drawing.Point(23, 386);
            this._orientationSearchLabel.Name = "_orientationSearchLabel";
            this._orientationSearchLabel.Size = new System.Drawing.Size(84, 20);
            this._orientationSearchLabel.TabIndex = 12;
            this._orientationSearchLabel.Text = "Orientation";
            // 
            // _searchButton
            // 
            this._searchButton.Location = new System.Drawing.Point(653, 130);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(98, 283);
            this._searchButton.TabIndex = 13;
            this._searchButton.Text = "Search";
            this._searchButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(151, 323);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Getero",
            "Bi",
            "Lesbi",
            "Gay"});
            this.comboBox2.Location = new System.Drawing.Point(151, 383);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 15;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this._searchButton);
            this.Controls.Add(this._orientationSearchLabel);
            this.Controls.Add(this._sexSearchLabel);
            this.Controls.Add(this._firstNameSearchLabel);
            this.Controls.Add(this._citySearchLabel);
            this.Controls.Add(this._toSearchLabel);
            this.Controls.Add(this._ageSearchLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._searchFormLabel);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _searchFormLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label _ageSearchLabel;
        private System.Windows.Forms.Label _toSearchLabel;
        private System.Windows.Forms.Label _citySearchLabel;
        private System.Windows.Forms.Label _firstNameSearchLabel;
        private System.Windows.Forms.Label _sexSearchLabel;
        private System.Windows.Forms.Label _orientationSearchLabel;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}