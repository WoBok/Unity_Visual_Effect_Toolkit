using UnityEngine;

public class VectorUtility
{
    /// <summary>
    /// 根据两点位置生成向量
    /// </summary>
    /// <param name="from">起点</param>
    /// <param name="to">终点</param>
    /// <returns>从起点指向重点的向量</returns>
    public static Vector3 GenerateVector(Vector3 from, Vector3 to)
    {
        return to - from;
    }
    /// <summary>
    /// 根据两点位置计算距离
    /// </summary>
    /// <param name="p1">点1</param>
    /// <param name="p2">点2</param>
    /// <returns>两点之间的位置</returns>
    public static float Distance(Vector3 p1, Vector3 p2)
    {
        return Magnitude(GenerateVector(p1, p2));
    }
    /// <summary>
    /// 根据两点位置计算未开方的距离，效率更好，适合用于比较大小
    /// </summary>
    /// <param name="p1">点1</param>
    /// <param name="p2">点2</param>
    /// <returns>未开方的距离</returns>
    public static float SqrDistance(Vector3 p1, Vector3 p2)
    {
        return SqrMagnitude(GenerateVector(p1, p2));
    }
    /// <summary>
    /// 计算两个向量的点积
    /// </summary>
    /// <param name="a">向量A</param>
    /// <param name="b">向量B</param>
    /// <returns></returns>
    public static float Dot(Vector3 a, Vector3 b)
    {
        return a.x * b.x + a.y * b.y + a.z * b.z;
    }
    /// <summary>
    /// 计算未开方的向量模长
    /// </summary>
    /// <param name="v">向量</param>
    /// <returns>未开方的向量模长</returns>
    public static float SqrMagnitude(Vector3 v)
    {
        return Dot(v, v);
    }
    /// <summary>
    /// 计算向量模长
    /// </summary>
    /// <param name="v">向量</param>
    /// <returns>向量模长</returns>
    public static float Magnitude(Vector3 v)
    {
        return Mathf.Sqrt(SqrMagnitude(v));
    }
    /// <summary>
    /// 比较两个向量的模长，返回向量A的模长是否比向量B的模长大
    /// </summary>
    /// <param name="a">向量A</param>
    /// <param name="b">向量B</param>
    /// <returns>向量A的模长是否比向量B的模长大</returns>
    public static bool CompareMagnitude(Vector3 a, Vector3 b)
    {
        return SqrMagnitude(a) > SqrMagnitude(b);
    }
    /// <summary>
    /// 比较两个向量的模长，返回模长较大的向量
    /// </summary>
    /// <param name="a">向量A</param>
    /// <param name="b">向量B</param>
    /// <returns>模长较大的向量</returns>
    public static Vector3 MagnitudeMax(Vector3 a, Vector3 b)
    {
        return CompareMagnitude(a, b) ? a : b;
    }
    /// <summary>
    /// 比较两个向量的模长，返回模长较小的向量
    /// </summary>
    /// <param name="a">向量A</param>
    /// <param name="b">向量B</param>
    /// <returns></returns>
    public static Vector3 MagnitudeMin(Vector3 a, Vector3 b)
    {
        return CompareMagnitude(a, b) ? b : a;
    }
    /// <summary>
    /// 计算向量的单位向量
    /// </summary>
    /// <param name="v">向量</param>
    /// <returns>单位向量</returns>
    public static Vector3 Normalize(Vector3 v)
    {
        var magnitude = Magnitude(v);
        return magnitude == 0 ? Vector3.zero : v / Magnitude(v);
    }
    /// <summary>
    /// 计算两个向量之间的夹角,返回值为弧度制
    /// </summary>
    /// <param name="a">向量A</param>
    /// <param name="b">向量B</param>
    /// <returns>弧度制向量夹角</returns>
    public static float AngleRad(Vector3 a, Vector3 b)
    {
        var s = Mathf.Sqrt(SqrMagnitude(a) * SqrMagnitude(b));
        return s == 0 ? 0 : Mathf.Acos(Dot(a, b) / s);
    }
    /// <summary>
    /// 计算两个向量之间的夹角，返回值为角度制
    /// </summary>
    /// <param name="a">向量A</param>
    /// <param name="b">向量B</param>
    /// <returns>角度制向量夹角</returns>
    public static float AngleDeg(Vector3 a, Vector3 b)
    {
        return AngleRad(a, b) * Mathf.Rad2Deg;
    }
    /// <summary>
    /// 判断两个向量方向是否大致相同
    /// </summary>
    /// <param name="a">向量A</param>
    /// <param name="b">向量B</param>
    /// <returns>两个向量方向是否大致相同</returns>
    public static bool IsRoughlySameDirection(Vector3 a, Vector3 b)
    {
        return Dot(a, b) > 0;
    }
    /// <summary>
    /// 判断两个向量是否垂直
    /// </summary>
    /// <param name="a">向量A</param>
    /// <param name="b">向量B</param>
    /// <returns>两个向量是否垂直</returns>
    public static bool IsPerpendicular(Vector3 a, Vector3 b)
    {
        return Dot(a, b) == 0;
    }
    /// <summary>
    /// 生成向量A在向量B上的投影
    /// </summary>
    /// <param name="a">向量A</param>
    /// <param name="b">向量B</param>
    /// <returns></returns>
    public static Vector3 Project(Vector3 a, Vector3 b)
    {
        var sqrMagnitude = SqrMagnitude(b);
        return sqrMagnitude == 0 ? Vector3.zero : b * (Dot(a, b) / sqrMagnitude);//Todo: 验证
    }
    public static Vector3 Perpendicular(Vector3 v, Vector3 axis)//Todo: 验证
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
    /// 获得平行于地面的方向
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
    /// 计算两个向量构成的三角形的面积
    /// </summary>
    /// <param name="a">向量A</param>
    /// <param name="b">向量B</param>
    /// <returns>三角形的面积</returns>
    public static float TriangelArea(Vector3 a, Vector3 b)
    {
        return Magnitude(Cross(a, b)) / 2;
    }
}