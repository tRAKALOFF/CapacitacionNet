﻿CREATE PROCEDURE NETDESLIB.USP_GETCLIENTEBYID
(
	@IDCLIENTE VARCHAR(36)
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
	WHERE IDCLIENTE = @IDCLIENTE
	ORDER BY NOMBRES;
	
OPEN C1;
	
END