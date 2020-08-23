-- 组件基类
--[[
	1. 所有组件都必须继承BasePlugin，这里也包括了UIBaseView
	2. 当前UI卸载之后会自动卸载这个UI上绑定的所有组件	
--]]

BasePlugin = Class("BasePlugin")

local _M = BasePlugin

--region 不对外提供
function _M:ctor(params)
	self.uiCore = nil
	self.childPlugins = nil
end

function _M:DestoryChildPlugin()
	if self.childPlugins == nil then 
		return
	end
	for i,v in ipairs(self.childPlugins) do
		if v ~= nil then 
			v:DestoryPlugin()
		end
	end
	self.childPlugins = nil
end
function _M:BindUICore(core)
	if core == nil then 
		return
	end

	self:UnBindUIcore()
	self.uiCore = core
	self.uiCore:Init(self)
end
function _M:UnBindUIcore()
	if not self.uiCore then 
		return
	end
	self.uiCore:UnInit(self)
	self.uiCore = nil
end

function _M:OnCreate() end
function _M:OnDestory() end
--endregion
    
--region 对外接口
-- 创建一个组件
function _M:CreatePlugin(pluginClass,obj)
	local tplugin = pluginClass.New()
	tplugin:BindUICore(obj)
	if self.childPlugins == nil then 
		self.childPlugins = {}
	end
	table.insert(self.childPlugins,tplugin)

	tplugin:OnCreate()

	return tplugin
end
-- 删除一个组件（最终UI卸载时会自动调用，但是为了代码的完整性最好还是手动调用）
function _M:DestoryPlugin(plugin)
	local tempPlugin = plugin or self
	tempPlugin:UnBindUIcore()
	tempPlugin:DestoryChildPlugin()
	if plugin then 
		table.Remove(self.childPlugins,plugin,true)
	end

	self:OnDestory()
end
--endregion