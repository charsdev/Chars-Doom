using UnityEngine;
using TMPro;
public class BlinkText : MonoBehaviour
{
    private TextMeshProUGUI text;
    private void Awake()
    {
        text = gameObject.GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, Mathf.PingPong(Time.unscaledTime, 1));
    }
}
