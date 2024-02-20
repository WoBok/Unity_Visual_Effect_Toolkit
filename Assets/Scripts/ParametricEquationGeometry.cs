using UnityEngine;

public class ParametricEquationGeometry : MonoBehaviour
{
    void Start()
    {
        for (float i = 0; i < Mathf.PI * 3; i += Mathf.Deg2Rad)
        {
            Cycloid(1, i, out float x, out float y);
            var obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            obj.transform.localScale = Vector3.one * 0.01f;
            obj.transform.position = new Vector3(x, 0, y);
        }
    }

    void Cycloid(float r, float t, out float x, out float y)
    {
        x = r * (t - Mathf.Sin(t));
        y = r * (1 - Mathf.Cos(t));
    }
}
