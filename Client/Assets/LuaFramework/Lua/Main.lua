--主入口函数。从这里开始lua逻辑
function Main()					
	print("logic start aaaaaa   ")	 		
end

--场景切换通知
function OnLevelWasLoaded(level)
	collectgarbage("collect")
	Time.timeSinceLevelLoad = 0
end

function OnApplicationQuit()
end

print("----1")

-- 游戏逻辑入口
require "Data/ULua/System/GameMain"

print("----2")