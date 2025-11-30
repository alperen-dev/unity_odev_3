using UnityEngine;
using System.Collections;

public class Enemy2Fire : MonoBehaviour
{
	[SerializeField] private GameObject bullet;
    [SerializeField] private float fireFrequency = 2.0f;
	[SerializeField] private float fireOffset = 0.3f;
	
	private Transform[] gunBarrelTransforms;
	private bool fireStarted = false;
	public bool FireStarted
	{
		get
		{
			return fireStarted;
		}
		set
		{
			fireStarted = value;
		}
	}
	private int gunBarrelIndex = 0;
	
	void Awake()
	{
		gunBarrelTransforms = new Transform[2];
		gunBarrelTransforms[0] = transform.Find("GunBarrel1");
		gunBarrelTransforms[1] = transform.Find("GunBarrel2");
	}

	void Start()
	{
		StartCoroutine(Fire());
	}

	private IEnumerator Fire()
	{
		while(true)
		{
			while(fireStarted == false)
			{
				yield return null;
			}
			Instantiate(bullet, gunBarrelTransforms[gunBarrelIndex].position + gunBarrelTransforms[gunBarrelIndex].up * fireOffset, gunBarrelTransforms[gunBarrelIndex].rotation);
			gunBarrelIndex = (gunBarrelIndex + 1) % gunBarrelTransforms.Length;
			yield return new WaitForSeconds(fireFrequency); // 2 saniye bekle (wait)
		}
	}
}
