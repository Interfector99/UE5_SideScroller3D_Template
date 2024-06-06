// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SideScroller3D : ModuleRules
{
	public SideScroller3D(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
