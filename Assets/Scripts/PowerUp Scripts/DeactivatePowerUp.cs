using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivatePowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Deactivate", 6f);
    }

    // Update is called once per frame
    void Deactivate()
    {
        Destroy(gameObject);
    }
}
