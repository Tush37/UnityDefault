using UnityEditor;

public class WebGLBuilderScript 
{
     [MenuItem("Custom Utilities/Build StandaloneLinux64")]
    static void PerformBuild()
    {
        string[] defaultScene = { "Assets/Scenes/MainScene.unity" };
        BuildPipeline.BuildPlayer(defaultScene, "./builds/game.x86_64",
            BuildTarget.StandaloneLinux64, BuildOptions.None);
    }

    [MenuItem("Custom Utilities/Build Asset Bundle StandaloneLinux64")]
    static void PerformAssetBundleBuild()
    {
        BuildPipeline.BuildAssetBundles("../AssetBundles/", BuildAssetBundleOptions.ChunkBasedCompression,
            BuildTarget.StandaloneLinux64);
    }
    
    
    [MenuItem("Custom Utilities/Build WebGL")]
    public static void PerformBuildWebgl()
    {
        
        string pathToDeploy = "./builds/WebGLversionNew/";    
         var sceneSettings = EditorBuildSettings.scenes;
		string[] scenePaths = new string[sceneSettings.Length];

		for (int i = 0; i < scenePaths.Length; ++i)
		{
			scenePaths[i] = sceneSettings[i].path;
		}
         
         

        BuildPipeline.BuildPlayer(scenePaths, pathToDeploy, BuildTarget.WebGL, BuildOptions.None);
        
    }
    

}
