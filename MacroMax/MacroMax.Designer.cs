namespace MacroMax
{
    partial class MacroMax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacroMax));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBindingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBindingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reBindsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.togglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boundListBox = new System.Windows.Forms.CheckedListBox();
            this.macroListBox = new System.Windows.Forms.ListBox();
            this.bindButton = new System.Windows.Forms.Button();
            this.recordMacroButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.mimicButton = new System.Windows.Forms.Button();
            this.startButtonTextBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.mimicTextBox = new System.Windows.Forms.TextBox();
            this.toggleCheckBox = new System.Windows.Forms.CheckBox();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.mimicPage = new System.Windows.Forms.TabPage();
            this.mimicStartTextBox = new System.Windows.Forms.TextBox();
            this.mimicStart = new System.Windows.Forms.Button();
            this.togglePage = new System.Windows.Forms.TabPage();
            this.toggleTextBox = new System.Windows.Forms.TextBox();
            this.toggleButton = new System.Windows.Forms.Button();
            this.macroPage = new System.Windows.Forms.TabPage();
            this.releaseStopCheckBox = new System.Windows.Forms.CheckBox();
            this.macroCommandLabel = new System.Windows.Forms.Label();
            this.showAllRadioButton = new System.Windows.Forms.RadioButton();
            this.showReBindRadioButton = new System.Windows.Forms.RadioButton();
            this.showToggleRadioButton = new System.Windows.Forms.RadioButton();
            this.ShowMacroRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.mimicPage.SuspendLayout();
            this.togglePage.SuspendLayout();
            this.macroPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(553, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.deleteBindingToolStripMenuItem,
            this.toolStripMenuItem2,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.newToolStripMenuItem.Text = "New Binding";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newMacroButton_Click);
            // 
            // deleteBindingToolStripMenuItem
            // 
            this.deleteBindingToolStripMenuItem.Name = "deleteBindingToolStripMenuItem";
            this.deleteBindingToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.deleteBindingToolStripMenuItem.Text = "Delete Binding";
            this.deleteBindingToolStripMenuItem.Click += new System.EventHandler(this.deleteMacroButton_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem2.Text = "Save";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBindingsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showBindingsToolStripMenuItem
            // 
            this.showBindingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.reBindsToolStripMenuItem,
            this.togglesToolStripMenuItem,
            this.macrosToolStripMenuItem});
            this.showBindingsToolStripMenuItem.Name = "showBindingsToolStripMenuItem";
            this.showBindingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showBindingsToolStripMenuItem.Text = "Show Bindings";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Checked = true;
            this.allToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // reBindsToolStripMenuItem
            // 
            this.reBindsToolStripMenuItem.Name = "reBindsToolStripMenuItem";
            this.reBindsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.reBindsToolStripMenuItem.Text = "Re-Binds";
            this.reBindsToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // togglesToolStripMenuItem
            // 
            this.togglesToolStripMenuItem.Name = "togglesToolStripMenuItem";
            this.togglesToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.togglesToolStripMenuItem.Text = "Toggles";
            this.togglesToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // macrosToolStripMenuItem
            // 
            this.macrosToolStripMenuItem.Name = "macrosToolStripMenuItem";
            this.macrosToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.macrosToolStripMenuItem.Text = "Macros";
            this.macrosToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // boundListBox
            // 
            this.boundListBox.FormattingEnabled = true;
            this.boundListBox.Location = new System.Drawing.Point(12, 111);
            this.boundListBox.Name = "boundListBox";
            this.boundListBox.Size = new System.Drawing.Size(170, 319);
            this.boundListBox.TabIndex = 2;
            this.boundListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.boundListBox_ItemCheck_1);
            this.boundListBox.SelectedIndexChanged += new System.EventHandler(this.boundListBox_SelectedIndexChanged);
            // 
            // macroListBox
            // 
            this.macroListBox.FormattingEnabled = true;
            this.macroListBox.Location = new System.Drawing.Point(6, 33);
            this.macroListBox.Name = "macroListBox";
            this.macroListBox.Size = new System.Drawing.Size(216, 303);
            this.macroListBox.TabIndex = 3;
            this.macroListBox.SelectedIndexChanged += new System.EventHandler(this.macroListBox_SelectedIndexChanged);
            // 
            // bindButton
            // 
            this.bindButton.Enabled = false;
            this.bindButton.Location = new System.Drawing.Point(228, 143);
            this.bindButton.Name = "bindButton";
            this.bindButton.Size = new System.Drawing.Size(104, 46);
            this.bindButton.TabIndex = 4;
            this.bindButton.Text = "Set Macro Start Button";
            this.bindButton.UseVisualStyleBackColor = true;
            this.bindButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // recordMacroButton
            // 
            this.recordMacroButton.Enabled = false;
            this.recordMacroButton.Location = new System.Drawing.Point(229, 33);
            this.recordMacroButton.Name = "recordMacroButton";
            this.recordMacroButton.Size = new System.Drawing.Size(104, 34);
            this.recordMacroButton.TabIndex = 5;
            this.recordMacroButton.Text = "Start Recording";
            this.recordMacroButton.UseVisualStyleBackColor = true;
            this.recordMacroButton.Click += new System.EventHandler(this.addMacroButton_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(441, 27);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(98, 23);
            this.runButton.TabIndex = 6;
            this.runButton.Text = "Run Bindings";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // mimicButton
            // 
            this.mimicButton.Enabled = false;
            this.mimicButton.Location = new System.Drawing.Point(174, 101);
            this.mimicButton.Name = "mimicButton";
            this.mimicButton.Size = new System.Drawing.Size(104, 42);
            this.mimicButton.TabIndex = 8;
            this.mimicButton.Text = "Re-Bound Button";
            this.mimicButton.UseVisualStyleBackColor = true;
            this.mimicButton.Click += new System.EventHandler(this.mimicButton_Click);
            // 
            // startButtonTextBox
            // 
            this.startButtonTextBox.Location = new System.Drawing.Point(228, 195);
            this.startButtonTextBox.Name = "startButtonTextBox";
            this.startButtonTextBox.ReadOnly = true;
            this.startButtonTextBox.Size = new System.Drawing.Size(104, 20);
            this.startButtonTextBox.TabIndex = 12;
            // 
            // insertButton
            // 
            this.insertButton.Enabled = false;
            this.insertButton.Location = new System.Drawing.Point(229, 257);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(104, 23);
            this.insertButton.TabIndex = 14;
            this.insertButton.Text = "Insert Command";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(229, 312);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 23);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete Command";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(229, 286);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(104, 23);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Edit Command";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // mimicTextBox
            // 
            this.mimicTextBox.Location = new System.Drawing.Point(174, 148);
            this.mimicTextBox.Name = "mimicTextBox";
            this.mimicTextBox.ReadOnly = true;
            this.mimicTextBox.Size = new System.Drawing.Size(104, 20);
            this.mimicTextBox.TabIndex = 19;
            // 
            // toggleCheckBox
            // 
            this.toggleCheckBox.AutoSize = true;
            this.toggleCheckBox.Enabled = false;
            this.toggleCheckBox.Location = new System.Drawing.Point(115, 197);
            this.toggleCheckBox.Name = "toggleCheckBox";
            this.toggleCheckBox.Size = new System.Drawing.Size(112, 17);
            this.toggleCheckBox.TabIndex = 20;
            this.toggleCheckBox.Text = "Toggle this Button";
            this.toggleCheckBox.UseVisualStyleBackColor = true;
            this.toggleCheckBox.CheckedChanged += new System.EventHandler(this.toggleCheckBox_CheckedChanged);
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.mimicPage);
            this.mainTabs.Controls.Add(this.togglePage);
            this.mainTabs.Controls.Add(this.macroPage);
            this.mainTabs.Location = new System.Drawing.Point(192, 64);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(347, 366);
            this.mainTabs.TabIndex = 21;
            // 
            // mimicPage
            // 
            this.mimicPage.Controls.Add(this.mimicStartTextBox);
            this.mimicPage.Controls.Add(this.mimicStart);
            this.mimicPage.Controls.Add(this.mimicButton);
            this.mimicPage.Controls.Add(this.mimicTextBox);
            this.mimicPage.Controls.Add(this.toggleCheckBox);
            this.mimicPage.Location = new System.Drawing.Point(4, 22);
            this.mimicPage.Name = "mimicPage";
            this.mimicPage.Padding = new System.Windows.Forms.Padding(3);
            this.mimicPage.Size = new System.Drawing.Size(339, 340);
            this.mimicPage.TabIndex = 2;
            this.mimicPage.Text = "Re-Bind a Button";
            this.mimicPage.UseVisualStyleBackColor = true;
            // 
            // mimicStartTextBox
            // 
            this.mimicStartTextBox.Location = new System.Drawing.Point(45, 148);
            this.mimicStartTextBox.Name = "mimicStartTextBox";
            this.mimicStartTextBox.ReadOnly = true;
            this.mimicStartTextBox.Size = new System.Drawing.Size(104, 20);
            this.mimicStartTextBox.TabIndex = 19;
            // 
            // mimicStart
            // 
            this.mimicStart.Enabled = false;
            this.mimicStart.Location = new System.Drawing.Point(45, 101);
            this.mimicStart.Name = "mimicStart";
            this.mimicStart.Size = new System.Drawing.Size(104, 41);
            this.mimicStart.TabIndex = 23;
            this.mimicStart.Text = "Set the Start Button";
            this.mimicStart.UseVisualStyleBackColor = true;
            this.mimicStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // togglePage
            // 
            this.togglePage.Controls.Add(this.toggleTextBox);
            this.togglePage.Controls.Add(this.toggleButton);
            this.togglePage.Location = new System.Drawing.Point(4, 22);
            this.togglePage.Name = "togglePage";
            this.togglePage.Padding = new System.Windows.Forms.Padding(3);
            this.togglePage.Size = new System.Drawing.Size(339, 340);
            this.togglePage.TabIndex = 3;
            this.togglePage.Text = "Toggle a Button";
            this.togglePage.UseVisualStyleBackColor = true;
            // 
            // toggleTextBox
            // 
            this.toggleTextBox.Location = new System.Drawing.Point(83, 180);
            this.toggleTextBox.Name = "toggleTextBox";
            this.toggleTextBox.ReadOnly = true;
            this.toggleTextBox.Size = new System.Drawing.Size(121, 20);
            this.toggleTextBox.TabIndex = 1;
            // 
            // toggleButton
            // 
            this.toggleButton.Enabled = false;
            this.toggleButton.Location = new System.Drawing.Point(83, 64);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(121, 58);
            this.toggleButton.TabIndex = 0;
            this.toggleButton.Text = "Toggle a Button";
            this.toggleButton.UseVisualStyleBackColor = true;
            this.toggleButton.Click += new System.EventHandler(this.toggleButton_Click);
            // 
            // macroPage
            // 
            this.macroPage.Controls.Add(this.releaseStopCheckBox);
            this.macroPage.Controls.Add(this.macroCommandLabel);
            this.macroPage.Controls.Add(this.macroListBox);
            this.macroPage.Controls.Add(this.recordMacroButton);
            this.macroPage.Controls.Add(this.startButtonTextBox);
            this.macroPage.Controls.Add(this.editButton);
            this.macroPage.Controls.Add(this.bindButton);
            this.macroPage.Controls.Add(this.insertButton);
            this.macroPage.Controls.Add(this.deleteButton);
            this.macroPage.Location = new System.Drawing.Point(4, 22);
            this.macroPage.Name = "macroPage";
            this.macroPage.Padding = new System.Windows.Forms.Padding(3);
            this.macroPage.Size = new System.Drawing.Size(339, 340);
            this.macroPage.TabIndex = 1;
            this.macroPage.Text = "Make a Macro";
            this.macroPage.UseVisualStyleBackColor = true;
            // 
            // releaseStopCheckBox
            // 
            this.releaseStopCheckBox.AutoSize = true;
            this.releaseStopCheckBox.Location = new System.Drawing.Point(229, 221);
            this.releaseStopCheckBox.Name = "releaseStopCheckBox";
            this.releaseStopCheckBox.Size = new System.Drawing.Size(102, 17);
            this.releaseStopCheckBox.TabIndex = 20;
            this.releaseStopCheckBox.Text = "Release to Stop";
            this.releaseStopCheckBox.UseVisualStyleBackColor = true;
            this.releaseStopCheckBox.CheckedChanged += new System.EventHandler(this.stopButton_Click);
            // 
            // macroCommandLabel
            // 
            this.macroCommandLabel.AutoSize = true;
            this.macroCommandLabel.Location = new System.Drawing.Point(6, 17);
            this.macroCommandLabel.Name = "macroCommandLabel";
            this.macroCommandLabel.Size = new System.Drawing.Size(92, 13);
            this.macroCommandLabel.TabIndex = 19;
            this.macroCommandLabel.Text = "Macro Commands";
            // 
            // showAllRadioButton
            // 
            this.showAllRadioButton.AutoSize = true;
            this.showAllRadioButton.Checked = true;
            this.showAllRadioButton.Location = new System.Drawing.Point(15, 33);
            this.showAllRadioButton.Name = "showAllRadioButton";
            this.showAllRadioButton.Size = new System.Drawing.Size(66, 17);
            this.showAllRadioButton.TabIndex = 22;
            this.showAllRadioButton.TabStop = true;
            this.showAllRadioButton.Text = "Show All";
            this.showAllRadioButton.UseVisualStyleBackColor = true;
            this.showAllRadioButton.CheckedChanged += new System.EventHandler(this.showAllRadioButton_CheckedChanged);
            // 
            // showReBindRadioButton
            // 
            this.showReBindRadioButton.AutoSize = true;
            this.showReBindRadioButton.Location = new System.Drawing.Point(87, 33);
            this.showReBindRadioButton.Name = "showReBindRadioButton";
            this.showReBindRadioButton.Size = new System.Drawing.Size(98, 17);
            this.showReBindRadioButton.TabIndex = 23;
            this.showReBindRadioButton.Text = "Show Re-Binds";
            this.showReBindRadioButton.UseVisualStyleBackColor = true;
            this.showReBindRadioButton.CheckedChanged += new System.EventHandler(this.showAllRadioButton_CheckedChanged);
            // 
            // showToggleRadioButton
            // 
            this.showToggleRadioButton.AutoSize = true;
            this.showToggleRadioButton.Location = new System.Drawing.Point(12, 56);
            this.showToggleRadioButton.Name = "showToggleRadioButton";
            this.showToggleRadioButton.Size = new System.Drawing.Size(93, 17);
            this.showToggleRadioButton.TabIndex = 24;
            this.showToggleRadioButton.Text = "Show Toggles";
            this.showToggleRadioButton.UseVisualStyleBackColor = true;
            this.showToggleRadioButton.CheckedChanged += new System.EventHandler(this.showAllRadioButton_CheckedChanged);
            // 
            // ShowMacroRadioButton
            // 
            this.ShowMacroRadioButton.AutoSize = true;
            this.ShowMacroRadioButton.Location = new System.Drawing.Point(99, 56);
            this.ShowMacroRadioButton.Name = "ShowMacroRadioButton";
            this.ShowMacroRadioButton.Size = new System.Drawing.Size(90, 17);
            this.ShowMacroRadioButton.TabIndex = 25;
            this.ShowMacroRadioButton.Text = "Show Macros";
            this.ShowMacroRadioButton.UseVisualStyleBackColor = true;
            this.ShowMacroRadioButton.CheckedChanged += new System.EventHandler(this.showAllRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Binding List";
            // 
            // MacroMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowMacroRadioButton);
            this.Controls.Add(this.showToggleRadioButton);
            this.Controls.Add(this.showReBindRadioButton);
            this.Controls.Add(this.showAllRadioButton);
            this.Controls.Add(this.mainTabs);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.boundListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MacroMax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macro Max";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MacroMax_FormClosing);
            this.Load += new System.EventHandler(this.MacroMax_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainTabs.ResumeLayout(false);
            this.mimicPage.ResumeLayout(false);
            this.mimicPage.PerformLayout();
            this.togglePage.ResumeLayout(false);
            this.togglePage.PerformLayout();
            this.macroPage.ResumeLayout(false);
            this.macroPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckedListBox boundListBox;
        private System.Windows.Forms.ListBox macroListBox;
        private System.Windows.Forms.Button bindButton;
        private System.Windows.Forms.Button recordMacroButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button mimicButton;
        private System.Windows.Forms.TextBox startButtonTextBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox mimicTextBox;
        private System.Windows.Forms.CheckBox toggleCheckBox;
        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage macroPage;
        private System.Windows.Forms.TabPage mimicPage;
        private System.Windows.Forms.Button mimicStart;
        private System.Windows.Forms.TextBox mimicStartTextBox;
        private System.Windows.Forms.TabPage togglePage;
        private System.Windows.Forms.Button toggleButton;
        private System.Windows.Forms.TextBox toggleTextBox;
        private System.Windows.Forms.Label macroCommandLabel;
        private System.Windows.Forms.RadioButton showAllRadioButton;
        private System.Windows.Forms.RadioButton showReBindRadioButton;
        private System.Windows.Forms.RadioButton showToggleRadioButton;
        private System.Windows.Forms.RadioButton ShowMacroRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox releaseStopCheckBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBindingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBindingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reBindsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem togglesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macrosToolStripMenuItem;
    }
}

