Entity Framework
First time setup
Clone this repository to another system
 Install EF CLI Tool Globally
dotnet tool install --global dotnet-ef
  Verify Installation
dotnet ef
You should see a list of EF Core CLI commands.
Install Required NuGet Packages
Ensure the following packages are installed:
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
Alternatively, confirm they are present in the .csproj file:
<ItemGroup>
   <PackageReference Include="Microsoft.EntityFrameworkCore" Version="7.0.0" />
   <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="7.0.0" />
   <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="7.0.0" />
 </ItemGroup>
Then restore the packages:
dotnet restore

Database Setup
Create Initial Migration
dotnet ef migrations add InitialCreate
Apply Migration to Create Database
dotnet ef database update

Configuration
Update the 'appsettings.json' file with your connection string:
"ConnectionStrings": {
   "DefaultConnection": "Server=your-server;Database=your-db;Trusted_Connection=True;"
 }

Run the Application(Backend)
dotnet run
Run the Application(Frontend)
npm start