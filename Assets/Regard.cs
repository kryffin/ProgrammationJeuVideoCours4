using UnityEngine;

public class Regard : MonoBehaviour
{
    public GameObject ObjetCible;
    public float MaxDistance;
    [Range(0.1f, 5f)]
    public float Speed;

    void Update()
    {
        transform.LookAt(ObjetCible.transform, Vector3.up);

        if (Vector3.Distance(ObjetCible.transform.position, transform.position) > 10f)
        {
            Vector3 direction = (ObjetCible.transform.position - transform.position).normalized;
            transform.position += direction * Speed * Time.deltaTime;
        }
    }
}
