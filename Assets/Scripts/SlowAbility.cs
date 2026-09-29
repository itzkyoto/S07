using UnityEngine;

public class SlowAbility : BaseAbility
{
    public override void execute()
    {
        Shoot(5, StatusEFfect.Slow, 5f);
        PlayFeedback();
    }

}
