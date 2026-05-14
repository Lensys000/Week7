using UnityEngine;

public class enemyCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            healthScript player = collision.gameObject.GetComponent<healthScript>();

            if (player != null)
            {
                player.TakeDamage(10);
            }
        }
    }
}