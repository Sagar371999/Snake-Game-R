using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivatePickUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Deactivate", Random.Range(2f, 5f));
    }

    // Update is called once per frame
    void Deactivate()
    {
        //gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
