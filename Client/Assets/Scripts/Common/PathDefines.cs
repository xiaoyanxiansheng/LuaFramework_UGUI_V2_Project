using UnityEngine;

public static class PathDefines
{
    public static string S_ProjectPath = Application.dataPath.Replace("Client/Assets", "");     // 项目根路径
    public static string S_ProjectClientPath = S_ProjectPath + "Client/";                       // 项目Client路径
    public static string S_ProjectDataPath = S_ProjectPath + "Data/";                           // 项目Data路径
    public static string S_BundleRootInAssetPath = "AssetBundles/";
    public static string S_BundleRootPath = Application.dataPath + "/" + S_BundleRootInAssetPath;        // AssetBundle资源地址
    public static string S_BundleExportInAssetPath = "ExportBundles/";
    public static string S_BundleExportPath = Application.dataPath + "/" + S_BundleExportInAssetPath;    // 导出资源地址
}
