
using UnityEngine;

public class target : MonoBehaviour
{
    public float health = 100f;

    public void Takedamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }
    void Die ()
    {
        Destroy(gameObject);
    }
}
