# Cursor Tools
 Attention! The package is under development and may change in the future!

This package will give you the ability to control the position of the cursor. (Only for Windows,Maybe there is support WebGL)
# Installation:
Copy and paste in Package Manager:
~~~
https://github.com/ARtronClassicStudio/Cursor-Tools.git
~~~

# Use:

~~~C#
using UnityEngine;

public class Sample : MonoBehaviour
{
    private void Update()
    {
        CursorTools.CursorReturnMode();
    }
}
~~~

![gif](https://github.com/ARtronClassicStudio/Cursor-Tools/assets/68843488/19db1a38-bb50-4636-b788-3934ae2a2ccf)

You can also disable the x or y axis:

~~~C#
using UnityEngine;

public class Sample : MonoBehaviour
{
    private void Update()
    {
        CursorTools.CursorReturnMode(true,false);
    }
}
~~~
You can also set the cursor position:
~~~C#
using UnityEngine;

public class Sample : MonoBehaviour
{

    public Vector2 pose;

    private void Start()
    {
        CursorTools.SetCursorPosition(pose);
    }
}
~~~
Note that the method has 4 overloads:
~~~C#
SetCursorPosition(int x, int y);
SetCursorPosition(float x, float y);
SetCursorPosition(Vector2 value);
SetCursorPosition(Vector2Int value);
~~~
Getting the cursor position:
~~~C#
using UnityEngine;

public class Sample : MonoBehaviour
{

    public Vector2 pose;

    private void Start()
    {
        pose = CursorTools.GetCursorPosition;
    }
}
~~~
Note that GetCursorPosition is almost the same as Input.mousePosition except that this function directly gets from the library User32.dll

You can also use GetPosX or GetPosY separately for some other tasks.
~~~C#
using UnityEngine;

public class Sample : MonoBehaviour
{

    public int x;
    public int y;

    private void Start()
    {
       x = CursorTools.GetPosX;
       y = CursorTools.GetPosY;
        
    }
}
~~~
