using UnityEngine;
using UnityEngine.UI;

public class healthFill : MonoBehaviour
{
    [SerializeField] Image fillImage;

    public void SetHealth(float value)
    {
        fillImage.fillAmount = value;
    }
}