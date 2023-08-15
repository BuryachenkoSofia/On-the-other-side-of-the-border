using UnityEngine;

public class Movement : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.Translate(Vector3.left * 5f * Time.deltaTime);
    }
}
