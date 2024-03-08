public static class DependencyInjectionContainer
{
    public static IServiceCollection Inject(this IServiceCollection services)
    {
        //services.CoreDependencyMap();
        //services.AddScoped<IConsultorioContext, ConsultorioContext>();
        services.AddScoped<IPacienteRepository, PacienteRepository>();
        services.AddScoped<ITipoExameRepository, TipoExameRepository>();
        services.AddScoped<IExameRepository, ExameRepository>();
        services.AddScoped<IConsultaRepository, ConsultaRepository>();

        services.AddScoped<IPacienteService, PacienteService>();
        services.AddScoped<ITipoExameService, TipoExameService>();
        services.AddScoped<IExameService, ExameService>();
        services.AddScoped<IConsultaService, ConsultaService>();

        return services;
    }
    
}