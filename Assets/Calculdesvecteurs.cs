using UnityEngine;

public class Calculdesvecteurs : MonoBehaviour
{
    private void Start()
    {
        // Vecteurs 2D
        {
            Vector2 v1, v2, res;

            //a)
            v1 = new Vector2(5f, 8f);
            v2 = new Vector2(3f, 2f);

            res = v1 + v2;
            Debug.Log("a) " + v1 + " + " + v2 + " = " + res);

            //b)
            v1 = new Vector2(-1f, -3f);
            v2 = new Vector2(-2f, 2f);

            res = v1 - v2;
            Debug.Log("b) " + v1 + " - " + v2 + " = " + res);
        }

        // Vecteurs 3D
        {
            Vector3 v1, v2, res;

            //c)
            v1 = new Vector3(-2f, -1f, 5f);
            v2 = new Vector3(1f, 4f, 3f);

            res = v1 + v2;
            Debug.Log("c) " + v1 + " + " + v2 + " = " + res);

            //d)
            v1 = new Vector3(2f, -4f, 1f);
            v2 = new Vector3(-1f, -1f, 3f);

            res = v1 - v2;
            Debug.Log("d) " + v1 + " - " + v2 + " = " + res);
        }

    }
}
