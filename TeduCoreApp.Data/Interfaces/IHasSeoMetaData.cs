namespace TeduCoreApp.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        string SeoPageTitle { set; get; }
        string SeoAlias { set; get; }
        string SeoKeyWords { set; get; }
        string SeoDescription { get; set; }
    }
}