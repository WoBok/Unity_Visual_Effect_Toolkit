using UnityEngine;

public class GeometricPrimitive
{
    public static Vector2 Circle(float radius, float t)
    {
        return new Vector2(radius * Mathf.Cos(2 * Mathf.PI * t), radius * Mathf.Sin(2 * Mathf.PI * t));
    }
    public static Vector2 Cycloid(float radius, float t)
    {
        return new Vector2(radius * (t - Mathf.Sin(t)), radius * (1 - Mathf.Cos(t)));
    }
}