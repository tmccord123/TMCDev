namespace TMC.Web.Shared
{
    public interface IPrimaryKey<T>
    {
        T Id { get; set; }
    }
}