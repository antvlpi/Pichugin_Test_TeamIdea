CREATE DATABASE PhoneCompanyDatabase;

USE PhoneCompanyDatabase;

CREATE TABLE Company
(
	companyId INT IDENTITY(1,1) PRIMARY KEY,  
	companyName varchar(150) NOT NULL,
	companyCountry varchar(70) NOT NULL
);

CREATE TABLE Phone
(
	phoneId INT IDENTITY(1,1) PRIMARY KEY,  
	phoneModel varchar(100) NOT NULL,
	price INT NOT NULL,
	companyId INT NOT NULL,
	CONSTRAINT FK_Company_ID FOREIGN KEY (companyId) REFERENCES Company(companyId)
);