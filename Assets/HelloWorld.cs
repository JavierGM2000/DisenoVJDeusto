using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int i;
    Player player;
    Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning("ui ui ui ui");
        Debug.LogError("UI UI UI UI UI");
        Debug.Log("Hello");
        
        player = new Player("Ermenegildo");
        enemy = new Enemy("Agirrezgomezkorta");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello "+i++);
    }
}
