using System;
using MonoBrickFirmware.Display;

namespace MonoBrickUtils
{
    public static class Ev3Console
    {
        private static readonly Font font = Font.SmallFont;
        private static readonly int lineHeight = (int)font.maxHeight;
        private static readonly string[] buffer = new string[Lcd.Height / lineHeight];
        private static int line;

        public static void WriteLine(object o)
        {
            WriteLine(o == null ? "" : o.ToString());
        }

        public static void WriteLine(string text) 
        {
            if (line < buffer.Length)
            {
                buffer[line++] = text;
            }
            else
            {
                for (var i = 0; i < buffer.Length - 1; i++)
                {
                    buffer[i] = buffer[i + 1];
                }
                buffer[buffer.Length - 1] = text;
            }

            Render();
        }

        private static void Render() 
        {
            Lcd.Clear();
            for (var i = 0; i <= Math.Min(buffer.Length, line - 1); i++)
            {
                Lcd.WriteText(font, new Point(0, lineHeight * i), buffer[i], true);
            }
            Lcd.Update();
        }
    }
}

