using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Alien : MonoBehaviour
{
    private GameObject player;
    private Vector3 direct;
    public float speed = 2f;
    public float standardSpeed = 2;
    private bool enhance = false;
    private bool turnLeft = false;
    private bool attackCooldown = false;
    private bool dashCooldown = false;
    private bool fireCooldown = false;
    public bool summoning = false;
    private int summonLeft = 2;
    private float timer = 0;
    private float normalAttackTimer = 0;

    public Animator anim;
    public GameObject bullet;
    public Transform bulletOrigin;
    public GameObject slime;
    public GameObject manager;

    public GameObject atkrange;

    public float HP;

    public bool hitByTonado = false;
    public bool action;

    public GameObject bubbleHeart;
    // Start is called before the first frame update
    void Awake()
    {
        HP = 150;
        player = GameObject.FindGameObjectWithTag("Player");
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            gameObject.SetActive(false);
            manager.GetComponent<GameManager>().alienDeath = true;
            return;
        }
        if (!action) return;
        if (hitByTonado == true)
        {
            Invoke("ResetHitByTonado", 5);
        }
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0f);
        if (!enhance)
        {
            Action();
            resetAttack();
        }
        else
        {
            ActionEnhance();
            resetAttackEnhance();
        }
    }
    private void ResetHitByTonado()
    {
        hitByTonado = false;
    }
    private void resetAttack()
    {
        timer += Time.deltaTime;
        normalAttackTimer += Time.deltaTime;
        if (timer >= 3) 
        {
            dashCooldown = true;
            fireCooldown = true;
            timer = 0;
        }
        if (normalAttackTimer > 1)
        {
            attackCooldown = true;
            normalAttackTimer = 0;
        }
    }
    private void resetAttackEnhance()
    {
        timer += Time.deltaTime;
        normalAttackTimer += Time.deltaTime;
        if (timer >= 1.8f)
        {
            dashCooldown = true;
            fireCooldown = true;
            timer = 0;
        }
        if (normalAttackTimer > 1)
        {
            attackCooldown = true;
            normalAttackTimer = 0;
        }
    }

    private void Action()
    {
        if (HP <= 90 && !summoning && summonLeft > 1)
        {
            anim.SetTrigger("summon");
            summonLeft -= 1;
            summoning = true;
            Invoke("ChangeColor", 5);
        }
        else if (HP <= 40 && !summoning && summonLeft > 0)
        {
            anim.SetTrigger("summon");
            summonLeft -= 1;
            summoning = true;
        }
        if (summoning) return;
        float distance = player.transform.position.x - gameObject.transform.position.x;
        direct = new Vector3(distance, 0, 0);
        direct = direct.normalized;
        Vector3 currentScale = transform.localScale;

        if (Mathf.Abs(distance) < 1.5f)
        {
            if (player.GetComponent<Kirby>().onGround && attackCooldown)
            {
                anim.SetTrigger("hit");
                attackCooldown = false;
            }
        }

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
            anim.SetBool("move", true);
        }
        else
        {
            anim.SetBool("move", false);
        }

        if (Mathf.Abs(distance) > 5f)
        {
            int r = Random.Range (0, 2);
            if (r == 0 && dashCooldown)
            {
                anim.SetTrigger("dash");
                Invoke("speedUp", 0.2f);
                Invoke("resetSpeed", 0.5f);
                dashCooldown = false;
                fireCooldown = false;  
            }
            else if (r == 1 && fireCooldown)
            {
                anim.SetTrigger("fire");
                fireCooldown = false;
                dashCooldown = false;
            }           
        }

    }

    private void ActionEnhance()
    {
        if (HP <= 90 && !summoning && summonLeft > 1)
        {
            anim.SetTrigger("summon");
            summonLeft -= 1;
            summoning = true;
        }
        else if (HP <= 40 && !summoning && summonLeft > 0)
        {
            anim.SetTrigger("summon");
            summonLeft -= 1;
            summoning = true;
        }
        if (summoning) return;
        float distance = player.transform.position.x - gameObject.transform.position.x;
        direct = new Vector3(distance, 0, 0);
        direct = direct.normalized;
        Vector3 currentScale = transform.localScale;

        if (Mathf.Abs(distance) < 1.5f)
        {
            if (player.GetComponent<Kirby>().onGround && attackCooldown)
            {
                anim.SetTrigger("hit");
                attackCooldown = false;
            }
        }

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
            anim.SetBool("move", true);
        }
        else
        {
            anim.SetBool("move", false);
        }

        if (Mathf.Abs(distance) > 3.8f)
        {
            int r = Random.Range(0, 2);
            if (r == 0 && dashCooldown)
            {
                anim.SetTrigger("dash");
                Invoke("speedUp", 0.2f);
                Invoke("resetSpeed", 0.5f);
                dashCooldown = false;
                fireCooldown = false;
            }
            else if (r == 1 && fireCooldown)
            {
                anim.SetTrigger("fire");
                fireCooldown = false;
                dashCooldown = false;
            }
        }

    }

    private void speedUp()
    {
        speed = 12;
    }
    private void resetSpeed()
    {
        speed = standardSpeed;
    }

    private void Fire()
    {
        Vector3 target = player.transform.position - transform.position;
        bullet.GetComponent<BulletScript>().dir = target;
        GameObject myBullet = Instantiate(bullet, bulletOrigin.position, Quaternion.identity);
    }

    public void BeginBulletFire()
    {
        speed = 0;
        float time = 1;
        if (enhance) time = 2;
        float invokeTime = 0;
        for (int i = 0; i < time; i++)
        {
            Invoke("Fire", invokeTime);
            invokeTime += 0.2f;
        } 
    }
    public void EndBulletFire()
    {
        speed = standardSpeed;
    }

    private void Summon()
    {
        Vector3 location = player.transform.position;
        location.y += 10;
        Vector3 direct = player.GetComponent<Kirby>().direct;
        GameObject mySlime = Instantiate(slime, location, Quaternion.identity);     
    }

    public void BeginSummon()
    {
        int num = 10;
        if (enhance) num = 15;
        speed = 0;
        for (float i = 0; i < num; i+=1)
        {
            float t = i / 2;
            Invoke("Summon", t);
        }
    }
    public void EndSummon()
    {
        speed = standardSpeed;
        summoning = false;
    }

    public void BeginAttack()
    {
        atkrange.SetActive(true);
    }
    public void EndAttack()
    {
        atkrange.SetActive(false);
    }
    private void ChangeColor()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        enhance = true;
        standardSpeed = 3.25f;
        Instantiate(bubbleHeart, transform.position, Quaternion.identity);
    }

    public void GetHit(float damage)
    {
        if (summoning)
        {
            damage /= 2;
        }
        HP -= damage;
    }
}
