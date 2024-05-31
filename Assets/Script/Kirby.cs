using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Kirby : MonoBehaviour
{
    public Animator anim;
    public float speed;
    private bool dash = true;
    public bool onGround = false;
    public bool canDogde = false;
    public bool dogding = false;
    private bool dodgeSuccess = false;
    public bool followUpAttacking = false;
    public bool tonadoing = false;
    public bool webStatus = false;
    public bool poisonStatus = false;
    public bool poisonResist = false;
    public float force;
    public Vector3 direct;

    public float HP;
    public float energy = 0;

    public GameObject manager;
    public GameObject web;
    public GameObject SlimeLight;
    public GameObject Ani;

    public LayerMask wall;

    public bool splash = false;

    // Start is called before the first frame update
    void Start()
    {
        HP = 10;
        anim = gameObject.GetComponentInChildren<Animator>();
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            gameObject.SetActive(false);
            manager.GetComponent<GameManager>().kirbyDeath = true;
            return;
        }
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0f);
        if (Input.GetKey(KeyCode.A))
        {
            direct = new Vector3(-1, 0, 0);
            transform.Translate(direct * speed * Time.deltaTime);
            transform.localScale = new Vector3(-1, 1, 0) * 1;
            anim.SetBool("Move", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direct = new Vector3(1, 0, 0);
            transform.Translate(direct * speed * Time.deltaTime);
            transform.localScale = new Vector3(1, 1, 0) * 1;
            anim.SetBool("Move", true);
        }        
        else anim.SetBool("Move", false);

        if (tonadoing) return;


        if (Input.GetKeyDown(KeyCode.Q) && energy >= 100)
        {
            energy = 0;
            anim.SetTrigger("Tonado");
            tonadoing = true;
            speed = 0;
            Invoke("ResetTonadoing", 1.5f);           
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            if (onGround)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector3(0,1,0) * force);
                anim.SetBool("Jump", true) ;
                onGround = false;
            }
        }

        if ((Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.LeftShift)) && dash && !webStatus)
        {
            canDogde = true;
            Invoke("ResetCanDodge", 0.25f);        
            
            RaycastHit2D hit = Physics2D.Raycast(transform.position, direct, 0.5f, wall);
            if (hit.collider != null && !hit.collider.gameObject.CompareTag("CheckGround"))
            {
                return;
            }
            Dash();
        }

        if (!onGround && GetComponentInChildren<Rigidbody2D>().velocity.y <=0)
        {
            anim.SetBool("Fall", true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (dodgeSuccess)
            {
                dodgeSuccess = false;
                anim.SetTrigger("FollowUp");
            }
            else
            {
                anim.SetTrigger("Attack");
            }  
        }

        RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, direct, 0.5f);
        if (raycastHit2D.collider != null && !raycastHit2D.collider.gameObject.CompareTag("CheckGround"))
        {
            speed = 5f;
        }

    }
    private void ResetDodge()
    {
        dogding = false;
    }
    private void ResetCanDodge()
    {
        canDogde = false;
    }
    private void ResetDodgeSuccess()
    {
        dodgeSuccess = false;  
    }
    
    private void ResetTonadoing()
    {
        speed = 5;
        tonadoing = false;
    }
    private void Dash()
    {
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
        dash = false;
        speed = 15;
        Invoke("ResetSpeed", 0.3f);
        Invoke("ResetBodyType", 0.3f);
        Invoke("ResetDash", 1);
    }

    private void ResetDash()
    {
        dash = true;
    }
    private void ResetBodyType()
    {
        GetComponent<Rigidbody2D>().constraints &= ~RigidbodyConstraints2D.FreezePositionY;
    }
    private void ResetSpeed()
    {
        speed = 5;       
    }

    public void BeginWebStatus()
    {
        speed = 2;
        webStatus = true;
        web.SetActive(true);
        Invoke("EndWebStatus", 2f);
    }
    private void EndWebStatus()
    {
        ResetSpeed();
        webStatus = false;
        web.SetActive(false);
    }
    public void BeginPoisonStatus()
    {
        if (poisonResist) return;
        poisonStatus = true;
        Ani.GetComponent<SpriteRenderer>().color = Color.green;
        SlimeLight.SetActive(true);
        Invoke("EndPoisonStatus", 2);
        Invoke("Poisoning", 0.5f);
        Invoke("Poisoning", 1f);
        Invoke("Poisoning", 1.5f);
        Invoke("Poisoning", 2f);
    }
    public void EndPoisonStatus()
    {
        poisonStatus = false;
        Ani.GetComponent<SpriteRenderer>().color = Color.white;
        SlimeLight.SetActive(false);
    }
    private void Poisoning()
    {
        HP -= 0.25f;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("TeleportGate"))
        {
            transform.position = new Vector3(183.2f, 14.3f, 0);
        }
        if (collision.gameObject.CompareTag("TeleportGate2"))
        {
            transform.position = new Vector3(313.32f, 39.94f, 0);
        }
        if (collision.gameObject.CompareTag("TeleportGate3"))
        {
            Invoke("TeleportGate3", 0.5f);
        }
    }
    private void TeleportGate3()
    {
        transform.position = new Vector3(313.32f, 39.94f, 0);
    }
    public void GetHit(float damage)
    {
        if (canDogde)
        {
            ResetCanDodge();
            ResetDash();
            anim.SetTrigger("Dodge");
            dogding = true;
            Invoke("ResetDodge", 0.4f);
            dodgeSuccess = true;
            Invoke("ResetDodgeSuccess", 1);
            return;
        }
        if (dogding || followUpAttacking || tonadoing) return;
        HP -= damage;
    }
}
