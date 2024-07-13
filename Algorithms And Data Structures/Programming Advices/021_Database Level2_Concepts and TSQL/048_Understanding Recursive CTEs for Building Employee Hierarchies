



WITH EmployeeTreeHierarchy AS (
    -- Anchor member: This selects the root of the hierarchy (CEO in this case) and starts at Level 0
    SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL

    UNION ALL

    -- Recursive member: This part of the CTE builds the hierarchy and increments the Level by 1
    SELECT e.EmployeeID, e.ManagerID, e.Name, 
	CAST(ETH.Hierarchy + ' -> ' + e.Name AS VARCHAR(MAX)), 
	ETH.Level + 1 AS Level
    FROM Employees7 e
    INNER JOIN EmployeeTreeHierarchy ETH ON e.ManagerID = ETH.EmployeeID
)
-- This SELECT statement retrieves the hierarchical data with Level
SELECT * FROM EmployeeTreeHierarchy
ORDER BY Hierarchy;

