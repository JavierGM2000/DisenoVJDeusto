using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UltraPintado : MonoBehaviour
{
    GameObject[] allObjects;
    [Serialize]
    public string findByTag;
    public string nombre;
    
    [Serialize]
    public Color colr;
    Color prevCol;


    int frames = 0;
    // Start is called before the first frame update
    void Start()
    {

        allObjects = GameObject.FindGameObjectsWithTag(findByTag);
        //Renderer matComp = objeto.GetComponent<Renderer>();
        //matComp.material.color = colr;

        //allObjects = FindObjectsOfType<GameObject>();
        foreach (GameObject go in allObjects)
        {
            Renderer matComp = go.GetComponent<Renderer>();
            if (matComp != null)
            {
                matComp.material.SetColor("_Color", colr);
            }
        }

        prevCol = colr;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (colr != prevCol)
        {
            frames = 0;
            foreach (GameObject go in allObjects)
            {
                Renderer matComp = go.GetComponent<Renderer>();
                if (matComp != null)
                {
                    matComp.material.color = colr;
                }
            }
        }
    }
}
