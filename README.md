# **Dependency Injection Lifetime Patterns**  

This guide explains the **Dependency Injection (DI)** patterns in ASP.NET Core, focusing on the three primary lifetime models: **AddTransient**, **AddScoped**, and **AddSingleton**.

---

## **1. AddTransient - Transient**

### **Definition:**  
- A **new instance** is created every time the dependency is resolved.  
- **Scope:** A new instance is returned each time it is used.

### **Typical Use Cases:**  
- **Lightweight** and **stateless** services.  
- For example, email sending, validation services, or utilities.

### **Code Example:**  
```csharp
services.AddTransient<IMyService, MyService>();
