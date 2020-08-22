﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class GameLoggerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(GameLogger), typeof(System.Object));
		L.RegFunction("LogError", LogError);
		L.RegFunction("LogInfo", LogInfo);
		L.RegFunction("LogWarning", LogWarning);
		L.RegFunction("New", _CreateGameLogger);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateGameLogger(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				GameLogger obj = new GameLogger();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: GameLogger.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogError(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			string arg0 = ToLua.CheckString(L, 1);
			string[] arg1 = ToLua.CheckParamsString(L, 2, count - 1);
			GameLogger.LogError(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogInfo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			GameLogger.LogInfo(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogWarning(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			GameLogger.LogWarning(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
