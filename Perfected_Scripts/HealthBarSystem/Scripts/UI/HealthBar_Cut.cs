using UnityEngine;
using UnityEngine.UI;
public class HealthBar_Cut : MonoBehaviour
{
    private const float BAR_WIDTH = 0.75F;
    [SerializeField] Image barImage;
    [SerializeField] Transform damagedBarTemplate;
    [SerializeField] HealthSystem health;
    private float barWidth;
    private void Awake() {
        barWidth = gameObject.GetComponentInParent<RectTransform>().rect.width;
    }
    private void Start()
    {
        health.OnDamaged += HealthSystem_OnDamaged;
        health.OnHealed += HealthSystem_OnHealed;
    }

    private void Update() 
    {
        barImage.fillAmount = health.GetHealth()/100;
    }

    private void HealthSystem_OnHealed(object sender, System.EventArgs e)
    {
        barImage.fillAmount = health.GetHealth() / 100;
    }
    private void HealthSystem_OnDamaged(object sender, System.EventArgs e)
    {
        float beforeDamageFillAmount = barImage.fillAmount;
        barImage.fillAmount = health.GetHealth()/100;
        Transform damagedBar = Instantiate(damagedBarTemplate,transform);
        damagedBar.gameObject.SetActive(true);
        damagedBar.GetComponent<RectTransform>().anchoredPosition = new Vector2 (barImage.fillAmount * barWidth, barImage.GetComponent<RectTransform>().anchoredPosition.y);
        damagedBar.GetComponent<Image>().fillAmount = beforeDamageFillAmount - barImage.fillAmount;
        damagedBar.gameObject.AddComponent<HealthBar_Component_Fade>();
    }
}
