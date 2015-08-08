using UnityEngine;

public class JDebug : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDrawGizmos()
    {
        foreach (var rect in JRect.debugRectList)
        {
            JTools.DrawJRect(rect);
        }
    }

   
}
