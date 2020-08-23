--[[
	创建实体
		1 GameObject
		2 UI	
--]]

-- 获取gameobject
GetGameObjectById = ResourceManager.GetGameObjectById;
-- 取消创建
CancelCreateGameObjectAsync = ResourceManager.CancelCreateGameObjectAsync;
-- 创建GameObject
CreateGameObjectAsync = ResourceManager.CreateGameObjectAsync;
-- 卸载GamObject
DestoryGameObject = ResourceManager.DestoryGameObject;

-- 创建UI
function CreateUIPanelAsync(name,onCreate)
	return CreateGameObjectAsync(2,name,onCreate);
end