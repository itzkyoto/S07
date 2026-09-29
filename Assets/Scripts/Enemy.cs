using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ApplayStatus(StatusEFfect effect)
    {
        Debug.Log("enemigo recibe " + effect);
    }
    public void ApplayStatus(StatusEFfect effect, float duration)
    {
        Debug.Log("enemigo recibe " + effect + "time: " + duration);
    }
}
