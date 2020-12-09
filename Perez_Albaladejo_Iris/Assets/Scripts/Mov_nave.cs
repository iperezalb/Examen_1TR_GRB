using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_nave : MonoBehaviour
{
    [SerializeField] float velocidad = 5f;

    private float desplZ;
    private float desplX;
    private float desplY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        desplX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.left * desplX * Time.deltaTime * velocidad);

        desplY = Input.GetAxis("Vertical");

        transform.Translate(Vector3.back * desplZ * Time.deltaTime * velocidad);


    }
}
