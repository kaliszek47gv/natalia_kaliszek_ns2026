using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2 : MonoBehaviour
{
    public List<GameObject> obiekty = new List<GameObject>();
  
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject obj in obiekty) // tymczasowa zmienna obiekt
        {
            if (obj.GetComponent<MeshRenderer>() != null)
            {
                Debug.Log(obj.name + " jest 3D");
            }
            else if (obj.GetComponent<SpriteRenderer>() != null)
            {
                Debug.Log(obj.name + " jest 2D");
            }
        }
        
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
