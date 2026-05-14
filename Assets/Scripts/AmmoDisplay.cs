using TMPro;
using UnityEngine;

public class AmmoDisplay : MonoBehaviour
{
    [SerializeField] Gun gun;
    [SerializeField] TMP_Text ammoText;

    void Update()
    {
        ammoText.text = gun.Ammo + "/" + gun.MaxAmmo;
    }
}
