using UnityEngine;

public class SimpleCharacterController2D : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private Color lightColor = Color.white;
    [SerializeField] private Color darkColor = Color.grey;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Animator parentAnimator;
    [SerializeField] private Vector3 startPosition;


    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private bool isGrounded;
    private float horizontalInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Get the Animator from the parent and play animation
        //parentAnimator = GetComponent<Animator>();
        if (parentAnimator != null)
        {
            parentAnimator.Play("PlayerEntranceANi");
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") ||
            collision.gameObject.CompareTag("LightPlatform") ||
            collision.gameObject.CompareTag("DarkPlatform"))
        {
            Debug.Log("Hit a platform");
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") ||
            collision.gameObject.CompareTag("LightPlatform") ||
            collision.gameObject.CompareTag("DarkPlatform"))
        {
            Debug.Log("left a platform");
            isGrounded = false;
        }
    }

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            gameManager.ChangeColor();
        }
    }

    public void ChangeColor(string color)
    {
        if (color == "Light")
        {
            spriteRenderer.color = lightColor;
        }
        else if (color == "Dark")
        {
            spriteRenderer.color = darkColor;
        }
    }

    public void Reset()
    {
        transform.position = startPosition;
    }
}