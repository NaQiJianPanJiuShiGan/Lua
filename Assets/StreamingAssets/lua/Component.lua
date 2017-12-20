Component=				--组件表
{
	property1 =100,
	property2 ="helloworld"
}

function Component:Awake()

	Debugger.Log("TankCmp Start name=")

end

function Component:Start()
	Debugger.Log("TankCmp Start name=")
end

--更多自定义方法或生命周期方法略

function Component:New(obj)
	local o={}
	setmetatable(o,self)
	self.__index = self  
	return o
end

function Component:Update(gameobjcet)
	local Input = UnityEngine.Input
	
	local x = Input.GetAxis("Horizontal")
	local y = Input.GetAxis("Vertical")
	
	x = gameobjcet.transform.position.x+x
	y = gameobjcet.transform.position.z+y
	gameobjcet.transform.position = Vector3.New(x,0,y)
end