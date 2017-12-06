--[[
if	(1)
then
	print("1为 true")
end

x="xx"
x=nil
if	x then
	print(x)
else
	print("x 值为 nil")
end

while(true)
do
print("循环")
end

for var=exp1,exp2,exp3 do
	<执行体>
end

var 从exp1变化到exp2,每次每次变化以exp3为步长递增var，并执行一次“执行体”exp3是可选的，如果不指定，默认为1


for	i=10,5,-3 do
	print(i)
	end

function f(x)
	print("function")
	return x*2
end
for	i=1,f(5) do
	print(i)
	end



--for循环的三个表达式在循环前一次性求值，以后不再进行求值，例如f(x)只会在循环前执行一次，其结果用在后面的循环中

--泛型for循环，类似于foreach语句

day={key="星期一","星期二","星期三","星期四","星期五"}
--day["key"]="value"
day[1]=2

for i,var in ipairs(day) do
	print(var);
end
--在lua 中pairs与ipairs两个迭代器用法相近，但有一点是不一样的：
--pairs 可以遍历表中的所有key，并且除了迭代器本身以及遍历表本身还可以返回nil
--但是ipairs则不能反悔nil，只能返回数字0，如果遇到nil则退出，他只能遍历到表中第一个不是整数的key
--ipairs从下标为1开始遍历，然后下标累加1，如果某个下表元素不存在就会终止遍历，这就导致如果下标不连续或者不是从1开始的表就会终端或者遍历不到元素。

function testFun(tab,fun)
	for k,v in pairs(tab) do
		print(fun(k,v))
	end
end
tab = {key1="key1",key2="key2"}
testFun(tab,function(key,val)	--匿名函数
		return key.."="..val
	end
)

print(day.key..day[1])--表中的元素可以用.或[]获取当键值为数字时不能使用.获取
day.key=nil--删除表中数据，删除表中数据时，索引会不连续不会迁移
day=nil--删除整个表，释放内存


function fun(n)
	if n==1 then
			return n
	else
			return n*fun(n-1)
	end
end

print(fun(5));

fun2=fun
print(fun2(5))

myprint=function(n)
print(n)
end


function MaxNum(num1,num2,myprint)
	if num1>num2 then
		result = num1
	else
		result = num2
	end
	myprint(result)
end


--myprint(10)
MaxNum(5,6,myprint)  --将方法作为参数传递


table= {3,2,5,1,8,2}


function FindMaxValue(tab)
	local m=1;		--表中的第一个的索引
	local mi=tab[1]  --表中的第一个值
	for key,value in pairs(tab) do
		if	mi<value then
			mi=key
			m=value
		end
	end
	return m,mi
end
print(table[2+1])
print(FindMaxValue(table))
--查找表中最小值
function FindMinValue(tab)
	local m=1;		--表中的第一个的索引
	local mi=tab[1]	--表中的第一个值
	for key,value in ipairs(tab) do
		if value < mi then
			mi =value
			m=key
		end
	end
	return mi,m
end

print(FindMinValue(table))



--逻辑运算符，
--and 若A为false，则返回A，否则返回B 相当于&&
--or 若A为true，则返回A，否则返回B，相当于||
--not 逻辑非操作符，与逻辑运算结果相反，如果条件为true，逻辑非为false 相当于！
-- ..连接两个字符串，链接时将数字转为字符串如果是表，则出错
print(type(1 .."2"))

--#一元运算符，返回字符串或表的长度 #hello返回5
print(#{1,2,3,4})

--定义协同函数
co1=coroutine.create(
	function(a,b)
		print(a+b)
		coroutine.yield()
		print(a-b)
	end
)

coroutine.resume(co1,20,30)--指定启动的协同函数，传入参数
--1.定义协同函数coroutine.create
--2.启动协同函数coroutine.resume

co2=coroutine.wrap(
	function(a,b)
		print(a+b)
	end
)
co2(30,30)
coroutine.resume(co1,20,30)


array ={{"小红","小明"},{"小刘"},{"张三"}}
for k,v in pairs(array) do
	for i,j in pairs(v) do
		print(j)
	end
end

--自定义迭代器

--for 变量列表 in 迭代函数，状态变量，控制变量  do
	--循环体
--end

--1。调用迭代函数，（把状态变量和控制变量当作参数传递给迭代函数）
--2。如果迭代函数的返回值为nil,退出for循环
	--如果不是nil的话，把返回值赋值给变量列表，并执行循环体

function square (_State,control)
	if (control>=_State) then
		return nil
	else
		control=control+1
		return control,control*control
	end
end

for k,v in square,9,0 do
	print(k,v)
end




mytable={}
mytable[1]="lua"
mytable[2]="Java"
mytable[2.1]="C#"
mytable["Name"]="Ricardo"
print( type(mytable[Name]))
print(mytable.Name)
print(mytable[2.1])


table1={"aaa","bbb","ccc",key="value"}

--table连接
print(table.concat(mytable))--表中字符串拼接
print(table.concat(table1,",",1,2))--以，分割拼接，从1拼接到2

--table插入

table.insert(mytable,"PHP")
print(mytable[3])
table.insert(mytable,2,"Boo")--在2下标处插入,原数据向后顺移保持索引的连续性
print(mytable[2])
print(mytable[3])
table.remove(mytable,2)--移除下标2的值，保持索引的连续性
print(mytable[2])



--模块
class={}
class.num=1
class.Name="class"
function class.func1()
	print("class的func1")
end
local function func2()
	print(class.num,class.Name)
end

return class

--元表
a={"lua","C#","Java","Php","Js"}--普通表
b={}--元表
a=setmetatable(a,b)--设置元表，返回第一个表

print(getmetatable(a))--getmetatable得到普通表的元表
print(b)


tab= setmetatable({"lua","C#","Java","Php","Js"},{__metatable="asd"})
print(tab[2])
print(getmetatable(tab))--使用__metatable可以保护元表，禁止用户访问元表中的成员或修改元表，如果不使用会返回元表





------------------------------------------------------------__index
a={"lua","C#","Java","Php","Js"}--普通表
b={
__index=function(tab,key)--tab普通表，key所访问不存在的键
	print("调用了Index方法")
	return "C++"
end
}--元表

newtab={}
newtab[6]="C"
newtab[7]="boo"
c={
__index=newtab
}--元表

--a=setmetatable(a,b)
a=setmetatable(a,c)
print(a[1],a[7])


----------------------------------------------------------__newindex

a={"lua","C#","Java","Php","Js"}--普通表
b={
__newindex=function(tab,key,value)--当我们对表添加一个新的索引时调用
	print("要添加的Kay为:"..key.."要添加的value:"..value)
	rawset(tab,key,value)
end
}
newtab={}
newtab[6]="c"
newtab[7]="boo"
c={
__newindex=newtab--当添加的数据下标已经存在就修改普通表，如果不存在就添加进newtab表
}
--a=setmetatable(a,b)
a=setmetatable(a,c)
a[6]="c"
print(a[6])
print(newtab[6])



---------------------------------------------------------为表添加操作符

a={"lua","C#","Java","Php","Js"}--普通表
b={
__add=function(tab,newtab)--表相加时将表添加在表的尾部
	local max=0
	for k,v in pairs(tab) do--得到普通表最大的索引值
		if(k>max) then
			max=k
		end
	end
	for k,v in pairs(newtab) do
		max=max+1
		table.insert(tab,max,v)--将第二个表的值插入到第一个表中
	end
end
}

a=setmetatable(a,b)
newtab={"c","boo"}

v=newtab+a
v2=newtab+a
print(v)

for i,j in pairs(a) do
	print(i.."="..j)
end


---------------------------------------------------------__Call

a={"lua","C#","Java","Php","Js"}--普通表
b={
__call=function(tab,arg)--将表当作函数使用
	print("arg")
	return "123"
end
}
setmetatable(a,b)
print(a(1))



---------------------------------------------------------__tostring

a={"lua","C#","Java","Php","Js"}--普通表
b={
__tostring=function(tab)--将表当作函数使用
	local str=""
	for k,v in pairs(tab) do
		str=str..v..","
	end
	return str
end
}
setmetatable(a,b)
print(a)

--]]
-- 以只读方式打开文件
file = io.open("test.lua", "r")

-- 输出文件第一行
print(file:read())

-- 关闭打开的文件
file:close()

-- 以附加的方式打开只写文件
file = io.open("test.lua", "a")

-- 在文件最后一行添加 Lua 注释
file:write("--test")

-- 关闭打开的文件
file:close()























