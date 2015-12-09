using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public float maxHP = 100.0F;
    public float currentHealth;
    public GameObject Enemy;
    private int isKuollut;
    CapsuleCollider capsuleCollider;
    bool isDead;
    EnemyMovement enemyMovement;
    Animator anim;
    public AudioClip damageClip;
    // Use this for initialization
    AudioSource playerAudio;
    void Awake()
    {
        playerAudio = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        enemyMovement = GetComponent<EnemyMovement>();
        isKuollut = Animator.StringToHash("isKuollut");
    }
    void Start()
    {

        currentHealth = maxHP;

    }

    // Update is called once per frame
    void Update()
    {

        checkStatus();

    }
    public void checkStatus()
    {
        {
            if (currentHealth > maxHP)
                currentHealth = maxHP;

            if (currentHealth < 0)
                currentHealth = 0;

            if (currentHealth == 0)
                Death();
        }
    }
    public void receiveDamage(float damage)
    {
        playerAudio.clip = damageClip;
        playerAudio.Play();
        currentHealth = currentHealth - damage;
        Debug.Log("CURRENTHEALTH : " + currentHealth);
    }
    void Death()
    {
        // Set the death flag so this function won't be called again.
        isDead = true;

        // Turn off any remaining shooting effects.
        // playerShooting.DisableEffects();

        // Tell the animator that the player is dead.
        //anim.SetTrigger("Die");
        anim.SetBool(isKuollut, true);

        // Set the audiosource to play the death clip and play it (this will stop the hurt sound from playing).
        //playerAudio.clip = deathClip;
        //playerAudio.Play();

        // Turn off the movement and shooting scripts.
        //  enemyMovement.enabled = false;
        //  playerShooting.enabled = false;
    }


}
