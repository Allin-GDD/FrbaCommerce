  ---tengo que tener pregunta, respeuesta, fecha de respuesta, id publicacion, id client,usuario
  CREATE TABLE PreguntasYRespuestas(
  Id numeric(18,0) identity(1,1) PRIMARY KEY,
  UsuarioPublicador nvarchar(100) NOT NULL,
  UsuarioPregunta nvarchar(100) NOT NULL,
  Id_Publicacion numeric(18,0) NOT NULL,
  Pregunta nvarchar(255),
  Respuesta nvarchar(255),
  FechaRespuesta datetime)
  
