using UnityEngine;

public class Enemy2TriggerZone : MonoBehaviour
{
	private bool isTriggered = false;
	public bool IsTriggered => isTriggered;
	private Enemy2Fire enemy2Fire;

	void Awake()
	{
		enemy2Fire = transform.GetComponentInParent<Enemy2Fire>();
	}

	void OnTriggerEnter(Collider other)
	{
		
		if(other.CompareTag("Player"))
		{
			isTriggered = true;
			enemy2Fire.FireStarted = true;
		}
	}
	void OnTriggerExit(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			isTriggered = false;
			enemy2Fire.FireStarted = false;
		}
	}

}
