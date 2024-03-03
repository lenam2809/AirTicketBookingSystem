# Air Ticket Booking System

Air Ticket Booking System is a WinForms application developed in C# that provides a user-friendly interface for booking flights. The project follows a three-tier architecture to separate concerns between User Interface (UI), Business Logic Layer (BLL), and Data Access Layer (DAL). It utilizes the Repository Pattern for flexible database access.

## Features

- Display a list of available flights with detailed information.
- Book flights by selecting a flight and entering relevant passenger details.
- Check the booking status by entering the booking code.
- Manage customer information linked to flight reservations.
- Maintain the list of flights, allowing administrators to add, edit, or delete flight details.

## Technology Stack

- C# for application logic.
- WinForms for the user interface.
- Entity Framework (or ADO.NET) for database interaction.
- Repository Pattern for flexible data access.

## Project Structure

The project is organized into three main layers:

1. **UI (User Interface):** Contains WinForms for presenting information to the user and capturing input.
2. **BLL (Business Logic Layer):** Manages business rules and logic. Connects UI and DAL.
3. **DAL (Data Access Layer):** Handles communication with the database, providing data to the BLL.

## Getting Started

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio.
3. Configure the connection string in `app.config` or `web.config`.
4. Build and run the application.

## Dependencies

- Entity Framework (if used) - Install using NuGet Package Manager.

```bash
Install-Package EntityFramework
