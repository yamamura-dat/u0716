using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hensu : MonoBehaviour
{
    int vx = 20;
    //順次処理、分岐処理、繰り返し処理
    public void ensyu71()
    {
        int vx = 5;
        Debug.Log(vx);

        vx = 10;
        Debug.Log(vx);
    }

    public void ensyu72()
    {
        Debug.Log(vx);
    }

    public void ensyu74()
    {
        vx += 10;
        Debug.Log(vx);
    }

    int a = 10;

    // Start is called before the first frame update
    public void Proc()
    {
        float fw = 3.14f;
        string str = "こんにちは";
        bool bl = true;

        Debug.Log(a+a);
        Debug.Log(fw);
        Debug.Log(str);
        Debug.Log(bl);
    }

    public void Proc2()
    {
        Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
