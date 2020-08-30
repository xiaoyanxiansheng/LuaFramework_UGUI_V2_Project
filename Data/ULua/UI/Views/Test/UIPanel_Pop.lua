-- 弹框UI

-- 继承UIBaseView
UIPanel_Pop = UIBaseView.New(UIConst.UIPanel_Pop);

local _M = UIPanel_Pop;

function _M:OnCreate()
	printUILog("UIPanel_Test OnCreate");

	-- 创建一个测试组件
	self.TestPlugin = self:CreatePlugin(TestPlugin,self.testCore)
end

function _M:OnRegisterMessage()
	printUILog("UIPanel_Test OnRegisterMessage");
end

function _M:OnShow()
	printUILog("UIPanel_Test OnShow");

	self.TestPlugin:Show()
end

function _M:OnClose()
	printUILog("UIPanel_Test OnClose");
end

function _M:OnDestory()
	printUILog("UIPanel_Test OnDestory");
end

function _M:ClickClose(sender)
	UIManager:Close(UIConst.UIPanel_Pop);
end