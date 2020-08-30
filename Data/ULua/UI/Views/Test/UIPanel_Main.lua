-- 全屏UI

UIPanel_Main = UIBaseView.New(UIConst.UIPanel_Main);

local _M = UIPanel_Main;
_M.isMainUI = true

function _M:OnCreate()
    printUILog("UIPanel_Main OnCreate");
end

function _M:OnRegisterMessage()
    printUILog("UIPanel_Main OnRegisterMessage");
end

function _M:OnShow()
    printUILog("UIPanel_Main OnShow");

    -- self.text.text = "被lua修改后的文本 我是全屏UI"
end

function _M:OnClose()
    printUILog("UIPanel_Main OnClose");
end

function _M:OnDestory()
    printUILog("UIPanel_Main OnDestory");
end

function _M:ClickPop(sender)
    UIManager:Open(nil,UIConst.UIPanel_Pop);
end

function _M:ClickFull(sender)
    UIManager:Open(nil,UIConst.UIPanel_Main1);
end