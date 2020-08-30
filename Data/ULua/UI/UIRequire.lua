-- UI模块打印开关
LOG_UI = true;
function printUILog(...)
    if LOG_UI then 
        local debugInfo = debug.getinfo(2,"nSl")
        print(debugInfo.short_src.." " ..debugInfo.name..":"..debugInfo.currentline,...)
    end
end

-- 组件模块
require "Data/ULua/UI/Views/Plugins/PluginsRequire";
-- UI常量
require "Data/ULua/UI/Views/Base/UIConst";
-- UI页面
require "Data/ULua/UI/Views/Base/UIBaseView";
-- UI集合
require "Data/ULua/UI/Views/Base/UIBaseCollect";
-- UI管理
require "Data/ULua/UI/Views/Base/UIManager";