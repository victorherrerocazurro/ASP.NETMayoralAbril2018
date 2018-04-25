
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Unity.Configuration
'Fix the the following dependency 
Imports Unity.MVC.VB.SampleObject

Namespace App_Start
    ''' <summary>
    ''' Specifies the Unity configuration for the main container.
    ''' </summary>
    Public Class UnityConfig
#Region "Unity Container"
        Private Shared container As New Lazy(Of IUnityContainer)(Function()
                                                                     Dim container = New UnityContainer()
                                                                     RegisterTypes(container)
                                                                     Return container

                                                                 End Function)

        ''' <summary>
        ''' Gets the configured Unity container.
        ''' </summary>
        Public Shared Function GetConfiguredContainer() As IUnityContainer
            Return container.Value
        End Function
#End Region

        ''' <summary>Registers the type mappings with the Unity container.</summary>
        ''' <param name="container">The unity container to configure.</param>
        ''' <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        ''' change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        Public Shared Sub RegisterTypes(container As IUnityContainer)
            ' NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            ' container.LoadConfiguration()

            ' TODO: Register your types here
            ''Uncomment the following code and fix the  SampleObject dependency

            'Tenemos la responsabilidad de complatar todas las depedencias

            'Cuando el contenedor de IoC de Unity se encuentre con una depedencia de tipo ISchoolService,
            'la resolverra con una instancia de SchoolService
            container.RegisterType(Of ISchoolService, SchoolService)()
            container.RegisterType(Of SchoolContext, SchoolContext)()
            container.RegisterType(Of ICourseDao, EntityFrameworkCourseDao)()
        End Sub
    End Class
End Namespace


