using MoreMountains.Feedbacks;
using UnityEngine;

public class FireAbility : BaseAbility
{
    public MMF_Player fireParticlesFeedback;

    protected override void PlayFeedback()
    {
        base.PlayFeedback();                       
        if (fireParticlesFeedback != null)
            fireParticlesFeedback.PlayFeedbacks(); 
    }
    public override void Execute()
    {
        Shoot(10, StatusEFfect.Burn, 3f);
        PlayFeedback();
    }
}
