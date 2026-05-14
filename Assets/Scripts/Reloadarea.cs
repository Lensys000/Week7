using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

public class Reloadarea : MonoBehaviour
{
    public UnityEvent Onbuttonpressed;
    [SerializeField] Gun gun;
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
            if (gun.Ammo < gun.MaxAmmo)
            {
                Onbuttonpressed.Invoke();
            }
        }

    }
}