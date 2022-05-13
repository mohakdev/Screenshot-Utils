using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    [MenuItem("Screenshot Utils/Take Screenshot &INS")]
    public static void TakeScreenshot()
    {
        string Time = System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        ScreenCapture.CaptureScreenshot($"{GetSavePath()}Img-{Time}.png");
        print("Screenshot taken!");
    }
    static string GetSavePath()
    {
        string path = "Packages/com.radiantgames.screenshotutils/Images/";
        return path;
    }
}
