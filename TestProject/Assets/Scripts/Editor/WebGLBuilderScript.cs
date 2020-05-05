using UnityEditor;

public class BuildScript 
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
    static void PerformBuildWebgl()
    {
        string[] defaultScene = { "Assets/Scenes/MainScene.unity" }; 
        string pathToDeploy = "builds/WebGLversionNew/";       

        BuildPipeline.BuildPlayer(defaultScene, pathToDeploy, BuildTarget.WebGL, BuildOptions.None);
        
    }
    

}
