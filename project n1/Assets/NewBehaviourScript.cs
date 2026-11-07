using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{

    //Ta referencja jest pusta, zostaje uzupe³niona podczas pierwszego HIT()
    private Rigidbody2D rb;

    public SpriteRenderer sprite;
    public Gradient hpColor;

    public float hp = 100;

    private void Update()
    {
       //blad 3 hp = 100;
    }

    //Funkcja wywo³ywana przy trafieniu
    public void Hit(float dmg)
    {
        if (rb == null || hp == 100)
        {
            //if first hit activate rigidbody
            rb = GetComponent<Rigidbody2D>();//blad 5
            rb.bodyType = RigidbodyType2D.Dynamic;
        }

        hp -= dmg;//blad 4

        sprite.color = hpColor.Evaluate((float)(hp / 100));//blad 6

        CheckIfKill();
    }

    //Jeœli ¿ycie spadnie poni¿ej zera obiekt powinien zostaæ zniszczony
    void CheckIfKill()
    {
        if (hp <= 0)//blad 1
        {
            Destroy(gameObject);//8
        }
    }

    // Funkcja zwraca najwiêkszego inta z listy
    public int ReturnHighNumber(List<int> data)
    {
       //blad 2(?) return 1;

        int high = 0;

        foreach (int i in data)
        {
            if (i > high)
            {
                high = i; //7
            }
        }

        return high;
    }


}