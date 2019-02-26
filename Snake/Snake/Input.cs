using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    internal class Input
    {
        private static readonly Hashtable KeyTable = new Hashtable();

        public static bool KeyPressed(Keys key)
        {
            if (KeyTable[key] == null)
            {
                return false;
            }

            return (bool)KeyTable[key];
        }

        public static void ChangeState(Keys key, bool state)
        {
            KeyTable[key] = state;
        }
    }
}