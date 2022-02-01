SELECT companyName, c1.Avarge_Cost
FROM (SELECT c2.companyName, AVG(price) AS Avarge_Cost, MAX(AVG(price))OVER() AS Max_Avarge_Cost
		FROM Company AS c2
		INNER JOIN Phone AS ph2
		ON c2.companyId = ph2.companyId
		GROUP BY c2.companyName) AS c1
WHERE c1.Avarge_Cost = c1.Max_Avarge_Cost
