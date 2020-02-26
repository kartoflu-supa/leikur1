using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerInteractions : MonoBehaviour
{
    public float speed = 1000f;
    public float move = 500f;
    public Rigidbody rb;
    public Transform stopT;
    bool gameMove = true;
    public float zPos = -6;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Start!");
    }

    void Update()
    {
        if ( zPos == stopT.position.z)
        {
            Debug.Log("BOOM!");
            
        }
        zPos = stopT.position.z;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float time = Time.deltaTime;
        rb.AddForce(0,0,speed*time);
        if (gameMove == true)
        {
            if (Input.GetKey("d"))
            {
                rb.AddForce(move * time, 0, 0);
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(-move * time, 0, 0);
            }
        }
        /*
        if (stopT.position.z == transform.position.z)
        {
           
        }
        */
    }
}
