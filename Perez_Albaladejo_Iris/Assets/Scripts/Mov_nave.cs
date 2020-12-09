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

        transform.Translate(Vector3.right * desplX * Time.deltaTime * velocidad);

        desplZ = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * desplZ * Time.deltaTime * velocidad);

        /*desplY = Input.GetButtonDown("joystickbutton 4");

        transform.Translate(Vector3.down * desplY * Time.deltaTime * velocidad);*/


    }
}
