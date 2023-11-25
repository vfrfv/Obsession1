using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] float _speed;

    void Update()
    {
        transform.Rotate(0, _speed * Time.deltaTime, 0);
    }
}
