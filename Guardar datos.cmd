@echo off

for /f "tokens=2-4 delims=/ " %%d in ("%date%") do (
   set year=%%f
   set month=%%d
   set day=%%e
)

set commitMessage=Dia: %month%-%day%-%year%


cd /d %~dp0
git add .
git commit -m "%commitMessage%"
git push

timeout /t 5 


