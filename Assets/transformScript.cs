using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformScript : MonoBehaviour
{
    int dir = 1;
    int drops = 0;
    GameObject[] wagons;
    float speed = 2.0f;
    float rotateSpeed = 90.0f;
    // Start is called before the first frame update
    void Start()
    {
        wagons = GameObject.FindGameObjectsWithTag("Wagon");
    }

    // Update is called once per frame
    void Update()
    {
        MoverTeclado();
        EscalarTeclado();
        //XaxisAnim();
        DropWagon2();
        transform.Rotate(new Vector3(0, rotateSpeed, 0) * Time.deltaTime);
    }

    private void DropWagon2()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if(drops<wagons.Length)
            {
                wagons[drops].GetComponent<Transform>().parent=null;
                speed *= 2;
            }
            drops++;
        }
    }

    private void DropWagon1()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (drops == 0)
            {
                Transform childToRemove = transform.Find("ZaamuretsTurretCar (1)");
                childToRemove.parent = null;
                speed *= 2;
            }
            else if (drops == 1)
            {
                Transform childToRemove = transform.Find("ZaamuretsWagon");
                childToRemove.parent = null;
                speed *= 2;
            }
            else if (drops == 2)
            {
                Transform childToRemove = transform.Find("ZaamuretsLocomotive");
                childToRemove.parent = null;
                speed *= 2;
            }
            drops++;
        }
    }

    private void XaxisAnim()
    {
        if (transform.position.x > 4.0f)
        {
            dir = -1;
        }
        if (transform.position.x < -4.0f)
        {
            dir = 1;
        }
        transform.Translate(new Vector3((1.0f * Time.deltaTime) * dir, 0, 0));
    }

    private void EscalarTeclado()
    {
        Vector3 esc = new Vector3();
        if (Input.GetKey(KeyCode.H))
        {
            esc.z = 1.0f;
        }
        if (Input.GetKey(KeyCode.K))
        {
            esc.z = -1.0f;
        }
        if (Input.GetKey(KeyCode.U))
        {
            esc.y = 1.0f;
        }
        if (Input.GetKey(KeyCode.J))
        {
            esc.y = -1.0f;
        }
        this.transform.localScale += esc*4*Time.deltaTime;
    }

    private void MoverTeclado()
    {
        Vector3 mov = new Vector3();
        if (Input.GetKey(KeyCode.A))
        {
            mov.z = 1.0f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            mov.z = -1.0f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            mov.y = 1.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            mov.y = -1.0f;
        }
        transform.Translate(mov * speed * Time.deltaTime);
    }
}
