# Student Web Service
REST API created with ASP.Net Core 5.0

### ASP.NET Core Web Service & EntityFramework Core Based Startup Template

ASP.NET makes it easy to build services that reach a broad range of clients, including browsers and mobile devices.

With ASP.NET you use the same framework and patterns to build both web pages and services, side-by-side in the same project.

## EndPoints

| Methods  | Endpoint                            | Description                        |
| -------- | ------------------------------------| -----------------------------------|
| GET      | ​/api​/Students                     | Get all Students                   |
| GET      | ​/api​/Students/{id}                | Get a especific Student            |
| POST     | ​/api​/Students                     | Add new Student                    |
| PUT      | ​/api​/Students/{id}                | Update a Student                   |
| DELETE   | ​/api​/Students/{id}                | Delete a Student                   |

## Example Value | Schema
```
{
  "id": 0,
  "matricula": "string",
  "nombre": "string",
  "apellido": "string",
  "cedula": "string",
  "carrera": "string",
  "creditosAprobados": 0,
  "indice": 0,
  "condicionAcademica": "string",
  "fechaIngreso": "2021-03-26T22:29:15.290Z"
}
```
## Prerequirements

* Visual Studio 2017 or higher
* .NET Core SDK
* SQL Server

## How To Run

* Create Database in SQL Server
* Open solution in Visual Studio
* Change ConnectionString in appsettings.json
* Run migration
* Run the application.
