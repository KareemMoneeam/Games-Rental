Create Database Games_Rental_System;
use Games_Rental_System;
/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     5/29/2022 7:06:23 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADMIN_ACCOUNT') and o.name = 'FK_ADMIN_AC_A_LOGIN_ADMIN')
alter table ADMIN_ACCOUNT
   drop constraint FK_ADMIN_AC_A_LOGIN_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADMIN_ACCOUNT') and o.name = 'FK_ADMIN_AC_A_SIGNUP_ADMIN')
alter table ADMIN_ACCOUNT
   drop constraint FK_ADMIN_AC_A_SIGNUP_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"BROWSE"') and o.name = 'FK_BROWSE_BROWSE_CLIENT')
alter table "BROWSE"
   drop constraint FK_BROWSE_BROWSE_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"BROWSE"') and o.name = 'FK_BROWSE_BROWSE2_GAME')
alter table "BROWSE"
   drop constraint FK_BROWSE_BROWSE2_GAME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENT_ACCOUNT') and o.name = 'FK_CLIENT_A_CSIGNUP_CLIENT')
alter table CLIENT_ACCOUNT
   drop constraint FK_CLIENT_A_CSIGNUP_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENT_ACCOUNT') and o.name = 'FK_CLIENT_A_C_LOGIN_CLIENT')
alter table CLIENT_ACCOUNT
   drop constraint FK_CLIENT_A_C_LOGIN_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GAME') and o.name = 'FK_GAME_ADD_ADMIN')
alter table GAME
   drop constraint FK_GAME_ADD_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GAME') and o.name = 'FK_GAME_DEVELOPES_VENDOR')
alter table GAME
   drop constraint FK_GAME_DEVELOPES_VENDOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GAME_CATEGORIES') and o.name = 'FK_GAME_CAT_REFERENCE_GAME')
alter table GAME_CATEGORIES
   drop constraint FK_GAME_CAT_REFERENCE_GAME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GAME_PLATFORMS') and o.name = 'FK_GAME_PLA_REFERENCE_GAME')
alter table GAME_PLATFORMS
   drop constraint FK_GAME_PLA_REFERENCE_GAME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENT') and o.name = 'FK_RENT_RENT_GAME')
alter table RENT
   drop constraint FK_RENT_RENT_GAME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENT') and o.name = 'FK_RENT_RENT2_CLIENT')
alter table RENT
   drop constraint FK_RENT_RENT2_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENT') and o.name = 'FK_RENT_RENT3_VENDOR')
alter table RENT
   drop constraint FK_RENT_RENT3_VENDOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"RETURN"') and o.name = 'FK_RETURN_RETURN_GAME')
alter table "RETURN"
   drop constraint FK_RETURN_RETURN_GAME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"RETURN"') and o.name = 'FK_RETURN_RETURN2_CLIENT')
alter table "RETURN"
   drop constraint FK_RETURN_RETURN2_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SEARCHBYCRITERIA') and o.name = 'FK_SEARCHBY_RELATIONS_GAME')
alter table SEARCHBYCRITERIA
   drop constraint FK_SEARCHBY_RELATIONS_GAME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SEARCHBYCRITERIA') and o.name = 'FK_SEARCHBY_RELATIONS_CLIENT')
alter table SEARCHBYCRITERIA
   drop constraint FK_SEARCHBY_RELATIONS_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('UPDATEGAMEDETAILS') and o.name = 'FK_UPDATEGA_REFERENCE_GAME')
alter table UPDATEGAMEDETAILS
   drop constraint FK_UPDATEGA_REFERENCE_GAME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('UPDATEGAMEDETAILS') and o.name = 'FK_UPDATEGA_REFERENCE_ADMIN')
