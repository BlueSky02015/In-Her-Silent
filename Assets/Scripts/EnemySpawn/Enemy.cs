using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject player;
    private Transform enemySpawnPoint;
    private GameObject currentEnemy; // Store reference to the spawned enemy

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemySpawnPoint = this.gameObject.transform;
        currentEnemy = SpawnEnemy(); // Store the spawned enemy reference
    }

    void Update()
    {
        FacePlayer();
    }

    GameObject SpawnEnemy()
    {
        if (enemyPrefab != null && enemySpawnPoint != null)
        {
            return Instantiate(enemyPrefab, enemySpawnPoint.position, enemySpawnPoint.rotation);
        }
        else
        {
            Debug.LogError("Enemy prefab or spawn point is not set.");
            return null;
        }
    }

    void FacePlayer()
    {
        // Set the enemy's face to the player
        if (player != null && currentEnemy != null)
        {
            Vector3 directionToPlayer = player.transform.position - currentEnemy.transform.position;
            directionToPlayer.y = 0; // Optional: keep the enemy upright by ignoring vertical difference

            if (directionToPlayer != Vector3.zero)
            {
                Quaternion lookRotation = Quaternion.LookRotation(directionToPlayer);
                currentEnemy.transform.rotation = lookRotation;
            }
        }
    }
}