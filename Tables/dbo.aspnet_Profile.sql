CREATE TABLE [dbo].[aspnet_Profile]
(
[UserId] [uniqueidentifier] NOT NULL,
[PropertyNames] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[PropertyValuesString] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[PropertyValuesBinary] [image] NOT NULL,
[LastUpdatedDate] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[aspnet_Profile] ADD CONSTRAINT [PK__aspnet_P__1788CC4C6118EC1A] PRIMARY KEY CLUSTERED  ([UserId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[aspnet_Profile] ADD CONSTRAINT [FK__aspnet_Pr__UserI__345EC57D] FOREIGN KEY ([UserId]) REFERENCES [dbo].[aspnet_Users] ([UserId])
GO
