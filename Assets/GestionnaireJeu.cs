using UnityEngine;

public class GestionnaireJeu : MonoBehaviour
{
    private float _clock;
    private float _delay;

    public GameObject Car;

    private void Start()
    {
        _clock = Time.time;
        _delay = Random.Range(1f, 5f);
    }

    private void Update()
    {
        if (Time.time > _clock + _delay)
        {
            Debug.Log("GO");

            Car.GetComponent<Deplacement>().enabled = true;
            this.enabled = false;
        }
        else
        {
            //Diplays clock
            float progress = (Time.time / (_clock + _delay)) * 100f;
            Debug.Log("Chargement du moteur : " + progress + "%");
        }
    }
}
