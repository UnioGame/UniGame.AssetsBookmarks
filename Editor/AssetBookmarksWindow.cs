namespace UniGame.AssetBookmarks.Editor
{
#if ODIN_INSPECTOR
    using Sirenix.OdinInspector;
    using Sirenix.OdinInspector.Editor;
#endif
    
    using UnityEditor;

#if ODIN_INSPECTOR

    public class AssetBookmarksWindow : OdinEditorWindow
    {
#region static data

        [MenuItem("UniGame/Tools/Bookmarks")]
        public static void Open()
        {
            var window = GetWindow<AssetBookmarksWindow>();
            window.InitializeDrawer();
            window.Show();
            window.Focus();
        }

#endregion
        
        [InlineProperty]
        [HideLabel]
        public AssetBookmarkDrawer drawer = new();

        protected override void Initialize()
        {
            InitializeDrawer();
            base.Initialize();
        }

        [Button("Reload")]
        [OnInspectorInit]
        public void InitializeDrawer()
        {
            drawer.Initialize();
            drawer.UpdateBookmarks();
            Selection.selectionChanged -= UpdateSelection;
            Selection.selectionChanged += UpdateSelection;
        }

        public void UpdateSelection()
        {
            drawer.AddBookmark(Selection.activeObject);
        }

        protected override void OnDestroy()
        {
            Selection.selectionChanged -= UpdateSelection;
            base.OnDestroy();
        }
    }
    
#endif
    
}
