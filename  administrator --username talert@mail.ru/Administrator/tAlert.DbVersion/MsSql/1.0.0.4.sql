/*==============================================================*/
/* Table: black_list                                            */
/*==============================================================*/
create table black_list (
   black_list_id        uniqueidentifier     not null,
   date                 datetime             not null,
   description          nvarchar(max)        not null,
   constraint PK_BLACK_LIST primary key (black_list_id)
)
