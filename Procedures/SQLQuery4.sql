 
   select *from Compra
   select *from Publicacion
   select *from Usuario where Usuario = 'ananquel_Sepúlveda@gmail.com'
   select *from Clientes where Mail = 'ananquel_Sepúlveda@gmail.com' id 12
    
  
  
  Select AVG(C.Calificacion_Cant_Estrellas)  from (Publicacion p 
  INNER JOIN Compra C ON c.Codigo_Pub = p.Codigo)
  WHERE (p.Id = 12 AND p.Publicador = 'C' AND
    year(C.Fecha) = 2013 AND (MONTH(C.Fecha) = 4 OR MONTH(c.Fecha) = 5 OR MONTH(C.Fecha) = 6)
) 
    
    
Select * from Compra c INNER JOIN 


    exec listadoMayoresSinCalificaciones 2013, 1
    
    
     Select * from Usuario Where Usuario = 'odette_Morales@gmail.com'
     select * from Compra where Calificacion_Cant_Estrellas = 2
     AND Id_Cliente = 4
     AND YEAR(Fecha) = 2013 AND( MONTH(Fecha) = 1 OR MONTH(Fecha) = 2 OR MONTH(Fecha) = 3)


    
    exec listadoMayoresFacturacion 2013, 1
  
  Select * from Usuario Where Usuario = 'Razon Social Nº:34@gmail.com'
  
  select SUM(F.Total) FROM (Publicacion P 
  INNER JOIN Factura F ON p.Codigo = f.Pub_Cod)
  WHERE(p.Id = 27 AND P.Publicador = 'E' AND
  year(F.Fecha) = 2013 AND (MONTH(F.Fecha) = 1 OR MONTH(F.Fecha) = 2 OR MONTH(F.Fecha) = 3)
) 
  
  
  select *from Factura
  Select AVG(C.Calificacion_Cant_Estrellas)  from (Publicacion p 
  INNER JOIN Compra C ON c.Codigo_Pub = p.Codigo)
  WHERE (p.Id = 12 AND p.Publicador = 'C' AND
    year(C.Fecha) = 2013 AND (MONTH(C.Fecha) = 4 OR MONTH(c.Fecha) = 5 OR MONTH(C.Fecha) = 6)
) 
    
    
    
(   
select * from Publicacion p where 
p.Id = 12 AND p.Publicador = 'C' AND
    year(p.Fecha) = 2013 AND (MONTH(p.Fecha) = 4 OR MONTH(p.Fecha) = 5 OR MONTH(p.Fecha) = 6)) T
    On t.Codigo = c.Codigo_Pu