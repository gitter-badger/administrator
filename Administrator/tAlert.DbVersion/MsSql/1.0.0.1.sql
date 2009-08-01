/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     09.04.2009 19:26:22                          */
/*==============================================================*/


alter table service_event
   drop constraint FK_SERVICE__REFERENCE_EVENT


alter table dbo.event
   drop constraint FK_EVENT_REFERENCE_ORGANIZA


alter table dbo.event
   drop constraint FK_EVENT_REFERENCE_PERSON2


alter table dbo.event
   drop constraint FK_EVENT_REFERENCE_PERSON


alter table dbo.event
   drop constraint PK_EVENT


if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.tmp_event')
            and   type = 'U')
   drop table dbo.tmp_event


execute sp_rename event, tmp_event

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
   review               nvarchar(max)        null,
   price_cash           decimal              not null,
   price_non_cash       decimal              not null,
   loss                 decimal              not null,
   description          nvarchar(max)        null,
   state                tinyint              null,
   constraint PK_EVENT primary key (event_id)
)



insert into event (event_id, contact_person_id, manager_person_id, organization_id, name, type, person_number, price_cash,price_non_cash, loss, state,review,description)
			select event_id, contact_person_id, manager_person_id, organization_id, name, type, person_number, price,	  0,			  loss, state,review,description
from dbo.tmp_event



if exists (select 1
            from  sysobjects
           where  id = object_id('dbo.tmp_event')
            and   type = 'U')
   drop table dbo.tmp_event

alter table event
   add constraint FK_EVENT_REFERENCE_PERSON2 foreign key (contact_person_id)
      references person (person_id)


alter table event
   add constraint FK_EVENT_REFERENCE_PERSON foreign key (manager_person_id)
      references person (person_id)


alter table event
   add constraint FK_EVENT_REFERENCE_ORGANIZA foreign key (organization_id)
      references organization (organization_id)


alter table service_event
   add constraint FK_SERVICE__REFERENCE_EVENT foreign key (event_id)
      references event (event_id)


