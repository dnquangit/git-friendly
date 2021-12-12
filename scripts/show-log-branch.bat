@echo off 
set arg1=%1
@echo on 
cd %arg1% 
TortoiseGitProc.exe /command:log
exit
