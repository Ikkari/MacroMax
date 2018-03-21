namespace MacroMax
{
    partial class eventHookForm
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
            this.keyPressedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.keyUpRadioButton = new System.Windows.Forms.RadioButton();
            this.keyDownRadioButton = new System.Windows.Forms.RadioButton();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.altLabel = new System.Windows.Forms.Label();
            this.controlLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keyPressedLabel
            // 
            this.keyPressedLabel.AutoSize = true;
            this.keyPressedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyPressedLabel.Location = new System.Drawing.Point(27, 42);
            this.keyPressedLabel.Name = "keyPressedLabel";
            this.keyPressedLabel.Size = new System.Drawing.Size(0, 37);
            this.keyPressedLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Press any Key";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 120);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(137, 120);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // keyUpRadioButton
            // 
            this.keyUpRadioButton.AutoSize = true;
            this.keyUpRadioButton.Location = new System.Drawing.Point(152, 97);
            this.keyUpRadioButton.Name = "keyUpRadioButton";
            this.keyUpRadioButton.Size = new System.Drawing.Size(39, 17);
            this.keyUpRadioButton.TabIndex = 10;
            this.keyUpRadioButton.Text = "Up";
            this.keyUpRadioButton.UseVisualStyleBackColor = true;
            this.keyUpRadioButton.CheckedChanged += new System.EventHandler(this.keyUpRadioButton_CheckedChanged);
            // 
            // keyDownRadioButton
            // 
            this.keyDownRadioButton.AutoSize = true;
            this.keyDownRadioButton.Checked = true;
            this.keyDownRadioButton.Location = new System.Drawing.Point(12, 97);
            this.keyDownRadioButton.Name = "keyDownRadioButton";
            this.keyDownRadioButton.Size = new System.Drawing.Size(53, 17);
            this.keyDownRadioButton.TabIndex = 11;
            this.keyDownRadioButton.TabStop = true;
            this.keyDownRadioButton.Text = "Down";
            this.keyDownRadioButton.UseVisualStyleBackColor = true;
            this.keyDownRadioButton.CheckedChanged += new System.EventHandler(this.keyDownRadioButton_CheckedChanged);
            // 
            // shiftLabel
            // 
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Location = new System.Drawing.Point(12, 81);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(0, 13);
            this.shiftLabel.TabIndex = 12;
            // 
            // altLabel
            // 
            this.altLabel.AutoSize = true;
            this.altLabel.Location = new System.Drawing.Point(67, 81);
            this.altLabel.Name = "altLabel";
            this.altLabel.Size = new System.Drawing.Size(0, 13);
            this.altLabel.TabIndex = 13;
            // 
            // controlLabel
            // 
            this.controlLabel.AutoSize = true;
            this.controlLabel.Location = new System.Drawing.Point(134, 81);
            this.controlLabel.Name = "controlLabel";
            this.controlLabel.Size = new System.Drawing.Size(0, 13);
            this.controlLabel.TabIndex = 14;
            // 
            // eventHookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(222, 156);
            this.ControlBox = false;
            this.Controls.Add(this.controlLabel);
            this.Controls.Add(this.altLabel);
            this.Controls.Add(this.shiftLabel);
            this.Controls.Add(this.keyDownRadioButton);
            this.Controls.Add(this.keyUpRadioButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyPressedLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "eventHookForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Press any Key";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.eventHookForm_FormClosing);
            this.Load += new System.EventHandler(this.eventHookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keyPressedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton keyUpRadioButton;
        private System.Windows.Forms.RadioButton keyDownRadioButton;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.Label altLabel;
        private System.Windows.Forms.Label controlLabel;
    }
}