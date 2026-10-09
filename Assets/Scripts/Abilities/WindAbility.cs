using MoreMountains.Feedbacks;
using UnityEngine;

public class WindAbility : BaseAbility
{
    public MMF_Player windParticlesFeedback;

    protected override void PlayFeedback()
    {
        base.PlayFeedback();
        if (windParticlesFeedback != null)
            windParticlesFeedback.PlayFeedbacks();
    }
    public override void Execute()
    {
        Shoot(10, StatusEFfect.Wind, 3f);
        PlayFeedback();
    }
}
