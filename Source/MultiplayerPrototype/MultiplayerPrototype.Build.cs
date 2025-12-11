// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MultiplayerPrototype : ModuleRules
{
	public MultiplayerPrototype(ReadOnlyTargetRules Target) : base(Target)
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
			"MultiplayerPrototype",
			"MultiplayerPrototype/Variant_Platforming",
			"MultiplayerPrototype/Variant_Platforming/Animation",
			"MultiplayerPrototype/Variant_Combat",
			"MultiplayerPrototype/Variant_Combat/AI",
			"MultiplayerPrototype/Variant_Combat/Animation",
			"MultiplayerPrototype/Variant_Combat/Gameplay",
			"MultiplayerPrototype/Variant_Combat/Interfaces",
			"MultiplayerPrototype/Variant_Combat/UI",
			"MultiplayerPrototype/Variant_SideScrolling",
			"MultiplayerPrototype/Variant_SideScrolling/AI",
			"MultiplayerPrototype/Variant_SideScrolling/Gameplay",
			"MultiplayerPrototype/Variant_SideScrolling/Interfaces",
			"MultiplayerPrototype/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
