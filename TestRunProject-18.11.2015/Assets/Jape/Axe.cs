using UnityEngine;
using System.Collections;

public class Axe : MonoBehaviour
{
    public float timeBetweenAttacks = 0.02f;
    private float timer = 0.01f;
    public int damage = 1;
    public float attackDuration = 0.01F;
    public bool attacking = false;
    bool enemyInRange;
    EnemyHealth eHealth;


    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKeyDown("mouse 0"))
        {

  // Add the time since Update was last called to the timer.
            timer += Time.deltaTime;
            Debug.Log("timer: " + timer);
            Debug.Log("timeBetweenAttacks: " + timeBetweenAttacks);
            
                if (timer >= attackDuration) {
                timer = 0;
                // timer = timer - timeBetweenAttacks;
                // ... attack.
                attacking = true;
                }
                // Attack();
            
        }
        if (Input.GetKeyUp("mouse 0"))
        {
            attacking = false;
        }
    }


    void OnTriggerEnter(Collider col)
    {
      
        Debug.Log("Collisioni tähän tagiin : " + col.gameObject.name);
        if (attacking)
        {
            if (col.gameObject.name == "Enemy" || col.gameObject.name == "Enemy1" || col.gameObject.name == "Enemy2" || col.gameObject.name == "Enemy3" || col.gameObject.name == "Enemy4" || col.gameObject.name == "Enemy5" || col.gameObject.name == "Enemy6" || col.gameObject.name == "overlord" || col.gameObject.name == "creature1")
        {
                enemyInRange = true;
           // if (eHealth.currentHealth <= 0)
                 //GameObject.Destroy(col.gameObject); 
              col.SendMessage("receiveDamage", damage, SendMessageOptions.DontRequireReceiver);
                
            }
        }

        }


    void EnableDamage()
    {
        if (attacking == true) return;
        attacking = true;
        StartCoroutine("DisableDamage");
    }

    IEnumerator DisableDamage()
    {
        yield return new WaitForSeconds(attackDuration);
        attacking = false;
    }

}
//RAYCAST