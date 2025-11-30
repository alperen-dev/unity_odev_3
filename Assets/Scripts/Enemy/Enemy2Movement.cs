using UnityEngine;

public class Enemy2Movement : MonoBehaviour
{
	[SerializeField] private float movementSpeed = 4.0f;
	private Enemy2TriggerZone enemy2TriggerZone;
	private GameObject player;

	void Awake()
	{
		player = GameObject.FindWithTag("Player");
		enemy2TriggerZone = transform.Find("TriggerZone").GetComponent<Enemy2TriggerZone>();
	}

	void Update()
    {
		// rotate to player
		Quaternion rotationDirection = Quaternion.LookRotation(player.transform.position - transform.position);
		transform.rotation = rotationDirection;
		if(enemy2TriggerZone.IsTriggered == false) // move to player
		{
			transform.position += transform.forward * movementSpeed * Time.deltaTime;
		}
		//Debug.Log(Vector3.Magnitude(player.transform.position - transform.position));
		//Debug.Log(enemy2TriggerZone.IsTriggered);
    }
}
