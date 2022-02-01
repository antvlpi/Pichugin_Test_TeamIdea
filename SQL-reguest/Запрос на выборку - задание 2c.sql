SELECT MostExpensive.Company_Name, ph2.phoneModel AS Most_Expensive_Model, ph2.price
FROM (SELECT c1.companyName AS Company_Name, MAX(ph1.price) AS Max_Price
	  FROM Company AS c1
	  INNER JOIN Phone AS ph1
	  ON c1.companyId = ph1.companyId
	  GROUP BY  c1.companyName) AS MostExpensive
INNER JOIN Phone AS ph2
ON ph2.price = MostExpensive.Max_Price
ORDER BY MostExpensive.Company_Name;