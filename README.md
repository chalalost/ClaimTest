# InsuranceClaim
---
This project is an assignment to create a simplified version of an Insurance Claim System..

The system should:

1. Allow customers to file claims online.
2. Store claims in a database.
3. Process claims and assign them a status (e.g., Pending, Approved, Rejected).
4. Provide an API to retrieve claims by their status.

# Code Structure 
---
 ```bash
Backend:
├── Controllers         # Presentation Layer
│   └── ClaimsController.cs
├── Services            # Business Logic Layer
│   └── ClaimsService.cs
├── Repositories        # Data Access Layer
│   └── ClaimsRepository.cs
├── Models              # Data Models
│   └── DTOs            
│       └── ClaimSubmissionDto.cs
│   └── Enums            
│       └── ClaimStatus.cs
├── Data               # DbContext Configuration
│   └── Entities
        └── Claim.cs
│   └── ClaimsDbContext.cs
├── Program.cs          # Application Startup
└── Startup.cs          # Dependency Injection Configuration
 ```

 ```bash
Frontend
├── Pages               # Razor Pages
│   └── Home.razor    
├── Shared              # Shared Components
│   └── NavMenu.razor   
│   └── ClaimDto.cs
│   └── ClaimSubmissionDto.cs
├── Program.cs          # Blazor WebAssembly Startup
└── wwwroot             # Static files and assets
````

 ```bash
Test
InsuranceClaim.TestAPI
├── ClaimsControllerTests.cs  # API controller tests
````
# Accomplishments in 3 Days (Weekday Progress)
---
Despite working on this during the week with limited time, the following milestones were achieved in just 3 days:

**Day 1: Backend Implementation**

- Designed the layered architecture and implemented the core backend logic.
- Developed endpoints for claim submission, processing, and retrieval.
- Configured Microsoft.EntityFrameworkCore.InMemory for temporary data storage.
- Validation data

**Day 2: Frontend Development**

- Built the Blazor WebAssembly frontend with a clean and responsive UI.
- Integrated form validation for claim submission.
- Connected the frontend with backend APIs to enable data flow.

**Day 3: Unit Testing**

- Wrote unit tests for the service, repository, and controller layers using NUnit.
- Verified business logic and ensured backend APIs work as expected.

# Introduction
---
This repository contains three separate projects:

1. **Server**: A back-end API built with .NET 8 Web API.
2. **ClientBlazor**: A front-end application built with Blazor WebAssembly.
3. **Tests**: A testing enviroment built with Nunit.

Database this project using is an in-memory database.
The client communicates with the server via HTTP requests.

There are total four endpoints:

- `Claims/submit-claim`: claim Submission API;
- `Claims/process-claim/{id}`: claim Processing API;
- `Claims/retrieve-claims`: retrieve Claim API;
- `Claims/get-all-claims`: get all Claims API

# ToDo List:
---
After completing this project, it became clear that to make the system more robust and production-ready, so i figure out that several enhancements would be necessary:

 - User Accounts for Authorization and Authentication.
 - Persistent Database.
 - Search Functionality.
 - Pagination.
 - Additional Improvements.

## Prerequisites
---
Ensure the following tools are installed on your machine:

- [Visual Studio 2022](https://visualstudio.microsoft.com/) (with .NET 8 SDK)
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)

---

### **Clone the Repository**
Clone the repository to your local machine:
```bash
git clone <repository-url>
cd <repository-folder>
