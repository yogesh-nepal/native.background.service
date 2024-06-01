# native.background.service

native.background.service is an ASP.NET Core 8 application demonstrating the implementation of background processing using native .NET Core background services. This repository provides examples of different types of background tasks, including fire-and-forget, delayed, recurring, and continuation tasks.

## Description

In .NET Core, background services are long-running tasks that run in the background of an application without requiring an external library like Hangfire. This demo project illustrates how native .NET Core background services can be utilized to handle various background task scenarios efficiently.

## Features

- **Fire-and-Forget Tasks:** Execute tasks immediately and once.
- **Delayed Tasks:** Execute tasks after a specified delay.
- **Recurring Tasks:** Execute tasks at regular intervals.
- **Continuation Tasks:** Execute tasks sequentially after preceding tasks complete.

## Getting Started

To run the background-service-demo project locally:

1. Clone the repository.
2. Ensure you have the .NET Core 8 SDK installed.
3. Restore dependencies and build the project.
4. Run the application.

## Project Structure

- **Services:** Contains classes for implementing different types of background tasks.

## Acknowledgments

- .NET Core documentation for providing guidance on implementing background services.
