CREATE PROCEDURE OrdersPrediction
AS
BEGIN
	WITH DiferenciasDias AS (
		SELECT custid,
			   DATEDIFF(DAY, orderdate, LEAD(orderdate) OVER (PARTITION BY custid ORDER BY orderdate)) AS DiasSiguientes
		FROM SALES.ORDERS
	),
	PromedioDias AS (
		SELECT custid,
			   AVG(DiasSiguientes) AS PromedioDias
		FROM DiferenciasDias
	   WHERE DiasSiguientes IS NOT NULL
		GROUP BY custid
	),
	UltimaOrden AS (
		SELECT custid, MAX(orderdate) AS FechaUltimaOrden
		FROM SALES.ORDERS
		GROUP BY custid

	)
	SELECT U.custid,
		   C.companyname,
		   U.FechaUltimaOrden,
		   P.PromedioDias,
		   DATEADD(DAY, P.PromedioDias, U.FechaUltimaOrden) AS FechaPosibleSiguienteOrden

	FROM UltimaOrden U
	JOIN PromedioDias P ON U.custid = P.custid
	INNER JOIN SALES.CUSTOMERS C ON C.custid = U.custid
	ORDER BY C.companyname
END