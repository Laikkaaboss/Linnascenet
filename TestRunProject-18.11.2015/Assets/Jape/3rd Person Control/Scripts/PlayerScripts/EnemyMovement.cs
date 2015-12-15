using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    // Transform player;               // Reference to the player's position.
    public GameObject player;
    PlayerHealth playerHealth;      // Reference to the player's health.
    EnemyHealth enemyHealth;        // Reference to this enemy's health.
    NavMeshAgent nav;               // Reference to the nav mesh agent.
                                    //EnemyMovement enemyMovement;
    Animator anim;
    public GameObject ragdoll;
    private bool death = true;
    public GameObject enemy;
    public AudioClip dodClip;
    // Use this for initialization
    AudioSource playerAudio;
    private int isKuollut;
    public GameObject HpDrop;
    Transform enemyPos;

    void Awake()
    {
        isKuollut = Animator.StringToHash("Die");
        playerAudio = GetComponent<AudioSource>();
        // Set up the references.
        anim = GetComponent<Animator>();
    //    player = GameObject.FindGameObjectWithTag("Player").transform;
        //enemyMovement = GetComponent<EnemyMovement>();
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
        enemyPos = enemy.transform;

    }


    void Update()
    {
        // If the enemy and the player have health left...
	//	Debug.Log(Vector3.Distance (player.transform.position, enemy.transform.position));
			
        if (playerHealth.currentHealth > 0)
           
        {
           // nav.SetDestination(player.transform.position);
         //   Debug.Log("Perkele");
	//if (Vector3.Distance (player.transform.position, enemy.transform.position) < rangeToAggro) 

            if (enemyHealth.currentHealth <= 0)
            {
                if (death == true)
                {
                    playerAudio.clip = dodClip;
                    playerAudio.Play();
                    Debug.Log("KUOLI");
                    //  isKuollut = true;
                    nav.Stop();
                   // enemy.transform.y 0 jotain jee 
                    anim.SetBool(isKuollut, true);
                    // SpawnRagdoll();
                    Destroy(enemy,10);
                    death = false;
                    GameObject newHpDrop = (GameObject)Instantiate(HpDrop, enemyPos.position,Quaternion.identity);
                  //  newHpDrop.transform.Rotate(Vector3.right);
                    newHpDrop.name = "HpDrop";



                }
                //Sammuttaa kokonaan skriptin, pitäisi kaataa vain vihun liike
                //                 enemyMovement.enabled = false;

            }
            // ... set the destination of the nav mesh agent to the player.
            if (death == true)
            {
                //   nav.SetDestination(player.position);
            }
        
        // Otherwise...
        else
        {
            // ... disable the nav mesh agent.
            nav.enabled = false;
        }
		}
    }
    void SpawnRagdoll() 
    {
      //  Instantiate(ragdoll, enemy.transform.position, Quaternion.identity);

        //  var clone = Instantiate(ragdoll, transform.position, transform.rotation);
        //   Destroy(clone.gameObject, 5);
    }
}