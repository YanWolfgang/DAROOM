using UnrealBuildTool;

public class DAROOMTarget : TargetRules
{
	public DAROOMTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("DAROOM");
	}
}
