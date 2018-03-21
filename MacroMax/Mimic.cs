using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MouseKeyboardLibrary;

namespace MacroMax
{
    [Serializable]
    class Mimic : Binding
    {

        public Mimic(string theTitle) : base(theTitle)
        {
            bindType = BindType.REBIND;
        }

        public Mimic(string p, EventType eventType, int p_2, int p_3, int p_4, int p_5, List<Macro> list, InputType inputType, InputType inputType_2,bool p_6, bool p_7)
            : base(p)
        {
            title = p;
            this.eventType = eventType;
            key = (Keys)p_2;
            mouseKey = (MouseButtons)p_3;
            secondKey = (Keys)p_4;
            secMouseKey = (MouseButtons)p_5;
            macroList = list;
            startType = inputType;
            secondaryType = inputType_2;
            toggleThis = p_6;
            useThisBinding = p_7;

            bindType = BindType.REBIND;
        }

        public override void run(EventType aEvent)
        {

             //place this in the mimic class
           
               // if (secondaryType == InputType.KEYBOARD)
                    mimic(aEvent);
               // else
                 //   mimicMouse(aEvent);

                return;
            
           
        }

        private void mimic(EventType aEvent)
        {
            if (toggleThis)
            {

                if (isToggled)
                {
                    
                    KeyboardSimulator.KeyUp(secondKey);
                }
                else
                {
                    KeyboardSimulator.KeyDown(secondKey);
                }

                isToggled = isToggled ? false : true;

            }
            
            if(!toggleThis)
            {
                if (aEvent == EventType.KEYDOWN || aEvent == EventType.MOUSEDOWN)
                {
                    KeyboardSimulator.KeyDown(secondKey);
                }

                if (aEvent == EventType.KEYUP || aEvent == EventType.MOUSEUP)
                {
                    KeyboardSimulator.KeyUp(secondKey);
                }
            }
        }

        private void mimicMouse(EventType aEvent)
        {

            if (toggleThis && (aEvent == EventType.KEYUP || aEvent == EventType.MOUSEUP))
            {

                if (isToggled)
                {
                    MouseSimulator.MouseUp(convertMouseButton(secMouseKey));
                }
                else
                {
                    MouseSimulator.MouseDown(convertMouseButton(secMouseKey));
                }

                isToggled = isToggled ? false : true;

            }
            

            if(!toggleThis){
                if (aEvent == EventType.MOUSEDOWN || aEvent == EventType.KEYDOWN)
                {
                    MouseSimulator.MouseDown(convertMouseButton(secMouseKey));
                }

                if (aEvent == EventType.KEYUP || aEvent == EventType.MOUSEUP)
                {
                    MouseSimulator.MouseUp(convertMouseButton(secMouseKey));
                }
            }
        }



        private MouseButton convertMouseButton(MouseButtons button)
        {
            switch (button)
            {
                case MouseButtons.Left:
                    return MouseButton.Left;

                case MouseButtons.Right:
                    return MouseButton.Right;

                case MouseButtons.Middle:
                    return MouseButton.Middle;

                default:
                    return 0;
            }
        }


    }
}
