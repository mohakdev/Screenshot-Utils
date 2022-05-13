using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    readonly static string Path = "Packages/com.radiantgames.screenshotutils/Images/";
    readonly static string Time = System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
    readonly static string ImageName = $"Img_{Time}.png";

    [MenuItem("Screenshot Utils/Take Screenshot &INS")]
    private static void TakeScreenshot()
    {
        ScreenCapture.CaptureScreenshot(Path + ImageName);
        PrintCompletedLine();
    }
    //--------------------------------------
    /// <summary>
    /// Captures a ScreenShot
    /// </summary>
    public static void CaptureScreenshot()
    {
        //This method is same as TakeScreenshot but its public so other scripts could access it.
        ScreenCapture.CaptureScreenshot(Path + ImageName);
        PrintCompletedLine();
    }
    //--------------------------------------
    /// <summary>
    /// Captures a ScreenShot
    /// </summary>
    /// <param name="UserPath">Location of the File for Example "Assets/MyFolder/" </param>
    public static void CaptureScreenshot(string UserPath)
    {
        ScreenCapture.CaptureScreenshot(UserPath + "/" + ImageName);
        PrintCompletedLine();
    }


    static void PrintCompletedLine()
    {
        //This method is just used to show that screenshot is taken successfully
        Debug.Log("ScreenShot Taken!");
    }
}
