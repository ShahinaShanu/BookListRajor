# BookListRajor: in One Razor Page, added 2 different functionalty call from 2 another Razor Page.
and also Used the API call and fasionable styles.

Crud Operations are performed by this .net core application using Entity framework [BookListRajor].
Note: before making the project make sure the 4 Nuget packages installed in your visual studio: Go to Tools/Nuget Package Manager>Nuget Pkg for Solution>browse:
1. Microsoft.AspNetCore.MVC.RazorRuntimeCompilation  then in startup.cs file add AddRazorRunTimeCompilation() method.
2. Microsoft.EntityFrameworkCore
3. Microsoft.EntityFrameworkCore.SqlServer
4. Microsoft.EntityFrameworkCore.Tools
after installation of that 4 packages you need to create connection string in AppSettings.json file in project.
Then Create Model for creating database and table.
open Package manager Consoe and type: Add-Migration [MeaningfulUserDefinedName] then Enter
also type another Cmd : Update-Database and press Enter
successfully created db and table.
