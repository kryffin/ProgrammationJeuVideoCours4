using UnityEngine;

public class DeplacementCube : MonoBehaviour
{
    void Update()
    {
        transform.position += transform.forward * 3f * Time.deltaTime;
        transform.Rotate(new Vector3(0f, 45f * Time.deltaTime, 0f));
    }
}
