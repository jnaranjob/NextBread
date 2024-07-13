CREATE SEQUENCE seq_CodigoVenta
    START WITH 1
    INCREMENT BY 1;
GO

CREATE TRIGGER trg_GenerateCodigoVenta
ON CajaRegistradora
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @CodigoVenta NVARCHAR(20);
    DECLARE @currentDateTime NVARCHAR(14);
    DECLARE @nextValue INT;
    -- Inserta la fecha en este formato -- 'YYYYMMDDHHMMSS'
    SET @currentDateTime = CONVERT(VARCHAR, GETDATE(), 112) + 
                           RIGHT('0' + CONVERT(VARCHAR, DATEPART(HOUR, GETDATE())), 2) + 
                           RIGHT('0' + CONVERT(VARCHAR, DATEPART(MINUTE, GETDATE())), 2) + 
                           RIGHT('0' + CONVERT(VARCHAR, DATEPART(SECOND, GETDATE())), 2);
    -- Obteniene valor de la secuencia, el cual se debe de crear con la base
    SET @nextValue = NEXT VALUE FOR seq_CodigoVenta;
    SET @CodigoVenta = @currentDateTime + RIGHT('0000' + CONVERT(VARCHAR, @nextValue), 4);

    -- Inserta el registro con el CodigoVenta generado
    INSERT INTO CajaRegistradora (CodigoVenta, IdTipoPago, CompraFinal, IdUsuario)
    SELECT @CodigoVenta, IdTipoPago, CompraFinal, IdUsuario
    FROM inserted;
END;