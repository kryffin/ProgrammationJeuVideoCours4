using UnityEngine;

public class Deplacement : MonoBehaviour
{
    [Range(-50f, 50f)]
    public float Speed;
    public Moteur Moteur;
    public bool ReservoirInfini;

    public GameObject[] Wheels;

    private void Start()
    {
        Moteur = new Moteur();
    }

    public void Update()
    {
        Vector3 velocity = transform.forward;
        /*if (Input.GetKey(KeyCode.Z))
        {
            velocity += Vector3.right;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            velocity += Vector3.left;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            velocity += Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            velocity += Vector3.back;
        }*/

        if (ReservoirInfini || Moteur.Roule(velocity.normalized.magnitude * Time.deltaTime))
        {
            gameObject.transform.position += velocity.normalized * Speed * Time.deltaTime;
        }

        foreach (GameObject g in Wheels)
        {
            g.transform.Rotate(new Vector3(Speed / 10f, 0f, 0f));
        }
    }
}
