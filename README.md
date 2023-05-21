Project Name :- Simple Web App


1-This is a simple web application built using ASP.NET Core, Dapper, and MSSQL Server. The application allows users to manage a list of products, including adding, editing, and deleting products.
2-Before running the application, ensure that you have the following installed on your machine:

.NET Core SDK (version 6.0 or later)
MSSQL Server

3-To get started with the application, follow these steps:
Clone this repository to your local machine or download the source code.
Open the solution file (WebApplication.sln) in Visual Studio or your preferred code editor.

4-Database Setup:-
Open the appsettings.json file located in the project's root folder.
Modify the "DefaultConnection" connection string to match your MSSQL Server configuration.

5-Ensure that your MSSQL Server instance is running.
Open the Package Manager Console in Visual Studio (Tools > NuGet Package Manager > Package Manager Console).
Run the following command to apply the database migrations:

6-Running the Application
Build the solution to restore NuGet packages and compile the application.
Press F5 or use the "Start Debugging" button to run the application.
The application will launch in your default web browser.

7-Features
The web application includes the following features:

1:Homepage: Displays a list of products and their prices.
2:Add Product: Allows users to add a new product and its price.
3:Edit Product: Enables users to update the details of an existing product.
4:Delete Product: Allows users to delete an existing product.

8-Technologies Used
The application is built using the following technologies and frameworks:

ASP.NET Core
Dapper (for database access)
MSSQL Server
HTML, CSS, and JavaScript/jQuery

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.
