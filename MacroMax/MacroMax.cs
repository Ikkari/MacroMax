using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using MouseKeyboardLibrary;

namespace MacroMax
{
    public partial class MacroMax : Form
    {
        KeyboardHook keyHook = new KeyboardHook();
        List<Binding> keyBinds = new List<Binding>();
        private bool recording = false;
        int lastTime = 0;
        private bool running = false;
        private int selectedMacro = 0;
        private saveLoad sL = new saveLoad();


       Keys supressMacroKey = Keys.None;

        private BindType displayBinds = BindType.ALL;

        public MacroMax()
        {
            InitializeComponent();
           
        }

         private void MacroMax_Load(object sender, EventArgs e)
        {
           keyHook.KeyDown += keyHook_KeyDown;
            keyHook.KeyUp += keyHook_KeyUp;
            keyHook.KeyPress += keyHook_KeyPress;
        }


         void keyHook_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (running)
             { 
                 
                 for (int i = 0; i < keyBinds.Count; i++)
                 {
                     if (keyBinds.ElementAt(i).key == (Keys)e.KeyChar)
                     {
                         e.Handled = true;
                         break;
                     }
                 }
                    
             }
         }


        void keyHook_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (recording)
            {
                int time = Environment.TickCount - lastTime;
                keyBinds.ElementAt(boundListBox.SelectedIndex).macroList.Add(new Macro(EventType.KEYUP, (int)e.KeyCode, time));
                lastTime = Environment.TickCount;
                macroListBox.Items.Add(time + " ticks");
                macroListBox.Items.Add(e.KeyCode.ToString() + " KeyUp");
            }
            if (running)
            { 
                        
                for (int i = 0; i < keyBinds.Count; i++)
                {
                    if (keyBinds.ElementAt(i).checkMacro(e, EventType.KEYUP))
                   {
                     
                      if (keyBinds.ElementAt(i).key != supressMacroKey)
                      {

                            supressMacroKey = keyBinds.ElementAt(i).secondKey;

                          if (keyBinds.ElementAt(i).isToggled == false)
                           {
                               e.SuppressKeyPress = true;
                               e.Handled = true;
                           }

                           keyBinds.ElementAt(i).run(EventType.KEYUP);
                           
                     }
                      else
                      {
                           supressMacroKey = Keys.None;
                       }
                       break;
                   }
                }

            }
            
        }

        void keyHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (recording)
            {
                int time = Environment.TickCount - lastTime;
                keyBinds.ElementAt(boundListBox.SelectedIndex).macroList.Add(new Macro(EventType.KEYDOWN, (int)e.KeyCode, time));
                lastTime = Environment.TickCount;
                macroListBox.Items.Add(time + " ticks");
                macroListBox.Items.Add(e.KeyCode.ToString() + " KeyDown");
            }

            if (running)
            { 
                        
                for (int i = 0; i < keyBinds.Count; i++)
                {
                    if (keyBinds.ElementAt(i).checkMacro(e, EventType.KEYDOWN))
                    {

                       if (keyBinds.ElementAt(i).key != supressMacroKey)
                       {
                            supressMacroKey = keyBinds.ElementAt(i).secondKey;


                            switch (keyBinds.ElementAt(i).bindType)
                            {
                                case BindType.MACRO:
                                    {//release to stop does not work - repeats the start key stroke - also needs needs a loop

                                        if (keyBinds.ElementAt(i).isToggled == false)
                                        {
                                            e.SuppressKeyPress = true;
                                            e.Handled = true;

                                        //runs the binding
                                        keyBinds.ElementAt(i).run(EventType.KEYDOWN);
                                        }

                                    }
                                    break;
                                case BindType.REBIND:
                                    {
                                        //this works other than toggling this bind
                                        if (keyBinds.ElementAt(i).isToggled == false)
                                        {
                                            e.SuppressKeyPress = true;
                                            e.Handled = true;
                                        }
                                        //runs the binding
                                        keyBinds.ElementAt(i).run(EventType.KEYDOWN);
                                    }
                                    break;
                                case BindType.TOGGLE:
                                    {//have not tested this yet
                                        if (keyBinds.ElementAt(i).isToggled == false)
                                        {
                                            e.SuppressKeyPress = true;
                                            e.Handled = true;
                                        }
                                        //runs the binding
                                        keyBinds.ElementAt(i).run(EventType.KEYDOWN);
                                    }
                                    break;
                            }
                           
                        }
                        else
                        {
                            supressMacroKey = Keys.None;
                        }
                        break;
                    }
                        
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eventHookForm aform = new eventHookForm();
            DialogResult result = aform.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (aform.inputType == InputType.KEYBOARD)
                {
                    keyBinds.ElementAt(selectedMacro).key = aform.key.KeyCode;
                    keyBinds.ElementAt(selectedMacro).startType = InputType.KEYBOARD;
                }

                if (aform.inputType == InputType.MOUSE)
                {
                    keyBinds.ElementAt(selectedMacro).mouseKey = aform.mouse.Button;
                    keyBinds.ElementAt(selectedMacro).startType = InputType.MOUSE;
                }
                keyBinds.ElementAt(selectedMacro).eventType = aform.keyEvent;
                        aform.Close();
                        refreshMacro();
            }
        }

        private void boundListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshMacro();

            if (keyBinds.Count > 0)
            {
                if (keyBinds.ElementAt(selectedMacro).bindType == BindType.MACRO)
                {
                    macroPageToggle(true);
                    togglePageToggle(false);
                    mimicPageToggle(false);
                }

                if (keyBinds.ElementAt(selectedMacro).bindType == BindType.TOGGLE)
                {
                    macroPageToggle(false);
                    togglePageToggle(true);
                    mimicPageToggle(false);
                }

                if (keyBinds.ElementAt(selectedMacro).bindType == BindType.REBIND)
                {
                    macroPageToggle(false);
                    togglePageToggle(false);
                    mimicPageToggle(true);
                }
            }
        }

        private void refreshBoundListBox()
        {
            boundListBox.Items.Clear();

            for (int i = 0; i < keyBinds.Count; i++)
            { 
                if(keyBinds.ElementAt(i).bindType == displayBinds || displayBinds == BindType.ALL)
            boundListBox.Items.Add(keyBinds.ElementAt(i).title,keyBinds.ElementAt(i).useThisBinding);
            
            }
        
        }

        private void togglePageToggle(bool p)
        {
            if (p == true)
            { toggleButton.Enabled = true; }

            if (p == false)
            { toggleButton.Enabled = false; }
        }

        private void macroPageToggle(bool p)
        {
            if (p)
            {
                recordMacroButton.Enabled = true;
                bindButton.Enabled = true;
                insertButton.Enabled = true;
            }

            if (!p)
            {
                recordMacroButton.Enabled = false;
                bindButton.Enabled = false;
                insertButton.Enabled = false;
            }
        }

        private void refreshMacro()
        {
            startButtonTextBox.Text = "";
            mimicTextBox.Text = "";
            mimicStartTextBox.Text = "";
            toggleTextBox.Text = "";

            macroListBox.Items.Clear();

            for (int i = 0; i < keyBinds.Count; i++)
            {
                if(boundListBox.SelectedItem != null)
                if (keyBinds.ElementAt(i).title == boundListBox.SelectedItem.ToString())
                {
                    selectedMacro = i;;

                    if (keyBinds.ElementAt(i).startType == InputType.KEYBOARD)
                    {
                        startButtonTextBox.Text = keyBinds.ElementAt(i).key.ToString() + " " + keyBinds.ElementAt(i).eventType.ToString().ToLower();
                        mimicStartTextBox.Text = keyBinds.ElementAt(i).key.ToString();
                        toggleTextBox.Text = keyBinds.ElementAt(i).key.ToString();

                    }

                    if (keyBinds.ElementAt(i).startType == InputType.MOUSE)
                    {
                        startButtonTextBox.Text = keyBinds.ElementAt(i).mouseKey.ToString() + " " + keyBinds.ElementAt(i).eventType.ToString().ToLower();
                        mimicStartTextBox.Text = keyBinds.ElementAt(i).mouseKey.ToString() + " Mouse";
                        toggleTextBox.Text = keyBinds.ElementAt(i).mouseKey.ToString() + " Mouse";
                    }

                    if (keyBinds.ElementAt(i).bindType == BindType.REBIND)
                    {

                        if (keyBinds.ElementAt(i).secondaryType == InputType.KEYBOARD)
                        {
                            mimicTextBox.Text = keyBinds.ElementAt(i).secondKey.ToString();
                        }

                        if (keyBinds.ElementAt(i).toggleThis)
                        {
                            toggleCheckBox.CheckState = CheckState.Checked;
                            keyBinds.ElementAt(i).toggleThis = true;
                        }
                        else
                        {
                            toggleCheckBox.CheckState = CheckState.Unchecked;
                            keyBinds.ElementAt(i).toggleThis = false;
                        }

                        if (keyBinds.ElementAt(i).secondaryType == InputType.MOUSE)
                        {
                            mimicTextBox.Text = keyBinds.ElementAt(i).secMouseKey.ToString();
                        }
                    }


                    if (keyBinds.ElementAt(i).macroList.Count > 0)
                    {
                        foreach (Macro macro in keyBinds.ElementAt(i).macroList)
                        {
                            macroListBox.Items.Add(macro.timeBeforeEvent + " ticks");
                            if (macro.theMacro == EventType.KEYDOWN || macro.theMacro == EventType.KEYUP)
                            {
                                Keys key = (Keys)macro.theMacroEvent;
                                macroListBox.Items.Add(key.ToString() + " " + macro.theMacro.ToString());
                            }
                           
                        }
                    }
                }
            }
        }


        private void addMacroButton_Click(object sender, EventArgs e)
        {
            if (recording)
            {
                keyHook.Stop();
                recording = false;
                recordMacroButton.Text = "Start Recording";
            }
            else
            { 
            keyHook.Start();
            lastTime = Environment.TickCount;
            recording = true;
            recordMacroButton.Text = "Stop Recording";
                
            }
            macroListBox.Focus();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (running)
            {
                keyHook.Stop();
                running = false;
                runButton.Text = "Run macros";
                newToolStripMenuItem.Enabled = true;
                deleteBindingToolStripMenuItem.Enabled = true;

                if (boundListBox.SelectedItem != null)
                {
                    if(keyBinds.ElementAt(selectedMacro).bindType == BindType.MACRO)
                    macroPageToggle(true);

                    if (keyBinds.ElementAt(selectedMacro).bindType == BindType.REBIND)
                    mimicPageToggle(true);

                    if (keyBinds.ElementAt(selectedMacro).bindType == BindType.TOGGLE)
                    togglePageToggle(true);
                }
            }
            else
            {
                if (recording)
                {
                    recording = false;
                }

                keyHook.Start();
                running = true;
                runButton.Text = "Stop macros";
                macroPageToggle(false);
                mimicPageToggle(false);
                togglePageToggle(false);
                newToolStripMenuItem.Enabled = false;
                deleteBindingToolStripMenuItem.Enabled = false;

            }
            macroListBox.Focus();
        }

        private void mimicButton_Click(object sender, EventArgs e)
        {
            eventHookForm form = new eventHookForm();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (form.inputType == InputType.KEYBOARD)
                {
                    //create a macro for the key chosen
                    keyBinds.ElementAt(selectedMacro).secondKey = form.key.KeyCode;
                    keyBinds.ElementAt(selectedMacro).secondaryType = InputType.KEYBOARD;
                }

                if (form.inputType == InputType.MOUSE)
                {
                    keyBinds.ElementAt(selectedMacro).secMouseKey = form.mouse.Button;
                    keyBinds.ElementAt(selectedMacro).secondaryType = InputType.MOUSE;
                }
                            form.Close();
            }
            macroListBox.Focus();
            refreshMacro();
        }

        private void newMacroButton_Click(object sender, EventArgs e)
        {
            List<string> bindList = new List<string>(boundListBox.Items.Cast<string>());

            TitleSet aTitle = new TitleSet(bindList);
            DialogResult result = aTitle.ShowDialog();

            if (result == DialogResult.OK)
            {
                switch (aTitle.bindType)
                { 
                    case BindType.MACRO:
                            keyBinds.Add(new MacroBind(aTitle.title));
                            mainTabs.SelectedTab = macroPage;
                        break;

                    case BindType.REBIND:
                        keyBinds.Add(new Mimic(aTitle.title));
                        mainTabs.SelectedTab = mimicPage;

                        break;

                    case BindType.TOGGLE:
                        keyBinds.Add(new toggle(aTitle.title));
                        mainTabs.SelectedTab = togglePage;
                        break;
                }
                
                boundListBox.Items.Add(keyBinds.ElementAt(keyBinds.Count - 1).title);
                boundListBox.SelectedIndex = boundListBox.Items.Count-1;
                aTitle.Close();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            
        }
        

        private void deleteButton_Click(object sender, EventArgs e)
        {
                    int element = macroListBox.SelectedIndex / 2;

                    DialogResult confirm = MessageBox.Show("Do you really want to delete this command?",
         "Delete Command", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        keyBinds.ElementAt(selectedMacro).macroList.RemoveAt(element);
                    }
            refreshMacro();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
                    int element = macroListBox.SelectedIndex / 2;

                    Macro temp = keyBinds.ElementAt(selectedMacro).macroList.ElementAt(element);
                    EditMacro editForm = new EditMacro(temp);
                    DialogResult result = editForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        keyBinds.ElementAt(selectedMacro).macroList.ElementAt(element).theMacro = editForm.eventType;
                        keyBinds.ElementAt(selectedMacro).macroList.ElementAt(element).theMacroEvent = (int)editForm.key;
                        keyBinds.ElementAt(selectedMacro).macroList.ElementAt(element).timeBeforeEvent = editForm.time;
                    }
                    editForm.Close();
            refreshMacro();
        }

        private void macroListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            insertButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
                    int element = macroListBox.SelectedIndex / 2;

                    EditMacro editForm = new EditMacro();
                    DialogResult result = editForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        keyBinds.ElementAt(selectedMacro).macroList.Insert(element, editForm.macro);
                    }
                    editForm.Close();
            refreshMacro();
        }

        private void MacroMax_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(keyHook.IsStarted)
            {
                keyHook.Stop();
            }
        }

        private void boundListBox_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            if (!boundListBox.GetItemChecked(selectedMacro))
                    {
                        keyBinds.ElementAt(selectedMacro).useThisBinding = true;
                    }
                    else 
                    {
                        keyBinds.ElementAt(selectedMacro).useThisBinding = false;
                    }
        }

        private void toggleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (keyBinds.ElementAt(selectedMacro).toggleThis == false)
                keyBinds.ElementAt(selectedMacro).toggleThis = true;
                    else
                keyBinds.ElementAt(selectedMacro).toggleThis = false;
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            if (boundListBox.SelectedItem == null)
            {

            }
            else
            {
                eventHookForm bindForm = new eventHookForm();
                DialogResult result = bindForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (bindForm.inputType == InputType.KEYBOARD)
                    {
                        //create a toggle for the key chosen
                        keyBinds.ElementAt(selectedMacro).key = bindForm.key.KeyCode;
                        keyBinds.ElementAt(selectedMacro).startType = InputType.KEYBOARD;
                    }

                    if (bindForm.inputType == InputType.MOUSE)
                    {
                        keyBinds.ElementAt(selectedMacro).mouseKey = bindForm.mouse.Button;
                        keyBinds.ElementAt(selectedMacro).startType = InputType.MOUSE;
                    }

                    keyBinds.ElementAt(selectedMacro).eventType = bindForm.keyEvent;
                    bindForm.Close();
                    keyBinds.ElementAt(selectedMacro).toggleThis = true;
                }
                macroListBox.Focus();
                refreshMacro();
            }
        }

        private void clearStopButton_click(object sender, EventArgs e)
        {
            
        }


        private void mimicPageToggle(bool toggle)
        {
            if (toggle)
            {
                mimicButton.Enabled = true;
                mimicStart.Enabled = true;
                toggleCheckBox.Enabled = true;
            }

        if (!toggle)
        {
            mimicButton.Enabled = false;
            mimicStart.Enabled = false;
            toggleCheckBox.Enabled = false;
        }

        }

        private void deleteMacroButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you really want to delete this Binding?",
         "Delete Binding", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                boundListBox.Items.RemoveAt(selectedMacro);
                keyBinds.RemoveAt(selectedMacro);
                macroPageToggle(false);
                mimicPageToggle(false);
                togglePageToggle(false);
            }
        }

        private void showAllRadioButton_CheckedChanged(object sender, EventArgs e)
        {


            if (showAllRadioButton.Checked)
                displayBinds = BindType.ALL;

            if (showReBindRadioButton.Checked)
                displayBinds = BindType.REBIND;

            if (showToggleRadioButton.Checked)
                displayBinds = BindType.TOGGLE;

            if (ShowMacroRadioButton.Checked)
                displayBinds = BindType.MACRO;

            refreshBoundListBox();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            sL.saveBindings(keyBinds);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "max";
            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.Cancel)
                return;
            
            if(openFile.FileName == "" || openFile.FileName == null)
                MessageBox.Show("Invalid file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            keyBinds = sL.loadBindings(openFile.FileName);

            refreshBoundListBox();
            refreshMacro();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender.ToString() == "All")
            {
                showAllRadioButton.Checked = true;
                allToolStripMenuItem.Checked = true;
                togglesToolStripMenuItem.Checked = false;
                reBindsToolStripMenuItem.Checked = false;
                macrosToolStripMenuItem.Checked = false;
            }

            if (sender.ToString() == "Re-Binds")
            {
                showReBindRadioButton.Checked = true;
                allToolStripMenuItem.Checked = false;
                togglesToolStripMenuItem.Checked = false;
                reBindsToolStripMenuItem.Checked = true;
                macrosToolStripMenuItem.Checked = false;
            }

            if (sender.ToString() == "Toggles")
            {
                showToggleRadioButton.Checked = true;
                allToolStripMenuItem.Checked = false;
                togglesToolStripMenuItem.Checked = true;
                reBindsToolStripMenuItem.Checked = false;
                macrosToolStripMenuItem.Checked = false;
            }

            if (sender.ToString() == "Macros")
            {
                ShowMacroRadioButton.Checked = true;
                allToolStripMenuItem.Checked = false;
                togglesToolStripMenuItem.Checked = false;
                reBindsToolStripMenuItem.Checked = false;
                macrosToolStripMenuItem.Checked = true;
            }
        }


        

    }
}
