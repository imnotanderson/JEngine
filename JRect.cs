using System;
using System.Collections.Generic;

public class JRect
{
    public static List<JRect> debugRectList = new List<JRect>();
    public JPoint center;
    public float width, height;
    public JPoint point1, point2;

    public JRect(JPoint center, float width, float height)
    {
        debugRectList.Add(this);
        this.center = center;
        this.width = width;
        this.height = height;
        this.point1 = JPoint.Zero;
        this.point1 = JPoint.Zero;
        PointUpt();
    }

    public JRect(float x, float y, float width, float height)
    : this(new JPoint(x, y), width, height)
    {

    }

    ~JRect()
    {
        debugRectList.Remove(this);
    }

    public void PointUpt()
    {
        point1.x = center.x - width / 2f;
        point1.y = center.y + height / 2f;
        point2.x = center.x + width / 2f;
        point2.y = center.y - height / 2f;
    }

    public bool IsIn(JPoint point)
    {
        if (point1.x <= point.x
            && point.x <= point2.x
            && point2.y <= point.y
            && point.y <= point1.y)
        {
            return true;
        }
        return false;
    }

    public bool IsIn(JRect rect)
    {
        if (IsIn(rect.point1) || IsIn(rect.point2))
        {
            return true;
        }
        return false;
    }

    public JPoint PopupPoint(JRect rect, JPoint moveDir)
    {
        UnityEngine.Debug.Log("x");
        if (IsIn(rect) || rect.IsIn(this))
        {
            JPoint tmCenter = rect.center;
            JPoint p = rect.center - center;
            float d = p.Mod;
            JPoint dir = moveDir.Contrary;
            dir = dir.Normal;
            float absX = Math.Abs(dir.x);
            float absY = Math.Abs(dir.y);
            float heightSum = (rect.height + this.height) / 2f;
            float widthSum = (rect.width + this.width) / 2f;
            UnityEngine.Debug.Log(widthSum);
            //向上下弹--
            if (absY >= absX)
            {
                float y = rect.center.y + (dir.y >= 0 ? heightSum : -heightSum);
                tmCenter.y = y;
            }
            else
            //向左右弹--
            {
                float x = rect.center.x + (dir.x >= 0 ? widthSum : -widthSum);
                tmCenter.x = x;
            }
            return tmCenter;
        }
        return rect.center;
    }
}


