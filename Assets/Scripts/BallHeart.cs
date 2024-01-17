using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHeart : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.localScale = new Vector3(Mathf.Abs(Mathf.Sin(Time.time)), Mathf.Abs(Mathf.Sin(Time.time)), 0);

    }
}
