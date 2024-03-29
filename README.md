# aspnet-microservices-architecture
 An e - commerce system for selling different technologicals products 👾. It represents a proof of concept example for building an application based on microservices architecture on .Net platforms which used Asp.Net Web API, Docker, RabbitMQ, MassTransit, Grpc, Ocelot API Gateway, MongoDB, Redis, PostgreSQL, SqlServer, Dapper, Entity Framework Core and CQRS.

# Architecture: 
<p align="center">
    <img src="assets/bigpicture.png" alt="Preview">
</p>

# Ordering microservice architecture
<p align="center">
    <img src="assets/architecture.png" alt="Preview">
</p>

# Web app
<p align="center">
    <img src="assets/ux.png" alt="Preview">
</p>


# Skills and Competences

Catalog microservice represents;

* ASP.NET Core Web API application
* REST API principles, CRUD operations
* MongoDB database connection and containerization
* Repository Pattern Implementation
* Swagger Open API implementation


Basket microservice represents;

* ASP.NET Web API application
* REST API principles, CRUD operations
* Redis database connection and containerization
* Consume Discount gRPC Service for inter-service sync communication to calculate product final price
* Publish BasketCheckout Queue with using MassTransit and RabbitMQ


Discount microservice represents;

* ASP.NET gRPC Server application
* Build a Highly Performant inter-service gRPC Communication with Basket Microservice
* Exposing gRPC Services with creating Protobuf messages
* Using Dapper for micro-orm implementation to simplify data access and ensure high performance
* PostgreSQL database connection and containerization


Microservices Communication

* Sync inter-service gRPC Communication
* Async Microservices Communication with RabbitMQ Message-Broker Service
* Using RabbitMQ Publish/Subscribe Topic Exchange Model
* Using MassTransit for abstraction over RabbitMQ Message-Broker system
* Publishing BasketCheckout event queue from Basket microservices and Subscribing this event from Ordering microservices
* Create RabbitMQ EventBus.Messages library and add references Microservices


Ordering Microservice

* Implementing DDD, CQRS, and Clean Architecture with using Best Practices
* Developing CQRS with using MediatR, FluentValidation and AutoMapper packages
* Consuming RabbitMQ BasketCheckout event queue with using MassTransit-RabbitMQ Configuration
* SqlServer database connection and containerization
* Using Entity Framework Core ORM and auto migrate to SqlServer when application startup


API Gateway Ocelot Microservice

* Implement API Gateways with Ocelot
* Sample microservices/containers to reroute through the API Gateways
* Run multiple different API Gateway/BFF container types
* The Gateway aggregation pattern in Shopping.Aggregator


WebUI ShoppingApp Microservice

* ASP.NET Core Web Application with Bootstrap 4 and Razor template
* Call Ocelot APIs with HttpClientFactory
* ASPNET Core Razor Tools — View Components, partial Views, Tag Helpers, Model Bindings and Validations, Razor Sections etc.


Ancillary Containers

* Use Portainer for Container lightweight management UI which allows you to easily manage your different Docker environments
* pgAdmin PostgreSQL Tools feature rich Open Source administration and development platform for PostgreSQL


Docker Compose establishment with all microservices on docker;

* Containerization of microservices
* Containerization of databases
* Override Environment variables