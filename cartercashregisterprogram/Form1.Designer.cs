namespace cartercashregisterprogram
{
    partial class mcdonaldsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mcdonaldsForm));
            this.burgertextBox = new System.Windows.Forms.TextBox();
            this.friestextBox = new System.Windows.Forms.TextBox();
            this.sodatextBox = new System.Windows.Forms.TextBox();
            this.icecreamtextBox = new System.Windows.Forms.TextBox();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.sodaLabel = new System.Windows.Forms.Label();
            this.icecreamLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.burgercostLabel = new System.Windows.Forms.Label();
            this.friescostLabel = new System.Windows.Forms.Label();
            this.sodaCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burgertextBox
            // 
            this.burgertextBox.Location = new System.Drawing.Point(218, 54);
            this.burgertextBox.Name = "burgertextBox";
            this.burgertextBox.Size = new System.Drawing.Size(27, 20);
            this.burgertextBox.TabIndex = 0;
            // 
            // friestextBox
            // 
            this.friestextBox.Location = new System.Drawing.Point(218, 80);
            this.friestextBox.Name = "friestextBox";
            this.friestextBox.Size = new System.Drawing.Size(27, 20);
            this.friestextBox.TabIndex = 1;
            // 
            // sodatextBox
            // 
            this.sodatextBox.Location = new System.Drawing.Point(218, 106);
            this.sodatextBox.Name = "sodatextBox";
            this.sodatextBox.Size = new System.Drawing.Size(27, 20);
            this.sodatextBox.TabIndex = 2;
            // 
            // icecreamtextBox
            // 
            this.icecreamtextBox.Location = new System.Drawing.Point(218, 132);
            this.icecreamtextBox.Name = "icecreamtextBox";
            this.icecreamtextBox.Size = new System.Drawing.Size(27, 20);
            this.icecreamtextBox.TabIndex = 3;
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.BackColor = System.Drawing.Color.Transparent;
            this.burgerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerLabel.ForeColor = System.Drawing.Color.Ivory;
            this.burgerLabel.Location = new System.Drawing.Point(12, 54);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(63, 20);
            this.burgerLabel.TabIndex = 4;
            this.burgerLabel.Text = "Burger";
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.BackColor = System.Drawing.Color.Transparent;
            this.friesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesLabel.ForeColor = System.Drawing.Color.Ivory;
            this.friesLabel.Location = new System.Drawing.Point(12, 80);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(49, 20);
            this.friesLabel.TabIndex = 5;
            this.friesLabel.Text = "Fries";
            // 
            // sodaLabel
            // 
            this.sodaLabel.AutoSize = true;
            this.sodaLabel.BackColor = System.Drawing.Color.Transparent;
            this.sodaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sodaLabel.ForeColor = System.Drawing.Color.Ivory;
            this.sodaLabel.Location = new System.Drawing.Point(12, 106);
            this.sodaLabel.Name = "sodaLabel";
            this.sodaLabel.Size = new System.Drawing.Size(51, 20);
            this.sodaLabel.TabIndex = 6;
            this.sodaLabel.Text = "Soda";
            // 
            // icecreamLabel
            // 
            this.icecreamLabel.AutoSize = true;
            this.icecreamLabel.BackColor = System.Drawing.Color.Transparent;
            this.icecreamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icecreamLabel.ForeColor = System.Drawing.Color.Ivory;
            this.icecreamLabel.Location = new System.Drawing.Point(12, 132);
            this.icecreamLabel.Name = "icecreamLabel";
            this.icecreamLabel.Size = new System.Drawing.Size(91, 20);
            this.icecreamLabel.TabIndex = 7;
            this.icecreamLabel.Text = "Ice Cream";
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(9, 171);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(94, 22);
            this.totalButton.TabIndex = 8;
            this.totalButton.Text = "Calculate Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.Yellow;
            this.quantityLabel.Location = new System.Drawing.Point(200, 33);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(64, 16);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Quantity";
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.Yellow;
            this.menuLabel.Location = new System.Drawing.Point(12, 29);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(53, 20);
            this.menuLabel.TabIndex = 10;
            this.menuLabel.Text = "Menu";
            // 
            // burgercostLabel
            // 
            this.burgercostLabel.AutoSize = true;
            this.burgercostLabel.BackColor = System.Drawing.Color.Transparent;
            this.burgercostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgercostLabel.ForeColor = System.Drawing.Color.Yellow;
            this.burgercostLabel.Location = new System.Drawing.Point(127, 61);
            this.burgercostLabel.Name = "burgercostLabel";
            this.burgercostLabel.Size = new System.Drawing.Size(39, 16);
            this.burgercostLabel.TabIndex = 11;
            this.burgercostLabel.Text = "$2.49";
            // 
            // friescostLabel
            // 
            this.friescostLabel.AutoSize = true;
            this.friescostLabel.BackColor = System.Drawing.Color.Transparent;
            this.friescostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friescostLabel.ForeColor = System.Drawing.Color.Yellow;
            this.friescostLabel.Location = new System.Drawing.Point(127, 83);
            this.friescostLabel.Name = "friescostLabel";
            this.friescostLabel.Size = new System.Drawing.Size(39, 16);
            this.friescostLabel.TabIndex = 12;
            this.friescostLabel.Text = "$1.89";
            // 
            // sodaCost
            // 
            this.sodaCost.AutoSize = true;
            this.sodaCost.BackColor = System.Drawing.Color.Transparent;
            this.sodaCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sodaCost.ForeColor = System.Drawing.Color.Yellow;
            this.sodaCost.Location = new System.Drawing.Point(127, 106);
            this.sodaCost.Name = "sodaCost";
            this.sodaCost.Size = new System.Drawing.Size(39, 16);
            this.sodaCost.TabIndex = 13;
            this.sodaCost.Text = "$0.99";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(127, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "$1.19";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.ForeColor = System.Drawing.Color.Yellow;
            this.costLabel.Location = new System.Drawing.Point(127, 33);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(39, 16);
            this.costLabel.TabIndex = 15;
            this.costLabel.Text = "Cost";
            // 
            // mcdonaldsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(361, 361);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sodaCost);
            this.Controls.Add(this.friescostLabel);
            this.Controls.Add(this.burgercostLabel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.icecreamLabel);
            this.Controls.Add(this.sodaLabel);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.icecreamtextBox);
            this.Controls.Add(this.sodatextBox);
            this.Controls.Add(this.friestextBox);
            this.Controls.Add(this.burgertextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mcdonaldsForm";
            this.Text = "McDonald\'s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox burgertextBox;
        private System.Windows.Forms.TextBox friestextBox;
        private System.Windows.Forms.TextBox sodatextBox;
        private System.Windows.Forms.TextBox icecreamtextBox;
        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.Label sodaLabel;
        private System.Windows.Forms.Label icecreamLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Label burgercostLabel;
        private System.Windows.Forms.Label friescostLabel;
        private System.Windows.Forms.Label sodaCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label costLabel;
    }
}

