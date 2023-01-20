namespace PROJECT_NAME.Api;

public static class Injection
{
    public static void InjectPROJECT_NAMEApi(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .InjectPROJECT_NAMEDomain()
            .InjectPROJECT_NAMEApplication(configuration)
            .InjectPROJECT_NAMEInfrastructure(configuration);			
    }
}
