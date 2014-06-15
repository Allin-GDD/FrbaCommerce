create procedure actualizarStock

@Codigo numeric (18,0),
@Stock numeric (18,0)
AS 
BEGIN
UPDATE Publicacion
SET Stock = (Stock - @Stock)
WHERE Codigo = @Codigo 
END