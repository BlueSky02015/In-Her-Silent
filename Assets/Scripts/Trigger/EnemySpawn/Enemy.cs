using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform enemySpawnPoint;
    public GameObject enemyPrefab;
    public GameObject player;
    private GameObject currentEnemy; // Store reference to the spawned enemy
    BoxCollider boxCollider;
    private bool enemySpawned = false;
    private float eraseTime = 0f;
    public float time = 0f;
    private bool timerRunning = false;
    AudioManager audioManager;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        enemySpawnPoint = this.gameObject.transform;

        // Make sure the collider is set as a trigger
        if (boxCollider != null)
        {
            boxCollider.isTrigger = true;
        }
    }

    void Update()
    {
        if (currentEnemy != null)
        {
            FacePlayer();

            // Handle the erase timer manually instead of using Invoke
            if (timerRunning)
            {
                time -= Time.deltaTime;
                if (time <= eraseTime)
                {
                    ErasedEnemy();
                }
            }
        }
    }

    GameObject SpawnEnemy()
    {
        if (enemyPrefab != null && enemySpawnPoint != null)
        {
            enemySpawned = true;
            currentEnemy = Instantiate(enemyPrefab, enemySpawnPoint.position, enemySpawnPoint.rotation);
            timerRunning = true;
            eraseTime = 0f;
            return currentEnemy;
        }
        else
        {
            Debug.LogError("Enemy prefab or spawn point is not set.");
            return null;
        }
    }

    void FacePlayer()
    {
        if (player != null && currentEnemy != null)
        {
            Vector3 directionToPlayer = player.transform.position - currentEnemy.transform.position;
            directionToPlayer.y = 0;

            if (directionToPlayer != Vector3.zero)
            {
                Quaternion lookRotation = Quaternion.LookRotation(directionToPlayer);
                currentEnemy.transform.rotation = lookRotation;
            }
        }
    }

    void ErasedEnemy()
    {
        if (currentEnemy != null)
        {
            Destroy(currentEnemy);
            currentEnemy = null;
            enemySpawned = false;
            timerRunning = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !enemySpawned)
        {
            currentEnemy = SpawnEnemy();


            float randomPitch = Random.Range(0.8f, 1.2f);
            audioManager.playSFX(audioManager.GrannyJumpSFX, randomPitch);
            
            GetComponent<Collider>().enabled = false;
        }
    }
}