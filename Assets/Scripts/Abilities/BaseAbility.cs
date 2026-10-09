using UnityEngine;
using MoreMountains.Feedbacks;

public abstract class BaseAbility : MonoBehaviour
{
    public GameObject projectilePrefab;

    public Transform firepoint;

    public MMF_Player castFeedback;

    public abstract void Execute();
    protected virtual void PlayFeedback()
    {
        if (castFeedback == null) return;
        castFeedback.PlayFeedbacks();
    }
    protected void Shoot(float speed, StatusEFfect effect, float effectDuration)
    {
        GameObject go = Instantiate(projectilePrefab, firepoint.position, firepoint.rotation);

        if (go.TryGetComponent(out Projectile p))
        {
            p.speed = speed;
            p.effect = effect;
            p.effectDuration = effectDuration;
        }
    }
}
