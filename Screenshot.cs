using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    readonly static string FolderName = "Screenshots";

    [MenuItem("Screenshot Utils/Take Screenshot &INS")]
    private static void TakeScreenshot()
    {
        MakeImageFolder();
        ScreenCapture.CaptureScreenshot(GetPath() +"/"+ GetImageName());
        PrintCompletedLine();
    }
    //--------------------------------------
    /// <summary>
    /// Captures a ScreenShot
    /// </summary>
    public static void CaptureScreenshot()
    {
        MakeImageFolder(); 
        ScreenCapture.CaptureScreenshot(GetPath() + "/" + GetImageName());
        PrintCompletedLine();
    }
    //--------------------------------------
    /// <summary>
    /// Captures a ScreenShot
    /// </summary>
    /// <param name="UserPath">Location of the File for Example "Assets/MyFolder/" </param>
    public static void CaptureScreenshot(string UserPath)
    {
        ScreenCapture.CaptureScreenshot(UserPath + "/" + GetImageName());
        PrintCompletedLine();
    }

    static string GetPath()
    {
        string path = Path.Combine(Application.dataPath, $"../{FolderName}");
        return Path.GetFullPath(path);
    }
    /// <summary>
    /// Makes the folder where all screenshots are saved. If that folder already exists then it simply exits and does noting at all
    /// </summary>
    static void MakeImageFolder()
    {
        if (Directory.Exists(GetPath())) { return; }
        Directory.CreateDirectory(GetPath());
    }
    static string GetImageName()
    {
        int TakeNo = PlayerPrefs.GetInt("ScreenshotTakeNo", 100);
        PlayerPrefs.SetInt("ScreenshotTakeNo", TakeNo + 1);
        return $"Image-{TakeNo}.png";
    }
    static void PrintCompletedLine()
    {
        //This method is just used to show that screenshot is taken successfully
        Debug.Log($"ScreenShot Taken!");
    }
}