using UnityEngine;

public class PlayerFire : MonoBehaviour
{
	[SerializeField] private GameObject bullet;
	[SerializeField] private Transform gunBarrelTransform;
	[SerializeField] private float spawnOffset;
	void Update()
    {
		if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
		{
			Instantiate(bullet, gunBarrelTransform.position + gunBarrelTransform.up * spawnOffset, gunBarrelTransform.rotation);
		}
    }
}
