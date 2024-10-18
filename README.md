# ClaimsPortal
Michel Musangu
ST10079108
PROG6212 POE PART 2
Github Link: https://github.com/ST10079108/ProgPart2-ST10079108-MichelMusangu



Instructions:

1. Download the zipped project from github and open the project from Visual Studio.
2. Check nuget packages for Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.SqlServer, and Microsoft.EntityFrameworkCore.Tools
3. Delete Migrations folder.
4. Click tools, Nuget package manager, Package manager console.
5. run Add-Migrations "Migration-1"
6. run Update-Database
7. open sql server object explorer, databases, right click ClaimsDb, New Query.
8. enter this data and run the query:

INSERT INTO [dbo].[Claims] ([Name], [Description], [HoursWorked], [Rate], [Total], [Status])
VALUES 
('Lionel Messi', 'Football skills training', 20, 100, 2000, 'Pending'),
('Cristiano Ronaldo', 'Endorsement event', 15, 120, 1800, 'Pending'),
('Neymar Jr', 'Charity football match', 10, 150, 1500, 'Pending');

9. refresh Claims table
10. run the application

If for some reason the application wont run, please try using http instead of https.




Reference List:

Reference 1
W3SChools. (2023) How to - file upload button. Available at: https://www.w3schools.com/howto/howto_html_file_upload_button.asp (Accessed: 17 October 2024).

Reference 2
stackOverflow. (2017) HTML file input window limit size?. Available at: stackoverflow.com (Accessed: 18 October 2024).

Reference 3
Youtube. (2024) ASP.NET Core MVC CRUD Operations using .NET 8 and Entity Framework Core - MVC For Beginners Tutorial. Available at: https://www.youtube.com/watch?v=_uSw8sh7xKs (Accessed: 13 October 2024).