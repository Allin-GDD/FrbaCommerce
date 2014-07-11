CREATE trigger Trig_Insert_Publicacion_Rubro ON Publicacion
AFTER INSERT
AS
BEGIN
DECLARE @id_Publicacion numeric(18,0), @id_Rubro numeric(18,0)
SET @id_Publicacion = (Select Codigo From inserted)

INSERT INTO Publicacion_Rubro(id_Publicacion,id_Rubro)
values(@id_Publicacion,@id_Rubro)
END