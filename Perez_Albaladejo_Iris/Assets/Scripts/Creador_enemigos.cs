using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creador_enemigos : MonoBehaviour
{
    [SerializeField] GameObject Enemigo;

    [SerializeField] Transform initPos;

    Vector3 newPosY;
    Vector3 newPosX;

    // Start is called before the first frame update
    void Start()
    {
        for (int n = 0; n < 20; n++)
        {
            float randomPosY = Random.Range(0f, 20f);

            float randomPosX = Random.Range(-10f, 10f);

            Vector3 desplazarPosY = new Vector3(0, randomPosY, 2 * n);

            newPosY = initPos.position + desplazarPosY;

            Instantiate(Enemigo, newPosY, Quaternion.identity);

            Vector3 desplazarPosX = new Vector3(randomPosX, 0, 2 * n);

            newPosX = initPos.position + desplazarPosX;


            Instantiate(Enemigo, newPosX, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
