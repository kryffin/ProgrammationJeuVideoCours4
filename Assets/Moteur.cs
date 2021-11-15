using UnityEngine;

public class Moteur
{
    private float _essence;

    public Moteur()
    {
        _essence = 10f;
        Debug.Log("Essence : " + _essence);
    }

    public float Essence
    {
        get => _essence;
        set => _essence = value;
    }

    public bool Roule(float consommation)
    {
        _essence -= consommation;
        return _essence > 0f;
    }
}
