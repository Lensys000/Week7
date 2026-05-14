using UnityEngine;
using UnityEngine.Events;

public class healthScript : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;

    public UnityEvent<float> onHealthChanged;

    void Start()
    {
        onHealthChanged?.Invoke(currentHealth / maxHealth);
    }

    public void TakeDamage(float damage = 50)
    {
        currentHealth -= damage;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        onHealthChanged?.Invoke(currentHealth / maxHealth);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void HealToFull()
    {
        currentHealth = maxHealth;

        onHealthChanged?.Invoke(1f); 
    }
}