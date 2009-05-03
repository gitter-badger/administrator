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
   price                decimal              not null,
   loss                 decimal              not null,
   description          nvarchar(max)        null,
   state                tinyint              null,
   constraint PK_EVENT primary key (event_id)
)


/*==============================================================*/
/* Table: image                                                 */
/*==============================================================*/
create table image (
   image_id             uniqueidentifier     not null,
   data                 image                not null,
   name                 nvarchar(50)         null,
   constraint PK_IMAGE primary key (image_id)
)


/*==============================================================*/
/* Table: organization                                          */
/*==============================================================*/
create table organization (
   organization_id      uniqueidentifier     not null,
   name                 nvarchar(50)         not null,
   short_name           nvarchar(50)         null,
   legal_address        nvarchar(50)         null,
   post_address         nvarchar(50)         null,
   address              nvarchar(50)         null,
   email                nvarchar(50)         null,
   scope_of_activity    nvarchar(50)         null,
   phone                nvarchar(50)         null,
   state                int                  null,
   cancellation_number  int                  null,
   discount             decimal              null,
   description          nvarchar(max)        null,
   constraint PK_ORGANIZATION primary key (organization_id)
)


/*==============================================================*/
/* Table: person                                                */
/*==============================================================*/
create table person (
   person_id            uniqueidentifier     not null,
   image_id             uniqueidentifier     null,
   first_name           nvarchar(50)         not null,
   last_name            nvarchar(50)         not null,
   surname              nvarchar(50)         not null,
   phone                nvarchar(50)         null,
   mobile               nvarchar(50)         null,
   email                nvarchar(50)         null,
   icq                  nvarchar(20)         null,
   sex                  bit                  not null,
   description          nvarchar(max)        null,
   constraint PK_PERSON primary key (person_id)
)


/*==============================================================*/
/* Table: person_organization                                   */
/*==============================================================*/
create table person_organization (
   person_id            uniqueidentifier     null,
   organization_id      uniqueidentifier     null,
   post                 nvarchar(50)         null
)


/*==============================================================*/
/* Table: service                                               */
/*==============================================================*/
create table service (
   service_id           uniqueidentifier     not null,
   service_type_id      uniqueidentifier     null,
   name                 nvarchar(50)         null,
   constraint PK_SERVICE primary key (service_id)
)


/*==============================================================*/
/* Table: service_event                                         */
/*==============================================================*/
create table service_event (
   service_event_id     uniqueidentifier     not null,
   event_id             uniqueidentifier     null,
   service_id           uniqueidentifier     null,
   start_date           datetime             not null,
   end_date             datetime             not null,
   description          nvarchar(max)        null,
   constraint PK_SERVICE_EVENT primary key (service_event_id)
)


/*==============================================================*/
/* Table: service_type                                          */
/*==============================================================*/
create table service_type (
   service_type_id      uniqueidentifier     not null,
   name                 nvarchar(50)         null,
   constraint PK_SERVICE_TYPE primary key (service_type_id)
)


alter table event
   add constraint FK_EVENT_REFERENCE_ORGANIZA foreign key (organization_id)
      references organization (organization_id)


alter table event
   add constraint FK_EVENT_REFERENCE_PERSON2 foreign key (contact_person_id)
      references person (person_id)


alter table event
   add constraint FK_EVENT_REFERENCE_PERSON foreign key (manager_person_id)
      references person (person_id)


alter table person
   add constraint FK_PERSON_REFERENCE_IMAGE foreign key (image_id)
      references image (image_id)


alter table person_organization
   add constraint FK_PERSON_O_REFERENCE_PERSON foreign key (person_id)
      references person (person_id)


alter table person_organization
   add constraint FK_PERSON_O_REFERENCE_ORGANIZA foreign key (organization_id)
      references organization (organization_id)


alter table service
   add constraint FK_SERVICE_REFERENCE_SERVICE_ foreign key (service_type_id)
      references service_type (service_type_id)


alter table service_event
   add constraint FK_SERVICE__REFERENCE_EVENT foreign key (event_id)
      references event (event_id)


alter table service_event
   add constraint FK_SERVICE__REFERENCE_SERVICE foreign key (service_id)
      references service (service_id)

