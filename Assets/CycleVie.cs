using UnityEngine;

class CoffreVoiture
{
    public CoffreVoiture()
    {
        Debug.Log("Le coffre de la voiture a été créé");
    }

    public CoffreVoiture(int x)
    {
        Debug.Log("Le coffre de la voiture a été créé avec l'argument : " + x);
    }

    ~CoffreVoiture()
    {
        Debug.Log("Le coffre de la voiture sera maintenant détruit !");
    }
}

public class CycleVie : MonoBehaviour
{
    private CoffreVoiture _coffreVide;
    private CoffreVoiture _coffreArgument;

    private void Start()
    {
        _coffreVide = new CoffreVoiture();
        _coffreArgument = new CoffreVoiture(10);
    }

    private void Awake()
    {
        Debug.Log("La voiture se réveille");
    }

    private void OnEnable()
    {
        Debug.Log("La voiture finit son paramétrage juste avant son utilisation");
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.T) && _coffreVide != null && _coffreArgument != null)
        {
            _coffreVide = null;
            _coffreArgument = null;
        }

        if (Input.GetKeyUp(KeyCode.Y))
        {
            Destroy(this);
        }
    }

    ~CycleVie()
    {
        Debug.Log("La voiture est en voie de destruction");
    }
}
