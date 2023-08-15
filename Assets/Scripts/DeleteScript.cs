using UnityEngine;

public class DeleteScript : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag != "Main") Destroy(other.gameObject);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag != "Main") Destroy(other.gameObject);
    }
}
