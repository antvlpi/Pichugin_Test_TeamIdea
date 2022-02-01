SELECT COUNT(*) Count_from_China FROM Company AS c
LEFT JOIN Phone AS ph
ON c.companyId = ph.companyId
WHERE c.companyCountry = 'Китай';