alter table UPDATEGAMEDETAILS
   drop constraint FK_UPDATEGA_REFERENCE_ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ADMIN_ACCOUNT')
            and   name  = 'A_LOGIN_FK'
            and   indid > 0
            and   indid < 255)
   drop index ADMIN_ACCOUNT.A_LOGIN_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ADMIN_ACCOUNT')
            and   name  = 'A_SIGNUP_FK'
            and   indid > 0
            and   indid < 255)
   drop index ADMIN_ACCOUNT.A_SIGNUP_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN_ACCOUNT')
            and   type = 'U')
   drop table ADMIN_ACCOUNT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"BROWSE"')
            and   name  = 'BROWSE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index "BROWSE".BROWSE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"BROWSE"')
            and   name  = 'BROWSE_FK'
            and   indid > 0
            and   indid < 255)
   drop index "BROWSE".BROWSE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"BROWSE"')
            and   type = 'U')
   drop table "BROWSE"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENT')
            and   type = 'U')
   drop table CLIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CLIENT_ACCOUNT')
            and   name  = 'C_LOGIN_FK'
            and   indid > 0
            and   indid < 255)
   drop index CLIENT_ACCOUNT.C_LOGIN_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CLIENT_ACCOUNT')
            and   name  = 'CSIGNUP_FK'
            and   indid > 0
            and   indid < 255)
   drop index CLIENT_ACCOUNT.CSIGNUP_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENT_ACCOUNT')
            and   type = 'U')
   drop table CLIENT_ACCOUNT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GAME')
            and   name  = 'DEVELOPES_FK'
            and   indid > 0
            and   indid < 255)
   drop index GAME.DEVELOPES_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GAME')
            and   name  = 'ADD_FK'
            and   indid > 0
            and   indid < 255)
   drop index GAME.ADD_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GAME')
            and   type = 'U')
   drop table GAME
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GAME_CATEGORIES')
            and   type = 'U')
   drop table GAME_CATEGORIES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GAME_PLATFORMS')
            and   type = 'U')
   drop table GAME_PLATFORMS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENT')
            and   name  = 'RENT2_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENT.RENT2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENT')
            and   name  = 'RENT_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENT.RENT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RENT')
            and   type = 'U')
   drop table RENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"RETURN"')
            and   name  = 'RETURN2_FK'
            and   indid > 0
            and   indid < 255)
   drop index "RETURN".RETURN2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"RETURN"')
            and   name  = 'RETURN_FK'
            and   indid > 0
            and   indid < 255)
   drop index "RETURN".RETURN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"RETURN"')
            and   type = 'U')
   drop table "RETURN"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SEARCHBYCRITERIA')
            and   name  = 'RELATIONSHIP_10_FK'
            and   indid > 0
            and   indid < 255)
   drop index SEARCHBYCRITERIA.RELATIONSHIP_10_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SEARCHBYCRITERIA')
            and   name  = 'RELATIONSHIP_9_FK'
            and   indid > 0
            and   indid < 255)
   drop index SEARCHBYCRITERIA.RELATIONSHIP_9_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SEARCHBYCRITERIA')
            and   type = 'U')
   drop table SEARCHBYCRITERIA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('UPDATEGAMEDETAILS')
            and   type = 'U')
   drop table UPDATEGAMEDETAILS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VENDOR')
            and   type = 'U')
   drop table VENDOR
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   ADMIN_ID             numeric(8)           not null,
   A_FIRSTNAME          varchar(15)          not null,
   A_LASTNAME           varchar(15)          not null,
   constraint PK_ADMIN primary key nonclustered (ADMIN_ID)
)
go

/*==============================================================*/
/* Table: ADMIN_ACCOUNT                                         */
/*==============================================================*/
create table ADMIN_ACCOUNT (
   A_USERNAME           varchar(32)          not null,
   ADMIN_ID             numeric(8)           not null,
   A_PASSWORD           varchar(64)          not null,
   A_EMAIL              nvarchar(255)        not null,
   constraint PK_ADMIN_ACCOUNT primary key nonclustered (A_USERNAME)
)
go

/*==============================================================*/
/* Index: A_SIGNUP_FK                                           */
/*==============================================================*/
create index A_SIGNUP_FK on ADMIN_ACCOUNT (
ADMIN_ID ASC
)
go

/*==============================================================*/
/* Index: A_LOGIN_FK                                            */
/*==============================================================*/
create index A_LOGIN_FK on ADMIN_ACCOUNT (
ADMIN_ID ASC
)
go

/*==============================================================*/
/* Table: "BROWSE"                                              */
/*==============================================================*/
create table "BROWSE" (
   CLIENT_ID            numeric(8)           not null,
   GAME_ID              numeric(8)           not null,
   constraint PK_BROWSE primary key (CLIENT_ID, GAME_ID)
)
go

/*==============================================================*/
/* Index: BROWSE_FK                                             */
/*==============================================================*/
create index BROWSE_FK on "BROWSE" (
CLIENT_ID ASC
)
go

/*==============================================================*/
/* Index: BROWSE2_FK                                            */
/*==============================================================*/
create index BROWSE2_FK on "BROWSE" (
GAME_ID ASC
)
go

