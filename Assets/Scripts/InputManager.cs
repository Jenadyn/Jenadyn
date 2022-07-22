using UnityEngine;
using System;

public class InputManager : MonoBehaviour
{
    public KeyCode KeyUp = KeyCode.UpArrow;
    public KeyCode KeyDown = KeyCode.DownArrow;
    public static Action MoveUp;
    public static Action MoveDown;

    private void Update()
    {
        if(Input.GetKey(KeyUp))
        {
            MoveUp?.Invoke();
        }

        if(Input.GetKey(KeyDown))
        {
            MoveDown?.Invoke();
        }
    }
}
