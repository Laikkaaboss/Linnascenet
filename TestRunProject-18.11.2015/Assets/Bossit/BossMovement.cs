using UnityEngine;
using System.Collections;

public class BossMovement : MonoBehaviour
{
    //Transform player;               // Reference to the player's position.
    public GameObject player;
    PlayerHealth playerHealth;      // Reference to the player's health.
    BossHealth bossHealth;        // Reference to this enemy's health.
    NavMeshAgent nav;               // Reference to the nav mesh agent.
                                    //EnemyMovement enemyMovement;
    Animator anim;
    public GameObject ragdoll;
    private bool death = true;
    public GameObject Boss;
    public AudioClip dodClip;
    // Use this for initialization
    AudioSource playerAudio;
    private int isKuollut;
    public GameObject nextLvl;
    Transform BossPos;
    void Awake()

    {
       
        isKuollut = Animator.StringToHash("IsKuollut");
        playerAudio = GetComponent<AudioSource>();
        // Set up the references.
        anim = GetComponent<Animator>();
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        //enemyMovement = GetComponent<EnemyMovement>();
        playerHealth = player.GetComponent<PlayerHealth>();
        bossHealth = GetComponent<BossHealth>();
        nav = GetComponent<NavMeshAgent>();
        BossPos = Boss.transform;

    }


    void Update()
    {
        // If the enemy and the player have health left...

        if (playerHealth.currentHealth > 0){

            if (bossHealth.currentHealth <= 0)
            {
                if (death == true)
                {
                    playerAudio.clip = dodClip;
                    playerAudio.Play();
                    nav.Stop();
                    anim.SetBool(isKuollut, true);
                    // Destroy(Boss, 10);
                    //     death = false;


                    // GameObject newnextLvl = (GameObject)Instantiate(nextLvl, BossPos.position, Quaternion.identity);
                    // newnextLvl.name = "nextLvl";
                    // Debug.Log("LVLDROP TULI");

                    //Soita tässä dialogi X
                    waitti();
                    StartCoroutine(waitti());
                    
                }

            }
            // ... set the destination of the nav mesh agent to the player.

        }
        // Otherwise...
        else
        {
            // ... disable the nav mesh agent.
            nav.enabled = false;
        }
    }
    IEnumerator waitti()
    {
        yield return new WaitForSeconds(10);
        Application.LoadLevel(Application.loadedLevel + 1);

    }
}