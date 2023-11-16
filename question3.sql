SELECT p.ProductName, c.CategoryName
FROM products p
LEFT JOIN productcategories pc ON p.ProductID = pc.ProductID
LEFT JOIN categories c ON pc.CategoryID = c.CategoryID
ORDER BY p.ProductName;
