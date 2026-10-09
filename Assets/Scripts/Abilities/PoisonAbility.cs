using MoreMountains.Feedbacks;
using UnityEngine;

public class PoisonAbility : BaseAbility
{
    public MMF_Player poisonParticlesFeedback;

    protected override void PlayFeedback()
    {
        base.PlayFeedback();
        if (poisonParticlesFeedback != null)
            poisonParticlesFeedback.PlayFeedbacks();
    }
    public override void Execute()
    {
        Shoot(15, StatusEFfect.Poison, 3.5f);
        PlayFeedback();
    }
}
