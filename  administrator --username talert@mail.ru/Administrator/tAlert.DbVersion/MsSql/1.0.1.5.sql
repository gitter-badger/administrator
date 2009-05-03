/*==============================================================*/
/* View: vw_person_list                                         */
/*==============================================================*/
CREATE VIEW vw_person_list as (
SELECT [p].*, [i].[data] as [photo], [po].[organization_id], [po].[post], [o].[name] as [organization_name]
FROM [person] as p
LEFT OUTER JOIN [image] AS [i] ON [i].[image_id] = [p].[image_id]
LEFT OUTER JOIN [dbo].[person_organization] AS [po] ON [po].[person_id] = [p].[person_id]
LEFT OUTER JOIN [dbo].[organization] AS [o] ON [o].[organization_id] = [po].[organization_id])
GO
