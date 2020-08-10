:: Copyright (c) Microsoft. All rights reserved.
:: Licensed under the MIT license. See LICENSE file in the project root for full license information.

@echo off

echo =============================================
echo     Start to build RDP Client Test Suite
echo =============================================

set CurrentPath=%~dp0
set TestSuiteRoot=%CurrentPath%..\..\..\..\

call "%CurrentPath%..\..\..\..\common\setBuildTool.cmd"
if ErrorLevel 1 (
	exit /b 1
)

call "%CurrentPath%..\..\..\..\common\setVsPath.cmd"
if ErrorLevel 1 (
	exit /b 1
)

call "%CurrentPath%..\..\..\..\common\checkWix.cmd"
if ErrorLevel 1 (
	exit /b 1
)

call "%CurrentPath%..\..\..\..\common\checkSpecExplorer.cmd"
if ErrorLevel 1 (
	exit /b 1
)

call "%CurrentPath%..\..\..\..\common\setPtfVer.cmd"
if ErrorLevel 1 (
	exit /b 1
)

call "%CurrentPath%..\..\..\..\common\setTestSuiteVer.cmd"
if ErrorLevel 1 (
	exit /b 1
)

set KeyFile=%1
if not defined KeyFile (
	%buildtool% "%TestSuiteRoot%TestSuites\RDP\Client\src\RDP_Client.sln" /t:clean;rebuild /p:Configuration="Release"
) else (
	%buildtool% "%TestSuiteRoot%TestSuites\RDP\Client\src\RDP_Client.sln" /t:clean;rebuild /p:AssemblyOriginatorKeyFile=%KeyFile% /p:DelaySign=true /p:SignAssembly=true /p:Configuration="Release"
)

if ErrorLevel 1 (
	echo Error: Failed to build RDP test suite
	exit /b 1
)

if exist "%TestSuiteRoot%drop\TestSuites\RDP\Client" (
	rd /s /q "%TestSuiteRoot%drop\TestSuites\RDP\Client"
)

%buildtool% "%TestSuiteRoot%TestSuites\RDP\Client\src\deploy\deploy.wixproj" /t:Clean;Rebuild /p:Configuration="Release"

if ErrorLevel 1 (
	echo Error: Failed to generate the msi installer
	exit /b 1
)

echo ==============================================
echo    Build RDP Client test suite successfully
echo ==============================================