/*
**	Copyright (c) 2016-2023 YeHaike(841660657@qq.com).
**	All rights reserved.
**	@ Date : 2017/11/21
*/

using UnrealBuildTool;
using System.Collections.Generic;

public class HiSQLite3_UEDemoEditorTarget : TargetRules
{
	public HiSQLite3_UEDemoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.AddRange( new string[] { "HiSQLite3_UEDemo" } );
	}
}
