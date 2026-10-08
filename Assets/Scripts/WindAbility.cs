using UnityEngine;

public class WindAbility : BaseAbility
{
    public override void execute()
    {
        Shoot(10, StatusEFfect.Wind, 3f);
        PlayFeedback();
    }
}
