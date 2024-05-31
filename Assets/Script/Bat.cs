using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    private GameObject player;
    private GameObject checkGround;
    private GameObject targetPos;
    private Vector3 direct;
    private Vector3 target;
    private Vector3 position;
    public float speed = 1.5f;
    private bool turnLeft = false;
    private bool attackCooldown = true;
    private bool attacking = false;

    public Animator anim;
    public GameObject manager;

    public GameObject atkrange;
    public GameObject subLight;

    public float HP;

    public bool action = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        checkGround = GameObject.FindGameObjectWithTag("CheckGround");
        targetPos = GameObject.FindGameObjectWithTag("Target");
        HP = 7;
        anim = GetComponent<Animator>();
        
    }

    void Update()
    {
        if (HP <= 0)
        {
            GameObject myLight = Instantiate(subLight, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
            return;
        } 
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0f);
        if (!action)
        {
            return;
        }
        Action();
    }

    private void Action()
    {
        target =   checkGround.transform.position - transform.position;
        float distance = player.transform.position.x - gameObject.transform.position.x;
        direct = new Vector3(distance, 0, 0);
        direct = direct.normalized;
        Vector3 currentScale = transform.localScale;
        if (!attacking)
        {
            if (Mathf.Abs(distance) > 1)
            {
                if (distance < 0)
                {
                    turnLeft = true;
                }
                else
                {
                    turnLeft = false;
                }
                if (distance < 0 && turnLeft == true)
                {
                    transform.localScale = new Vector3(1, 1, 0) * 1;
                }
                else if (distance > 0 && turnLeft == false)
                {
                    transform.localScale = new Vector3(-1, 1, 0) * 1;
                }
                if (!attacking)
                {
                    gameObject.transform.position += direct * speed * Time.deltaTime;
                }
            }
        }
        else
        {
            speed = 20;
            gameObject.transform.position += target * speed * Time.deltaTime;
        }
        
        if (attackCooldown && Mathf.Abs(distance) < 2)
        {
            position = transform.position;
            attacking = true;
            attackCooldown = false;
            anim.SetTrigger("Attack");         
            Invoke("ResetAttackCooldown", 2);
            Invoke("ResetAnim", 0.4f);
        }
    }

    public void BeginNormalAttack()
    {
        atkrange.SetActive(true);
    }
    public void EndNormalAttack()
    {
        atkrange.SetActive(false);
    }
    public void GetHit(float damage)
    {
        HP -= damage;
    }

    private void ResetAnim()
    {
        speed = 1.5f;
        attacking = false;
        transform.position = position;
    }

    private void ResetAttackCooldown()
    {
        attackCooldown = true;
    }
}
