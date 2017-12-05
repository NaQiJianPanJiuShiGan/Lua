﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_TextureWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Texture), typeof(UnityEngine.Object));
		L.RegFunction("SetGlobalAnisotropicFilteringLimits", SetGlobalAnisotropicFilteringLimits);
		L.RegFunction("GetNativeTexturePtr", GetNativeTexturePtr);
		L.RegFunction("New", _CreateUnityEngine_Texture);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("masterTextureLimit", get_masterTextureLimit, set_masterTextureLimit);
		L.RegVar("anisotropicFiltering", get_anisotropicFiltering, set_anisotropicFiltering);
		L.RegVar("width", get_width, set_width);
		L.RegVar("height", get_height, set_height);
		L.RegVar("filterMode", get_filterMode, set_filterMode);
		L.RegVar("anisoLevel", get_anisoLevel, set_anisoLevel);
		L.RegVar("wrapMode", get_wrapMode, set_wrapMode);
		L.RegVar("mipMapBias", get_mipMapBias, set_mipMapBias);
		L.RegVar("texelSize", get_texelSize, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Texture(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Texture obj = new UnityEngine.Texture();
				ToLua.Push(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Texture.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalAnisotropicFilteringLimits(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Texture.SetGlobalAnisotropicFilteringLimits(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNativeTexturePtr(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture));
			System.IntPtr o = obj.GetNativeTexturePtr();
			LuaDLL.lua_pushlightuserdata(L, o);
			return 1;
		}
		catch(Exception e)
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
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_masterTextureLimit(IntPtr L)
	{
		LuaDLL.lua_pushinteger(L, UnityEngine.Texture.masterTextureLimit);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anisotropicFiltering(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Texture.anisotropicFiltering);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_width(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			int ret = obj.width;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index width on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			int ret = obj.height;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index height on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_filterMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.FilterMode ret = obj.filterMode;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index filterMode on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anisoLevel(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			int ret = obj.anisoLevel;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index anisoLevel on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_wrapMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.TextureWrapMode ret = obj.wrapMode;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index wrapMode on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mipMapBias(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			float ret = obj.mipMapBias;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mipMapBias on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_texelSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.Vector2 ret = obj.texelSize;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index texelSize on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_masterTextureLimit(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Texture.masterTextureLimit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_anisotropicFiltering(IntPtr L)
	{
		try
		{
			UnityEngine.AnisotropicFiltering arg0 = (UnityEngine.AnisotropicFiltering)ToLua.CheckObject(L, 2, typeof(UnityEngine.AnisotropicFiltering));
			UnityEngine.Texture.anisotropicFiltering = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_width(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.width = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index width on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.height = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index height on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_filterMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.FilterMode arg0 = (UnityEngine.FilterMode)ToLua.CheckObject(L, 2, typeof(UnityEngine.FilterMode));
			obj.filterMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index filterMode on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_anisoLevel(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.anisoLevel = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index anisoLevel on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_wrapMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			UnityEngine.TextureWrapMode arg0 = (UnityEngine.TextureWrapMode)ToLua.CheckObject(L, 2, typeof(UnityEngine.TextureWrapMode));
			obj.wrapMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index wrapMode on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mipMapBias(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture obj = (UnityEngine.Texture)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mipMapBias = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mipMapBias on a nil value" : e.Message);
		}
	}
}

