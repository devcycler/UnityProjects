using UnityEngine;
using UnityEngine.UI;
public class HealthBar_Basic : MonoBehaviour
{
    [SerializeField] HealthSystem health;
    [SerializeField] Image bar;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = health.GetHealth() / 100;
    }
}
