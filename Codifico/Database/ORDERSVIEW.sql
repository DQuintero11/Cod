CREATE PROCEDURE OrdersView
    @custid INT
AS
BEGIN
    -- Consulta que filtra por el id recibido como parámetro
    SELECT orderid, requireddate, shippeddate, shipname, shipaddress, shipcity, custid
    FROM SALES.Orders
    WHERE custid = @custid
END;


select distinct custid, count(*)
from SALES.Orders
group by custid
