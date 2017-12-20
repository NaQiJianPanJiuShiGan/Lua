require"Logic/Network"

function Main()
	local luaHelper =LuaFramework.LuaHelper
	local networkMgr = LuaHelper.GetNetManager()
	local appConst = LuaFramework.AppConst
	
	appConst.SocketPort=1234
	appConst.SocketAddress="127.0.0.1"
	networkMgr:SendConnect()
	Debugger.Log("Client start")
end
