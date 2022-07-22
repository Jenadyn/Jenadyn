using UnityEngine;

public class PaddleBot : Paddle
{
    [Header("Ball Position")]
    [SerializeField] private Transform ball;

    private void Start()
    {
        ball = GameObject.Find("Circle").transform;
    }

    private void Update()
    {
        MoveDown();
        MoveUp();
    }
    public override void MoveDown()
    {
        if (ball.position.y < this.transform.position.y)
            this.transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
    }

    public override void MoveUp()
    {
        if (ball.position.y > this.transform.position.y)
            this.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
    }
}
