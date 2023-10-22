using UnrealBuildTool;

public class GDL_Group_GameTarget : TargetRules
{
	public GDL_Group_GameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("GDL_Group_Game");
	}
}
