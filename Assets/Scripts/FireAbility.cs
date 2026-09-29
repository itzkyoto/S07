using UnityEngine;

public class FireAbility : BaseAbility
{
    public override void execute()
    {
        Shoot(10, StatusEFfect.Burn, 3f);
        PlayFeedback();
    }
}
