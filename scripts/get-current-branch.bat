@echo off 
set arg1=%1
@echo on 
cd %arg1% 
git branch --show-current
