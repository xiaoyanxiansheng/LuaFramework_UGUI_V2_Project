-- 全屏UI

UIPanel_Main1 = UIBaseView.New(UIConst.UIPanel_Main1);

local _M = UIPanel_Main1;
_M.isMainUI = true

function _M:OnCreate()
    printUILog("UIPanel_Main1 OnCreate");
end

function _M:OnRegisterMessage()
    printUILog("UIPanel_Main1 OnRegisterMessage");
end

function _M:OnShow()
    printUILog("UIPanel_Main1 OnShow");
end

function _M:OnClose()
    printUILog("UIPanel_Main1 OnClose");
end

function _M:OnDestory()
    printUILog("UIPanel_Main1 OnDestory");
end

function _M:ClickClose(sender)
    UIManager:Close(UIConst.UIPanel_Main1);
end

function _M:ClickPop(sender)
	UIManager:Open(nil,UIConst.UIPanel_Pop);
end