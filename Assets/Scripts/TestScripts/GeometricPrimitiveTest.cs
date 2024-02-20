using UnityEngine;

public class GeometricPrimitiveTest : MonoBehaviour
{
    public Vector2 center;
    public float arcLength;
    public float angle;
    public float radius;
    public float c;
    void OnGUI()
    {
        if (GUILayout.Button("等距离生成圆"))
        {
            var parent = new GameObject("Circle");
            var step = arcLength / radius / (Mathf.PI * 2);
            for (float t = 0; t < 1; t += step)
            {
                var point = GeometricPrimitive.Circle(radius, t) + center;
                var obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                obj.transform.SetParent(parent.transform);
                obj.transform.position = new Vector3(point.x, 0, point.y);
                obj.transform.localScale = Vector3.one * 0.05f;
            }
        }
        if (GUILayout.Button("等角度生成圆"))
        {
            var parent = new GameObject("Circle");
            var step = angle * Mathf.Deg2Rad / (Mathf.PI * 2);
            for (float t = 0; t < 1; t += step)
            {
                var point = GeometricPrimitive.Circle(radius, t) + center;
                var obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                obj.transform.SetParent(parent.transform);
                obj.transform.position = new Vector3(point.x, 0, point.y);
                obj.transform.localScale = Vector3.one * 0.05f;
            }
        }
        if (GUILayout.Button("Generate Cycloid"))
        {
            var parent = new GameObject("Cycloid");
            var step = arcLength / radius / (Mathf.PI * 2);
            for (float t = 0; t < c * Mathf.PI; t += step)
            {
                var point = GeometricPrimitive.Cycloid(radius, t) + center;
                var obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                obj.transform.SetParent(parent.transform);
                obj.transform.position = new Vector3(point.x, 0, point.y);
                obj.transform.localScale = Vector3.one * 0.05f;
            }
        }
    }
}