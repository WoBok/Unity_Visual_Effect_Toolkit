using UnityEngine;

public class VectorUtility
{
    /// <summary>
    /// ��������λ����������
    /// </summary>
    /// <param name="from">���</param>
    /// <param name="to">�յ�</param>
    /// <returns>�����ָ���ص������</returns>
    public static Vector3 GenerateVector(Vector3 from, Vector3 to)
    {
        return to - from;
    }
    /// <summary>
    /// ��������λ�ü������
    /// </summary>
    /// <param name="point1">��1</param>
    /// <param name="point2">��2</param>
    /// <returns>����֮���λ��</returns>
    public static float Distance(Vector3 point1, Vector3 point2)
    {
        return Magnitude(GenerateVector(point1, point2));
    }
    /// <summary>
    /// ��������λ�ü���δ�����ľ��룬Ч�ʸ��ã��ʺ����ڱȽϴ�С
    /// </summary>
    /// <param name="point1">��1</param>
    /// <param name="point2">��2</param>
    /// <returns>δ�����ľ���</returns>
    public static float SqrDistance(Vector3 point1, Vector3 point2)
    {
        return SqrMagnitude(GenerateVector(point1, point2));
    }
    /// <summary>
    /// �������������ĵ��
    /// </summary>
    /// <param name="vectorA">����A</param>
    /// <param name="vectorB">����B</param>
    /// <returns></returns>
    public static float Dot(Vector3 vectorA, Vector3 vectorB)
    {
        return vectorA.x * vectorB.x + vectorA.y * vectorB.y + vectorA.z * vectorB.z;
    }
    /// <summary>
    /// ����δ����������ģ��
    /// </summary>
    /// <param name="vector">����</param>
    /// <returns>δ����������ģ��</returns>
    public static float SqrMagnitude(Vector3 vector)
    {
        return Dot(vector, vector);
    }
    /// <summary>
    /// ��������ģ��
    /// </summary>
    /// <param name="vector">����</param>
    /// <returns>����ģ��</returns>
    public static float Magnitude(Vector3 vector)
    {
        return Mathf.Sqrt(Magnitude(vector));
    }
    /// <summary>
    /// �Ƚ�����������ģ������������A��ģ���Ƿ������B��ģ����
    /// </summary>
    /// <param name="vectorA">����A</param>
    /// <param name="vectorB">����B</param>
    /// <returns>����A��ģ���Ƿ������B��ģ����</returns>
    public static bool CompareMagnitude(Vector3 vectorA, Vector3 vectorB)
    {
        return SqrMagnitude(vectorA) > SqrMagnitude(vectorB);
    }
    /// <summary>
    /// �Ƚ�����������ģ��������ģ���ϴ������
    /// </summary>
    /// <param name="vectorA">����A</param>
    /// <param name="vectorB">����B</param>
    /// <returns>ģ���ϴ������</returns>
    public static Vector3 MagnitudeMax(Vector3 vectorA, Vector3 vectorB)
    {
        return CompareMagnitude(vectorA, vectorB) ? vectorA : vectorB;
    }
    /// <summary>
    /// �Ƚ�����������ģ��������ģ����С������
    /// </summary>
    /// <param name="vectorA">����A</param>
    /// <param name="vectorB">����B</param>
    /// <returns></returns>
    public static Vector3 MagnitudeMin(Vector3 vectorA, Vector3 vectorB)
    {
        return CompareMagnitude(vectorA, vectorB) ? vectorB : vectorA;
    }
    /// <summary>
    /// ������������֮��ļн�,����ֵΪ������
    /// </summary>
    /// <param name="vectorA">����A</param>
    /// <param name="vectorB">����B</param>
    /// <returns>�����������н�</returns>
    public static float AngleRad(Vector3 vectorA, Vector3 vectorB)
    {
        return Mathf.Acos(Dot(vectorA, vectorB) / Mathf.Sqrt(SqrMagnitude(vectorA) * SqrMagnitude(vectorB)));
    }
    /// <summary>
    /// ������������֮��ļнǣ�����ֵΪ�Ƕ���
    /// </summary>
    /// <param name="vectorA">����A</param>
    /// <param name="vectorB">����B</param>
    /// <returns>�Ƕ��������н�</returns>
    public static float AngleDeg(Vector3 vectorA, Vector3 vectorB)
    {
        return AngleRad(vectorA, vectorB) * Mathf.Rad2Deg;
    }
}