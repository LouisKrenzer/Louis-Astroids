using UnityEngine;

public class AsteroidController : MonoBehaviour
{

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 100f);

    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}