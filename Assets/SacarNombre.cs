using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SacarNombre : MonoBehaviour
{
    // Start is called before the first frame update
    public static int num = 0;
    [Serialize]
    public Color col;
    [Serialize]
    public string nombre;
    void Start()
    {
        Debug.Log($"Yo {name}, estoy vivo, consciente y buscado por la IRS");

        Renderer matComp = GetComponent<Renderer>();

        if (matComp != null)
        {
            if(num%2==0)
                matComp.material.SetColor("_Color", Color.red);
            else
                matComp.material.SetColor("_Color", Color.yellow);
        }
        num++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
