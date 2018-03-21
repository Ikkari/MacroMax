using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MouseKeyboardLibrary;
using System.Drawing;

namespace MacroMax
{
    public abstract class Binding
    {
        public List<Macro> macroList = new List<Macro>();
       
        //variables used to identify the binding
        public BindType bindType;
        public string title = "";  //this is used when runnign the macros to locate them and needs to be made unique
        public bool useThisBinding = false; //Used with a checkbox to stop using this spefic macro/re-bind

        //used for macros
        public Keys key;  //start key or key that gets replaced by the mimic key
        public Keys secondKey = Keys.None; //Secondary binding key used for swap or mimic

        public MouseButtons mouseKey;
        public MouseButtons secMouseKey = MouseButtons.None;

        public EventType eventType; //the eventType for the start of the macro

        //indiactes whether this is a keyboard or mouse event
        public InputType startType; 
        public InputType secondaryType;

        //used to toggle a button or macro on or off
        public bool isToggled = false;
        public bool toggleThis = false;


        public Binding(string theTitle)
        {
            title = theTitle;
        }


        public abstract void run(EventType aEvent);

        public bool checkMacro(MouseButtons e, EventType aEvent)
        {
            switch (aEvent)
            {
                case EventType.MOUSEDOWN:
                    if (e == mouseKey && useThisBinding && bindType != BindType.TOGGLE)
                        return true;
                    else
                        return false;
                case EventType.MOUSEUP:
                    if (e == mouseKey && useThisBinding)
                        return true;
                    else
                        return false;
                case EventType.MOUSEWHEEL:
                    if (e == mouseKey && useThisBinding)
                        return true;
                    else
                        return false;
                case EventType.NONE:
                    return false;

                default:
                    return false;
            }

        }
        public bool checkMacro(KeyEventArgs e, EventType aEvent)
        {

            switch (aEvent)
            {
                case EventType.KEYDOWN:
                    if (e.KeyCode == key && useThisBinding && bindType != BindType.TOGGLE)
                        return true;
                    else
                        return false;
                case EventType.KEYUP:
                    if (e.KeyCode == key && useThisBinding)
                        return true;
                    else
                        return false;
                case EventType.NONE:
                    return false;

                default:
                    return false;
            }

        }


    }//end of binding class

    [Serializable]
    public class Macro
    {
        //this clas stores the key to simulated
        //all times are in system time should be miliseconds
        public EventType theMacro;
        public int theMacroEvent;
        public int timeBeforeEvent;

        public Point location;

        public Macro(EventType type, int theEvent, int time)
        {
            theMacro = type;
            theMacroEvent = theEvent;
            timeBeforeEvent = time;
        }

        public Macro(EventType type, Point theEvent, int time)
        {
            theMacro = type;
            location = theEvent;
            timeBeforeEvent = time;
            
        }
    }

    [Serializable]
    public enum EventType
    {
        NONE,
        MOUSEMOVE,
        MOUSEDOWN,
        MOUSEUP,
        MOUSEWHEEL,
        KEYDOWN,
        KEYUP
    }

    [Serializable]
    public enum BindType
    { 
        REBIND,
        TOGGLE,
        MACRO,
        ALL
    }

    [Serializable]
    public enum InputType
    { 
        KEYBOARD,
        MOUSE
    
    }
}
