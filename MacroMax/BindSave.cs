using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacroMax
{
    [Serializable]
    class BindSave
    {
        public List<Macro> macroList = new List<Macro>();

        //variables used to identify the binding
        public BindType bindType;
        public string title;  //this is used when runnign the macros to locate them and needs to be made unique
        public bool useThisBinding = false; //Used with a checkbox to stop using this spefic macro/re-bind

        //used for macros
        public int key;  //start key or key that gets replaced by the mimic key
        public int secondKey; //Secondary binding key used for swap or mimic

        public int mouseKey;
        public int secMouseKey;

        public EventType eventType; //the eventType for the start of the macro

        //indiactes whether this is a keyboard or mouse event
        public InputType startType;
        public InputType secondaryType;

        //used to toggle a button or macro on or off
        public bool toggleThis = false;
        

        public BindSave(List<Macro> list, System.Windows.Forms.Keys keys, System.Windows.Forms.MouseButtons mouseButtons, System.Windows.Forms.Keys keys_2, System.Windows.Forms.MouseButtons mouseButtons_2, InputType inputType, InputType inputType_2, BindType bindType_2, EventType eventType_2, string p, bool p_2, bool p_3)
        {
            macroList = list;
            key = (int)keys;
            mouseKey = (int)mouseButtons;
            secondKey = (int)keys_2;
            secMouseKey = (int)mouseButtons_2;
            startType = inputType;
            secondaryType = inputType_2;
            bindType = bindType_2;
            eventType = eventType_2;
            title = p;
            toggleThis = p_2;
            useThisBinding = p_3;
        }
    }
}
