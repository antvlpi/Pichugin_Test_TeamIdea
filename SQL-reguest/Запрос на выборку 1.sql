SELECT c.companyName AS Company_Name,
	COALESCE(SUM(ph.price), 0) AS Phones_Sum, /* Если NULL тогда сумма 0 */
	COUNT(CASE WHEN ph.price IS NOT NULL THEN 0 END) AS Phones_Total /* Вместо 1 где нет моделей в продаже выводим 0*/
FROM Company AS c
LEFT JOIN Phone AS ph
ON c.companyId = ph.companyId
GROUP BY c.companyName
ORDER BY CASE 
	WHEN SUM(price) IS NULL THEN 1
	ELSE 0
END;
