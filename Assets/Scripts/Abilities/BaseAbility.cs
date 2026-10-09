using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.InputSystem;

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
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mouseWorld.z = 0f;

        Vector2 dir = mouseWorld - firepoint.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f; // 
        Quaternion rot = Quaternion.Euler(0f, 0f, angle);

        GameObject go = Instantiate(projectilePrefab, firepoint.position, rot);

        if (go.TryGetComponent(out Projectile p))
        {
            p.speed = speed;
            p.effect = effect;
            p.effectDuration = effectDuration;
        }
    }
}