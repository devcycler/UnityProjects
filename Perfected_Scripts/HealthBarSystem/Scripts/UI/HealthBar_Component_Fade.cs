using UnityEngine;
using UnityEngine.UI;
public class HealthBar_Component_Fade : MonoBehaviour
{
    private RectTransform rectTransform;
    [SerializeField] float fallTimer = 0.3f;
    private float fadeTimer = .5f;
    private Color color;
    private Image image;
    private void Awake() {
        rectTransform = transform.GetComponent<RectTransform>();
        image = transform.GetComponent<Image>();
        color = image.color;
    }
    private void Update()
    {
        fallTimer -= Time.deltaTime;
        if(fallTimer < 0)
        {
            float fallSpeed = 60f;
            rectTransform.anchoredPosition += Vector2.down * fallSpeed * Time.deltaTime;
            fadeTimer -= Time.deltaTime;
            if(fadeTimer < 0)
            {
                float fadeSpeed = 3f;
                color.a -= fadeSpeed * Time.deltaTime;
                image.color = color;
                if(color.a <= 0)
                    Destroy(gameObject);
            }
        }
    }
}
