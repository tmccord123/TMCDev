namespace TMC.Web.Shared
{
    /// <summary>
    /// Duallist item for SelectColumns dual list.
    /// </summary>
    public class SelectColumnsDualListItem : IDualListItem
    {
        public long Id { get; set; }

        public string DisplayText { get; set; }

        public string Tooltip { get; set; }

        public long CompareKey { get; set; }
    }
}