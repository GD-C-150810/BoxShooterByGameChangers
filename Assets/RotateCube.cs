using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateCube : MonoBehaviour
{
    public Transform tr;
    public bool DoSpin = true;
    public bool DoSpinRight = false;
    public bool DoSpinLeft = false;
    public float spinSpeed = 180f;
    public enum names { x, y, z };
    // Use this for initialization
    void Start()
    {
        tr = gameObject.transform;
    }



    // Update is called once per frame
    void Update()
    {

        //if (DoSpin)
        //{
        //    // tr.Rotate(Vector3.left * spinSpeed * Time.deltaTime);
        //    tr.Rotate(Vector3.right * spinSpeed * Time.deltaTime);
        //}
        if (DoSpin)
        {
            tr.Rotate(Vector3.up * spinSpeed * Time.deltaTime);

        }
        if (DoSpin == true && DoSpinRight == true)
        {
            DoSpinLeft = false;
            // tr.Rotate(Vector3.left * spinSpeed * Time.deltaTime);
            tr.Rotate(Vector3.right * spinSpeed * Time.deltaTime);
        }
        else if (DoSpin == true && DoSpinLeft == true)
        {
            DoSpinRight = false;
            // tr.Rotate(Vector3.left * spinSpeed * Time.deltaTime);
            tr.Rotate(Vector3.left * spinSpeed * Time.deltaTime);
        }

    }
}