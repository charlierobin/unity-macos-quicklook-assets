#if UNITY_EDITOR_OSX

using UnityEngine;
using UnityEditor;

public class MacEditorQuickLookMenu : MonoBehaviour
{
    //[MenuItem("Edit/QuickLook _`")]
    [MenuItem("Assets/QuickLook _SPACE")]

    static void QuickLookSelectedAssets()
    {
        string[] selected = Selection.assetGUIDs;

        if (selected.Length == 0) return;

        string files = "";

        string assetsPath = Application.dataPath;

        foreach (string guid in selected)
        {
            var path = AssetDatabase.GUIDToAssetPath(guid);

            path = path["Assets".Length..];

            path = assetsPath + path;

            files = files + "\"" + path + "\" ";
        }

        System.Diagnostics.Process process = new System.Diagnostics.Process();

        process.StartInfo.FileName = "/bin/zsh";

        process.StartInfo.UseShellExecute = false;

        process.StartInfo.RedirectStandardInput = true;

        try
        {
            process.Start();

            process.StandardInput.WriteLine("qlmanage -p " + files);
        }
        catch (System.Exception e)
        {
            Debug.Log(e);
        }
    }
}

#endif
