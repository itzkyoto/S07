using UnityEngine;

public class PoisonAbility : BaseAbility
{
    public override void execute()
    {
        Shoot(15, StatusEFfect.Poison, 3.5f);
        PlayFeedback();
    }
}
