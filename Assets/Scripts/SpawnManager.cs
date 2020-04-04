using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  [SerializeField] GameObject[] animalPrefabs;
  public int animalIndex;

  private float spawnPosZ = 20;
  private float spawnRangeX = 10;
  private float startDelay = 2;
  private float spawnInterval = 1.5f;

  private void Start()
  {
    InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.S))
    {
      SpawnRandomAnimal();
    }
  }

  private void SpawnRandomAnimal()
  {
    int animalIndex = Random.Range(0, animalPrefabs.Length);

    Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

    Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
  }
}