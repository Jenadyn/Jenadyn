using UnityEngine;

public abstract class Paddle : MonoBehaviour
{
    [SerializeField] protected float speed;

    public abstract void MoveUp();

    public abstract void MoveDown();
}
