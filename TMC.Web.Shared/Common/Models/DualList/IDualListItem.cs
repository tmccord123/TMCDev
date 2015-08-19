namespace TMC.Web.Shared
{
    public interface IDualListItem : IPrimaryKey<long>
    {
        string DisplayText { get; set; }

        string Tooltip { get; set; }

        long CompareKey { get; set; }
    }
}