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
    /// <param name="point1">点1</param>
    /// <param name="point2">点2</param>
    /// <returns>两点之间的位置</returns>
    public static float Distance(Vector3 point1, Vector3 point2)
    {
        return Magnitude(GenerateVector(point1, point2));
    }
    /// <summary>
    /// 根据两点位置计算未开方的距离，效率更好，适合用于比较大小
    /// </summary>
    /// <param name="point1">点1</param>
    /// <param name="point2">点2</param>
    /// <returns>未开方的距离</returns>
    public static float SqrDistance(Vector3 point1, Vector3 point2)
    {
        return SqrMagnitude(GenerateVector(point1, point2));
    }
    /// <summary>
    /// 计算两个向量的点积
    /// </summary>
    /// <param name="vectorA">向量A</param>
    /// <param name="vectorB">向量B</param>
    /// <returns></returns>
    public static float Dot(Vector3 vectorA, Vector3 vectorB)
    {
        return vectorA.x * vectorB.x + vectorA.y * vectorB.y + vectorA.z * vectorB.z;
    }
    /// <summary>
    /// 计算未开方的向量模长
    /// </summary>
    /// <param name="vector">向量</param>
    /// <returns>未开方的向量模长</returns>
    public static float SqrMagnitude(Vector3 vector)
    {
        return Dot(vector, vector);
    }
    /// <summary>
    /// 计算向量模长
    /// </summary>
    /// <param name="vector">向量</param>
    /// <returns>向量模长</returns>
    public static float Magnitude(Vector3 vector)
    {
        return Mathf.Sqrt(Magnitude(vector));
    }
    /// <summary>
    /// 比较两个向量的模长，返回向量A的模长是否比向量B的模长大
    /// </summary>
    /// <param name="vectorA">向量A</param>
    /// <param name="vectorB">向量B</param>
    /// <returns>向量A的模长是否比向量B的模长大</returns>
    public static bool CompareMagnitude(Vector3 vectorA, Vector3 vectorB)
    {
        return SqrMagnitude(vectorA) > SqrMagnitude(vectorB);
    }
    /// <summary>
    /// 比较两个向量的模长，返回模长较大的向量
    /// </summary>
    /// <param name="vectorA">向量A</param>
    /// <param name="vectorB">向量B</param>
    /// <returns>模长较大的向量</returns>
    public static Vector3 MagnitudeMax(Vector3 vectorA, Vector3 vectorB)
    {
        return CompareMagnitude(vectorA, vectorB) ? vectorA : vectorB;
    }
    /// <summary>
    /// 比较两个向量的模长，返回模长较小的向量
    /// </summary>
    /// <param name="vectorA">向量A</param>
    /// <param name="vectorB">向量B</param>
    /// <returns></returns>
    public static Vector3 MagnitudeMin(Vector3 vectorA, Vector3 vectorB)
    {
        return CompareMagnitude(vectorA, vectorB) ? vectorB : vectorA;
    }
    /// <summary>
    /// 计算两个向量之间的夹角,返回值为弧度制
    /// </summary>
    /// <param name="vectorA">向量A</param>
    /// <param name="vectorB">向量B</param>
    /// <returns>弧度制向量夹角</returns>
    public static float AngleRad(Vector3 vectorA, Vector3 vectorB)
    {
        return Mathf.Acos(Dot(vectorA, vectorB) / Mathf.Sqrt(SqrMagnitude(vectorA) * SqrMagnitude(vectorB)));
    }
    /// <summary>
    /// 计算两个向量之间的夹角，返回值为角度制
    /// </summary>
    /// <param name="vectorA">向量A</param>
    /// <param name="vectorB">向量B</param>
    /// <returns>角度制向量夹角</returns>
    public static float AngleDeg(Vector3 vectorA, Vector3 vectorB)
    {
        return AngleRad(vectorA, vectorB) * Mathf.Rad2Deg;
    }
}