using MoreMountains.Feedbacks;
using UnityEngine;

public class SlowAbility : BaseAbility
{
    public MMF_Player SlowParticlesFeedback;

    protected override void PlayFeedback()
    {
        base.PlayFeedback();
        if (SlowParticlesFeedback != null)
            SlowParticlesFeedback.PlayFeedbacks();
    }
    public override void execute()
    {
        Shoot(5, StatusEFfect.Slow, 5f);
        PlayFeedback();
    }

}
