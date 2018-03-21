using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MouseKeyboardLibrary;

namespace MacroMax
{
    public partial class eventHookForm : Form
    {
        MouseHook mouseHook = new MouseHook();
        KeyboardHook keyHook = new KeyboardHook();
        public bool useMouse = false;
        private bool getMouse = true;

        public InputType inputType = InputType.KEYBOARD;
        public KeyEventArgs key;
        public MouseEventArgs mouse = new MouseEventArgs(MouseButtons.None, 0, 0, 0, 0);
        
        public EventType keyEvent = EventType.KEYDOWN;


        public eventHookForm()
        {
            InitializeComponent();
        }

        public eventHookForm(int noMouse)
        {
            InitializeComponent();
            getMouse = false;
        }

        private void eventHookForm_Load(object sender, EventArgs e)
        {
            if (getMouse)
            {
                mouseHook.MouseDown += mouseHook_MouseDown;
                mouseHook.MouseWheel += mouseHook_MouseWheel;
            }

            keyHook.KeyDown += keyHook_KeyDown;
            keyHook.Start();
        }

        private void mouseHook_MouseWheel(object sender, MouseEventArgs e)
        {
            mouse = e;
            okButton.Enabled = true;
            setLabels();
        }

        private void mouseHook_MouseDown(object sender, MouseEventArgs e)
        {   
            
            mouse = e;
            okButton.Enabled = true;
            setLabels();
        }

        void keyHook_KeyDown(object sender, KeyEventArgs e)
        {
           key = e;
           okButton.Enabled = true;
           setLabels();
        }

        private void setLabels()
        {
            if (key != null && !useMouse)
            {
                inputType = InputType.KEYBOARD;
                keyPressedLabel.Text = key.KeyCode.ToString();
            }

            if (mouse.Button != MouseButtons.None && useMouse)
            {
                inputType = InputType.MOUSE;
                keyPressedLabel.Text = mouse.Button.ToString();
            }

        }

        private void eventHookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            keyHook.Stop();
            mouseHook.Stop();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(key != null || mouse.Button != MouseButtons.None)
            this.DialogResult = DialogResult.OK;
        }


        

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keyDownRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            keyEvent = EventType.KEYDOWN;
        }

        private void keyUpRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            keyEvent = EventType.KEYUP;
        }

    }
}
