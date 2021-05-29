using UnityEngine;
using UnityEngine.UI;
public class HealthBar_ColorChange : MonoBehaviour
{
    [SerializeField] HealthSystem healthSys;
    [SerializeField] Image bar;
    [SerializeField] Color startColor;
    [SerializeField] Color endColor;
    void Start()
    {
        bar.fillAmount = healthSys.GetHealth();
    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = healthSys.GetHealth() / 100;
        // if(healthSys.GetHealth() > 75)
        //     bar.GetComponent<Image>().color = startColor;
        // else
            bar.GetComponent<Image>().color = Color.Lerp(endColor,startColor,bar.fillAmount*.9f);
    }
}
