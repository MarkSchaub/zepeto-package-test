using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZepetoTweenPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ZepetoTweenPosition");
        this.transform.Translate(this.transform.forward * Time.deltaTime * 3);
    }
}
