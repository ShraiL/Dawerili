# Dawerili
Step 1: Install Docker
Since you've already installed Docker, I will assume Docker is up and running. If you haven't done so already, make sure to check that Docker Desktop is installed and running.

Open Docker Desktop, and make sure it’s working properly.

Step 2: Set Up SQL Server in Docker
Open PowerShell or Command Prompt:
You can run Docker commands directly from PowerShell (Windows) or Terminal (macOS/Linux).

Pull the SQL Server Image:
Run this command to pull the SQL Server image from Docker Hub. This will download the official Microsoft SQL Server image:

bash
Copy
docker pull mcr.microsoft.com/mssql/server
This command may take some time, depending on your internet connection.

Run SQL Server in Docker:
Now, run SQL Server in a Docker container. Execute the following command:

bash
Copy
docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=YourPassword123' -p 1433:1433 --name sql_server_container -d mcr.microsoft.com/mssql/server
-e 'ACCEPT_EULA=Y': Accepts the SQL Server license agreement.

-e 'MSSQL_SA_PASSWORD=YourPassword123': Set the sa (System Administrator) password. Replace YourPassword123 with your own password.

-p 1433:1433: Maps port 1433 of the container (the default SQL Server port) to port 1433 on your local machine.

--name sql_server_container: Gives the container a name (sql_server_container in this case).

-d: Runs the container in detached mode (background).

Verify SQL Server is Running:
After running the above command, check that SQL Server is running by using the command:

bash
Copy
docker ps
This should display a list of running containers. You should see sql_server_container listed.

If you need logs to check if there are issues, use:

bash
Copy
docker logs sql_server_container
Step 3: Connect to SQL Server (Using SSMS or Azure Data Studio)
Download and Install SQL Server Management Studio (SSMS) or Azure Data Studio:

Download SSMS

Download Azure Data Studio

Connect to SQL Server:
Open SSMS or Azure Data Studio and use the following connection details:

Server Name: localhost,1433

Username: sa

Password: YourPassword123 (the password you set earlier when running the Docker container).

Verify Connection:
Once connected, you should see the SQL Server instance. From here, you can manage your databases.

Step 4: Create the Database and Table
Now that you’ve connected to SQL Server, let’s create the database and table that your application will use.

Create a Database:
Run the following SQL script to create the UG database:

sql
Copy
CREATE DATABASE UG;
GO
Switch to the UG Database:
After creating the database, we need to switch to it:

sql
Copy
USE UG;
GO
Create the People Table:
Now, create a table to store user information. Run this SQL script to create the People table:

sql
Copy
CREATE TABLE People (
    Id INT IDENTITY PRIMARY KEY,
    Firstname NVARCHAR(30) NOT NULL,
    Lastname NVARCHAR(30) NOT NULL
);
GO
Id: INT IDENTITY means this column will auto-increment.

Firstname: NVARCHAR(30) means the first name can store up to 30 characters.

Lastname: Same as Firstname, storing the last name.
