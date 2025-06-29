USE products_databse;
GO

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);

INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Laptop', 'Electronics', 1000.00),
(2, 'TV', 'Electronics', 800.00),
(3, 'Phone', 'Electronics', 800.00),
(4, 'Tablet', 'Electronics', 600.00),
(5, 'Sofa', 'Furniture', 1200.00),
(6, 'Chair', 'Furniture', 300.00),
(7, 'Bed', 'Furniture', 1200.00),
(8, 'Table', 'Furniture', 800.00);

SELECT * FROM Products;

WITH RankedProducts AS (
    SELECT *,
        RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum
    FROM Products
)
SELECT * 
FROM RankedProducts
WHERE RankNum <= 3;

