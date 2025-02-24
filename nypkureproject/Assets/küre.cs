using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    public float speed = 5f; // Hareket hızı
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Rigidbody bileşenini al
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Sağ-Sol (ok tuşları: Left, Right)
        float moveVertical = Input.GetAxis("Vertical"); // İleri-Geri (ok tuşları: Up, Down)

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * speed;
        
        // Yalnızca x ve z ekseninde hareket, y ekseninde (yerçekimi) korunuyor
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }
}
