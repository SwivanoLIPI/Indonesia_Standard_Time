
@echo off
 
setlocal
 
echo.
echo Determine whether we are on an 32 or 64 bit machine
echo.
 
if "%PROCESSOR_ARCHITECTURE%"=="x86" if "%PROCESSOR_ARCHITEW6432%"=="" goto x86
 
set ProgramFilesPath=%ProgramFiles(x86)%
 
goto startResetting
 
:x86
 
set ProgramFilesPath=%ProgramFiles%
 
:startResetting
 
echo.
 
if exist "%ProgramFilesPath%\Windows Resource Kits\Tools\subinacl.exe" goto filesExist
 
echo ***ERROR*** - Could not find file %ProgramFilesPath%\Windows Resource Kits\Tools\subinacl.exe. Double-check that SubInAcl is correctly installed and re-run this script.
goto END
 
:filesExist
 
pushd "%ProgramFilesPath%\Windows Resource Kits\Tools"
 
subinacl.exe /subkeyreg HKEY_LOCAL_MACHINE /grant=administrators=f  /grant=system=f
subinacl.exe /subkeyreg HKEY_CURRENT_USER /grant=administrators=f  /grant=system=f
subinacl.exe /subkeyreg HKEY_CLASSES_ROOT /grant=administrators=f  /grant=system=f
subinacl.exe /subdirectories %windir% /grant=administrators=f /grant=system=f
 
echo FINISHED.
echo. 
echo Press any key to exit . . .
pause >NUL
 
popd
 
:END
 
endlocal