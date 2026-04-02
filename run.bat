@echo off
chcp 65001 >nul
echo ========================================
echo    Car Dealership Project - IPG201
echo ========================================
echo.
cd IPG_201_AIO
echo Building project...
"C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" carDealershipProject.csproj /p:Configuration=Debug /verbosity:minimal
if %ERRORLEVEL% EQU 0 (
    echo.
    echo [OK] Build successful!
    echo.
    echo Starting application...
    echo.
    start bin\Debug\carDealershipProject.exe
) else (
    echo.
    echo [ERROR] Build failed! Please check errors.
    pause
)
