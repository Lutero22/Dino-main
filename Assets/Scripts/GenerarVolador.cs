using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarVolador : MonoBehaviour
{
    public GameObject Spawn;
    public GameObject Obstaculo;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("a", 2, 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void a()
    {
        Spawn = Instantiate(Obstaculo, transform.position, Quaternion.identity) as GameObject;
    }
}
