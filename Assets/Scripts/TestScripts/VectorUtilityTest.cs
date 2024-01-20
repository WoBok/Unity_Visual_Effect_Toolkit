using UnityEngine;

public class VectorUtilityTest : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    void OnGUI()
    {
        if (GUILayout.Button("CalculateVector Angle"))
        {
            print(VectorUtility.AngleDeg(object1.forward, object2.forward));
            print(VectorUtility.AngleRad(object1.forward, object2.forward));
            print(Vector3.Angle(object1.forward, object2.forward));
        }
    }
}