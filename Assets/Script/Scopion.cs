using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scopion : MonoBehaviour
{
    private GameObject player;
    private Vector3 direct;
    public float speed = 4f;
    private bool turnLeft = false;
    private bool attackCooldown = true;

    public Animator anim;
    public GameObject manager;

    public GameObject atkrange;
    public GameObject subLight;

    public float HP;

    public bool action = false;

    void Awake()
    {
        HP = 42;
        player = GameObject.FindGameObjectWithTag("Player");
        anim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (HP <= 0)
        {
            GameObject myLight = Instantiate(subLight, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
            return;
        }
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0f);
        if (!action) return;
        Action();
    }


    private void Action()
    {
        float distance = player.transform.position.x - gameObject.transform.position.x;
        direct = new Vector3(distance, 0, 0);
        direct = direct.normalized;
        Vector3 currentScale = transform.localScale;
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
                transform.localScale = new Vector3(-1, 1, 0) * 1;
            }
            else if (distance > 0 && turnLeft == false)
            {
                transform.localScale = new Vector3(1, 1, 0) * 1;
            }
            gameObject.transform.position += direct * speed * Time.deltaTime;
        }

        if (Mathf.Abs(distance) < 2 && attackCooldown && player.GetComponent<Kirby>().onGround)
        {
            attackCooldown = false;
            anim.SetTrigger("Attack");
            Invoke("ResetAttackCooldown", 3);
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
    private void ResetAttackCooldown()
    {
        attackCooldown = true;

    }
    public void GetHit(float damage)
    {
        HP -= damage;
    }
}
