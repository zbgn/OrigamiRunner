using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {
public int obstaclesPoolSize = 25;
private GameObject[] obstacles;
private Vector2 objectPoolPosition = new Vector2 (-15f, -25f);
public float spawnRate = 4f;
private float timeSinceLastSpawned;
private float spawnXPosition = 10f;
private int currentObstacle = 0;
public List<GameObject> objectList = new List<GameObject>();

void Start () {
								obstacles = new GameObject[obstaclesPoolSize];
								for (int i = 0; i < obstaclesPoolSize; i++)
								{
																obstacles[i] = (GameObject) Instantiate(objectList[Random.Range(0,objectList.Count)], objectPoolPosition, Quaternion.identity);
								}
}

// Update is called once per frame
void Update () {
								timeSinceLastSpawned += Time.deltaTime;

								if (timeSinceLastSpawned >= spawnRate)
								{
																timeSinceLastSpawned = 0;
																obstacles[currentObstacle].transform.position = new Vector2(spawnXPosition, 0f);
																currentObstacle++;
																if (currentObstacle >= obstaclesPoolSize)
																{
																								currentObstacle = 0;
																}
								}
}
}
