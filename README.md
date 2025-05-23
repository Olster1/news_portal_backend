# News Portal Backend

This is the backend API for the News Portal built with .NET 9.

## Prerequisites

- [Docker](https://www.docker.com/get-started) installed on your machine
---

## Running the Application with Docker

Follow these steps to build and run the app using Docker.

### 1. Clone the repository and move to Directory

```bash
git clone https://github.com/Olster1/news_portal_backend.git
cd news_portal_backend
```

### 2. Build Docker Image

```bash
docker build -t news-portal .
```

### 3. Run the Docker Image

```bash
docker run -p 5001:8080 news-portal
```

You can now access the API [localhost:5001/](http://localhost:5001)

### Documentation

To see the available API's, see the documentation at once the app is running:

http://localhost:5001/openapi/v1.json
