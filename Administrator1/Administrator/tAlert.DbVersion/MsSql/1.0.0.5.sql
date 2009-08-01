ALTER TABLE [dbo].[organization] DROP COLUMN [state]
ALTER TABLE [dbo].[organization] DROP COLUMN [cancellation_number]
GO
/*==============================================================*/
/* View: vw_organization_cancelation_count                      */
/*==============================================================*/
CREATE VIEW vw_organization_cancelation_count as (
	SELECT o.organization_id, count(e.state) as [canceled_count]
	FROM dbo.organization AS o
	LEFT OUTER JOIN dbo.event as e ON e.organization_id = o.organization_id
	WHERE e.state = 2
	GROUP BY o.organization_id,o.short_name)
GO
/*==============================================================*/
/* View: vw_organization_finished_count                         */
/*==============================================================*/
CREATE VIEW vw_organization_finished_count as (
	SELECT o.organization_id, count(e.state) as [finished_count]
	FROM dbo.organization AS o
	LEFT OUTER JOIN dbo.event as e ON e.organization_id = o.organization_id
	WHERE e.state = 1
	GROUP BY o.organization_id,o.short_name)
GO
/*==============================================================*/
/* View: vw_organization_list                                   */
/*==============================================================*/
CREATE VIEW vw_organization_list as (
SELECT  [o].*
		,CASE WHEN [vwc].[canceled_count] IS NULL THEN 0 ELSE [vwc].[canceled_count] END as [canceled_count]
		,CASE WHEN [vwf].[finished_count] IS NULL THEN 0 ELSE [vwf].[finished_count] END as [finished_count]
		,[p].[surname] +' '+ [p].[first_name] +' '+ [p].[last_name]	as [director_name]
		,CAST(CASE WHEN [bl].[black_list_id] IS NULL THEN 0 ELSE 1 END as BIT) as [is_in_blacklist]
FROM [organization] AS [o]
LEFT OUTER JOIN [dbo].[vw_organization_cancelation_count] as [vwc] ON [vwc].[organization_id] = [o].[organization_id]
LEFT OUTER JOIN [dbo].[vw_organization_finished_count] as [vwf] ON [vwf].[organization_id] = [o].[organization_id]
LEFT OUTER JOIN [dbo].[person_organization] as [po] ON [o].[organization_id] = [po].[organization_id] AND [po].[post] LIKE 'генеральный директор'
LEFT OUTER JOIN [dbo].[person] as p ON [p].[person_id] = [po].[person_id]
LEFT OUTER JOIN [dbo].[black_list] as bl ON [bl].[black_list_id] = [o].[organization_id])
