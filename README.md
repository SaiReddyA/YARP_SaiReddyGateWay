# YARP API Gateway Project


This project demonstrates how to set up an API Gateway using **YARP (Yet Another Reverse Proxy)** in a .NET application. The gateway proxies requests to multiple backend services, such as `StudentService` and `TeacherService`.


## Features

- API Gateway with YARP for routing requests to multiple backend services.
- Reverse proxy setup with route matching and transformations.
- Supports dynamic path-based routing (`GET by ID`, `GET all`).
- Easily extensible for additional backend services.

## Prerequisites
1. .NET SDK 8.0 or later installed.
2. Visual Studio 2022 or a compatible code editor.
3. Backend services (e.g., `StudentService`, `TeacherService`) running locally.

## Setup Instructions

### Clone the Repository
```bash
git clone https://github.com/SaiReddyA/YARP_SaiReddyGateWay.git
cd YARP_SaiReddyGateWay
```
Project Structure
- Gateway Project: The main YARP-based gateway application.
- Backend Services: Example services for Students and Teachers.
  
Known Issues
- 502 Bad Gateway: This occurs if backend services are not running or are incorrectly configured.
- Route Matching Issues: Ensure paths in appsettings.json match backend service endpoints.

