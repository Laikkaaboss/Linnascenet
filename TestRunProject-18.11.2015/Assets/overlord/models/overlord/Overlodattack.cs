using UnityEngine;
using System.Collections;

public class Overlodattack : MonoBehaviour {

    public float timeBetweenAttacks = 0.5f;     // The time in seconds between each attack.
    public int attackDamage = 10;               // The amount of health taken away per attack.


    Animator anim;                              // Reference to the animator component.
    public GameObject player;                          // Reference to the player GameObject.
    Transform playerPos;
    Transform enemyPos;
    public GameObject enemy;
    PlayerHealth playerHealth;   // Reference to the player's health.
    BossHealth bossHealth;
    NavMeshAgent nav;
    BossMovement bossMovement;                    // EnemyHealth enemyHealth;                    // Reference to this enemy's health.
    bool playerInRange;                         // Whether player is within the trigger collider and can be attacked.
    float timer;                                // Timer for counting up to the next attack.
    public int rangeToAggro;
    private int Lyopelaaja;
    private int isAggro;
    void Awake()
    {
        // Setting up the references.
        Lyopelaaja = Animator.StringToHash("LyoPelaaja");
        isAggro = Animator.StringToHash("isAggro");
        nav = GetComponent<NavMeshAgent>();
        // player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        bossHealth = GetComponent<BossHealth>();
        anim = GetComponent<Animator>();
        //  playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        playerPos = player.transform;
        enemyPos = enemy.transform;
    }


    void OnTriggerEnter(Collider other)
    {
        // If the entering collider is the player...
        Debug.Log("Tulostaa" + other.gameObject);
        if (other.gameObject == player)
        {
            //Lyö pelaajaa
            //     anim.SetBool()
            anim.SetBool(Lyopelaaja, true);
            //    Lyopelaajaa = true;

            //anim.SetTrigger("FIGHT Blend Tree");
            // ... the player is in range.
            nav.SetDestination(enemyPos.position);
            playerInRange = true;
        }
    }


    void OnTriggerExit(Collider other)
    {
        // If the exiting collider is the player...

        if (other.gameObject == player)
        {
            anim.SetBool(Lyopelaaja, false);
            // Lyopelaajaa = false;
            //Jatkaa jahtaamista
            // ... the player is no longer in range.
            playerInRange = false;
        }
    }


    void Update()
    {
        if (Vector3.Distance(player.transform.position, enemy.transform.position) < rangeToAggro)
        {
            anim.SetBool(isAggro, true);
            if (playerInRange == false)
            {
                nav.SetDestination(playerPos.position);
            }

            // Add the time since Update was last called to the timer.
            timer += Time.deltaTime;

            // If the timer exceeds the time between attacks, the player is in range and this enemy is alive...
            if (timer >= timeBetweenAttacks && playerInRange && bossHealth.currentHealth > 0)
            {
                // ... attack.
                Attack();
            }

            // If the player hadas zero or less health...
            if (playerHealth.currentHealth <= 0)
            {
                // ... tell the animator the player is dead.
                anim.SetTrigger("Die");
            }
        }
        else
        {
            nav.SetDestination(enemyPos.position);
            anim.SetBool(isAggro, false);
        }
    }


    void Attack()
    {
        // Reset the timer.
        timer = 0f;

        // If the player has health to lose...
        if (playerHealth.currentHealth > 0)
        {
            // ... damage the player.
            playerHealth.TakeDamage(attackDamage);
        }
    }
}