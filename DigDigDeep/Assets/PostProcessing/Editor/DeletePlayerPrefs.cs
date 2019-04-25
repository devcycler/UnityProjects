using UnityEditor;
using UnityEngine;

public class DeletePlayerPrefs : EditorWindow
{
    static void DeleteAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
