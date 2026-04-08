// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CodeTest : ModuleRules
{
	public CodeTest(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"CodeTest",
			"CodeTest/Variant_Platforming",
			"CodeTest/Variant_Platforming/Animation",
			"CodeTest/Variant_Combat",
			"CodeTest/Variant_Combat/AI",
			"CodeTest/Variant_Combat/Animation",
			"CodeTest/Variant_Combat/Gameplay",
			"CodeTest/Variant_Combat/Interfaces",
			"CodeTest/Variant_Combat/UI",
			"CodeTest/Variant_SideScrolling",
			"CodeTest/Variant_SideScrolling/AI",
			"CodeTest/Variant_SideScrolling/Gameplay",
			"CodeTest/Variant_SideScrolling/Interfaces",
			"CodeTest/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
