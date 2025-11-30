using UnityEngine;

public class Enemy1Movement : MonoBehaviour
{
	[SerializeField] private float movementSpeed = 4.5f;
	private Enemy1DamageZone enemy1DamageZone;
	private GameObject player;

	void Awake()
	{
		player = GameObject.FindWithTag("Player");
		enemy1DamageZone = transform.Find("DamageZone").GetComponent<Enemy1DamageZone>();
	}

	void Update()
    {
		if(enemy1DamageZone.IsPlayerInside == false)
		{
			Quaternion rotationDirection = Quaternion.LookRotation(player.transform.position - transform.position);
			transform.rotation = rotationDirection;
			transform.position += transform.forward * movementSpeed * Time.deltaTime;
		}
    }
}
