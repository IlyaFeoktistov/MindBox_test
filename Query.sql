USE TestBase

SELECT Products.[Name], Categories.[Name]
FROM ProductsCategories 
LEFT JOIN Products ON ProductsCategories.ProductId = Products.Id
LEFT JOIN Categories ON ProductsCategories.CategoryId = Categories.Id