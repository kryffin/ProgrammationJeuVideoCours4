using UnityEngine;

public class Deplacement : MonoBehaviour
{
    private GameObject[] _wheels;

    [Range(-50f, 50f)]
    public float Speed;
    public Moteur Moteur;
    public bool ReservoirInfini;

    [Range(0f, 5f)]
    public float WheelThreshold;

    private void Start()
    {
        Moteur = new Moteur();

        _wheels = new GameObject[]
        {
            transform.Find("Wheel_fl").gameObject,
            transform.Find("Wheel_fr").gameObject,
            transform.Find("Wheel_rl").gameObject,
            transform.Find("Wheel_rr").gameObject
        };
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

        foreach (GameObject g in _wheels)
        {
            g.transform.Rotate(new Vector3(Speed / 10f, 0f, 0f));
            if (Mathf.Abs(Speed) >= WheelThreshold)
                g.GetComponent<MeshRenderer>().material.color = Color.red;
            else
                g.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
}
