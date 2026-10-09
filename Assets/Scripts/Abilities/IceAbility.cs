using MoreMountains.Feedbacks;
using UnityEngine;

public class IceAbility : BaseAbility
{
    public MMF_Player iceParticlesFeedback;

    protected override void PlayFeedback()
    {
        base.PlayFeedback();
        if (iceParticlesFeedback != null)
            iceParticlesFeedback.PlayFeedbacks();
    }
    public override void Execute()
    {
        Shoot(8, StatusEFfect.Freeze, 2f);
        PlayFeedback();
    }
}
