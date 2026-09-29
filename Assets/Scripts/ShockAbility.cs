using UnityEngine;

public class ShockAbility : BaseAbility
{
    public override void execute()
    {
        Shoot(10, StatusEFfect.Shock, 3f);
        PlayFeedback();
    }
}
