# windows service

## to run as a service
set environment variable insallUtil = C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil
build as Release go to directory, launch %installUtil% digiseiWindowsService.exe as admin

to install: 
%installUtil% digiseiWindowsService.exe
to uninstall:
%installUtil% /u digiseiWindowsService.exe to uninstall

if this will not work because error 5 execute it changing from menu permissions about the user

absolute paths:
C:\Users\Taccarlo\Documents\Lavoro\Studio personale\windowsServiceStudy\windowsServiceStudy\digiseiWindowsService\digiseiWindowsService\bin\Release>C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil -u digiseiWindowsService.exe
C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil
C:\Users\Taccarlo\Documents\Lavoro\Studio personale\windowsServiceStudy\windowsServiceStudy\digiseiWindowsService\digiseiWindowsService\bin\Release