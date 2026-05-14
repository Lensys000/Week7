using UnityEngine;
using Cinemachine;

public class screenShake : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera vCam;
    [SerializeField] Gun gun;
    [SerializeField] float shakeDuration = 0.1f;
    float shakeTimer = 0;

    public void startShake()
    {
        Debug.Log("startShake called");
        if (gun.AttemptFire())
        {
            shakeTimer = shakeDuration;
        }
    }

    void Update()
    {
        if (shakeTimer > 0)
        {
            vCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 5;
            shakeTimer -= Time.deltaTime;
        }
        else
        {
            vCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0;
        }
    }
}