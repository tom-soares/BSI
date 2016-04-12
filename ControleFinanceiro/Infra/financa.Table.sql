GO
CREATE TABLE "User" (
	"email" nvarchar (30) NOT NULL ,
	"user" nvarchar (20) NOT NULL ,
	"password" nvarchar (10) NOT NULL ,
	CONSTRAINT "PK_Email" PRIMARY KEY  CLUSTERED 
	(
		"email"
	)
	
)
GO
CREATE TABLE [dbo].[Registros] (
    [id]        INT            IDENTITY (1, 1) NOT NULL,
    [Descricao] NVARCHAR (200) NULL,
    [Valor]     REAL           NULL,
    CONSTRAINT [PK_Registros] PRIMARY KEY CLUSTERED ([id] ASC)
);

