using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;

public class MenuItems
{
    [MenuItem("SkyRogue_ModTools/Build Asset Bundles")]
    public static void SaveBundle()
    {
        string buildPath = "Assets/ModPacks/ModPack/";
        
        string[] platformnames = { "win", "mac", "lin" };

        for (int i = 0; i < platformnames.Length; i++)
        {
            string platformPath = buildPath + platformnames[i] + "/";
            if (!Directory.Exists(platformPath))
            {
                Directory.CreateDirectory(platformPath);
            }
        }

        BuildPipeline.BuildAssetBundles(buildPath + "win/", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
        BuildPipeline.BuildAssetBundles(buildPath + "mac/", BuildAssetBundleOptions.None, BuildTarget.StandaloneOSXUniversal);
        BuildPipeline.BuildAssetBundles(buildPath + "lin/", BuildAssetBundleOptions.None, BuildTarget.StandaloneLinuxUniversal);
    }

}
