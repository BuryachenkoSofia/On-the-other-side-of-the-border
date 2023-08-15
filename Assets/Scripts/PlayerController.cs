using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float force = 3;

    private new Rigidbody2D rigidbody;
    public GameObject skin0, skin1;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        skin0.gameObject.SetActive(true);
        skin1.gameObject.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameObject.transform.position.y < 0) rigidbody.AddForce(Vector2.up * (force - rigidbody.velocity.y), ForceMode2D.Impulse);
        }
        if (gameObject.transform.position.y > 0)
        {
            float v = Input.GetAxisRaw("Vertical") * PlayerPrefs.GetFloat("speed") * Time.fixedDeltaTime * -1;
            rigidbody.velocity = transform.TransformDirection(new Vector2(rigidbody.velocity.x, v));
        }


        if (gameObject.transform.position.y > 0)
        {
            skin0.gameObject.SetActive(false);
            skin1.gameObject.SetActive(true);
        }
        else if (gameObject.transform.position.y < 0)
        {
            skin0.gameObject.SetActive(true);
            skin1.gameObject.SetActive(false);
        }
        rigidbody.MoveRotation(rigidbody.velocity.y * 2.0F);
    }
}
