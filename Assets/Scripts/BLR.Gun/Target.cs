using UnityEngine;

public class Target : MonoBehaviour
{
    public float Health = 100;

    public void TakeDamage(float damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Die();
        }
        Debug.Log("I've got " + Health + "hp");
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
