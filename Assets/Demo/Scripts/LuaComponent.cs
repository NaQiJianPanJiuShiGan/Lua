using UnityEngine;
using System.Collections;
using LuaFramework;
using LuaInterface;

public class LuaComponent : MonoBehaviour {

    LuaTable luaTable = null;


    /// <summary>
    /// 添加Lua组件，调用参数中lua表的New方法，将其返回的表赋予table
    /// </summary>
    /// <param name="go">待添加的游戏对象</param>
    /// <param name="luaclass">待添加的lua表</param>
    /// <returns></returns>
    public static LuaTable ADD(GameObject go,LuaTable luaclass)
    {
        LuaFunction table = luaclass.GetLuaFunction("New");//通过._index元表返回表
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
    /// <summary>
    /// 获取游戏对象上的lua表，
    /// </summary>
    /// <param name="go">游戏对象</param>
    /// <param name="table">要获取的表</param>
    /// <returns></returns>
    public static LuaTable Get(GameObject go, LuaTable table)
    {
        LuaComponent[] cmps = go.GetComponents<LuaComponent>();//得到go上的所有lua组件
        for (int i = 0; i < cmps.Length; i++)
        {
            string mat1 = table.ToString();
            string mat2 = cmps[i].luaTable.GetMetaTable().ToString();//通过元表地址找到对应的luacomponent
            if (mat1==mat2)
            {
                return cmps[i].luaTable;//找到与查找组件名字相同的lua组件返回
            }
        }
        return null;
    }

    void CallAwake()
    {
        LuaFunction fun = luaTable.GetLuaFunction("Awake");//得到表中的方法
        if (fun!=null)
        {
            fun.Call(luaTable,gameObject);
        }
    }
	// Use this for initialization
	void Start () {
        LuaFunction fun = luaTable.GetLuaFunction("Start");
        if (fun!=null)
        {
            fun.Call(luaTable,gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {    
        //效率问题待优化
        LuaFunction fun = luaTable.GetLuaFunction("Update");
        if (fun!=null)
        {
            fun.Call(luaTable,gameObject);
        }
        
	}
}
