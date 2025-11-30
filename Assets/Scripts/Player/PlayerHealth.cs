using TMPro;
using UnityEditorInternal;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	[HideInInspector] public static PlayerHealth instance;
	
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
			UIManager.instance.SetPlayerHealthText();
		}
	}
	
	
	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		UIManager.instance.SetPlayerHealthText();
	}

}
