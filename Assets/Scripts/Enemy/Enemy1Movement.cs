using UnityEngine;

public class Enemy1 : MonoBehaviour
{
	[SerializeField] private float movementSpeed = 4.5f;
	private GameObject player;

	void Awake()
	{
		player = GameObject.FindWithTag("Player");
	}

	void Update()
    {
		Vector3 direction = (player.transform.position - transform.position).normalized;
		Quaternion rotationDirection = Quaternion.LookRotation(player.transform.position - transform.position);
		transform.rotation = rotationDirection;
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }
}
