-- 全屏UI

UIPanel_Main = UIBaseView.New(UIConst.UIPanel_Main);

local _M = UIPanel_Main;
_M.isMainUI = true

function _M:OnCreate()
    print("UIPanel_Main OnCreate");
end

function _M:OnRegisterMessage()
    print("UIPanel_Main OnRegisterMessage");
end

function _M:OnShow()
    print("UIPanel_Main OnShow");

    self.text.text = "被lua修改后的文本 我是全屏UI"
end

function _M:OnClose()
    print("UIPanel_Main OnClose");
end

function _M:OnDestory()
    print("UIPanel_Main OnDestory");
end

function _M:ClickPop(sender)
    UIManager:Open(nil,UIConst.UIPanel_Pop);
end

function _M:ClickFull(sender)
    UIManager:Open(nil,UIConst.UIPanel_Main1);
end