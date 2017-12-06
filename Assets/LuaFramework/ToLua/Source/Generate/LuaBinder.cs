﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using UnityEngine;
using LuaInterface;

public static class LuaBinder
{
	public static void Bind(LuaState L)
	{
		float t = Time.realtimeSinceStartup;
		L.BeginModule(null);
		DebuggerWrap.Register(L);
		TestLogWrap.Register(L);
		ViewWrap.Register(L);
		BaseWrap.Register(L);
		ManagerWrap.Register(L);
		L.BeginModule("UnityEngine");
		UnityEngine_ComponentWrap.Register(L);
		UnityEngine_BehaviourWrap.Register(L);
		UnityEngine_MonoBehaviourWrap.Register(L);
		UnityEngine_GameObjectWrap.Register(L);
		UnityEngine_TransformWrap.Register(L);
		UnityEngine_TrackedReferenceWrap.Register(L);
		UnityEngine_ApplicationWrap.Register(L);
		UnityEngine_PhysicsWrap.Register(L);
		UnityEngine_ColliderWrap.Register(L);
		UnityEngine_TimeWrap.Register(L);
		UnityEngine_TextureWrap.Register(L);
		UnityEngine_Texture2DWrap.Register(L);
		UnityEngine_ShaderWrap.Register(L);
		UnityEngine_MaterialWrap.Register(L);
		UnityEngine_RendererWrap.Register(L);
		UnityEngine_WWWWrap.Register(L);
		UnityEngine_ScreenWrap.Register(L);
		UnityEngine_CameraWrap.Register(L);
		UnityEngine_CameraClearFlagsWrap.Register(L);
		UnityEngine_AudioClipWrap.Register(L);
		UnityEngine_AudioSourceWrap.Register(L);
		UnityEngine_AssetBundleWrap.Register(L);
		UnityEngine_ParticleSystemWrap.Register(L);
		UnityEngine_AsyncOperationWrap.Register(L);
		UnityEngine_LightWrap.Register(L);
		UnityEngine_LightTypeWrap.Register(L);
		UnityEngine_SleepTimeoutWrap.Register(L);
		UnityEngine_AnimatorWrap.Register(L);
		UnityEngine_InputWrap.Register(L);
		UnityEngine_KeyCodeWrap.Register(L);
		UnityEngine_SkinnedMeshRendererWrap.Register(L);
		UnityEngine_SpaceWrap.Register(L);
		UnityEngine_AnimationBlendModeWrap.Register(L);
		UnityEngine_QueueModeWrap.Register(L);
		UnityEngine_PlayModeWrap.Register(L);
		UnityEngine_WrapModeWrap.Register(L);
		UnityEngine_QualitySettingsWrap.Register(L);
		UnityEngine_RenderSettingsWrap.Register(L);
		UnityEngine_RectTransformWrap.Register(L);
		L.BeginModule("UI");
		UnityEngine_UI_TextWrap.Register(L);
		L.EndModule();
		L.BeginModule("Experimental");
		L.BeginModule("Director");
		UnityEngine_Experimental_Director_DirectorPlayerWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("Events");
		L.RegFunction("UnityAction", UnityEngine_Events_UnityAction);
		L.EndModule();
		L.EndModule();
		L.BeginModule("LuaFramework");
		LuaFramework_UtilWrap.Register(L);
		LuaFramework_AppConstWrap.Register(L);
		LuaFramework_LuaHelperWrap.Register(L);
		LuaFramework_ByteBufferWrap.Register(L);
		LuaFramework_LuaBehaviourWrap.Register(L);
		LuaFramework_GameManagerWrap.Register(L);
		LuaFramework_LuaManagerWrap.Register(L);
		LuaFramework_PanelManagerWrap.Register(L);
		LuaFramework_SoundManagerWrap.Register(L);
		LuaFramework_TimerManagerWrap.Register(L);
		LuaFramework_ThreadManagerWrap.Register(L);
		LuaFramework_NetworkManagerWrap.Register(L);
		LuaFramework_ResourceManagerWrap.Register(L);
		L.EndModule();
		L.BeginModule("System");
		L.RegFunction("Action", System_Action);
		L.RegFunction("Action_NotiData", System_Action_NotiData);
		L.RegFunction("Action_UnityEngine_Objects", System_Action_UnityEngine_Objects);
		L.EndModule();
		L.EndModule();
		L.BeginPreLoad();
		L.AddPreLoad("UnityEngine.MeshRenderer", LuaOpen_UnityEngine_MeshRenderer, typeof(UnityEngine.MeshRenderer));
		L.AddPreLoad("UnityEngine.ParticleEmitter", LuaOpen_UnityEngine_ParticleEmitter, typeof(UnityEngine.ParticleEmitter));
		L.AddPreLoad("UnityEngine.ParticleRenderer", LuaOpen_UnityEngine_ParticleRenderer, typeof(UnityEngine.ParticleRenderer));
		L.AddPreLoad("UnityEngine.ParticleAnimator", LuaOpen_UnityEngine_ParticleAnimator, typeof(UnityEngine.ParticleAnimator));
		L.AddPreLoad("UnityEngine.BoxCollider", LuaOpen_UnityEngine_BoxCollider, typeof(UnityEngine.BoxCollider));
		L.AddPreLoad("UnityEngine.MeshCollider", LuaOpen_UnityEngine_MeshCollider, typeof(UnityEngine.MeshCollider));
		L.AddPreLoad("UnityEngine.SphereCollider", LuaOpen_UnityEngine_SphereCollider, typeof(UnityEngine.SphereCollider));
		L.AddPreLoad("UnityEngine.CharacterController", LuaOpen_UnityEngine_CharacterController, typeof(UnityEngine.CharacterController));
		L.AddPreLoad("UnityEngine.CapsuleCollider", LuaOpen_UnityEngine_CapsuleCollider, typeof(UnityEngine.CapsuleCollider));
		L.AddPreLoad("UnityEngine.Animation", LuaOpen_UnityEngine_Animation, typeof(UnityEngine.Animation));
		L.AddPreLoad("UnityEngine.AnimationClip", LuaOpen_UnityEngine_AnimationClip, typeof(UnityEngine.AnimationClip));
		L.AddPreLoad("UnityEngine.AnimationState", LuaOpen_UnityEngine_AnimationState, typeof(UnityEngine.AnimationState));
		L.AddPreLoad("UnityEngine.BlendWeights", LuaOpen_UnityEngine_BlendWeights, typeof(UnityEngine.BlendWeights));
		L.AddPreLoad("UnityEngine.RenderTexture", LuaOpen_UnityEngine_RenderTexture, typeof(UnityEngine.RenderTexture));
		L.AddPreLoad("UnityEngine.Rigidbody", LuaOpen_UnityEngine_Rigidbody, typeof(UnityEngine.Rigidbody));
		L.EndPreLoad();
		Debugger.Log("Register lua type cost time: {0}", Time.realtimeSinceStartup - t);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_NotiData(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<NotiData>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_UnityEngine_Objects(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.Object[]>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_MeshRenderer(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_MeshRendererWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_ParticleEmitter(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_ParticleEmitterWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_ParticleRenderer(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_ParticleRendererWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_ParticleAnimator(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_ParticleAnimatorWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_BoxCollider(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_BoxColliderWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_MeshCollider(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_MeshColliderWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_SphereCollider(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_SphereColliderWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_CharacterController(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_CharacterControllerWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_CapsuleCollider(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_CapsuleColliderWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_Animation(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_AnimationWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_AnimationClip(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_AnimationClipWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_AnimationState(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_AnimationStateWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_BlendWeights(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_BlendWeightsWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_RenderTexture(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_RenderTextureWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_Rigidbody(IntPtr L)
	{
		try
		{
			int top = LuaDLL.lua_gettop(L);
			LuaState state = LuaState.Get(L);
			int preTop = state.BeginPreModule("UnityEngine");
			UnityEngine_RigidbodyWrap.Register(state);
			state.EndPreModule(preTop);
			LuaDLL.lua_settop(L, top);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

