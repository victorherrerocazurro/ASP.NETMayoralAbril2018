
Imports System.Linq
Imports System.Web.Mvc
Imports Microsoft.Practices.Unity.Mvc

<Assembly: WebActivatorEx.PreApplicationStartMethod(GetType(App_Start.UnityWebActivator), "Start")> 
<Assembly: WebActivatorEx.ApplicationShutdownMethod(GetType(App_Start.UnityWebActivator), "Shutdown")> 

Namespace App_Start
    ''' <summary>Provides the bootstrapping for integrating Unity with ASP.NET MVC.</summary>
    Public NotInheritable Class UnityWebActivator
        Private Sub New()
        End Sub
        ''' <summary>Integrates Unity when the application starts.</summary>
        Public Shared Sub Start()
            Dim container = UnityConfig.GetConfiguredContainer()

            FilterProviders.Providers.Remove(FilterProviders.Providers.OfType(Of FilterAttributeFilterProvider)().First())
            FilterProviders.Providers.Add(New UnityFilterAttributeFilterProvider(container))

            DependencyResolver.SetResolver(New UnityDependencyResolver(container))

            ' TODO: Uncomment if you want to use PerRequestLifetimeManager
            'Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility.RegisterModule(GetType(UnityPerRequestHttpModule))
        End Sub

        ''' <summary>Disposes the Unity container when the application is shut down.</summary>
        Public Shared Sub Shutdown()
            Dim container = UnityConfig.GetConfiguredContainer()
            container.Dispose()
        End Sub
    End Class
End Namespace

