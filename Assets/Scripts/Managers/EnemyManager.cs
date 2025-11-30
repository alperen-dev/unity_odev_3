using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
	[HideInInspector] public static EnemyManager instance;
	[Header("Prefabs")]
	[SerializeField] GameObject enemy1Prefab;
	[SerializeField] GameObject enemy2Prefab;
	
	[Header("Count")]
	[SerializeField] private int maxEnemy1Number;
	[SerializeField] private int maxEnemy2Number;
	
	[Header("Spawn Properities")]
	[SerializeField] private float maxSpawnDistance = 50.0f;
	[SerializeField] private float minSpawnDistance = 10.0f;
	private List<GameObject> enemy1List;
	private List<GameObject> enemy2List;


	void Awake()
	{
		instance = this;
		enemy1List = new List<GameObject>();
		enemy2List = new List<GameObject>();
	}
	
	public void DestroyEnemy(GameObject enemy)
	{
		enemy1List.Remove(enemy);
		enemy2List.Remove(enemy);
		Destroy(enemy);
	}
	
	void Update()
    {
        if(enemy1List.Count < maxEnemy1Number)
		{
			float distance = Random.Range(minSpawnDistance, maxSpawnDistance);
			Vector3 spawnPosition = Random.insideUnitSphere.normalized * distance;
			enemy1List.Add(Instantiate(enemy1Prefab, spawnPosition, new Quaternion()));
		}
		if(enemy2List.Count < maxEnemy2Number)
		{
			float distance = Random.Range(minSpawnDistance, maxSpawnDistance);
			Vector3 spawnPosition = Random.insideUnitSphere.normalized * distance;
			enemy2List.Add(Instantiate(enemy2Prefab, spawnPosition, new Quaternion()));
		}
		
    }
}
