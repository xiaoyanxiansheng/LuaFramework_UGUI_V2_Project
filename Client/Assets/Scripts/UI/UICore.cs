using UnityEngine;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine.Analytics;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using EventTrigger = UnityEngine.EventSystems.EventTrigger;
using UnityEngine.Events;

public class UICore : MonoBehaviour {

    #region enum
    // UI 类型
    public enum UIType 
    {
        MainUI = 1,
        PopUI,
        SonUI,
    }
    // 控件类型
    public enum ComponentType
    {
        Transform,
        GameObject,
        Canvas,
        Label,
        Input,
        Button,
        Texture,
        Toggle,
        UICore,
    }

    public enum EventType
    {
        Null,
        PointerClick,
        Press,
    }
    #endregion

    #region class
    [System.Serializable]
    public class ParamEvent
    {
        public string EventCallBack;
        public EventType eventType = EventType.Null;
    }

    [System.Serializable]
    public class Param
    {
        public string name;
        public Transform transform;
        public ComponentType componentType = ComponentType.Transform;
        public List<ParamEvent> events = new List<ParamEvent>();

        public Param Clone()
        {
            return (Param)MemberwiseClone();
        }
    }

    [System.Serializable]
    public class ParamArray
    {
        public Param parent;
        public ParamArrayEle first;
    }

    [System.Serializable]
    public class ParamArrayEle
    {
        public Param root;
        public List<Param> childs;
    }

    #endregion

    #region menber
    public UIType uiType = UIType.MainUI;
    public List<Param> param = new List<Param>();
    public List<ParamArray> paramArray = new List<ParamArray>();

    public List<Param> cacheParam = new List<Param>();
    #endregion

    #region method
    public void Init(LuaTable t)
    {
        if (t == null)
        {
            Debug.LogError("InitCore is error");
            return;
        }

        for(int i =0;i< cacheParam.Count; i++)
        {
            BindingWidget(t,cacheParam[i]);
        }
    }
    public void UnInit()
    {

    }

    public void BindingWidget(LuaTable t,Param param)
    {
        string name = param.name;
        Transform trans = param.transform;
        if (trans == null)
        {
            Debug.LogError("BindingWidget transform is null : ");
            return;
        }
        GameObject go = trans.gameObject;
        ComponentType componentType = param.componentType;
        // 引用绑定
        if (componentType == ComponentType.Transform)
        {
            t[name] = trans;
        }
        else if (componentType == ComponentType.Input)
        {
            //t[name] = go.GetComponent<UIInput>();
        }
        else if (componentType == ComponentType.Label)
        {
            //t[name] = go.GetComponent<UILabel>();
        }

        // 事件绑定
        List<ParamEvent> events = param.events;
        for(int i = 0;i < events.Count; i++)
        {
            RegisterCallBack(t, events[i].EventCallBack, param.transform.gameObject, events[i].eventType);
        }

        t["uiType"] = (int)this.uiType;
    }

    public void RegisterCallBack(LuaTable t ,string luaFactionName, GameObject go ,EventType eventType)
    {
        if (luaFactionName == "")
            return;
        LuaFunction luaFunction = t.GetLuaFunction(luaFactionName);
        if (luaFunction == null)
        {
            Debug.LogError("RegisterCallBack is error " + luaFactionName);
            return;
        }

        if (eventType == EventType.PointerClick)
        {
            var eventCom = go.GetComponent<EventTrigger>();
            if (eventCom == null) eventCom = go.AddComponent<EventTrigger>();
            EventTrigger.Entry entry = new EventTrigger.Entry();
            entry.eventID = EventTriggerType.PointerClick;
            UnityAction<BaseEventData> unityAction = (BaseEventData sender) => {
                luaFunction.Call(t, sender);
            };
            entry.callback.AddListener(unityAction);
            eventCom.triggers.Add(entry);
            //UIEventListener.Get(go).onClick = (GameObject sender) => { luaFunction.Call(t,sender); };
        }
        else {
            Debug.LogError("please add new a EventType");
        }
    }

    public void BindAllWidgets()
    {
        cacheParam.Clear();

        // 清理 设置错误的情况
        for (int i = param.Count-1; i >= 0; i--)
        {
            if (param[i].transform == null) 
            {
                param.RemoveAt(i);
            }
        }

        // 缓存
        foreach (Param v in param)
        {
            cacheParam.Add(v);
        }

        foreach(ParamArray v in paramArray)
        {
            Param frist = v.first.root;
            Transform parent = v.parent.transform;
            if (parent  != null)
            {
                cacheParam.Add(v.parent);
            }
            int count = parent.childCount;
            for(int i = 0; i < count; i++)
            {
                string rootName = frist.name + (i + 1);
                string index = "00" + (i + 1);
                Transform rooTrans = parent.Find(index);
                cacheParam.Add(BindAllWidgetsHelper(frist, rootName, rooTrans));
                for(int j = 0; j < v.first.childs.Count; j++)
                {
                    Param param = v.first.childs[j];
                    string childName = rootName + "_" + param.name;
                    Transform childTrans = rooTrans.Find(param.transform.name);
                    cacheParam.Add(BindAllWidgetsHelper(param, childName, childTrans));
                }
            }
        }
    }

    public Param BindAllWidgetsHelper(Param clone,string name,Transform trans,bool isClone = true)
    {
        Param param = null;
        if (isClone)
        {
            param = clone.Clone();
        }
        else
        {
            param = clone;
        }
        param.name = name;
        param.transform = trans;
        return param;
    }
    #endregion
}
