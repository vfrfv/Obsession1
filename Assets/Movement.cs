using UnityEngine;

public class Movement : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(1 * Time.deltaTime, 0, 0);
    }
}
