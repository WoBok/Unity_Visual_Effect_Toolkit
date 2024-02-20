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
    /// <param name="p1">��1</param>
    /// <param name="p2">��2</param>
    /// <returns>����֮���λ��</returns>
    public static float Distance(Vector3 p1, Vector3 p2)
    {
        return Magnitude(GenerateVector(p1, p2));
    }
    /// <summary>
    /// ��������λ�ü���δ�����ľ��룬Ч�ʸ��ã��ʺ����ڱȽϴ�С
    /// </summary>
    /// <param name="p1">��1</param>
    /// <param name="p2">��2</param>
    /// <returns>δ�����ľ���</returns>
    public static float SqrDistance(Vector3 p1, Vector3 p2)
    {
        return SqrMagnitude(GenerateVector(p1, p2));
    }
    /// <summary>
    /// �������������ĵ��
    /// </summary>
    /// <param name="a">����A</param>
    /// <param name="b">����B</param>
    /// <returns></returns>
    public static float Dot(Vector3 a, Vector3 b)
    {
        return a.x * b.x + a.y * b.y + a.z * b.z;
    }
    /// <summary>
    /// ����δ����������ģ��
    /// </summary>
    /// <param name="v">����</param>
    /// <returns>δ����������ģ��</returns>
    public static float SqrMagnitude(Vector3 v)
    {
        return Dot(v, v);
    }
    /// <summary>
    /// ��������ģ��
    /// </summary>
    /// <param name="v">����</param>
    /// <returns>����ģ��</returns>
    public static float Magnitude(Vector3 v)
    {
        return Mathf.Sqrt(SqrMagnitude(v));
    }
    /// <summary>
    /// �Ƚ�����������ģ������������A��ģ���Ƿ������B��ģ����
    /// </summary>
    /// <param name="a">����A</param>
    /// <param name="b">����B</param>
    /// <returns>����A��ģ���Ƿ������B��ģ����</returns>
    public static bool CompareMagnitude(Vector3 a, Vector3 b)
    {
        return SqrMagnitude(a) > SqrMagnitude(b);
    }
    /// <summary>
    /// �Ƚ�����������ģ��������ģ���ϴ������
    /// </summary>
    /// <param name="a">����A</param>
    /// <param name="b">����B</param>
    /// <returns>ģ���ϴ������</returns>
    public static Vector3 MagnitudeMax(Vector3 a, Vector3 b)
    {
        return CompareMagnitude(a, b) ? a : b;
    }
    /// <summary>
    /// �Ƚ�����������ģ��������ģ����С������
    /// </summary>
    /// <param name="a">����A</param>
    /// <param name="b">����B</param>
    /// <returns></returns>
    public static Vector3 MagnitudeMin(Vector3 a, Vector3 b)
    {
        return CompareMagnitude(a, b) ? b : a;
    }
    /// <summary>
    /// ���������ĵ�λ����
    /// </summary>
    /// <param name="v">����</param>
    /// <returns>��λ����</returns>
    public static Vector3 Normalize(Vector3 v)
    {
        var magnitude = Magnitude(v);
        return magnitude == 0 ? Vector3.zero : v / Magnitude(v);
    }
    /// <summary>
    /// ������������֮��ļн�,����ֵΪ������
    /// </summary>
    /// <param name="a">����A</param>
    /// <param name="b">����B</param>
    /// <returns>�����������н�</returns>
    public static float AngleRad(Vector3 a, Vector3 b)
    {
        var s = Mathf.Sqrt(SqrMagnitude(a) * SqrMagnitude(b));
        return s == 0 ? 0 : Mathf.Acos(Dot(a, b) / s);
    }
    /// <summary>
    /// ������������֮��ļнǣ�����ֵΪ�Ƕ���
    /// </summary>
    /// <param name="a">����A</param>
    /// <param name="b">����B</param>
    /// <returns>�Ƕ��������н�</returns>
    public static float AngleDeg(Vector3 a, Vector3 b)
    {
        return AngleRad(a, b) * Mathf.Rad2Deg;
    }
    /// <summary>
    /// �ж��������������Ƿ������ͬ
    /// </summary>
    /// <param name="a">����A</param>
    /// <param name="b">����B</param>
    /// <returns>�������������Ƿ������ͬ</returns>
    public static bool IsRoughlySameDirection(Vector3 a, Vector3 b)
    {
        return Dot(a, b) > 0;
    }
    /// <summary>
    /// �ж����������Ƿ�ֱ
    /// </summary>
    /// <param name="a">����A</param>
    /// <param name="b">����B</param>
    /// <returns>���������Ƿ�ֱ</returns>
    public static bool IsPerpendicular(Vector3 a, Vector3 b)
    {
        return Dot(a, b) == 0;
    }
    /// <summary>
    /// ��������A������B�ϵ�ͶӰ
    /// </summary>
    /// <param name="a">����A</param>
    /// <param name="b">����B</param>
    /// <returns></returns>
    public static Vector3 Project(Vector3 a, Vector3 b)
    {
        var sqrMagnitude = SqrMagnitude(b);
        return sqrMagnitude == 0 ? Vector3.zero : b * (Dot(a, b) / sqrMagnitude);//Todo: ��֤
    }
    public static Vector3 Perpendicular(Vector3 v, Vector3 axis)//Todo: ��֤
    {
        return Vector3.zero;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    public static Vector3 Direction(Vector3 from, Vector3 to)
    {
        return GenerateVector(from, to);
    }
    public static Vector3 DirectionNormalized(Vector3 from, Vector3 to)
    {
        return Normalize(Direction(from, to));
    }
    /// <summary>
    /// ���ƽ���ڵ���ķ���
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    public static Vector3 HorizontalDirection(Vector3 from, Vector3 to)
    {
        var direction = GenerateVector(from, to);
        direction.y = 0;
        return direction;
    }
    public static Vector3 HorizontalDirectionNormalized(Vector3 from, Vector3 to)
    {
        return Normalize(HorizontalDirection(from, to));
    }
    public static Vector3 Cross(Vector3 a, Vector3 b)
    {
        return new Vector3(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
    }
    /// <summary>
    /// ���������������ɵ������ε����
    /// </summary>
    /// <param name="a">����A</param>
    /// <param name="b">����B</param>
    /// <returns>�����ε����</returns>
    public static float TriangelArea(Vector3 a, Vector3 b)
    {
        return Magnitude(Cross(a, b)) / 2;
    }
}