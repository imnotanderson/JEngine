using UnityEngine;



public class JTools
{
    public static Vector2 JPoint2Vector2(JPoint point)
    {
        return new Vector3(point.x, point.y);
    }

    public static void DrawJRect(JRect rect)
    {
        Vector2 p1, p2, p3, p4;
        p1 = JTools.JPoint2Vector2(rect.point1);
        p4 = JTools.JPoint2Vector2(rect.point2);
        p2 = new Vector2(p4.x, p1.y);
        p3 = new Vector2(p1.x, p4.y);
        Gizmos.DrawLine(p1, p2);
        Gizmos.DrawLine(p2, p4);
        Gizmos.DrawLine(p3, p4);
        Gizmos.DrawLine(p1, p3);
    }

    public static void PrintJRect(JRect rect)
    {
        Debug.Log(string.Format("JRect:({0},{1}),{2},{3}", rect.center.x, rect.center.y, rect.width, rect.height));
    }
}