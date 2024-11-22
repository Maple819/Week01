// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class WeekTest : ModuleRules
{
	public WeekTest(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
