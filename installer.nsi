!define WIN64 ; Build 64-bit installer

!include "MUI2.nsh"

Name "DevAMP"
Outfile "DevAMP-Setup-x64.exe"
Icon "DevAMP\favicon.ico"

VIFileVersion "1.0.0.0"
VIProductVersion "1.0.0.0"
VIAddVersionKey CompanyName "iiniit"
VIAddVersionKey FileDescription "DevAMP Installer"
VIAddVersionKey ProductName "DevAMP"
VIAddVersionKey LegalCopyright "© 2025 iiniit"

InstallDir "$PROGRAMFILES64\devamp"
RequestExecutionLevel admin

!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH

!insertmacro MUI_LANGUAGE "English"

!define APP_NAME "DevAMP"
!define UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APP_NAME}"
!define UNINST_EXE "$INSTDIR\uninstall.exe"

Section "Install DevAMP"
    SetOutPath "$INSTDIR"

    File /r "DevAMP\windows\*.*"
    File "DevAMP\publish\Application Files\DevAMP\DevAMP.exe"
    File /r "DevAMP\publish\Application Files\DevAMP\*.*"

    CreateShortCut "$DESKTOP\DevAMP.lnk" "$INSTDIR\DevAMP.exe"

    WriteUninstaller "${UNINST_EXE}"

    WriteRegStr HKLM "${UNINST_KEY}" "DisplayName" "${APP_NAME}"
    WriteRegStr HKLM "${UNINST_KEY}" "UninstallString" "${UNINST_EXE}"
    WriteRegStr HKLM "${UNINST_KEY}" "InstallLocation" "$INSTDIR"
    WriteRegDWORD HKLM "${UNINST_KEY}" "NoModify" 1
    WriteRegDWORD HKLM "${UNINST_KEY}" "NoRepair" 1
SectionEnd

Section "Uninstall"
    Delete "$INSTDIR\DevAMP.exe"
    Delete "$DESKTOP\DevAMP.lnk"
    RMDir /r "$INSTDIR"

    DeleteRegKey HKLM "${UNINST_KEY}"
SectionEnd
