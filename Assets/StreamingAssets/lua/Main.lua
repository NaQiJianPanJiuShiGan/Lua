--主入口函数。从这里开始lua逻辑
function Main()					
	 	-- luahelper = luaframework.luahelper
	 	-- resmgr = luahelper.getresmanager()
	 	-- resmgr:loadprefab('box',{'box'},onloadfinish)
		LuaFramework.Util.Log("等待更新")
		local go = UnityEngine.GameObject('go')
		go.transform.position = Vector3.one
end

function  OnLoadFinish( objs )
	local go = UnityEngine.GameObject.Instantiate(objs[0])
	go.transform.position = Vector3.one
	LuaFramework.Util.Log('更新成功')
end
--场景切换通知
function OnLevelWasLoaded(level)

end