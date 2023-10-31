using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class FileDownload : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void downloadToFile(string PlayerName, string Description, string filename);
    [DllImport("__Internal")]
    private static extern void downloadNotes(string LeftPage, string RightPage, string filename);

    public static void DownloadToFile(string PlayerName, string Description, string filename)
    {
        downloadToFile(PlayerName + " Collected ",   Description, "Evidence_Collected.txt");
        Debug.Log("Method has been called");

    }

    public static void DownloadNotes(string LeftPage, string RightPage, string filename)
    {
        downloadToFile(LeftPage , RightPage, "NOTES.txt");
        Debug.Log("Method has been called");

    }


}
