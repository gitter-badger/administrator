/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     10.04.2009 22:00:27                          */
/*==============================================================*/


alter table service_event
   drop constraint FK_SERVICE__REFERENCE_EVENT
go

alter table dbo.event
   drop constraint FK_EVENT_REFERENCE_PERSON2
go

alter table dbo.event
   drop constraint FK_EVENT_REFERENCE_PERSON
go

alter table dbo.event
   drop constraint FK_EVENT_REFERENCE_ORGANIZA
go

alter table dbo.event
   drop constraint PK_EVENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.tmp_event')
            and   type = 'U')
   drop table dbo.tmp_event
go

execute sp_rename event, tmp_event
go

execute sp_revokedbaccess dbo
go

/*==============================================================*/
/* Table: event                                                 */
/*==============================================================*/
create table event (
   event_id             uniqueidentifier     not null,
   contact_person_id    uniqueidentifier     null,
   manager_person_id    uniqueidentifier     null,
   organization_id      uniqueidentifier     null,
   name                 nvarchar(255)        not null,
   type                 tinyint              not null,
   person_number        int                  null,
   review               nvarchar(max)        collate Cyrillic_General_CI_AS null,
   price_cash           decimal              not null,
   price_non_cash       decimal              not null,
   loss                 decimal              not null,
   description          nvarchar(max)        null,
   state                tinyint              null,
   registration_date    datetime             not null,
   exit_date            datetime             not null,
   constraint PK_EVENT primary key (event_id)
)
go

--WARNING: The following insert order will not restore columns: review, description
insert into event (event_id, contact_person_id, manager_person_id, organization_id, name, type, person_number, price_cash, price_non_cash, loss, state, registration_date, exit_date)
select event_id, contact_person_id, manager_person_id, organization_id, name, type, person_number, price_cash, price_non_cash, loss, state, ?, ?
from dbo.tmp_event
go

--WARNING: Drop cancelled because cannot restore columns: review, description
--if exists (select 1
--            from  sysobjects
--           where  id = object_id('dbo.tmp_event')
--            and   type = 'U')
--   drop table dbo.tmp_event
--go
alter table event
   add constraint FK_EVENT_REFERENCE_PERSON2 foreign key (contact_person_id)
      references person (person_id)
go

alter table event
   add constraint FK_EVENT_REFERENCE_PERSON foreign key (manager_person_id)
      references person (person_id)
go

alter table event
   add constraint FK_EVENT_REFERENCE_ORGANIZA foreign key (organization_id)
      references organization (organization_id)
go

alter table service_event
   add constraint FK_SERVICE__REFERENCE_EVENT foreign key (event_id)
      references event (event_id)
go

