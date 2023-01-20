namespace PROJECT_NAME.Application;

public static class Injection
{
    public static IServiceCollection InjectPROJECT_NAMEApplication(this IServiceCollection services, IConfiguration configuration)
    {	
        return services;
    }

    public static IApplicationBuilder InjectPROJECT_NAMEApplication(this IApplicationBuilder app)
    {

        return app;
    }
}
