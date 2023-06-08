using System.Runtime.InteropServices;
using System.Drawing;

namespace UnityEngine
{
    public struct CursorTools
    {
        [DllImport("user32.dll")]
        private static extern int SetCursorPos(int X, int Y);
        [DllImport("user32.dll")]
        private static extern void GetCursorPos(out Point point);
        public static void SetCursorPosition(int x, int y) => SetCursorPos(x,y);
        public static void SetCursorPosition(float x, float y) => SetCursorPos((int)x,(int)y);
        public static void SetCursorPosition(Vector2 value) => SetCursorPos((int)value.x,(int)value.y);
        public static void SetCursorPosition(Vector2Int value) => SetCursorPos(value.x,value.y);
        public static Vector2 GetCursorPosition
        {
            get
            {
                GetCursorPos(out Point p);
                return new Vector2(p.X,p.Y);
            }
        }
        public static int GetPosX
        {
            get
            {
                GetCursorPos(out Point p);
                return p.X;
            }
        }
        public static int GetPosY
        {
            get
            {
                GetCursorPos(out Point p);
                return p.Y;
            }
        }
        public static void CursorReturnMode(bool X = true,bool Y = true)
        {
            if (X)
            {
                if (GetPosX <= 0)
                {
                    SetCursorPosition(Screen.width, GetPosY);
                }
                else if (GetPosX >= Screen.width - 1)
                {
                    SetCursorPosition(0, GetPosY);
                }
            }

            if (Y)
            {
                if (GetPosY <= 0)
                {
                    SetCursorPosition(GetPosX, Screen.height);
                }
                else if (GetPosY >= Screen.height - 1)
                {
                    SetCursorPosition(GetPosX, 0);
                }
            }
        }
    }
}
