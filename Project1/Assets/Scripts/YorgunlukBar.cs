using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class YorgunlukBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Transform bar = transform.Find("Bar");
        bar.localScale = new Vector3(.4f, 1f);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
