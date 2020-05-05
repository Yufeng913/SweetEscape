using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded, canRoll, doubleJumped;
    
    private Animator anim;

    public Transform firePoint;
    public GameObject candyWrapper;

    public AudioSource jumpSound;

    public BoxCollider2D normalBox;
    public BoxCollider2D rollingBox;
    public CircleCollider2D normalCircle;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        rollingBox.enabled = false;
        normalBox.enabled = true;
        normalCircle.enabled = true;
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("canRoll", canRoll);

        if (grounded)
            doubleJumped = false;

        if (Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("GameplayFinal");

        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene("GameplayFinal");

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

        if (Input.GetKeyDown (KeyCode.D) && grounded && !canRoll)
        {
            Jump();
            jumpSound.Play();
        }

        if (Input.GetKeyDown(KeyCode.D) && !doubleJumped && !grounded)
        {
            Jump();
            doubleJumped = true;
            jumpSound.Play();
        }

        //GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        //transform.position += transform.right * Time.deltaTime * moveSpeed;
        
        // First fix animation
        anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));

        if (Input.GetKeyDown(KeyCode.S) && wrapperManager.candyWrappers > 0)
        {
            Instantiate(candyWrapper, firePoint.position, firePoint.rotation);
            wrapperManager.candyWrappers = wrapperManager.candyWrappers - 1;
        }

        if (Input.GetKey(KeyCode.A) && grounded)
        {
            canRoll = true;
            rollingBox.enabled = true;
            normalBox.enabled = false;
            normalCircle.enabled = false;
            transform.position += transform.right * Time.deltaTime * moveSpeed;
        }
        else
        {
            canRoll = false;
            rollingBox.enabled = false;
            normalBox.enabled = true;
            normalCircle.enabled = true;
            transform.position += transform.right * Time.deltaTime * moveSpeed;
        }
            
            
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }
}
