using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
	public static UIManager instance; 
	private TextMeshProUGUI text;
	void Awake()
	{
		instance = this;
		text = transform.Find("HealthText").gameObject.GetComponent<TextMeshProUGUI>();
	}

	public void SetHealthText()
	{
		if (text != null && PlayerHealth.instance != null)
		{
			float red = 1.0f - PlayerHealth.instance.Health / PlayerHealth.instance.MaxHealth;
			float green = PlayerHealth.instance.Health / PlayerHealth.instance.MaxHealth;
			text.color = new Color(red, green, 0.0f);
			text.SetText($"Health: {PlayerHealth.instance.Health}");
			
		}
	}
}
