using UnityEngine;

public static class PathDefines
{
    public static string S_ProjectPath = Application.dataPath.Replace("Client/Assets", ""); // 项目根路径
    public static string S_ProjectClientPath = S_ProjectPath + "Client/";                   // 项目Client路径
    public static string S_ProjectDataPath = S_ProjectPath + "Data/";                       // 项目Data路径
}
