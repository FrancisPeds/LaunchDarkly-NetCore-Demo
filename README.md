# 🚀 LaunchDarkly .NET Core Demo

This is a minimal .NET Web API project demonstrating how to use **LaunchDarkly feature flags** in a clean, enterprise-style architecture.

The goal of this project is to show how to:
- Integrate LaunchDarkly into a .NET Core application
- Separate feature flag logic using a dedicated service (`IFeatureToggleService`)
- Build modular, testable components that mimic real-world patterns

---

## 🛠️ Technologies Used

- ASP.NET Core 6 Web API
- LaunchDarkly Server SDK
- Dependency Injection
- REST API with JSON response
- Clean folder structure

---

## 📦 Project Structure

```
Controllers/         --> API endpoints
Services/            --> Business logic & LaunchDarkly wrapper
LaunchDarkly/        --> Client setup and configuration
Program.cs           --> DI setup and app startup
appsettings.json     --> SDK key config
```

---

## 🧪 What It Does

The API has a single endpoint:

```
GET /api/show-message
```

- If the `show-new-message` feature flag is **OFF** → returns `"👋 Hello, world!"`
- If the flag is **ON** → returns `"🚀 Welcome to the new feature!"`

---

## ⚙️ Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/FrancisPeds/LaunchDarkly-NetCore-Demo.git
cd LaunchDarkly-NetCore-Demo
```

### 2. Add Your LaunchDarkly SDK Key

Update `appsettings.json`:

```json
"LaunchDarkly": {
  "SdkKey": "your-sdk-key-here"
}
```

> Make sure you have a flag named `show-new-message` in your LaunchDarkly dashboard.

### 3. Run the App

```bash
dotnet run
```

Then open your browser or Postman:

```
GET http://localhost:5000/api/message
```

---

## 📄 Notes

- This project is for **demo purposes** only. It does not contain production-level error handling or external logging.
- Feature flags are checked using a lightweight `IFeatureToggleService` abstraction, making it easy to mock/test in larger systems.

---

## 🧠 Future Enhancements (Optional)

- Add unit tests for services
- Support user context switching
- Add more endpoints using other flag types (multivariate, % rollout)

---

## 🧾 License

This project is licensed under the MIT License.
