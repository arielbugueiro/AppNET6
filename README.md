# AppNET6
Este proyecto se trata de una pequeña app que implementa Clean Architecture, Inyección de Dependencia, base de datos SQL Server Management, Dapper como ORM, AutoMapper, Swagger, JWT, UnitOfWork, Control de Versiones y MSTest como herramienta de testing.



<p align="center">
<img src="https://user-images.githubusercontent.com/70410313/196942839-73a0c788-d138-468b-a84b-f282415c454c.PNG">
</p>





## Entre sus dependencias se encuentran:

- AutoMapper
  - [AutoMapper](https://www.nuget.org/packages/AutoMapper "Link to www.nuget.org")
  
- MediatR
  - [MediatR](https://www.nuget.org/packages/MediatR "Link to www.nuget.org")
  - [MediatR.Extensions.Microsoft.DependencyInjection](https://www.nuget.org/packages/MediatR.Extensions.Microsoft.DependencyInjection "Link to www.nuget.org")
  
- FLuentValidation
  - [FluentValidation](https://www.nuget.org/packages/FluentValidation "Link to www.nuget.org")
 
- Microsoft.AspNet.MVC
  - [Microsoft.AspNetCore.Mvc.Core](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Core "Link to www.nuget.org")
  - [Microsoft.AspNetCore.Mvc.Versioning](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Versioning "Link to www.nuget.org")
  
- HealthChecks
  - [HealthChecks.SqlServer](https://www.nuget.org/packages/AspNetCore.HealthChecks.SqlServer "Link to www.nuget.org")
  - [HealthChecks.UI](https://www.nuget.org/packages/AspNetCore.HealthChecks.UI "Link to www.nuget.org")
  - [HealthChecks.UI.Client](https://www.nuget.org/packages/AspNetCore.HealthChecks.UI.Client "Link to www.nuget.org")
  - [HealthChecks.UI.InMemory.Storage](https://www.nuget.org/packages/AspNetCore.HealthChecks.UI.InMemory.Storage "Link to www.nuget.org")
  
- MSTest
  - [MSTest.TestAdapter](https://www.nuget.org/packages/MsTest.TestAdapter "Link to www.nuget.org")
  - [MSTest.TestFramework](https://www.nuget.org/packages/MsTest.TestFramework "Link to www.nuget.org")
  - [MSTest.NET.Test.Sdk](https://www.nuget.org/packages/Microsoft.NET.Test.Sdk "Link to www.nuget.org")
  - [Microsoft.AspNetCore.Mvc.Testing](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Testing "Link to www.nuget.org")

- WatchDog
  - [WatchDog.NET](https://www.nuget.org/packages/WatchDog.NET "Link to www.nuget.org")

<hr>


## Instalación de la aplicación:

* **Clone (descargue) este repositorio.**
* **Descargue Visual Studio 2022 y Microsoft SQL Server Management Studio.**
* **Ingrese al software Sql Server Configuration Manager e inicie el servicio SQL Server (MSSQLSERVER).**
* **Abra Microsoft SQL Server Management Studio.**
* **Cree una base de datos llamada Northwind**
* **Abra una pestaña New Query y ejecute los archivos "instnwnd.sql y objects" ubicado en la descarga del proyecto (DataBase)**

<em>* **Recomendaciones:**</em>
* **Si desea probar los endpoint de swagger el JWT usuario: Arielb / password:123**



>Autor: [Ariel Bugueiro](https://arielbugueiro.github.io/portfolio2021/)
