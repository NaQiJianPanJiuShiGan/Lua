--主入口函数。从这里开始lua逻辑
require "Component"
local go
function Main()					
	 	LuaHelper = LuaFramework.LuaHelper
	 	resmgr = LuaHelper.GetResManager()
	 	resmgr:LoadPrefab('box',{'box'},OnLoadFinish)
		
		
		
		-- LuaFramework.Util.Log("等待更新")
		-- local go = UnityEngine.GameObject('go')
		-- go.transform.position = Vector3.one
		local go2 = UnityEngine.GameObject('go2')
		go2.transform.position = Vector3.one
		LuaComponent.ADD(go2,Component)
		local comp = LuaComponent.Get(go2,Component)
		
		-- resmgr:LoadPrefab("box",{'messagepanel'},OnLoadFinishUI)
		local PanelManager = LuaHelper.GetPanelManager()
		PanelManager:CreatePanel('message',OnLoadFinishUI)
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
	local tankCmp1 = LuaComponent.ADD(go,Component)
	go.transform.position = Vector3.one
	LuaFramework.Util.Log('更新')
	go.name= "go1";
	UpdateBeat:Add(Update)
end

function OnLoadFinishUI(objs)
	-- local uiGo = UnityEngine.GameObject.Instantiate(objs[0])
	-- local camvas = UnityEngine.GameObject.Find("Canvas")
	-- uiGo.transform:SetParent(camvas.transform:GetChild(0))
	-- uiGo.transform.localScale = Vector3.one
	-- uiGo.transform.localPosition = Vector3.zero
	
	-- local btn = uiGo.transform:FindChild("Btn_Enter").gameObject
	-- UIEvent.AddButtonClick(btn,Btn_Enter_Click)
	local btn= objs.transform:FindChild('Btn_Enter').gameObject
	LuaBehaviour = objs:GetComponent("LuaBehaviour")
	LuaBehaviour:AddClick(btn,Btn_Enter_Click)
end
function Btn_Enter_Click()
	Debugger.Log('触发点击事件')
	soundMgr=LuaHelper.GetSoundManager()
	soundMgr:PlayBackSound("sound","braveheart")
end

--场景切换通知
function OnLevelWasLoaded(level)

end