using UnityEngine;
using UnityEngine.UI;
public class HealthBar_Fade : MonoBehaviour
{
    private const float DAMAGED_HEALTH_FADE_TIMER_MAX = 0.75F;

    [SerializeField] Image barImage;
    [SerializeField] Image damagedBarImage;
    [SerializeField] HealthSystem health;
    [SerializeField,Range(0,2)] float damagedHealthFadeTimer;
    private Color damagedColor;

    private void Awake() {
        damagedColor = damagedBarImage.color;
        damagedColor.a = 0f;
    }
    private void Start() {
        health.OnDamaged += HealthSystem_OnDamaged;
        health.OnHealed += HealthSystem_OnHealed;
        damagedBarImage.fillAmount = barImage.fillAmount;
    }
    private void Update() {
        if(damagedColor.a > 0)
        {
            damagedHealthFadeTimer -= Time.deltaTime;
            if(damagedHealthFadeTimer < 0)
            {
                float fadeAmount = 5f;
                damagedColor.a -= fadeAmount * Time.deltaTime;
                damagedBarImage.color = damagedColor;
            }

        }
        barImage.fillAmount = health.GetHealth() / 100;
    }

    private void HealthSystem_OnHealed(object sender, System.EventArgs e)
    {

    }
    private void HealthSystem_OnDamaged(object sender, System.EventArgs e)
    {
        if(damagedColor.a <= 0)
        {
            damagedBarImage.fillAmount = barImage.fillAmount;
        }
        damagedColor.a = 1;
        damagedBarImage.color = damagedColor;
        damagedHealthFadeTimer = DAMAGED_HEALTH_FADE_TIMER_MAX;
    }
}
