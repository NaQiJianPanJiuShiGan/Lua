--[[
if	(1)
then
	print("1Ϊ true")
end

x="xx"
x=nil
if	x then
	print(x)
else
	print("x ֵΪ nil")
end

while(true)
do
print("ѭ��")
end

for var=exp1,exp2,exp3 do
	<ִ����>
end

var ��exp1�仯��exp2,ÿ��ÿ�α仯��exp3Ϊ��������var����ִ��һ�Ρ�ִ���塱exp3�ǿ�ѡ�ģ������ָ����Ĭ��Ϊ1


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



--forѭ�����������ʽ��ѭ��ǰһ������ֵ���Ժ��ٽ�����ֵ������f(x)ֻ����ѭ��ǰִ��һ�Σ��������ں����ѭ����

--����forѭ����������foreach���

day={key="����һ","���ڶ�","������","������","������"}
--day["key"]="value"
day[1]=2

for i,var in ipairs(day) do
	print(var);
end
--��lua ��pairs��ipairs�����������÷����������һ���ǲ�һ���ģ�
--pairs ���Ա������е�����key�����ҳ��˵����������Լ������������Է���nil
--����ipairs���ܷ���nil��ֻ�ܷ�������0���������nil���˳�����ֻ�ܱ��������е�һ������������key
--ipairs���±�Ϊ1��ʼ������Ȼ���±��ۼ�1�����ĳ���±�Ԫ�ز����ھͻ���ֹ��������͵�������±겻�������߲��Ǵ�1��ʼ�ı�ͻ��ն˻��߱�������Ԫ�ء�

function testFun(tab,fun)
	for k,v in pairs(tab) do
		print(fun(k,v))
	end
end
tab = {key1="key1",key2="key2"}
testFun(tab,function(key,val)	--��������
		return key.."="..val
	end
)

print(day.key..day[1])--���е�Ԫ�ؿ�����.��[]��ȡ����ֵΪ����ʱ����ʹ��.��ȡ
day.key=nil--ɾ���������ݣ�ɾ����������ʱ�������᲻��������Ǩ��
day=nil--ɾ���������ͷ��ڴ�


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
MaxNum(5,6,myprint)  --��������Ϊ��������


table= {3,2,5,1,8,2}


function FindMaxValue(tab)
	local m=1;		--���еĵ�һ��������
	local mi=tab[1]  --���еĵ�һ��ֵ
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
--���ұ�����Сֵ
function FindMinValue(tab)
	local m=1;		--���еĵ�һ��������
	local mi=tab[1]	--���еĵ�һ��ֵ
	for key,value in ipairs(tab) do
		if value < mi then
			mi =value
			m=key
		end
	end
	return mi,m
end

print(FindMinValue(table))



--�߼��������
--and ��AΪfalse���򷵻�A�����򷵻�B �൱��&&
--or ��AΪtrue���򷵻�A�����򷵻�B���൱��||
--not �߼��ǲ����������߼��������෴���������Ϊtrue���߼���Ϊfalse �൱�ڣ�
-- ..���������ַ���������ʱ������תΪ�ַ�������Ǳ������
print(type(1 .."2"))

--#һԪ������������ַ������ĳ��� #hello����5
print(#{1,2,3,4})

--����Эͬ����
co1=coroutine.create(
	function(a,b)
		print(a+b)
		coroutine.yield()
		print(a-b)
	end
)

coroutine.resume(co1,20,30)--ָ��������Эͬ�������������
--1.����Эͬ����coroutine.create
--2.����Эͬ����coroutine.resume

co2=coroutine.wrap(
	function(a,b)
		print(a+b)
	end
)
co2(30,30)
coroutine.resume(co1,20,30)


array ={{"С��","С��"},{"С��"},{"����"}}
for k,v in pairs(array) do
	for i,j in pairs(v) do
		print(j)
	end
end

--�Զ��������

--for �����б� in ����������״̬���������Ʊ���  do
	--ѭ����
--end

--1�����õ�������������״̬�����Ϳ��Ʊ��������������ݸ�����������
--2��������������ķ���ֵΪnil,�˳�forѭ��
	--�������nil�Ļ����ѷ���ֵ��ֵ�������б���ִ��ѭ����

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

--table����
print(table.concat(mytable))--�����ַ���ƴ��
print(table.concat(table1,",",1,2))--�ԣ��ָ�ƴ�ӣ���1ƴ�ӵ�2

--table����

table.insert(mytable,"PHP")
print(mytable[3])
table.insert(mytable,2,"Boo")--��2�±괦����,ԭ�������˳�Ʊ���������������
print(mytable[2])
print(mytable[3])
table.remove(mytable,2)--�Ƴ��±�2��ֵ������������������
print(mytable[2])



--ģ��
class={}
class.num=1
class.Name="class"
function class.func1()
	print("class��func1")
end
local function func2()
	print(class.num,class.Name)
end

return class

--Ԫ��
a={"lua","C#","Java","Php","Js"}--��ͨ��
b={}--Ԫ��
a=setmetatable(a,b)--����Ԫ�����ص�һ����

print(getmetatable(a))--getmetatable�õ���ͨ���Ԫ��
print(b)


tab= setmetatable({"lua","C#","Java","Php","Js"},{__metatable="asd"})
print(tab[2])
print(getmetatable(tab))--ʹ��__metatable���Ա���Ԫ����ֹ�û�����Ԫ���еĳ�Ա���޸�Ԫ�������ʹ�û᷵��Ԫ��





------------------------------------------------------------__index
a={"lua","C#","Java","Php","Js"}--��ͨ��
b={
__index=function(tab,key)--tab��ͨ��key�����ʲ����ڵļ�
	print("������Index����")
	return "C++"
end
}--Ԫ��

newtab={}
newtab[6]="C"
newtab[7]="boo"
c={
__index=newtab
}--Ԫ��

--a=setmetatable(a,b)
a=setmetatable(a,c)
print(a[1],a[7])


----------------------------------------------------------__newindex

a={"lua","C#","Java","Php","Js"}--��ͨ��
b={
__newindex=function(tab,key,value)--�����ǶԱ����һ���µ�����ʱ����
	print("Ҫ��ӵ�KayΪ:"..key.."Ҫ��ӵ�value:"..value)
	rawset(tab,key,value)
end
}
newtab={}
newtab[6]="c"
newtab[7]="boo"
c={
__newindex=newtab--����ӵ������±��Ѿ����ھ��޸���ͨ����������ھ���ӽ�newtab��
}
--a=setmetatable(a,b)
a=setmetatable(a,c)
a[6]="c"
print(a[6])
print(newtab[6])



---------------------------------------------------------Ϊ����Ӳ�����

a={"lua","C#","Java","Php","Js"}--��ͨ��
b={
__add=function(tab,newtab)--�����ʱ��������ڱ��β��
	local max=0
	for k,v in pairs(tab) do--�õ���ͨ����������ֵ
		if(k>max) then
			max=k
		end
	end
	for k,v in pairs(newtab) do
		max=max+1
		table.insert(tab,max,v)--���ڶ������ֵ���뵽��һ������
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

a={"lua","C#","Java","Php","Js"}--��ͨ��
b={
__call=function(tab,arg)--����������ʹ��
	print("arg")
	return "123"
end
}
setmetatable(a,b)
print(a(1))



---------------------------------------------------------__tostring

a={"lua","C#","Java","Php","Js"}--��ͨ��
b={
__tostring=function(tab)--����������ʹ��
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
-- ��ֻ����ʽ���ļ�
file = io.open("test.lua", "r")

-- ����ļ���һ��
print(file:read())

-- �رմ򿪵��ļ�
file:close()

-- �Ը��ӵķ�ʽ��ֻд�ļ�
file = io.open("test.lua", "a")

-- ���ļ����һ����� Lua ע��
file:write("--test")

-- �رմ򿪵��ļ�
file:close()























