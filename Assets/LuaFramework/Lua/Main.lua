--主入口函数。从这里开始lua逻辑
local go
function Main()					
	 	LuaHelper = LuaFramework.LuaHelper
	 	resmgr = LuaHelper.GetResManager()
	 	resmgr:LoadPrefab('box',{'box'},OnLoadFinish)
		
		-- LuaFramework.Util.Log("等待更新")
		-- local go = UnityEngine.GameObject('go')
		-- go.transform.position = Vector3.one
		TestLog.Log();
		Debugger.Log("日志系统打印")

end

function Update()
	LuaFramework.Util.Log("每帧执行一次")
	
	local Input = UnityEngine.Input
	local horizontal = Input.GetAxis("Horizontal") 
	local verticla = Input.GetAxis("Vertical")
	
	local x = go.transform.position.x+horizontal;
	local z = go.transform.position.z+verticla
	go.transform.position = Vector3.New(x,0,z)
end

function  OnLoadFinish( objs )
	go = UnityEngine.GameObject.Instantiate(objs[0])
	go.transform.position = Vector3.one
	LuaFramework.Util.Log('更新成功')
	UpdateBeat:Add(Update)
end
--场景切换通知
function OnLevelWasLoaded(level)

end