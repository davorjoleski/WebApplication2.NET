# 🚀 WebApplication2 - ASP.NET Core 9 Web API DevOps Project

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-9.0-purple)
![Docker](https://img.shields.io/badge/Docker-Containerized-blue)
![Kubernetes](https://img.shields.io/badge/Kubernetes-Orchestrated-326CE5)
![Helm](https://img.shields.io/badge/Helm-Deployed-0F1689)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-16-336791)

---

# 📖 Overview

This project is an **ASP.NET Core 9 Web API** that demonstrates a complete **backend + DevOps workflow**, starting from local development and ending with **Kubernetes orchestration using Helm**.

The purpose of this project was to learn how a **real-world backend application** is:

- ✅ Built
- ✅ Containerized
- ✅ Deployed
- ✅ Scaled
- ✅ Managed

---

# 🌿 Branches

| Branch | Description |
|---------|-------------|
| **master** | ASP.NET Core Web API + Docker Compose |
| **kubernetes** | Kubernetes deployment configuration |
| **helm** | Helm chart deployment |

---

# 🏗️ Project Architecture

```text
Client
   │
   ▼
ASP.NET Core Web API
   │
   ▼
Entity Framework Core
   │
   ▼
PostgreSQL
   │
   ▼
Docker Containers
   │
   ▼
Kubernetes Cluster
   │
   ▼
Helm Deployment
```

---

# 🛠️ Technologies

### Backend

- ✅ ASP.NET Core 9 Web API
- ✅ Entity Framework Core
- ✅ PostgreSQL
- ✅ AutoMapper
- ✅ FluentValidation
- ✅ JWT Authentication

### DevOps

- 🐳 Docker
- 🐳 Docker Compose
- ☸️ Kubernetes
- ⚓ Helm

### Kubernetes Components

- ConfigMaps
- Secrets
- Persistent Volumes (PV)
- Persistent Volume Claims (PVC)
- Horizontal Pod Autoscaler (HPA)
- NGINX Ingress Controller

---

# ✨ Features

- 🔐 JWT Authentication
- 📦 REST API
- ✏️ CRUD Operations
- ✅ FluentValidation
- 🔄 AutoMapper
- 🌍 Global Exception Middleware
- ❤️ Health Checks
- 🗄️ Entity Framework Core Migrations
- 🐘 PostgreSQL Integration

---

# 🐳 Docker

The application is fully containerized using Docker.

### Implemented

- ✅ Multi-stage Dockerfile
- ✅ Docker Compose
- ✅ API & PostgreSQL containers
- ✅ Docker Networking
- ✅ Environment Variables
- ✅ Automatic Database Startup Retry

---

# ☸️ Kubernetes

The application is deployed locally on Kubernetes.

### Implemented

- ✅ Deployments
- ✅ Pods
- ✅ ReplicaSets
- ✅ Services
- ✅ NodePort
- ✅ Ingress
- ✅ ConfigMaps
- ✅ Secrets
- ✅ Persistent Volumes
- ✅ Persistent Volume Claims
- ✅ Health Checks
- ✅ Horizontal Pod Autoscaler
- ✅ Rolling Updates

---

# ⚓ Helm

Deployment is managed using Helm.

### Implemented

- ✅ Custom Helm Chart
- ✅ values.yaml configuration
- ✅ Helm Install
- ✅ Helm Upgrade
- ✅ Helm Rollback
- ✅ Namespace Deployment

---

# 🗄️ Database

**Database:** PostgreSQL 16

### Implemented

- ✅ Entity Framework Core Migrations
- ✅ Automatic Migration Execution
- ✅ Startup Retry Logic
- ✅ Persistent Storage (PVC)

---

# ❤️ Health Checks

Implemented:

- ✅ Readiness Probe
- ✅ Liveness Probe

Endpoint

```text
/health
```

---

# 📦 Kubernetes Objects Used

- Namespace
- Deployment
- ReplicaSet
- Pod
- Service
- Ingress
- ConfigMap
- Secret
- PersistentVolume
- PersistentVolumeClaim
- HorizontalPodAutoscaler

---

# 🔥 Challenges Solved

Throughout development several production-like issues were solved:

- PostgreSQL startup timing
- Database migration execution
- Missing Users table
- Docker networking
- Kubernetes DNS resolution
- CrashLoopBackOff
- Health Check failures
- Ingress configuration
- Image update issues
- Rolling deployments
- PostgreSQL persistent storage

---

# 💻 Frequently Used Commands

## 🐳 Docker

```bash
docker compose up --build
docker compose down
docker compose ps
docker compose logs
```

---

## 🗄️ Entity Framework

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet ef migrations list
```

---

## ☸️ Kubernetes

```bash
kubectl get pods
kubectl get deployments
kubectl get services
kubectl describe pod
kubectl logs
kubectl apply -f
kubectl delete -f
kubectl port-forward
```

---

## ⚓ Helm

```bash
helm install
helm upgrade
helm rollback
helm uninstall
helm list
helm history
```

---

# 🚀 Future Improvements

- 🔄 GitHub Actions CI/CD
- 🐳 Docker Hub Integration
- ☁️ Azure Kubernetes Service (AKS)
- 📦 Azure Container Registry (ACR)
- 🐘 Azure PostgreSQL
- 🔐 Azure Key Vault
- 🌍 Terraform Infrastructure as Code
- 📊 Prometheus Monitoring
- 📈 Grafana Dashboards
- 📝 Loki / ELK Logging
- 🔒 HTTPS with Cert-Manager

---

# 📚 Learning Outcomes

This project provided hands-on experience with:

- Building scalable REST APIs
- Docker containerization
- Entity Framework Core migrations
- Kubernetes deployments
- Helm package management
- Production-style deployments
- Infrastructure troubleshooting
- Cloud-ready architecture

---

# 📈 Project Status

| Component | Status |
|-----------|--------|
| ASP.NET Core Web API | ✅ |
| Docker | ✅ |
| Docker Compose | ✅ |
| PostgreSQL | ✅ |
| Kubernetes | ✅ |
| Helm | ✅ |
| Production-ready Local Environment | ✅ |

---

# 🎯 Next Phase

- ☁️ Deploy to Azure Kubernetes Service (AKS)
- 🔄 Implement GitHub Actions CI/CD
- 📦 Azure Container Registry (ACR)
- 📊 Monitoring with Prometheus & Grafana
- 🔐 HTTPS using Cert-Manager
- 🌍 Infrastructure as Code using Terraform

---

## ⭐ Project Goal

This repository demonstrates a **complete backend DevOps workflow**, covering everything from **ASP.NET Core development** to **Docker**, **Kubernetes**, and **Helm**, providing a strong foundation for cloud-native deployments.
