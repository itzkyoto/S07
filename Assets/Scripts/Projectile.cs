using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public StatusEFfect effect;
    public float effectDuration;           
    public float lifetime = 3f;             
    public GameObject hitEffectPrefab;      

    private void Start() => Destroy(gameObject, lifetime);

    private void Update() => transform.position += transform.up * speed * Time.deltaTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.TryGetComponent(out Enemy enemy)) return;

        enemy.ApplayStatus(effect, effectDuration);

        if (hitEffectPrefab != null)
            Instantiate(hitEffectPrefab, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}