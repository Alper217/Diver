using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] fishPrefabs;  // Farklý balýklarýn prefab'larý
    public float repeat = 3f;
    public Transform[] leftSpawnPoints;
    public Transform[] rightSpawnPoints;

    public enum SpawnSide
    {
        Left,
        Right
    }

    void Start()
    {
        InvokeRepeating("Spawn", 5f, repeat);
    }

    void Spawn()
    {

        // Rastgele bir spawn noktasý seç
        SpawnSide spawnSide = (SpawnSide)Random.Range(0, 2);
        Transform selectedSpawnPoint = GetSpawnPoint(spawnSide);

        // Farklý balýklarýn prefab'larýný içeren listeyi kullanarak rastgele bir balýk seç
        GameObject randomFishPrefab = fishPrefabs[Random.Range(0, fishPrefabs.Length)];

        // Seçilen spawn noktasýnda rastgele balýðý instantiate et
        GameObject spawnedFish = Instantiate(randomFishPrefab, selectedSpawnPoint.position, Quaternion.identity);

        // FishMove bileþenini al
        FishMove fishMoveComponent = spawnedFish.GetComponent<FishMove>();

        // Eðer FishMove bileþeni varsa, hareket yönünü belirle
        if (fishMoveComponent != null)
        {
            fishMoveComponent.SetMovementDirection(spawnSide);

            // Eðer soldan spawnlanýyorsa, y rotation'ý 180 yap
            if (spawnSide == SpawnSide.Right)
            {
                spawnedFish.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
        }
    }

    Transform GetSpawnPoint(SpawnSide spawnSide)
    {
        // Saðdan mý, soldan mý spawn edileceðini kontrol et ve uygun spawn noktasýný döndür
        if (spawnSide == SpawnSide.Left)
        {
            int randomIndex = Random.Range(0, leftSpawnPoints.Length);
            return leftSpawnPoints[randomIndex];
        }
        else
        {
            int randomIndex = Random.Range(0, rightSpawnPoints.Length);
            return rightSpawnPoints[randomIndex];
        }
    }
}
