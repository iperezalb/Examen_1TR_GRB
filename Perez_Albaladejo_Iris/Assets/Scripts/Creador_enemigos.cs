using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creador_enemigos : MonoBehaviour
{
    [SerializeField] GameObject Enemigo;

    [SerializeField] Transform initPos;

    Vector3 newPosY;

    // Start is called before the first frame update
    void Start()
    {
        CrearEnemigo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CrearEnemigo()
    {
        for (int n = 0; n < 20; n++)
        {
            float randomPosY = Random.Range(0f, 20f);

            Vector3 desplazarPosY = new Vector3(0, randomPosY, 2 * n);

            newPosY = initPos.position + desplazarPosY;

            Instantiate(Enemigo, newPosY, Quaternion.identity);
        }

    }
}
