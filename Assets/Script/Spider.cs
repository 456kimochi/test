using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{
    private GameObject player;
    private Vector3 direct;
    public float speed = 2f;
    private bool turnLeft = false;
    private bool attackCooldown = true;
    private bool webFireCooldown = true;

    public Animator anim;
    public GameObject manager;

    public GameObject atkrange;
    public GameObject webBullet;
    public Transform webBulletOrigin;
    public GameObject subLight;

    public float HP;

    public bool action = false;

    void Awake()
    {
        HP = 36;
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

        if (Mathf.Abs(distance) < 3 && attackCooldown && player.GetComponent<Kirby>().onGround)
        {
            attackCooldown = false;
            anim.SetTrigger("Attack");
            speed = 10;
            Invoke("ResetAttackCooldown", 3);
        }
        else if (Mathf.Abs(distance) > 1 && webFireCooldown)
        {
            webFireCooldown = false;
            anim.SetTrigger("WebFire");
            speed = 0;
            float resetWebFireTime = Random.Range(5, 6.5f);
            Invoke("ResetWebFireCooldown", resetWebFireTime);
        }
    }
    public void BeginNormalAttack()
    {
        atkrange.SetActive(true);
    }
    public void EndNormalAttack()
    {
        atkrange.SetActive(false);
        speed = 2;
    }
    private void ResetAttackCooldown()
    {
        attackCooldown = true;

    }
    public void BeginWebFire()
    {
        Vector3 direct = player.transform.position - transform.position; 
        GameObject myWeb = Instantiate(webBullet, webBulletOrigin.position, Quaternion.identity);
        myWeb.GetComponent<WebBullet>().dir = direct;
    }
    public void EndWebFire()
    {
        speed = 2;
    }
    private void ResetWebFireCooldown()
    {
        webFireCooldown = true;
    }
    public void GetHit(float damage)
    {
        HP -= damage;
    }
}
