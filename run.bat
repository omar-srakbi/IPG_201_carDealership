@echo off
chcp 65001 >nul
echo ========================================
echo    Car Dealership Project - IPG201
echo ========================================
echo.

REM Check if packages folder exists, restore NuGet packages if missing
if not exist "packages\EntityFramework.6.5.0" (
    echo Restoring NuGet packages...
    if exist "packages\EntityFramework.6.5.0.zip" (
        echo Extracting EntityFramework...
        powershell -Command "Expand-Archive -Path 'packages\EntityFramework.6.5.0.zip' -DestinationPath 'packages\EntityFramework.6.5.0' -Force"
    ) else (
        echo Downloading EntityFramework 6.5.0...
        powershell -Command "Invoke-WebRequest -Uri 'https://www.nuget.org/api/v2/package/EntityFramework/6.5.0' -OutFile 'packages\EntityFramework.6.5.0.zip'"
        echo Extracting EntityFramework...
        powershell -Command "Expand-Archive -Path 'packages\EntityFramework.6.5.0.zip' -DestinationPath 'packages\EntityFramework.6.5.0' -Force"
    )
    echo.
)

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
