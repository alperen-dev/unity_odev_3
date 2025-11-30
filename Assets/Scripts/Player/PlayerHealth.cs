using TMPro;
using UnityEditorInternal;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	[HideInInspector] public static PlayerHealth instance;

	[Header("Health Text")]
	[SerializeField] private TextMeshPro text;
	
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
			if (value >= minHealth && value <= maxHealth)
			{
				health = value;
				UIManager.instance.SetHealthText();
			}
		}
	}
	
	
	void Awake()
	{
		instance = this;
	}
	
}
