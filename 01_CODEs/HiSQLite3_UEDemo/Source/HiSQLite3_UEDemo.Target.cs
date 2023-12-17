/*
**	Copyright (c) 2016-2023 YeHaike(841660657@qq.com).
**	All rights reserved.
**	@ Date : 2017/11/21
*/

using UnrealBuildTool;
using System.Collections.Generic;

public class HiSQLite3_UEDemoTarget : TargetRules
{
	public HiSQLite3_UEDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "HiSQLite3_UEDemo" } );
	}
}
