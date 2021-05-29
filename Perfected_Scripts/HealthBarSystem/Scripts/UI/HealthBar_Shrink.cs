using UnityEngine;
using UnityEngine.UI;
public class HealthBar_Shrink : MonoBehaviour
{
    private const float DAMAGED_HEALTH_SHRINK_TIMER_MAX = 0.75F;


    [SerializeField] Image barImage;
    [SerializeField] Image damagedBarImage;
    [SerializeField] HealthSystem health;
    [SerializeField,Range(0,2)] float shrinkTimer;
    private Color damagedColor;

    private void Start()
    {
        health.OnDamaged += HealthSystem_OnDamaged;
        health.OnHealed += HealthSystem_OnHealed;
        damagedBarImage.fillAmount = barImage.fillAmount;
    }
    private void Update()
    {
        shrinkTimer -= Time.deltaTime;
        if(shrinkTimer < 0)
        {
            if(barImage.fillAmount < damagedBarImage.fillAmount)
            {
                float shrinkSpeed = 0.5f;
                damagedBarImage.fillAmount -= shrinkSpeed * Time.deltaTime;
            }
        }
        barImage.fillAmount = health.GetHealth() / 100;
    }

    private void HealthSystem_OnHealed(object sender, System.EventArgs e)
    {
        damagedBarImage.fillAmount = barImage.fillAmount;
    }
    private void HealthSystem_OnDamaged(object sender, System.EventArgs e)
    {
        shrinkTimer = DAMAGED_HEALTH_SHRINK_TIMER_MAX;
    }
}
