using UnityEngine;

public class Deplacement : MonoBehaviour
{
    [Range(-5f, 5f)]
    public float Speed;
    public Moteur Moteur;

    private void Start()
    {
        Moteur = new Moteur();
    }

    public void Update()
    {
        if (Moteur.Roule(Speed * Time.deltaTime))
        {
            Vector3 velocity = Vector3.zero;
            if (Input.GetKey(KeyCode.Z))
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
            }

            gameObject.transform.position += velocity.normalized * Speed * Time.deltaTime;
        }
    }
}
