using Korn.Utils.GithubExplorer;
using Korn.Utils.WinForms;

static class Assets
{
    static Assets()
    {
        var repository = new RepositoryID("YoticKorn", "Overview");
        resolver = new GithubAssetsResolver(repository);

        KornIcon = ResolveImage("Assets/KornIcon.png");
    }

    static GithubAssetsResolver resolver;
    static Image ResolveImage(string path)
    {
        var bytes = resolver.Resolve(path);
        using var memoryStream = new MemoryStream(bytes);
        var image = Image.FromStream(memoryStream);

        return image;
    }

    public static Image KornIcon;
}