namespace UniGame.AssetBookmarks.Editor
{
    using System;
    using System.Collections.Generic;
    using UnityEngine.Serialization;

#if ODIN_INSPECTOR
    using Sirenix.OdinInspector;
#endif
    
    [Serializable]
    public class AssetBookmarksData
    {
#if ODIN_INSPECTOR
        [TabGroup("bookmarks")]
#endif
        [FormerlySerializedAs("pinnedBookmarks")]
        public List<string> pinned = new List<string>();
        
#if ODIN_INSPECTOR
        [TabGroup("bookmarks")]
        [PropertySpace(8)]
#endif
        public List<string> bookmarks = new List<string>();
        
#if ODIN_INSPECTOR
        [TabGroup("settings")]
        [InlineProperty]
        [HideLabel]
#endif
        public AssetBookmarksSettings settings = new AssetBookmarksSettings();
    }
}