using UnityEngine;
using System.Collections;
using LuaInterface;
using UnityEngine.UI;

public class UIEvent {

	public static void AddButtonClick(GameObject go,LuaFunction fun)
    {
        if (go==null||fun==null)
        {
            return;
        }
        Button btn = go.GetComponent<Button>();
        if (btn==null)
        {
            return;
        }
        btn.onClick.AddListener(delegate () { fun.Call(go); });
    }

    public static void ClearButtonClick(GameObject go,LuaFunction fun)
    {
        if (go == null || fun == null)
        {
            return;
        }
        Button btn = go.GetComponent<Button>();
        if (btn == null)
        {
            return;
        }
        btn.onClick.RemoveAllListeners();
    }
}
