using UnityEngine;

public class Enemy1 : MonoBehaviour
{
	[SerializeField] private GameObject player;
    [SerializeField] private float movementSpeed = 4.5f;
	
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 direction = (player.transform.position - transform.position).normalized;
		Quaternion rotationDirection = Quaternion.LookRotation(player.transform.position - transform.position);
		transform.rotation = rotationDirection;
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }
}
