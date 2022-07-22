using UnityEngine;

public class Circle : MonoBehaviour
{
    [Header("Velocity")]
    [SerializeField] private float speed;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rb.AddForce(RandomizeDirection() * speed);
    }

    private Vector2 RandomizeDirection()
    {
        float x = Random.value < 0.5f ? 3.3f : -3.3f;
        float y = Random.value < 0.5f ? 1.1f : -1.1f;
        return new Vector2(x, y);
    }
}