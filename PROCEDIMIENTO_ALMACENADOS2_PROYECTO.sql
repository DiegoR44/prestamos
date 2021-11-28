USE PRESTAMOS
GO
--PROCEDIMIENTO ALAMCENADO PARA LOGIN--

CREATE PROCEDURE LOGIN(
@NOMBRE_USUARIO VARCHAR(60),
@CLAVE_EMPLEADO VARCHAR(60),
@ID_EMPLEADO   INT OUTPUT
)
AS

BEGIN 
	SET @ID_EMPLEADO=0
	IF EXISTS(
		SELECT  * FROM EMPLEADOS
		WHERE NOMBRE_USUARIO COLLATE Latin1_General_CS_AS = @NOMBRE_USUARIO
		AND CLAVE_EMPLEADO  COLLATE Latin1_General_CS_AS = @CLAVE_EMPLEADO
	)
	SET @ID_EMPLEADO = (
		SELECT ID_EMPLEADO FROM EMPLEADOS
		WHERE NOMBRE_USUARIO  COLLATE Latin1_General_CS_AS = @NOMBRE_USUARIO
		AND CLAVE_EMPLEADO COLLATE Latin1_General_CS_AS = @CLAVE_EMPLEADO
	)
	END



DECLARE @ID_TRABAJADOR_SALIDA INT

EXEC LOGIN 'ADMIN','19331504',@ID_TRABAJADOR_SALIDA OUTPUT 

SELECT @ID_TRABAJADOR_SALIDA

--  JOIN MENUS--
SELECT DISTINCT M.* FROM PERMISOS_USUARIOS P
JOIN ROLES R ON R.ID_ROL =P.ID_ROL
JOIN SUB_VISTAS SB ON  SB.ID_SUB_MENUS=P.ID_SUB_MENUS
JOIN VISTAS M ON M.ID_MENUS=SB.ID_MENUS
JOIN EMPLEADOS E ON E.ID_ROL=P.ID_ROL AND P.ACTIVO=1
WHERE E.ID_TRABAJADOR=1

--SUB-MENU--
SELECT DISTINCT SB.* FROM PERMISOS_USUARIOS P
JOIN ROLES R ON R.ID_ROL =P.ID_ROL
JOIN SUB_MENUS SB ON  SB.ID_SUB_MENUS=P.ID_SUB_MENUS
JOIN MENUS M ON M.ID_MENUS=SB.ID_MENUS
JOIN EMPLEADOS E ON E.ID_ROL=P.ID_ROL AND P.ACTIVO=1
WHERE E.ID_TRABAJADOR=2


--PROCEDIMIENTO ALMACENADO PARA LOS MENUS Y PERMISOS DEL USUARIO--


CREATE PROC PRIVILEGIOS(
@ID_EMPLEADO INT
)
AS
BEGIN
	SELECT 
	(SELECT vistamenu.NOMBRE_MENU,vistamenu.ICONO ,

		(SELECT  SB.NOMBRE_SUB_MENU,SB.NOMBRE_FORMA FROM PERMISOS_USUARIOS P
		JOIN ROLES R ON R.ID_ROL =P.ID_ROL
		JOIN SUB_VISTAS SB ON  SB.ID_SUB_MENUS=P.ID_SUB_MENUS
		JOIN VISTAS M ON M.ID_MENUS=SB.ID_MENUS
		JOIN EMPLEADOS E ON E.ID_ROL=P.ID_ROL AND P.ACTIVO=1
		WHERE E.ID_EMPLEADO=US.ID_EMPLEADO AND sb.ID_MENUS=vistamenu.ID_MENUS
		FOR XML PATH('SUBMENU'),TYPE) AS 'DETALLESUBMENU'
	FROM
	(
		SELECT DISTINCT M.* FROM PERMISOS_USUARIOS P
			JOIN ROLES R ON R.ID_ROL =P.ID_ROL
			JOIN SUB_VISTAS SB ON  SB.ID_SUB_MENUS=P.ID_SUB_MENUS
			JOIN VISTAS M ON M.ID_MENUS=SB.ID_MENUS
			JOIN EMPLEADOS E ON E.ID_ROL=P.ID_ROL AND P.ACTIVO=1
			WHERE E.ID_EMPLEADO=US.ID_EMPLEADO
	)vistamenu
	FOR XML PATH ('MENU'),TYPE)AS 'DETALLEMENU'

	FROM EMPLEADOS US
	WHERE ID_EMPLEADO =@ID_EMPLEADO
	FOR XML PATH(''),ROOT('PERMISOS')

	END


	EXEC PRIVILEGIOS 1


	SELECT * FROM EMPLEADOS




