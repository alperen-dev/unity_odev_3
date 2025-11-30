using UnityEngine;

public class Enemy1DamageZone : MonoBehaviour
{
	[SerializeField] private float damagePerSecond = 10.0f;
	private bool isPlayerInside = false;
	[HideInInspector] public bool IsPlayerInside => isPlayerInside;
	void OnTriggerExit(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			isPlayerInside = false;
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			isPlayerInside = true;
		}
	}
	void Update()
	{
		if(isPlayerInside == true && PlayerHealth.instance != null)
		{
			PlayerHealth.instance.Health -= Time.deltaTime * damagePerSecond;
		}
	}
}
