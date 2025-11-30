using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 30.0f;
	[SerializeField] private float projectileDistance = 50.0f;
	[SerializeField] private float damage = 25.0f;
	private float sqrProjectileDistance;
	
	private Vector3 startPos;
    void Start()
	{
		startPos = transform.position;
		sqrProjectileDistance = projectileDistance * projectileDistance;
	}

	// Update is called once per frame
	void Update()
	{
		transform.position += transform.TransformDirection(Vector3.up * speed * Time.deltaTime);
		if (Vector3.SqrMagnitude(transform.position - startPos) >= sqrProjectileDistance)
		{
			Destroy(gameObject);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Enemy"))
		{
			other.gameObject.GetComponent<EnemyHealth>().Health -= damage;
			Destroy(gameObject);
		}
		else if(other.CompareTag("Player"))
		{
			other.gameObject.GetComponent<PlayerHealth>().Health -= damage;
			Destroy(gameObject);
		}
	}
}