/*==============================================================*/
/* Table: CLIENT                                                */
/*==============================================================*/
create table CLIENT (
   CLIENT_ID            numeric(8)           not null,
   C_FIRSTNAME          varchar(15)          not null,
   C_LASTNAME           varchar(15)          not null,
   C_AGE                numeric(2)           not null,
   C_PNUM               varchar(15)          not null,
   C_CITY               varchar(20)          null,
   C_GOV                varchar(20)          null,
   C_STREET             varchar(20)          null,
   GENDER               varchar(7)           not null,
   constraint PK_CLIENT primary key nonclustered (CLIENT_ID)
)
go

/*==============================================================*/
/* Table: CLIENT_ACCOUNT                                        */
/*==============================================================*/
create table CLIENT_ACCOUNT (
   C_USERNAME           varchar(32)          not null,
   CLIENT_ID            numeric(8)           not null,
   C_PASSWORD           varchar(64)          not null,
   C_EMAIL              nvarchar(255)        not null,
   constraint PK_CLIENT_ACCOUNT primary key nonclustered (C_USERNAME)
)
go

/*==============================================================*/
/* Index: CSIGNUP_FK                                            */
/*==============================================================*/
create index CSIGNUP_FK on CLIENT_ACCOUNT (
CLIENT_ID ASC
)
go

/*==============================================================*/
/* Index: C_LOGIN_FK                                            */
/*==============================================================*/
create index C_LOGIN_FK on CLIENT_ACCOUNT (
CLIENT_ID ASC
)
go

/*==============================================================*/
/* Table: GAME                                                  */
/*==============================================================*/
create table GAME (
   GAME_ID              numeric(8)           not null,
   VENDOR_ID            numeric(8)           not null,
   ADMIN_ID             numeric(8)           null,
   G_NAME               varchar(20)          not null,
   YEAR                 numeric(4)           not null,
   ADDITIONDATE         date                 null,
   constraint PK_GAME primary key nonclustered (GAME_ID)
)
go

/*==============================================================*/
/* Index: ADD_FK                                                */
/*==============================================================*/
create index ADD_FK on GAME (
ADMIN_ID ASC
)
go

/*==============================================================*/
/* Index: DEVELOPES_FK                                          */
/*==============================================================*/
create index DEVELOPES_FK on GAME (
VENDOR_ID ASC
)
go

/*==============================================================*/
/* Table: GAME_CATEGORIES                                       */
/*==============================================================*/
create table GAME_CATEGORIES (
   CATEGORIES           varchar(15)          not null,
   GAME_ID              numeric(8)           not null,
   constraint PK_GAME_CATEGORIES primary key nonclustered (CATEGORIES, GAME_ID)
)
go

/*==============================================================*/
/* Table: GAME_PLATFORMS                                        */
/*==============================================================*/
create table GAME_PLATFORMS (
   PLATFORMS            varchar(15)          not null,
   GAME_ID              numeric(8)           not null,
   constraint PK_GAME_PLATFORMS primary key nonclustered (PLATFORMS, GAME_ID)
)
go

/*==============================================================*/
/* Table: RENT                                                  */
/*==============================================================*/
create table RENT (
   GAME_ID              numeric(8)           not null,
   CLIENT_ID            numeric(8)           not null,
   VENDOR_ID            numeric(8)           not null,
   DATEOFRENTING        date                 null,
   constraint PK_RENT primary key (GAME_ID, CLIENT_ID, VENDOR_ID)
)
go

/*==============================================================*/
/* Index: RENT_FK                                               */
/*==============================================================*/
create index RENT_FK on RENT (
GAME_ID ASC
)
go

/*==============================================================*/
/* Index: RENT2_FK                                              */
/*==============================================================*/
create index RENT2_FK on RENT (
CLIENT_ID ASC
)
go

/*==============================================================*/
/* Table: "RETURN"                                              */
/*==============================================================*/
create table "RETURN" (
   GAME_ID              numeric(8)           not null,
   CLIENT_ID            numeric(8)           not null,
   constraint PK_RETURN primary key (GAME_ID, CLIENT_ID)
)
go

/*==============================================================*/
/* Index: RETURN_FK                                             */
/*==============================================================*/
create index RETURN_FK on "RETURN" (
GAME_ID ASC
)
go

