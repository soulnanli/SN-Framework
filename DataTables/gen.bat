set LUBAN_DLL=..\Luban\Luban.dll
set CONF_ROOT=.

dotnet %LUBAN_DLL% ^
    -t client ^
    -c cs-simple-json ^
    -d json  ^
    --conf %CONF_ROOT%\luban.conf ^
    -x outputCodeDir=..\Assets\GameData\LubanCSGen ^
    -x outputDataDir=..\Assets\GameData\LubanJSGen 

pause