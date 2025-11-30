using UnityEngine;

public class PlayerFire : MonoBehaviour
{
	[SerializeField] private GameObject bullet;
	[SerializeField] private Transform gunBarrelTransform;
	void Update()
    {
		if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
		{
			Instantiate(bullet, gunBarrelTransform.position, gunBarrelTransform.rotation);
		}
    }
}
