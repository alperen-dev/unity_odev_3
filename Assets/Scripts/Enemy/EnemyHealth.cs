using UnityEngine;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
	private TextMeshProUGUI text;
	
	[Header("Health")]
	[SerializeField] private float maxHealth = 100;
	[SerializeField] private float minHealth = 0;

	public float MaxHealth => maxHealth;
	public float MinHealth => minHealth;
	
	private float health = 100;
	public float Health
	{
		get
		{
			return health;
		}
		set
		{
			health = Mathf.Clamp(value, minHealth, maxHealth);
			SetEnemyHealthText();
			if(health == minHealth)
			{
				EnemyManager.instance.DestroyEnemy(gameObject);
			}
		}
	}
	void Awake()
	{
		text = transform.Find("Canvas")?.Find("HealthText")?.GetComponent<TextMeshProUGUI>();
	}
	void Start()
	{
		SetEnemyHealthText();
	}
	public void SetEnemyHealthText()
	{
		if (text != null)
		{
			float red = 1.0f - Health / MaxHealth;
			float green = Health / MaxHealth;
			text.color = new Color(red, green, 0.0f);
			text.SetText(((int)Health).ToString());
			
		}
	}
}
