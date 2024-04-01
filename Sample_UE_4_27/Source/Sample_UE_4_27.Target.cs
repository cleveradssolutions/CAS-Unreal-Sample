// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Sample_UE_4_27Target : TargetRules
{
	public Sample_UE_4_27Target( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "Sample_UE_4_27" } );

		if (Target.Platform == UnrealTargetPlatform.Mac || Target.Platform == UnrealTargetPlatform.IOS)
        {
	        bOverrideBuildEnvironment = true;
			// Xcode 15
			AdditionalCompilerArguments += " -Wno-deprecated-builtins";
			AdditionalCompilerArguments += " -Wno-error=single-bit-bitfield-constant-conversion";

			// Xcode 14
			AdditionalCompilerArguments += " -Wno-error=bitwise-instead-of-logical";
			AdditionalCompilerArguments += " -Wno-error=deprecated-declarations";
			AdditionalCompilerArguments += " -Wno-error=unqualified-std-cast-call";
			AdditionalCompilerArguments += " -Wno-error=unused-but-set-variable";
        }
	}
}
