CREATE TABLE [dbo].[TodoItem] (
    [id]        NVARCHAR (255)     CONSTRAINT [DF_TodoItem_id] DEFAULT (CONVERT([nvarchar](255),newid(),(0))) NOT NULL,
    [createdAt] DATETIMEOFFSET (3) CONSTRAINT [DF_TodoItem_createdAt] DEFAULT (CONVERT([datetimeoffset](3),sysutcdatetime(),(0))) NOT NULL,
    [updatedAt] DATETIMEOFFSET (3) NULL,
    [version]   ROWVERSION         NOT NULL,
    [deleted]   BIT                DEFAULT ((0)) NULL,
    [BookName]  NVARCHAR (MAX)     NOT NULL,
    [Author]    NVARCHAR (MAX)     NULL,
    [ISBN]      NVARCHAR (MAX)     NULL,
    [Language]  NVARCHAR (MAX)     NULL,
    PRIMARY KEY NONCLUSTERED ([BookName])
);


GO
CREATE CLUSTERED INDEX [createdAt]
    ON [dbo].[TodoItem]([createdAt] ASC);


GO
CREATE TRIGGER [TR_TodoItem_InsertUpdateDelete] ON [dbo].[TodoItem]
		   AFTER INSERT, UPDATE, DELETE
		AS
		BEGIN
			SET NOCOUNT ON;
			IF TRIGGER_NESTLEVEL() > 3 RETURN;

			UPDATE [dbo].[TodoItem] SET [dbo].[TodoItem].[updatedAt] = CONVERT (DATETIMEOFFSET(3), SYSUTCDATETIME())
			FROM INSERTED
			WHERE INSERTED.id = [dbo].[TodoItem].[id]
		END