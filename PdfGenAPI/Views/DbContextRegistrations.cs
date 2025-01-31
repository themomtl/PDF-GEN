using Microsoft.EntityFrameworkCore;
using PdfGenAPI.Views;

namespace PdfGenAPI;

public static class DbContextRegistrations
{
    private static void AddDb<TContext>(
        this IServiceCollection services,
        IConfiguration configuration,
        string connectionStringName
    )
        where TContext : DbContext
    {
        services.AddDbContext<TContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString(connectionStringName),
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5,
                        maxRetryDelay: TimeSpan.FromSeconds(30),
                        errorNumbersToAdd: null
                    );
                }
            )
        );
    }

    public static void AddDbContexts(this IServiceCollection services, IConfiguration configuration)
    {
        if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "IntegrationTest")
        {
            // services.AddDb<TSC_CT_Context>(configuration, "ct-test");
            // services.AddDb<TSC_AR_Context>(configuration, "ar-test");
            // services.AddDb<TSC_FL_Context>(configuration, "fl-test");
            // services.AddDb<TSC_GA_Context>(configuration, "ga-test");
            // services.AddDb<TSC_MA_Context>(configuration, "ma-test");
            // services.AddDb<TSC_MD_Context>(configuration, "md-test");
            // services.AddDb<TSC_ME_Context>(configuration, "me-test");
            // services.AddDb<TSC_MI_Context>(configuration, "mi-test");
            // services.AddDb<TSC_NC_Context>(configuration, "nc-test");
            // services.AddDb<TSC_NH_Context>(configuration, "nh-test");
            // services.AddDb<TSC_NJ_Context>(configuration, "nj-test");
            // services.AddDb<TSC_NY_Context>(configuration, "ny-test");
            // services.AddDb<TSC_OH_Context>(configuration, "oh-test");
            // services.AddDb<TSC_PA_Context>(configuration, "pa-test");
            // services.AddDb<TSC_RI_Context>(configuration, "ri-test");
            // services.AddDb<TSC_SC_Context>(configuration, "sc-test");
            // services.AddDb<TSC_TN_Context>(configuration, "tn-test");
            // services.AddDb<TSC_TX_Context>(configuration, "tx-test");
            // services.AddDb<TSC_VA_Context>(configuration, "va-test");
            // services.AddDb<TSC_VT_Context>(configuration, "vt-test");
        }
        else
        {
            services.AddDb<TSC_CT_Context>(configuration, "ct");
            services.AddDb<TSC_AR_Context>(configuration, "ar");
            services.AddDb<TSC_DE_Context>(configuration, "de");
            services.AddDb<TSC_FL_Context>(configuration, "fl");
            services.AddDb<TSC_GA_Context>(configuration, "ga");
            services.AddDb<TSC_IL_Context>(configuration, "il");
            services.AddDb<TSC_MA_Context>(configuration, "ma");
            services.AddDb<TSC_MD_Context>(configuration, "md");
            services.AddDb<TSC_ME_Context>(configuration, "me");
            services.AddDb<TSC_MI_Context>(configuration, "mi");
            services.AddDb<TSC_NC_Context>(configuration, "nc");
            services.AddDb<TSC_NH_Context>(configuration, "nh");
            services.AddDb<TSC_NJ_Context>(configuration, "nj");
            services.AddDb<TSC_NY_Context>(configuration, "ny");
            services.AddDb<TSC_OH_Context>(configuration, "oh");
            services.AddDb<TSC_PA_Context>(configuration, "pa");
            services.AddDb<TSC_RI_Context>(configuration, "ri");
            services.AddDb<TSC_SC_Context>(configuration, "sc");
            services.AddDb<TSC_TN_Context>(configuration, "tn");
            services.AddDb<TSC_TX_Context>(configuration, "tx");
            services.AddDb<TSC_VA_Context>(configuration, "va");
            services.AddDb<TSC_VT_Context>(configuration, "vt");
            services.AddDb<TSC_Utilities>(configuration, "utilities");
        }
    }
}
