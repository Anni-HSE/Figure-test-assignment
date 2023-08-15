SELECT [ProductId], COUNT(ProductId) as Times
FROM [Sales] sal 
	INNER JOIN (
		SELECT [CustomerId], MIN(DateCreated) as BecomeBuyerDate 
		FROM [Sales] GROUP BY CustomerId
	) as cus 
	ON sal.CustomerId = cus.CustomerId AND 
	   sal.DateCreated = cus.BecomeBuyerDate
GROUP BY ProductId