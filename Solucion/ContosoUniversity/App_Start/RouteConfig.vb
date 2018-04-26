Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        '1-Definir las mas restrictivas primero
        '2-Las rutas deben ser descriptivas de lo que va a suceder
        '3-En todas las rutas al final ya sea por las varibles de la propia ruta o por la asignacion de
        'defaults. deben quedar asignados los valores de controller y action

        'routes.MapRoute(
        'name:="Blog",
        'url:="Blog/Index", 'Asignacion de variables
        'defaults:=New With {.controller = "Blog", .action = "Index"}
        ')

        'Ruta particula para Blogs
        '/Blog/{cualquiera}/2018/04/25 -> Se ejecuta el metodo cualquiera del controlador BlogController
        'routes.MapRoute(
        'name:="Blog1",
        'url:="{controller}/{action}/{year}/{month}/{day}", 'Asignacion de variables
        'defaults:={},
        'constraints:=New With {.controller = "Blog", .action = "Desde", .year = "\d{4}", .month = "\d{2}", .day = "\d{2}"}
        ')

        'Esta ruta aunque sea valida, n es una buena ruta porque no es descriptiva de lo
        'que se va a producir en el servidor

        '/2018/04/25 -> Se ejecuta el metodo Index del controlador BlogController
        'routes.MapRoute(
        'name:="Blog2",
        'url:="{year}/{month}/{day}",
        'defaults:=New With {.controller = "Blog", .action = "Index"},
        'constraints:=New With {.year = "\d{4}", .month = "\d{2}", .day = "\d{2}"}
        ')

        'Generico
        '/ -> Metodo Index de HomeController
        routes.MapRoute(
            name:="Default",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional}
        )
    End Sub
End Module