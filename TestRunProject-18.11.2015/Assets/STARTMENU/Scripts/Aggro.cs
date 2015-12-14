using UnityEngine;
using System.Collections;


public class Aggro : MonoBehaviour {
    NavMeshAgent nav;
    Transform playerPos;
    Transform enemyPos;
    
    void Awake()
    {
        
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
             nav.SetDestination(playerPos.position);
            //anim.SetBool(Lyopelaaja, true);
        }
    }

    void OnTriggerExit (Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            nav.SetDestination(enemyPos.position);

            //anim.SetBool(Lyopelaaja, false);
        }
    }

   
}
