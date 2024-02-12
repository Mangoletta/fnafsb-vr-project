using UnrealBuildTool;

public class FNAF9Target : TargetRules
{
	public FNAF9Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("FNAF9");
	}
}
