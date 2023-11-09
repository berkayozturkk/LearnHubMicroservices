namespace LearnHub.Services.Catolog.ConfigurationSettings;

public interface IDatabaseSettings
{
    public string CourseCategoryName { get; set; }
    public string CategoryCollectionName { get; set; }
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
}
