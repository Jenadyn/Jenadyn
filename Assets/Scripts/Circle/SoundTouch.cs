using UnityEngine;

public class SoundTouch : MonoBehaviour
{
    [SerializeField] private AudioSource touchSFX;
    [SerializeField] private AudioSource touchDown;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        touchSFX.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Restart")
        {
            touchDown.Play();
        }
    }
}
