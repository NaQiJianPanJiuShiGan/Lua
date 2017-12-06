using UnityEngine;
using System.Collections;
using LuaFramework;
using LuaInterface;

public class LuaComponent : MonoBehaviour {

    LuaTable luaTable = null;

    public static LuaTable ADD(GameObject go,LuaTable luaclass)
    {
        LuaFunction table = luaclass.GetLuaFunction("NEW");//通过._index元表返回表
        if (table==null)
        {
            return null;
        }
        object[] rets = table.Call(luaclass);
        if (rets.Length!=1)
        {
            return null;
        }
        LuaComponent lcp = go.AddComponent<LuaComponent>();
        lcp.luaTable = (LuaTable)rets[0];
        lcp.CallAwake();
        return lcp.luaTable;
    }

    void CallAwake()
    {

    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
