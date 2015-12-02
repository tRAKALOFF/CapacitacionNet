﻿CREATE PROCEDURE NETDESLIB.USP_LISTARCLIENTES
(
)
LANGUAGE SQL

RESULT SETS 1

BEGIN	

DECLARE C1 CURSOR FOR
	SELECT IDCLIENTE
		,NOMBRES
		,APELLIDOS
		,CORREO
		,EDAD
	FROM NETDESLIB.CLIENTES
	ORDER BY APELLIDOS, NOMBRES;
	
OPEN C1;
	
END