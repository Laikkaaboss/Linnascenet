//using UnityEngine;
//using System.Collections;
//public class PlayerAttacking : MonoBehaviour

//{
//    public int attackDamage = 10;
//    public float range = 3f;
//    Ray attackRay;
//    RaycastHit attackHit;
//    EnemyHealth enemyHealth;
//    GameObject Enemy;

//    void Awake()
//    {
        
//       // enemyHealth = Enemy.GetComponent<EnemyHealth>();
//      //  enemyHealth = GetComponent<EnemyHealth>();
//    }

//    void Update()
//    {
//        if (Input.GetButtonDown("Lumbering"))
//        {
//            Attack();
//        }
//    }

   

//    void Attack()
//    {


//        if (Physics.Raycast(attackRay, out attackHit, range))
//        {
//            EnemyHealth enemyHealth = attackHit.collider.GetComponent<EnemyHealth>();

//            if (enemyHealth != null)
//                enemyHealth.TakeDamage(attackDamage, attackHit.point);
//        }
//    }
//}
//{
//    public GameObject enemy;
//    public float attackTimer;
//    public float coolDown;
//   // EnemyHealth enemyHealth;
//    // Use this for initialization
//    void Start()
//    {
//        attackTimer = 0;
//        coolDown = 2.0f;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (attackTimer > 0)
//            attackTimer -= Time.deltaTime;

//        if (attackTimer < 0)
//            attackTimer = 0;

//        if (Input.GetKeyUp(KeyCode.F))
//        {
//            if (attackTimer == 0)
//            {
//                Attack();
//                attackTimer = coolDown;
//            }
//        }

//    }

//    private void Attack()
//    {
//        float distance = Vector3.Distance(enemy.transform.position, transform.position);

//        Vector3 dir = (enemy.transform.position - transform.position).normalized;

//        float direction = Vector3.Dot(dir, transform.forward);

//        if (distance < 2.5f)
//        {
//            if (direction > 0)
//            {
//                EnemyHealth eh = (EnemyHealth)enemy.GetComponent("EnemyHealth");
//                eh.setCurrentHealth(-10);
//            }
//        }
//    }
//}