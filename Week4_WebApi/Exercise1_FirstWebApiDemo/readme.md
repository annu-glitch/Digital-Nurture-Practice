# ASP.NET Core Web API – README Documentation

## Overview

This documentation provides a structured explanation of creating a basic ASP.NET Core Web API project. It includes the foundational concepts of RESTful services, HTTP operations, controller architecture, and the configuration files involved in development using Visual Studio 2022.

---

## Objectives

### 1. Concept of RESTful Web Service, Web API & Microservice

- REST (Representational State Transfer) is an architectural style for designing networked applications using stateless communication via HTTP.
- Web API is a framework for building services that are accessible over HTTP, commonly used to expose application data to client-side apps.
- Microservice architecture breaks down applications into small, independently deployable services that communicate over APIs.

**REST Features:**
- Stateless communication
- Resource-oriented URIs
- Supports multiple response formats (JSON, XML)
- Standard HTTP verbs for interaction
- Decoupled client-server interaction

**Difference between Web Service and Web API:**
- Web Services are based on SOAP and exchange data in XML format only.
- Web APIs follow REST principles and can return JSON, XML, or plain text, making them lightweight and easier to integrate with various platforms.

---

### 2. HttpRequest and HttpResponse

- **HttpRequest** represents data sent by the client to the server, including method type, headers, and optional body content.
- **HttpResponse** is the data sent back to the client by the server, including status codes, headers, and returned data.

---

### 3. Action Verbs in Web API

- **HttpGet**: Used to retrieve data.
- **HttpPost**: Used to submit data to the server.
- **HttpPut**: Used to update existing data.
- **HttpDelete**: Used to delete data.

These verbs are declared using attributes in the controller to bind specific methods to HTTP operations.

---

### 4. HTTP Status Codes in Web API

- **200 OK**: The request was successful.
- **400 BadRequest**: The request was malformed or had missing data.
- **401 Unauthorized**: Authentication failed or was missing.
- **500 InternalServerError**: The server encountered an unexpected condition.

These status codes are returned from controller actions to indicate the result of API calls.

---

### 5. Web API Structure and Controller Responsibilities

- The Web API uses a controller-based model, where each controller handles a resource (e.g., Products, Users).
- Controllers inherit from a base controller class and define methods mapped to HTTP verbs.
- Each action method corresponds to a CRUD operation (Create, Read, Update, Delete).
- The routing system maps incoming URLs to controller actions based on defined route patterns.

---

### 6. Configuration Files in ASP.NET Core Web API

**Program.cs**
- Acts as the entry point of the application.
- Builds and configures the web host.
- Registers services and sets up the request handling middleware pipeline.

**appsettings.json**
- Stores configuration data like logging levels, database connections, and custom app settings.
- Supports hierarchical structure and can be environment-specific via files like appsettings.Development.json.

**launchSettings.json**
- Contains local environment settings used during development.
- Defines URLs, ports, environment variables, and browser launch preferences.
- Not used during production deployment.

**WebAPIConfig.cs and RouteConfig.cs (in .NET Framework 4.5)**
- Used in older ASP.NET projects to configure routing and controller mapping.
- In ASP.NET Core, attribute routing and middleware replace this configuration.

---

## Summary

The ASP.NET Core Web API framework enables developers to quickly build scalable, testable, and cross-platform HTTP services. By following RESTful principles and leveraging built-in features like routing, dependency injection, and Swagger UI, developers can create modern APIs that serve as the backbone for web, mobile, and desktop clients.
