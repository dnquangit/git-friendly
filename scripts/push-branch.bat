@echo off 
set arg1=%1
set arg2=%2
@echo on 
cd %arg1% 
git push origin %arg2% -u
