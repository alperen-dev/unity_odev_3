using UnityEngine;

public class Enemy1DamageZone : MonoBehaviour
{
	public float damagePerSecond = 10.0f;
	private bool isPlayerInside = false;
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
