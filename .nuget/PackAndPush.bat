Nuget pack Run00.Versioning.nuspec
@echo off
for /f "delims=" %%x in ('dir /od /a-d /b *.*') do set recent=%%x

Nuget push %recent% %1