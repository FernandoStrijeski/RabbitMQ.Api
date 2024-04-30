
    public class ApiVersionHelper
{
    public string GetApiVersion(HttpContext httpContext)
    {
        if (httpContext.Request.RouteValues.TryGetValue("version", out var versionValue))
        {
            return versionValue?.ToString();
        }

        return null;
    }
}