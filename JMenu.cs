using UnityEditor;
using UnityEngine;


public class JMenu : EditorWindow
{
    [UnityEditor.MenuItem("JMenu/Open")]
    public static void Open()
    {
        JMenu menu = EditorWindow.CreateInstance(typeof(JMenu)) as JMenu;
        menu.Show();
    }

    void OnGUI()
    {
        if (GUILayout.Button("Pupop"))
        {
            var rects = Selection.transforms[0].GetComponents<Rect>();
            var r1 = rects[0];
            var r2 = rects[1];
            JTools.PrintJRect(r1.rect);
            r1.rect.center = r1.rect.PopupPoint(r2.rect, r2.rect.center - r1.rect.center);
            r1.rect.PointUpt();
            JTools.PrintJRect(r1.rect);
            
        }
    }
}