# UCXComponentTest

UCXComponentTest is an automation test suite built to validate clinical workflows for the UCX application using Playwright with NUnit in C#. This framework supports component-level, UI, and API testing across microservices.

# Features
- Playwright + NUnit for browser-based automation
- API helper utilities for validating service interactions
- Environment-specific config support
- Page Object Model for scalable UI test architecture
- Easy integration into CI/CD pipelines

# Project Structure
<pre>
UCXComponentTest/
├── Environments/
│   ├── in1.json
│   └── qa.json
├── Pages/
│   └── UCXLoginPage.cs
├── Tests/
│   └── UCXLoginTest.cs
├── Utils/
│   ├── ApiHelper.cs
│   ├── PlaywrightDriver.cs
│   └── TestConfigReader.cs
</pre>

# Getting Started
 **Prerequisites:**
 
- .NET SDK 6 or above
- Node.js (for Playwright CLI)
- Playwright for .NET: playwright install

# Running the Tests
dotnet test

# CI/CD Integration
Integrate with Azure DevOps to run tests on every commit or deployment.

⸻

# Coming Soon
-	Kafka mock integration
-	Docker-based local test environment
-	Event-driven test validation support
