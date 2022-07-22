using UnityEngine;

public class SoundTouch : MonoBehaviour
{
    [SerializeField] private AudioSource touchSFX;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        touchSFX.Play();
    }
}
