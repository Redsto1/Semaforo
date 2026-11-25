using UnityEngine;

public class Semaforo : MonoBehaviour
{

    [SerializeField]
    GameObject GreenLight;
    [SerializeField]
    GameObject YellowLight;
    [SerializeField]
    GameObject RedLight;

    float Timer = 0f;

    private void Start()
    {
        turnOnLight(2);
    }

    private void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= 10f && RedLight.activeSelf == true)
        {
            turnOnLight(0);
            Timer = 0f;
        }
        if (Timer >= 15f && GreenLight.activeSelf == true)
        {
            turnOnLight(1);
            Timer = 0f;
        }
        if (Timer >= 2f && YellowLight.activeSelf == true)
        {
            turnOnLight(2);
            Timer = 0f;
        }
    }

    void turnOnLight(int selectedlight)
    {
        RedLight.SetActive(false);
        GreenLight.SetActive(false);
        YellowLight.SetActive(false);
        switch (selectedlight)
        {
            case 0:
                GreenLight.SetActive(true);
                break;
            case 1:
                YellowLight.SetActive(true);
                break;
            case 2:
                RedLight.SetActive(true);
                break;
            default:
                Debug.LogWarning("Outside of Light limit!");
                break;
        }

    }
}
