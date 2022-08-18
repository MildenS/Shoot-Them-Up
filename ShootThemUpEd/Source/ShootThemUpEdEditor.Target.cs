// Shoot Them Up Game. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ShootThemUpEdEditorTarget : TargetRules
{
	public ShootThemUpEdEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ShootThemUpEd" } );
	}
}