/*==============================================================*/
/* Index: RETURN2_FK                                            */
/*==============================================================*/
create index RETURN2_FK on "RETURN" (
CLIENT_ID ASC
)
go

/*==============================================================*/
/* Table: SEARCHBYCRITERIA                                      */
/*==============================================================*/
create table SEARCHBYCRITERIA (
   CLIENT_ID            numeric(8)           not null,
   GAME_ID              numeric(8)           not null,
   GID                  numeric(8)           null,
   GYEAR                numeric(4)           null,
   GNAME                varchar(20)          null,
   PALTFORM             varchar(15)          null,
   CATEGORY             varchar(15)          null,
   constraint PK_SEARCHBYCRITERIA primary key (CLIENT_ID, GAME_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_9_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_9_FK on SEARCHBYCRITERIA (
CLIENT_ID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_10_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_10_FK on SEARCHBYCRITERIA (
GAME_ID ASC
)
go

/*==============================================================*/
/* Table: UPDATEGAMEDETAILS                                     */
/*==============================================================*/
create table UPDATEGAMEDETAILS (
   ADMIN_ID             numeric(8)           not null,
   GAME_ID              numeric(8)           not null,
   PLATFORM             varchar(15)          null,
   CATEGORY             varchar(15)          null,
   G_NAME               varchar(15)          null,
   YEAR                 numeric(4)           null,
   constraint PK_UPDATEGAMEDETAILS primary key (ADMIN_ID, GAME_ID)
)
go

/*==============================================================*/
/* Table: VENDOR                                                */
/*==============================================================*/
create table VENDOR (
   VENDOR_ID            numeric(8)           not null,
   V_FIRSTNAME          varchar(15)          not null,
   V_LASTNAME           varchar(15)          not null,
   V_PNUM               varchar(15)          not null,
   V_CITY               varchar(20)          null,
   V_GOV                varchar(20)          null,
   V_STREET             varchar(20)          null,
   constraint PK_VENDOR primary key nonclustered (VENDOR_ID)
)
go

alter table ADMIN_ACCOUNT
   add constraint FK_ADMIN_AC_A_LOGIN_ADMIN foreign key (ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

alter table ADMIN_ACCOUNT
   add constraint FK_ADMIN_AC_A_SIGNUP_ADMIN foreign key (ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

alter table "BROWSE"
   add constraint FK_BROWSE_BROWSE_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table "BROWSE"
   add constraint FK_BROWSE_BROWSE2_GAME foreign key (GAME_ID)
      references GAME (GAME_ID)
go

alter table CLIENT_ACCOUNT
   add constraint FK_CLIENT_A_CSIGNUP_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table CLIENT_ACCOUNT
   add constraint FK_CLIENT_A_C_LOGIN_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table GAME
   add constraint FK_GAME_ADD_ADMIN foreign key (ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

alter table GAME
   add constraint FK_GAME_DEVELOPES_VENDOR foreign key (VENDOR_ID)
      references VENDOR (VENDOR_ID)
go

alter table GAME_CATEGORIES
   add constraint FK_GAME_CAT_REFERENCE_GAME foreign key (GAME_ID)
      references GAME (GAME_ID)
go

alter table GAME_PLATFORMS
   add constraint FK_GAME_PLA_REFERENCE_GAME foreign key (GAME_ID)
      references GAME (GAME_ID)
go

alter table RENT
   add constraint FK_RENT_RENT_GAME foreign key (GAME_ID)
      references GAME (GAME_ID)
go

alter table RENT
   add constraint FK_RENT_RENT2_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table RENT
   add constraint FK_RENT_RENT3_VENDOR foreign key (VENDOR_ID)
      references VENDOR (VENDOR_ID)
go

alter table "RETURN"
   add constraint FK_RETURN_RETURN_GAME foreign key (GAME_ID)
      references GAME (GAME_ID)
go

alter table "RETURN"
   add constraint FK_RETURN_RETURN2_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table SEARCHBYCRITERIA
   add constraint FK_SEARCHBY_RELATIONS_GAME foreign key (GAME_ID)
      references GAME (GAME_ID)
go

alter table SEARCHBYCRITERIA
   add constraint FK_SEARCHBY_RELATIONS_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table UPDATEGAMEDETAILS
   add constraint FK_UPDATEGA_REFERENCE_GAME foreign key (GAME_ID)
      references GAME (GAME_ID)
go

alter table UPDATEGAMEDETAILS
   add constraint FK_UPDATEGA_REFERENCE_ADMIN foreign key (ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

