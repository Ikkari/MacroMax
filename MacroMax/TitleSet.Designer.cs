namespace MacroMax
{
    partial class TitleSet
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.reBindRadioButton = new System.Windows.Forms.RadioButton();
            this.toggleRadioButton = new System.Windows.Forms.RadioButton();
            this.macroRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(15, 25);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 20);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.Text = "New Binding";
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            this.titleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.titleTextBox_KeyDown);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(73, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Binding Name";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(10, 105);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(269, 105);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // reBindRadioButton
            // 
            this.reBindRadioButton.AutoSize = true;
            this.reBindRadioButton.Checked = true;
            this.reBindRadioButton.Location = new System.Drawing.Point(6, 19);
            this.reBindRadioButton.Name = "reBindRadioButton";
            this.reBindRadioButton.Size = new System.Drawing.Size(106, 17);
            this.reBindRadioButton.TabIndex = 4;
            this.reBindRadioButton.TabStop = true;
            this.reBindRadioButton.Text = "Re-Bind a Button";
            this.reBindRadioButton.UseVisualStyleBackColor = true;
            this.reBindRadioButton.CheckedChanged += new System.EventHandler(this.reBindRadioButton_CheckedChanged);
            // 
            // toggleRadioButton
            // 
            this.toggleRadioButton.AutoSize = true;
            this.toggleRadioButton.Location = new System.Drawing.Point(118, 19);
            this.toggleRadioButton.Name = "toggleRadioButton";
            this.toggleRadioButton.Size = new System.Drawing.Size(101, 17);
            this.toggleRadioButton.TabIndex = 5;
            this.toggleRadioButton.Text = "Toggle a Button";
            this.toggleRadioButton.UseVisualStyleBackColor = true;
            this.toggleRadioButton.CheckedChanged += new System.EventHandler(this.reBindRadioButton_CheckedChanged);
            // 
            // macroRadioButton
            // 
            this.macroRadioButton.AutoSize = true;
            this.macroRadioButton.Location = new System.Drawing.Point(232, 19);
            this.macroRadioButton.Name = "macroRadioButton";
            this.macroRadioButton.Size = new System.Drawing.Size(94, 17);
            this.macroRadioButton.TabIndex = 6;
            this.macroRadioButton.Text = "Make a Macro";
            this.macroRadioButton.UseVisualStyleBackColor = true;
            this.macroRadioButton.CheckedChanged += new System.EventHandler(this.reBindRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reBindRadioButton);
            this.groupBox1.Controls.Add(this.macroRadioButton);
            this.groupBox1.Controls.Add(this.toggleRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 48);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Binding Type";
            // 
            // TitleSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 143);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.titleTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TitleSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Binding";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton reBindRadioButton;
        private System.Windows.Forms.RadioButton toggleRadioButton;
        private System.Windows.Forms.RadioButton macroRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}