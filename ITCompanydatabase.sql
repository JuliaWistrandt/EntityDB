CREATE DATABASE ITCompany;

GO

CREATE TABLE Company (
	CompanyID INT PRIMARY KEY IDENTITY(1,1),
	CompanyName NVARCHAR(50)
);

INSERT INTO Company VALUES 
('IT-Company');


CREATE TABLE Clients (
	clientID INT PRIMARY KEY IDENTITY(1,1),
	clientName NVARCHAR(50)
);


INSERT INTO Clients VALUES
('Client 1'),
('Client 2'),
('Client 3');


CREATE TABLE Tools (
	toolID INT PRIMARY KEY IDENTITY(1,1),
	toolName NVARCHAR(50)
);


INSERT INTO Tools VALUES
('MS SQL Server'),
('Visual Studio'),
('GitHub'),
('Azure');


CREATE TABLE Departments (
	departmentID INT PRIMARY KEY IDENTITY(1,1),
	departmantName NVARCHAR(50),
);


INSERT INTO Departments VALUES
('Business technology unit'),
('Integrated technology services'),
('ACTS');


CREATE TABLE Employee (
	employeeID INT PRIMARY KEY IDENTITY(1,1),
	employeeName NVARCHAR(50),
	departmentID INT,
	Salary DECIMAL(10,2),
	HireDate DATE,
	SuccessProjects INT,
	FOREIGN KEY (departmentID) REFERENCES Departments(departmentID)
);

INSERT INTO Employee VALUES
('August Henson', 1, 1000.00, '2020-01-01', 2),
('Tyler Patton', 1, 1500.00, '2020-02-01', 4),
('Geraldine Ramos', 2, 2000.00, '2020-03-01', 1),
('Odette Dawson', 2, 2500.00, '2020-03-01', 3),
('Leonard Mathews', 3, 3000.00, '2020-05-01', 5);


CREATE TABLE Projects (
	projectID INT PRIMARY KEY IDENTITY(1,1),
	projectName NVARCHAR(50),
	projectCost DECIMAL(10,2),
	departmentID INT,
	clienID INT,
	startDate DATE,
	endDate DATE
	FOREIGN KEY (departmentID) REFERENCES Departments(departmentID),
	FOREIGN KEY (clienID) REFERENCES Clients(clientID),
);

INSERT INTO Projects VALUES
('Project1', 10000.00, 1, 1, '2022-01-01', '2022-06-30'),
('Project2', 15000.00, 1, 2, '2022-03-01', '2022-09-30'),
('Project3', 20000.00, 2, 1, '2022-02-01', '2022-07-31'),
('Project4', 25000.00, 3, 3, '2022-04-01', '2022-12-31'),
('Project5', 30000.00, 2, 2, '2022-01-01', '2022-10-31'),
('Project6', 35000.00, 3, 3, '2022-05-01', '2022-11-30');



