using System.Runtime.InteropServices;
using UnityEngine;

public class Open_Links : MonoBehaviour
{
    public static void OpenUrl(string Url)
    {
#if !UNITY_EDITOR && UNITY_WEBGL
    OpenTab(Url);
#endif
    }

    [DllImport("__Internal")]
    private static extern void OpenTab(string url);
    // Start is called before the first frame update

}
