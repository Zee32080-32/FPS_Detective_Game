using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
public class RecordStats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Directory.CreateDirectory(Application.streamingAssetsPath + "/Collectible/");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void AddRecord(string Name, string PlayerNamer, string FilePath)
    {

        try
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(FilePath, true))
            {
                file.WriteLine("Object Collected: " + Name + " , " + "User Name: " + PlayerNamer);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Exception", ex);
        }
        
    }




}
