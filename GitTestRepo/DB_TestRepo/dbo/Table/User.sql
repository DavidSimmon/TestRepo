﻿CREATE TABLE [dbo].[User]
(
     [Id]           INT IDENTITY ( 1, 1 ) NOT NULL,
     FirstName      VARCHAR( 50 ) NOT NULL,
     LastName       VARCHAR( 50 ) NOT NULL,
     Email          VARCHAR( 100 ) NOT NULL,
     UserName       VARCHAR( 50 ) NOT NULL,
     CreateDate     DATETIME CONSTRAINT DF_User_CreateDate DEFAULT( GETDATE() ) NOT NULL,
     CONSTRAINT PK_User PRIMARY KEY CLUSTERED ( Id ASC ) WITH ( FILLFACTOR = 80 )
)
GO
