-- 组件基类
-- UICore的相关操作

BasePlugin = Class("BasePlugin")

local _M = BasePlugin

function _M:ctor(params)
	self.core = nil
end

function _M:BindUICore(obj)
	if obj == nil then 
		return
	end
	local tempCore = obj.transform:GetComponent("UICore")
	if tempCore == nil then 
		return
	end

	self:UnBindUIcore()
	self.core = tempCore
	self.core:Init(self)

	print("------ BindUICore" )
end

function _M:UnBindUIcore()
	if not self.core then 
		return
	end
	self.core:UnInit(self)
	self.core = nil

	print("------ UnBindUICore" )
end