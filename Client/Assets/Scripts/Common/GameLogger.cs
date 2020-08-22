using UnityEngine;
using System.Collections;

public class GameLogger {


    public static void LogError(string s , params string[] args)
    {

        if (args != null && args.Length > 0) 
        {
            foreach (string tempa in args) 
            {
                s += tempa;
            }
        }

        Debug.LogError(s);
    }
    public static void LogInfo(string s)
    {
        Debug.Log(s);
    }
    public static void LogWarning(string s)
    {
        Debug.LogWarning(s);
    }

}
