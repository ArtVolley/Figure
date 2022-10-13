# Figure

Задание на SQL

SELECT Products.Name, Categories.Name 
FROM Products 
LEFT OUTER JOIN Categories ON Products.Id = Categories.ProductId
