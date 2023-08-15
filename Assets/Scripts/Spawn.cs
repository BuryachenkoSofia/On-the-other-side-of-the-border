using System.Collections;
using UnityEngine;
using Random = System.Random;

public class Spawn : MonoBehaviour
{
    public Transform point0, point1;
    public GameObject Platform, Platform_Wide, Platform_Vertica_Small, Platform_Vertical;
    public GameObject coin;

    private float initialSpawnInterval = 3.0f, minSpawnInterval = 0.6f, accelerationRate = 0.1f;
    private float currentSpawnInterval;

    private void Start()
    {
        currentSpawnInterval = initialSpawnInterval;
        StartCoroutine(SpawnObstacles());
    }

    private IEnumerator SpawnObstacles()
    {
        while (true)
        {
            Random rnd = new Random();
            int who = rnd.Next(0, 5);
            switch (who)
            {
                case 0:
                    Instantiate(coin, point0.position, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(Platform, point0.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(Platform_Wide, point0.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(Platform_Vertica_Small, point0.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(Platform_Vertical, point0.position, Quaternion.identity);
                    break;
            }
            int who1 = rnd.Next(0, 5);
            switch (who1)
            {
                case 0:
                    Instantiate(coin, point1.position, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(Platform, point1.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(Platform_Wide, point1.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(Platform_Vertica_Small, point1.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(Platform_Vertical, point1.position, Quaternion.identity);
                    break;
            }

            if (currentSpawnInterval > minSpawnInterval)
                currentSpawnInterval -= accelerationRate;

            yield return new WaitForSeconds(currentSpawnInterval);
        }
    }
}
