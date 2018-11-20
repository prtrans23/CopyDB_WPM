﻿SELECT
	 A.TABLE_CATALOG
	 ,A.TABLE_NAME
	 ,A.ORDINAL_POSITION
	 ,A.COLUMN_NAME
	 ,A.DATA_TYPE
	 ,ISNULL(A.CHARACTER_MAXIMUM_LENGTH,'') AS CHARACTER_MAXIMUM_LENGTH
	 ,ISNULL(A.NUMERIC_PRECISION,'') AS NUMERIC_PRECISION
	 ,A.IS_NULLABLE as IS_NULLABLE
	 ,ISNULL(A.COLUMN_DEFAULT,'') as COLUMN_DEFAULT
	 ,ISNULL(B.CONSTRAINT_NAME,'') as CONSTRAINT_NAME
	 ,ISNULL(A.CHARACTER_SET_NAME,'') as CHARACTER_SET_NAME
	 ,ISNULL(A.COLLATION_NAME,'') as COLLATION_NAME
	 ,CASE WHEN ISNULL(C.NAME,'') = '' THEN '' ELSE 'Identity' END auto
FROM 
	 INFORMATION_SCHEMA.COLUMNS A
	 LEFT OUTER JOIN
	 INFORMATION_SCHEMA.KEY_COLUMN_USAGE B
	 ON A.TABLE_NAME = B.TABLE_NAME 
	 AND A.COLUMN_NAME = B.COLUMN_NAME
	 LEFT OUTER JOIN
	 syscolumns C 
	 ON C.ID = object_id(A.TABLE_NAME) AND A.COLUMN_NAME = C.NAME AND C.COLSTAT & 1 = 1 
WHERE
	 A.TABLE_NAME = '{targetTable}'
ORDER BY
	 A.ORDINAL_POSITION