using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] fishPrefabs;  // Farkl� bal�klar�n prefab'lar�
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

        // Rastgele bir spawn noktas� se�
        SpawnSide spawnSide = (SpawnSide)Random.Range(0, 2);
        Transform selectedSpawnPoint = GetSpawnPoint(spawnSide);

        // Farkl� bal�klar�n prefab'lar�n� i�eren listeyi kullanarak rastgele bir bal�k se�
        GameObject randomFishPrefab = fishPrefabs[Random.Range(0, fishPrefabs.Length)];

        // Se�ilen spawn noktas�nda rastgele bal��� instantiate et
        GameObject spawnedFish = Instantiate(randomFishPrefab, selectedSpawnPoint.position, Quaternion.identity);

        // FishMove bile�enini al
        FishMove fishMoveComponent = spawnedFish.GetComponent<FishMove>();

        // E�er FishMove bile�eni varsa, hareket y�n�n� belirle
        if (fishMoveComponent != null)
        {
            fishMoveComponent.SetMovementDirection(spawnSide);

            // E�er soldan spawnlan�yorsa, y rotation'� 180 yap
            if (spawnSide == SpawnSide.Right)
            {
                spawnedFish.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
        }
    }

    Transform GetSpawnPoint(SpawnSide spawnSide)
    {
        // Sa�dan m�, soldan m� spawn edilece�ini kontrol et ve uygun spawn noktas�n� d�nd�r
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
