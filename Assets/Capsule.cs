using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] float _speed;

    void Update()
    {
        transform.localScale += new Vector3(_speed, _speed, _speed) * Time.deltaTime;
    }
}
