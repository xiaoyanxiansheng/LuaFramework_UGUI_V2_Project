using UnityEngine;
using UnityEditor;

public static class UITools
{
    // 将uipanel显示在最上层
    public static void SetUITop(int instanceId , GameObject root = null) 
    {
        var uipanel = ResourceUtil.GetGameObjectById(instanceId);
        if (uipanel == null) return;
        if (root == null) root = GameObjectPool.Panel_Base;
        int childs = root.transform.childCount;
        uipanel.transform.SetSiblingIndex(childs - 1);
    }
}