# **Entity Framework Core Setup Guide**

This guide will help you set up Entity Framework Core for the first time.

---

## ** First-Time Setup**

### **1. Clone the Repository**

```bash
git clone https://github.com/your-username/your-repo.git
cd your-repo
```

---

### **2. Install EF CLI Tool Globally**

```bash
dotnet tool install --global dotnet-ef
```

---

### **3. Verify Installation**

```bash
dotnet ef

```

_You should see a list of EF Core CLI commands._
Ensure the following packages are installed:

---

### **4. Install Required NuGet Packages**

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

---

_Alternatively, confirm the packages are in your `.csproj` file:_

```xml
<ItemGroup>
   <PackageReference Include="Microsoft.EntityFrameworkCore" Version="7.0.0" />
   <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="7.0.0" />
   <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="7.0.0" />
 </ItemGroup>
Then restore the packages:
  <PackageReference Include="Microsoft.EntityFrameworkCore" Version="7.0.0" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="7.0.0" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="7.0.0" />
</ItemGroup>
```

---

### **5. Restore Packages**

```bash
dotnet restore
```

---

## ** Database Setup**

### **1. Create Initial Migration**
Apply Migration to Create Database
```bash
dotnet ef migrations add InitialCreate

```

---

### **2. Apply Migration to Create Database**

```bash
dotnet ef database update
```

---

## ** Configuration**

Update the `appsettings.json` file with your connection string:

Configuration
Update the 'appsettings.json' file with your connection string:
```json
"ConnectionStrings": {
   "DefaultConnection": "Server=your-server;Database=your-db;Trusted_Connection=True;"
 }
```

Run the Application(Backend)
_Replace_ `"your-server"` _and_ `"your-db"` _with your actual server and database names._

---

## ** Running the Application**

### **Run the Backend**

```bash
dotnet run
Run the Application(Frontend)
npm start
```

---

### **Run the Frontend**

```bash
npm install
npm start
```

---

## ** You're All Set!**

_You now have a working project with Entity Framework Core set up and ready to go._  
