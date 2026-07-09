WebApplication2 - ASP.NET Core Web API DevOps Project
Project Overview 3 Branches master->just the backend with docker-compose , 
                            kuberentes->kuberenetes setup
                            Helm -> Helm setup

This project is an ASP.NET Core 9 Web API that demonstrates a complete modern backend and DevOps workflow, starting from local development and ending with Kubernetes orchestration using Helm.

The goal of this project was to learn how a real-world backend application is built, containerized, deployed, and managed.

Technologies
ASP.NET Core 9 Web API
Entity Framework Core
PostgreSQL
AutoMapper
FluentValidation
JWT Authentication
Docker
Docker Compose
Kubernetes
Helm
ConfigMaps
Secrets
Horizontal Pod Autoscaler (HPA)
Persistent Volumes (PV)
Persistent Volume Claims (PVC)
NGINX Ingress Controller
Project Architecture

Client

↓

ASP.NET Core Web API

↓

Entity Framework Core

↓

PostgreSQL

↓

Docker Containers

↓

Kubernetes Cluster

↓

Helm Deployment

Features
REST API
CRUD Operations
JWT Authentication
FluentValidation
AutoMapper
Global Exception Middleware
Health Checks
Entity Framework Core Migrations
PostgreSQL Integration
Docker

The application is fully containerized using Docker.

Implemented:

Multi-stage Dockerfile
Docker Compose
Separate API and PostgreSQL containers
Docker Networking
Environment Variables
Automatic database startup retry
Kubernetes

The application is deployed locally on Kubernetes.

Implemented:

Deployments
Pods
ReplicaSets
Services
NodePort
Ingress
ConfigMaps
Secrets
Persistent Volumes
Persistent Volume Claims
Health Checks
Horizontal Pod Autoscaler
Rolling Updates
Helm

Application deployment is managed using Helm.

Implemented:

Custom Helm Chart
values.yaml configuration
Helm Install
Helm Upgrade
Helm Rollback
Namespace deployment
Database

Database:

PostgreSQL 16

Implemented:

Entity Framework Core Migrations
Automatic Migration Execution
Startup Retry Logic
Persistent Storage using PVC
Health Checks

Implemented:

Readiness Probe
Liveness Probe

Endpoint:

/health
Kubernetes Objects Used
Namespace
Deployment
Service
Ingress
ConfigMap
Secret
PersistentVolume
PersistentVolumeClaim
HorizontalPodAutoscaler
ReplicaSet
Pod
Challenges Solved

During development several production-like issues were resolved:

PostgreSQL startup timing
Database migration execution
Missing Users table
Docker networking
Kubernetes DNS resolution
CrashLoopBackOff
Health Check failures
Ingress configuration
Image update issues
Rolling deployments
PostgreSQL persistent storage
Commands Frequently Used
Docker
docker compose up --build
docker compose down
docker compose ps
docker compose logs
Entity Framework
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet ef migrations list
Kubernetes
kubectl get pods
kubectl get deployments
kubectl get services
kubectl describe pod
kubectl logs
kubectl apply -f
kubectl delete -f
kubectl port-forward
Helm
helm install
helm upgrade
helm rollback
helm uninstall
helm list
helm history
Future Improvements
GitHub Actions CI/CD
Docker Hub Integration
Azure Kubernetes Service (AKS)
Azure Container Registry (ACR)
Azure PostgreSQL
Azure Key Vault
Terraform Infrastructure as Code
Prometheus Monitoring
Grafana Dashboards
Loki / ELK Logging
HTTPS using Cert-Manager
Learning Outcomes

This project provided hands-on experience with:

Building scalable REST APIs
Docker containerization
Database migrations
Kubernetes deployments
Helm package management
Production-style application deployment
Infrastructure troubleshooting
Cloud-ready application architecture
Status

Current Status:

Local Development ✔
Docker ✔
Docker Compose ✔
PostgreSQL ✔
Kubernetes ✔
Helm ✔
Production-ready Local Environment ✔

Next Phase:

Cloud Deployment (Azure Kubernetes Service) and CI/CD Automation.
