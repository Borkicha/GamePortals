# GamePortals - Video Game Review & Rating Platform

A full-stack 3-Tier Web Application built with ASP.NET Core MVC designed for gaming enthusiasts to discover, search, review, and rate video games. Built using modern .NET 8 architecture, Entity Framework Core, and SQLite for lightweight, cross-platform deployment.

---

## Key Features

- **3-Tier Architecture:** Clear separation of concerns between Presentation (Razor/HTML/CSS), Application Logic (Controllers & Services), and Data Access (EF Core & SQLite).
- **Full CRUD Operations:** Seamless capabilities to Create, Read, Update (Edit), and Delete (Remove) games and user reviews.
- **Search & Filtering:** Dynamic search functionality by game title and filtering by genre.
- **Rating & Sorting System:** User-driven review and rating scoring, with real-time sorting capabilities by game name and average rating score.
- **User Authentication & Authorization:** Integrated ASP.NET Core Identity with role-based access control (Admin vs. Standard User).
- **Automated Data Seeding:** Built-in seed routines (SeedData.cs) to populate initial games, reviews, and admin accounts on first launch.

---

## Tech Stack

- **Backend:** C# (.NET 8 ASP.NET Core MVC)
- **Database & ORM:** SQLite (Microsoft.EntityFrameworkCore.Sqlite) with Entity Framework Core 8.0
- **Frontend:** HTML5, CSS3, JavaScript (DOM manipulation & client-side interactions), Bootstrap
- **Authentication:** ASP.NET Core Identity

---

## Architecture & Data Flow

The project strictly follows the Model-View-Controller (MVC) pattern to ensure clean code maintainability and testability:

```mermaid
graph TD
    Client[Browser Client] -->|HTTP Requests| View[Presentation Layer - HTML / CSS / JS / Razor]
    View -->|User Input / Actions| Controller[Controller Layer - Routing & Request Handling]
    Controller -->|Business Logic| Model[Model / Service Layer - Data Rules]
    Model -->|EF Core Operations| DB[(SQLite Database - gameportal.db)]