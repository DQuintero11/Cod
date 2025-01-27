CREATE PROCEDURE OrdersView
    @custid INT
AS
BEGIN
    SELECT orderid, requireddate, shippeddate, shipname, shipaddress, shipcity, custid
    FROM SALES.Orders
    WHERE custid = @custid
END;


