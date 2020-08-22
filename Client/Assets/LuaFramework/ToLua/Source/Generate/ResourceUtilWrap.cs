﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ResourceUtilWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ResourceUtil), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("GetRequestId", GetRequestId);
		L.RegFunction("CreateAssetBundleAsync", CreateAssetBundleAsync);
		L.RegFunction("CancelLoadBundleAsync", CancelLoadBundleAsync);
		L.RegFunction("DestoryAssetBundle", DestoryAssetBundle);
		L.RegFunction("CreateAssetAsync", CreateAssetAsync);
		L.RegFunction("CancelCreateAssetAsync", CancelCreateAssetAsync);
		L.RegFunction("DestoryAsset", DestoryAsset);
		L.RegFunction("CreateGameObjectAsync", CreateGameObjectAsync);
		L.RegFunction("CancelCreateGameObjectAsync", CancelCreateGameObjectAsync);
		L.RegFunction("DestoryGameObject", DestoryGameObject);
		L.RegFunction("GetGameObjectById", GetGameObjectById);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("isLog", get_isLog, set_isLog);
		L.RegVar("requestId", get_requestId, set_requestId);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRequestId(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			int o = ResourceUtil.GetRequestId();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateAssetBundleAsync(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			RequestLoadBundle.OnCreateAssetBundle arg1 = (RequestLoadBundle.OnCreateAssetBundle)ToLua.CheckDelegate<RequestLoadBundle.OnCreateAssetBundle>(L, 2);
			int o = ResourceUtil.CreateAssetBundleAsync(arg0, arg1);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CancelLoadBundleAsync(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			ResourceUtil.CancelLoadBundleAsync(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestoryAssetBundle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			ResourceUtil.DestoryAssetBundle(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateAssetAsync(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			RequestLoadAsset.OnLoadAsset arg1 = (RequestLoadAsset.OnLoadAsset)ToLua.CheckDelegate<RequestLoadAsset.OnLoadAsset>(L, 2);
			int o = ResourceUtil.CreateAssetAsync(arg0, arg1);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CancelCreateAssetAsync(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			ResourceUtil.CancelCreateAssetAsync(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestoryAsset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			ResourceUtil.DestoryAsset(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateGameObjectAsync(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			GameObjectPool.OnCreateGameObject arg2 = (GameObjectPool.OnCreateGameObject)ToLua.CheckDelegate<GameObjectPool.OnCreateGameObject>(L, 3);
			int o = ResourceUtil.CreateGameObjectAsync(arg0, arg1, arg2);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CancelCreateGameObjectAsync(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			ResourceUtil.CancelCreateGameObjectAsync(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestoryGameObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			ResourceUtil.DestoryGameObject(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGameObjectById(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.GameObject o = ResourceUtil.GetGameObjectById(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isLog(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, ResourceUtil.isLog);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_requestId(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, ResourceUtil.requestId);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isLog(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			ResourceUtil.isLog = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_requestId(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			ResourceUtil.requestId = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

