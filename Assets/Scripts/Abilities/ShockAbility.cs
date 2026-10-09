using MoreMountains.Feedbacks;
using UnityEngine;

public class ShockAbility : BaseAbility
{
    public MMF_Player shockParticlesFeedback;

    protected override void PlayFeedback()
    {
        base.PlayFeedback();
        if (shockParticlesFeedback != null)
            shockParticlesFeedback.PlayFeedbacks();
    }
    public override void execute()
    {
        Shoot(10, StatusEFfect.Shock, 3f);
        PlayFeedback();
    }
}
