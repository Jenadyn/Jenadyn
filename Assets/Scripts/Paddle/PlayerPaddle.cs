using UnityEngine;

public class PlayerPaddle : Paddle
{
    private void Start()
    {
        InputManager.MoveUp += this.MoveUp;
        InputManager.MoveDown += this.MoveDown;
    }

    public override void MoveUp()
    {
        this.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
    }

    public override void MoveDown()
    {
        this.transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
    }
}