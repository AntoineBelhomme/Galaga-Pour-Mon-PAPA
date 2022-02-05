using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody playerRb;
    public bullet bulletnow;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Horizontal");
        playerRb.transform.Translate(forwardInput * speed,0,0);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Vector3 offset = new Vector3(0, 1.5f, 0);
        Instantiate(this.bulletnow, (this.transform.position+offset), Quaternion.identity);
    }
}
