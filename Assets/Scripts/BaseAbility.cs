using UnityEngine;
using MoreMountains.Feedbacks;

public abstract class BaseAbility : MonoBehaviour
{
    public GameObject projectilePrefab;

    public Transform firepoint;

    public MMF_Player castFeedback;

    public abstract void execute();
    protected virtual void PlayFeedback()
    {
        castFeedback.PlayFeedbacks();
    }
    protected void Shoot(float speed,StatusEFfect effect, float duration)
    {
        GameObject proyectile = Instantiate(projectilePrefab, firepoint.position, Quaternion.identity); 
    }
    
}
