using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefiningElaborateHotkeys
{
    public class Keyboard
    {
        [DllImport("user32.dll")]
        private static extern short GetKeyState(Keys nVirtKey);

        public static bool IsKeyPressed(Keys testKey)
        {
            short result = GetKeyState(testKey);

            switch(result)
            {
                case 0:
                    // Not pressed and not toggled on.
                    return false;

                case 1:
                    // Not pressed, but toggled on
                    return false;

                default: 
                    // Pressed (and may be toggled on)
                    return true;
            }
        }
    }
}
