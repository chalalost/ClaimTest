# InsuranceClaim
For test only
# Introduction
This repository contains three separate projects:

1. **Server**: A back-end API built with .NET 8 Web API.
2. **ClientBlazor**: A front-end application built with Blazor WebAssembly.
3. **Client**: A front-end application built with React Typescript.

Select multi startup project to run all of them.

Database this project using is an in-memory database.
The client communicates with the server via HTTP requests.

There are three total endpoints:

- `Claim/submit`: claim Submission API;
- `Claim/process`: claim Processing API;
- `Claim/status`: retrieve Claims API;

---

## **Prerequisites**

Ensure the following tools are installed on your machine:

- [Visual Studio 2022](https://visualstudio.microsoft.com/) (with .NET 8 SDK)
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

---

### **Clone the Repository**
Clone the repository to your local machine:
```bash
git clone <repository-url>
cd <repository-folder>
