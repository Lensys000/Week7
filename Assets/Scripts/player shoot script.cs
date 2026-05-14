using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] screenShake screenShake;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           // Debug.Log("clicked from: " + gameObject.name);
            screenShake.startShake();
        }
    }
}