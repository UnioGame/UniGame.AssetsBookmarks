namespace UniGame.AssetBookmarks.Editor
{
    
    using UniModules.UniGame.Core.Editor.EditorProcessors;

#if ODIN_INSPECTOR
    using Sirenix.OdinInspector;
#endif
    
    public class AssetBookmarksAsset : GeneratedAsset<AssetBookmarksAsset>
    {
#if ODIN_INSPECTOR
        [InlineProperty]
        [HideLabel]
#endif
        public AssetBookmarksData data = new AssetBookmarksData();
    }
}