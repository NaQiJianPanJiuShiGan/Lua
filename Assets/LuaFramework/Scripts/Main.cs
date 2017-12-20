using UnityEngine;
using System.Collections;
using LuaInterface;

namespace LuaFramework {

    /// <summary>
    /// </summary>
    public class Main : MonoBehaviour {

        void Start() {
            AppFacade.Instance.StartUp();   //启动游戏
            //LuaState lua = new LuaState();
            //LuaBinder.Bind(lua);

            //string str = @" print('lua打印')
            //LuaFramework.Util.Log('C#工具打印')
            //Debugger.Log('C#中日志系统打印');
            //TestLog.Log();
            //";
            //lua.DoString(str);

        }
    }
}