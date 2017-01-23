using UnityEditor;

public class ExportadorDeAssetBundles
{
	[MenuItem ("Assets/Exporta AssetBundles")]
	static void BuildAllAssetBundles ()
	{
		BuildPipeline.BuildAssetBundles ("Assets/AssetBundles", BuildAssetBundleOptions.UncompressedAssetBundle, EditorUserBuildSettings.activeBuildTarget);
	}
}