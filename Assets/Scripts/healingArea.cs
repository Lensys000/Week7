using UnityEngine;
using UnityEngine.Events;

public class healingArea : MonoBehaviour
{
    public UnityEvent Onbuttonpressed;
    bool playerInRange;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            Onbuttonpressed?.Invoke();
        }
    }
}