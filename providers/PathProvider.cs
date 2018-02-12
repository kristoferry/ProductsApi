using System.IO;
using Microsoft.AspNetCore.Hosting;

public class PathProvider : IPathProvider 
{
    private IHostingEnvironment _hostingEnvironment;

    public PathProvider(IHostingEnvironment hostingEnvironment) {
        _hostingEnvironment = hostingEnvironment;
    }

    public string MapPath(string path) {
        var filePath = Path.Combine(_hostingEnvironment.ContentRootPath, path);
        return filePath;
    }
}