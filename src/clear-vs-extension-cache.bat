@echo off
echo ============================================
echo Clearing Visual Studio Extension Caches
echo ============================================

set VS_CACHE_ROOT=%LOCALAPPDATA%\Microsoft\VisualStudio

if not exist "%VS_CACHE_ROOT%" (
    echo Visual Studio cache folder not found.
    goto :eof
)

for /d %%D in ("%VS_CACHE_ROOT%\17.*") do (
    echo Processing %%D

    if exist "%%D\ExtensionCache" (
        echo  - Deleting ExtensionCache
        rmdir /s /q "%%D\ExtensionCache"
    )

    if exist "%%D\ComponentModelCache" (
        echo  - Deleting ComponentModelCache
        rmdir /s /q "%%D\ComponentModelCache"
    )
)

echo ============================================
echo Done. You can now start Visual Studio again.
echo ============================================
pause
