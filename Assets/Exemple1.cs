using UnityEngine;

public class Exemple1 : MonoBehaviour
{
    [SerializeField]
    private int _identifiant;
    
    public int X;

    private void Start()
    {
        _identifiant = 3;
        X = 1;
    }

    private void Update()
    {
        Debug.Log("id = " + _identifiant);
    }
}
