using UnityEngine;

public class IceAbility : BaseAbility
{
    public override void execute()
    {
        Shoot(8, StatusEFfect.Freeze, 2f);
        PlayFeedback();
    }
}
