CREATE PROCEDURE EmployeeDropDown
AS
BEGIN
		SELECT empid, concat(lastname , '	', firstname ) as [name] FROM [HR].[Employees]
END


CREATE PROCEDURE ShipperDropDown
AS
BEGIN
		SELECT shipperid, companyname FROM [Sales].[Shippers]
END


CREATE PROCEDURE ProductDropDown
AS
BEGIN
		SELECT productid , productname FROM [Production].[Products]
END