using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2 : MonoBehaviour
{
    public Gradient gradient;
    public List<GameObject> obiekty = new List<GameObject>();
  
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in obiekty) // tymczasowa zmienna obiekt
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
        
      public void Square(SpriteRenderer sprite)
    {
        sprite.color = gradient.Evaluate(sprite.gameObject.transform.position.y / 30); //evaluate sprawdza
         //kazdy game object posiada w sobie transform
    } 
    }

    // Update is called once per frame
    void Update()
    {
    foreach (GameObject obj in obiekty)
    {
        if(obj.GetComponent<SpriteRenderer>)
    }
    }
}
