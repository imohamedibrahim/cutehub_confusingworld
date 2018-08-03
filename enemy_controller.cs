//enemy controller ai based<NAVAGENT>//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy_controller : MonoBehaviour {
    public float radiusCircle = 18f;
    Transform player;
    public int turn;
    public int acc;
    public int spd;
    int dead;
    NavMeshAgent agent;
    Animator anim;
    
    int frame;
    bool give_access;
    public float roamRadius;
    public Rigidbody rigid;
    public int time_to_change;
	// Use this for initialization
	void Start () {
        give_access = true;
        player = player_manager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        frame = 0;
        anim = GetComponent<Animator>();
	}
    // Update is called once per frame
    void Update () {
        float distance = Vector3.Distance(player.position , transform.position);
        if (enemy_blocker.get_can_chase()&&distance < radiusCircle)
        {
            give_access = true;
            rigid.isKinematic = false;
            if (face(player.position))
            {
                Debug.Log("attack");
                agent.acceleration =acc;
                agent.speed = spd;
                anim.SetBool("isWalk",false);
                anim.SetBool("isAttack", false);
                anim.SetBool("isIdle", false);
                if (agent.stoppingDistance < distance)
                {
                    
                    agent.destination=player.position;
                    anim.SetBool("isRun", true);
                }
                else
                {
                    
                    anim.SetBool("isAttack", true);
                    anim.SetBool("isRun",false);
                }
            }
        }else
        {
            rigid.isKinematic = true;
            if (frame % time_to_change==0 || give_access)
            {
                roam(roamRadius);
                give_access = false;
                frame = 0;
            }
        }
        frame++;
		
	}
    void roam(float roamRadius)
    {
        agent.speed = 2;
        agent.acceleration = 2;
        anim.SetBool("isRun", false);
        anim.SetBool("isWalk", true);
        anim.SetBool("isAttack", false);
        if (Random.Range(-1, 10) % 5 == 0)
        {
            anim.SetBool("isAttack", true);
        }
        anim.SetBool("isIdle", false);
        Vector3 randomDirection = UnityEngine.Random.insideUnitSphere * roamRadius;
        NavMeshHit navHit;
        NavMesh.SamplePosition(randomDirection, out navHit, roamRadius, 1);
        if (face(randomDirection))
        {           
            agent.destination = navHit.position;
        }
    }
    bool face(Vector3 p)
    {
        Vector3 dir = (p-transform.position).normalized;
        Quaternion lookRotation =Quaternion.LookRotation(new Vector3(dir.x,0,dir.z));
        //lookRotation *= Quaternion.Euler(0,turn,0);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, 20f * Time.deltaTime);
        return true;
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position ,radiusCircle);
    }
}
