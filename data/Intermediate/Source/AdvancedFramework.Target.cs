using UnrealBuildTool;

public class AdvancedFrameworkTarget : TargetRules
{
	public AdvancedFrameworkTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("AdvancedFramework");
	}
}
