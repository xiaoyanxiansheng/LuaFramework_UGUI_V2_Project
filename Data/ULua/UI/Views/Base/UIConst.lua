---@class UIConst
UIConst = {
	--- test ---
	-- 单个UI
	UIPanel_Main = "UIPanel_Main",
	UIPanel_Main1 = "UIPanel_Main1",
	UIPanel_Pop = "UIPanel_Pop",
};

UIPath = {
	-- test
	UIPanel_Main = {
		"ui/panels/uipanel_main",
		"Data/ULua/UI/Views/Test/UIPanel_Main",
	},
	UIPanel_Main1 = {
		"ui/panels/uipanel_main1",
		"Data/ULua/UI/Views/Test/UIPanel_Main1",
	},
	UIPanel_Pop = {
		"ui/panels/uipanel_pop",
		"Data/ULua/UI/Views/Test/UIPanel_Pop",
	},
}

function GetPrefabPath(name)
	local name = UIConst[name];
	if name then 
		local info = UIPath[name];
		if info then 
			return info[1];
		end
	end
	return nil;
end
function GetUIScriptPath(name)
local name = UIConst[name];
	if name then 
		local info = UIPath[name];
		if info then 
			return info[2];
		end
	end
	return nil;
end