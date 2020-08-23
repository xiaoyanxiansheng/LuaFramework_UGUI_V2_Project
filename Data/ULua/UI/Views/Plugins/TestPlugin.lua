-- 测试组件

TestPlugin = Class("TestPlugin" , BasePlugin)

local _M = TestPlugin

function _M:OnCreate()
    print("[组件] 创建 TestPlugin")
end

function _M:OnDestory()
    print("[组件] 销毁 TestPlugin")
end

function _M:Show()
    self.text.text = "我是一个组件"
end

function _M:Click(sender)
    self.text.text = "我是一个被点击过的组件"
end