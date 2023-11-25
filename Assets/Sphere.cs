using UnityEngine;

public class Sphere : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(1 * Time.deltaTime, 0, 0);
    }
}
