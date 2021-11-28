
USE PRESTAMOS

/*
CREATE TABLE PRESTAMISTAS(
NO_PRESTAMISTA INT IDENTITY (1,1) PRIMARY KEY,
IDTRABAJADOR INT,
IDPRESTAMO INT, 
NOMBRE_PRESTAMISTA NVARCHAR(60),
EDAD_PRESTAMISTAS INT,
AREA_DE_OPERACION NVARCHAR(50)

--RELACIONES 
CONSTRAINT RELACION_A_TRABAJADORES FOREIGN KEY (IDTRABAJADOR) REFERENCES TRABAJADORES (IDTRABAJADOR),
CONSTRAINT RELACION_A_PRESTAMOS FOREIGN KEY (IDPRESTAMO) REFERENCES PRESTAMOS(IDPRESTAMO)
)
GO
*/


----------------------------------- PROCEDIMIENTOS ALMACENADOS ---------------------- 
-----LISTAR CATEGORIAS 
create proc Listar_Trabajadores
as

select *from EMPLEADOS order by NOMBRE_EMPLEADO asc
go

create proc Listar_Roles --completo
as
select *from ROLES order by NOMBRE_ROL asc
go
create proc Listar_Puestos--completo
as
select *from PUESTOS order by NOMBRE_PUESTOS asc
go
-----LISTAR PRESTAMOS
create proc Listar_Prestamos--cómpleto
as
select *from PRESTAMO order by MONTO_PRESTAMO,FECHA_PRESTAMO asc
go

----- TRABAJADOR crud  ya esta completo
create proc Agregar_Trabajador
@nombre_empleado  varchar(70),
@nombre_usuario varchar(50),
@sueldo_empleado int,
@clave_empleado varchar(50),
@domicilio_trabajador varchar(60),
@fecha_nacimiento date,
@telefono_trabajador varchar(60),
@Id_Rol int ,
@Id_Puesto int
as
insert into EMPLEADOS(NOMBRE_EMPLEADO,NOMBRE_USUARIO,SUELDO_EMPLEADO,
CLAVE_EMPLEADO,DOMICILIO_EMPLEADO,FECHA_NACIMIENTO,TELEFONO_EMPLEADO,ID_ROL,NO_PUESTO)
values (@nombre_empleado,@nombre_usuario,@sueldo_empleado,@clave_empleado,@domicilio_trabajador,
@fecha_nacimiento,@telefono_trabajador,@Id_Rol,@Id_Puesto)
go

create proc Actualizar_Trabajador --aun no funciona por que hay que pasarle todos los parametros a actualizar de la tabla empleado y estan incompletos aqui.
@idtrabajador int,
@nombre_trabajador  varchar(70),
@puesto_trabajador varchar(50),
@clave_trabajador varchar(50),
@domicilio_trabajador varchar(60),
@edad_trabajador int,
@telefono_trabajador varchar(60),
@Id_Rol int
as
update EMPLEADOS set NOMBRE_TRABAJADOR =@nombre_trabajador,
PUESTO_TRABAJADOR=@puesto_trabajador,CLAVE_TRABAJADOR=@clave_trabajador,DOMICILIO_TRABAJADOR=@domicilio_trabajador,
EDAD_TRABAJADOR=@edad_trabajador,TELEFONO_TRABAJADOR=@telefono_trabajador,ID_ROL=@Id_Rol WHERE EMPLEADOS=@idtrabajador
go




/*
create proc listar_bitacora_movimientos
as
select IDPROD AS ID, CATEGORIAS.CATEGORIA,MARCAS.MARCA,DESCRIPCION,PRECIO
 from PRODUCTOS 
INNER JOIN CATEGORIAS ON PRODUCTOS.IDCATEGORIA=CATEGORIAS.IDCATEG
INNER JOIN MARCAS ON PRODUCTOS.IDMARCA=MARCAS.IDMARCA
go
*/