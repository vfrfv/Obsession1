using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2 : MonoBehaviour
{

    private float _speedLocalScsale = 0.2f;
    private float _speedRotate = 50;
    private float _speedTranslate = 1;

    void Update()
    {
        transform.Translate(_speedTranslate * Time.deltaTime, 0, 0);

        transform.Rotate(0, _speedRotate * Time.deltaTime, 0);

        transform.localScale += new Vector3(_speedLocalScsale, _speedLocalScsale, _speedLocalScsale) * Time.deltaTime;

    }
}
