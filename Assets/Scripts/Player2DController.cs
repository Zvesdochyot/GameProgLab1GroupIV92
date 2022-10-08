using UnityEngine;

public class Player2DController : MonoBehaviour
{
    public float movementSpeed = 100;
    public float jumpForce = 5;
    
    private Rigidbody2D _playerBody;
    
    private void Start()
    {
        _playerBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float changedVelocityX = Input.GetAxis("Horizontal") * movementSpeed * Time.fixedDeltaTime;
        _playerBody.velocity = new Vector2(changedVelocityX, _playerBody.velocity.y);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(_playerBody.velocity.y) < 0.001f)
        {
            _playerBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}