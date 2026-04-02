# Car Dealership Project - IPG201

----------------------------------------
|THIS PROJECT CAN ONLY BE RUN ON WINDOWS|
----------------------------------------
## Project Description

Educational project for **IPG201** course at **Syrian Virtual University (SVU)**.

This project teaches students:
- Legacy Software Maintenance
- Working with outdated/unsupported technologies
- Managing projects without adequate documentation
- Windows Forms development with C# and .NET Framework

Features:
- Manage cars for sale/rent
- User accounts (Admin/User roles)
- Booking and purchasing operations

---

## Technologies Used

| Technology | Version | Status |
|------------|---------|--------|
| .NET Framework | 4.5.2 | ⚠️ Legacy |
| Windows Forms | - | ⚠️ Legacy |
| Entity Framework | 6.5.0 | ⚠️ Legacy |
| SQL Server LocalDB 2012 | - | ⚠️ Legacy |

---

## Installation Steps

### 1. Install .NET Framework 4.5.2 Developer Pack
Download: https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net452-developer-pack-offline-installer

### 2. Install SQL Server LocalDB 2012
Download: https://www.microsoft.com/en-us/download/details.aspx?id=50003
or google search: sql "localdb" 2012 
```cmd
msiexec /i SqlLocalDB2012X64.msi /quiet
```

### 3. Install git
https://git-scm.com/install/windows

### 4. Install PNU Font
Right-click `IPG_201_AIO\PNU-Medium.ttf` → "Install"

### 5. Restore NuGet Packages (First Run Only)
The `run.bat` script will automatically download and restore the EntityFramework package on first run.

**Manual restore (if automatic fails):**
```cmd
cd c:\IPG_201_carDealership
powershell -Command "Invoke-WebRequest -Uri 'https://www.nuget.org/api/v2/package/EntityFramework/6.5.0' -OutFile 'packages\EntityFramework.6.5.0.zip'"
powershell -Command "Expand-Archive -Path 'packages\EntityFramework.6.5.0.zip' -DestinationPath 'packages\EntityFramework.6.5.0' -Force"
```


---

## Quick Start

```cmd
cd c:/
git clone https://github.com/omar-srakbi/IPG_201_carDealership.git
cd IPG_201_carDealership
run.bat
```

## How to Run

### Method 1: Visual Studio (Easiest)
1. Open Visual Studio 2013 or later
2. Open `IPG_201_AIO.sln`
3. Press `F5`

### Method 2: Command Prompt
```cmd
cd C:\IPG_201_carDealership
run.bat
```

### Method 3: Direct Build
```cmd
cd C:\IPG_201_carDealership\IPG_201_AIO
C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe carDealershipProject.csproj /p:Configuration=Debug
start bin\Debug\carDealershipProject.exe
```

---

## Troubleshooting

| Error | Solution |
|-------|----------|
| .NETFramework reference assemblies not found | Install .NET Framework 4.5.2 Developer Pack |
| LocalDB instance not found | Install SQL Server LocalDB 2012 |
| Font 'PNU-Medium' not found | Install PNU-Medium.ttf font |
| Database connection failed | Check files exist in `datasets\` folder |
| Could not locate assembly "EntityFramework" | Run `run.bat` to auto-restore packages, or see Manual Restore in Installation Steps |

---

## Project Structure

```
C:\IPG_201_carDealership/
├── README.md
├── run.bat
├── IPG_201_AIO.sln
├── IPG_201_AIO/
│   ├── carDealershipProject.csproj
│   ├── Program.cs
│   ├── loginForm.cs
│   ├── signupForm.cs
│   ├── PNU-Medium.ttf
│   ├── datasets/
│   │   └── carDealershipDB.mdf
│   └── forms/
│       ├── admin/
│       └── user/
└── packages/
```

---

## User Roles

| Role | Permissions |
|------|-------------|
| Admin | Add/edit/delete cars, manage users |
| User | Browse cars, book, purchase |

---

## Notes for Students

This project uses legacy technologies intentionally for educational purposes. Learn to:
- Work with undocumented code
- Maintain old systems
- Understand EF6 (not EF Core)
- Use Windows Forms (still used in enterprise)

---

**Last Updated:** 2026-04-02

<div align="center">

**IPG201 - Syrian Virtual University**

```cmd
cd C:\IPG_201_carDealership && run.bat
```

</div>
