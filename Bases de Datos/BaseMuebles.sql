/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     22/06/2018 10:07:32                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TABLACOMPONENTE_MODULO') and o.name = 'FK_TABLACOM_REFERENCE_COMPONEN')
alter table TABLACOMPONENTE_MODULO
   drop constraint FK_TABLACOM_REFERENCE_COMPONEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TABLACOMPONENTE_MODULO') and o.name = 'FK_TABLACOM_REFERENCE_MODULO')
alter table TABLACOMPONENTE_MODULO
   drop constraint FK_TABLACOM_REFERENCE_MODULO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TABLAMODULO_COTIZACION') and o.name = 'FK_TABLAMOD_REFERENCE_COTIZACI')
alter table TABLAMODULO_COTIZACION
   drop constraint FK_TABLAMOD_REFERENCE_COTIZACI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TABLAMODULO_COTIZACION') and o.name = 'FK_TABLAMOD_REFERENCE_MODULO')
alter table TABLAMODULO_COTIZACION
   drop constraint FK_TABLAMOD_REFERENCE_MODULO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TABLAPIEZA_COMPONENTE') and o.name = 'FK_TABLAPIE_REFERENCE_COMPONEN')
alter table TABLAPIEZA_COMPONENTE
   drop constraint FK_TABLAPIE_REFERENCE_COMPONEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TABLAPIEZA_COMPONENTE') and o.name = 'FK_TABLAPIE_REFERENCE_PIEZA')
alter table TABLAPIEZA_COMPONENTE
   drop constraint FK_TABLAPIE_REFERENCE_PIEZA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COMPONENTE')
            and   type = 'U')
   drop table COMPONENTE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COTIZACION')
            and   type = 'U')
   drop table COTIZACION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MODULO')
            and   type = 'U')
   drop table MODULO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PIEZA')
            and   type = 'U')
   drop table PIEZA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TABLACOMPONENTE_MODULO')
            and   type = 'U')
   drop table TABLACOMPONENTE_MODULO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TABLAMODULO_COTIZACION')
            and   type = 'U')
   drop table TABLAMODULO_COTIZACION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TABLAPIEZA_COMPONENTE')
            and   type = 'U')
   drop table TABLAPIEZA_COMPONENTE
go

/*==============================================================*/
/* Table: COMPONENTE                                            */
/*==============================================================*/
create table COMPONENTE (
   NOMBRE               varchar(1)           null,
   IDENTIFICADOR        varchar(1)           not null,
   IMAGENPARTE1         varchar(Max)         null,
   IMAGENPARTE          varchar(Max)         null,
   PRECIOCOSTO          numeric              null,
   constraint PK_COMPONENTE primary key (IDENTIFICADOR)
)
go

/*==============================================================*/
/* Table: COTIZACION                                            */
/*==============================================================*/
create table COTIZACION (
   IDENTIFICADOR        varchar(1)           not null,
   CLIENTE              varchar(1)           null,
   PRECIOCOSTO          numeric              null,
   PRECIOVENTA          numeric              null,
   FECHA                datetime             null,
   constraint PK_COTIZACION primary key (IDENTIFICADOR)
)
go

/*==============================================================*/
/* Table: MODULO                                                */
/*==============================================================*/
create table MODULO (
   ALTOENMM             numeric              null,
   ANCHOENMM            numeric              null,
   LARGOENMM            numeric              null,
   TIPO                 varchar(1)           null,
   PRECIO               numeric              null,
   IMAGENPARTE1         varchar(Max)         null,
   IMAGENPARTE2         varchar(Max)         null,
   DESCRIPCION          varchar(Max)         null,
   NOMBRE               varchar(1)           null,
   IDENTIFICADOR        varchar(1)           not null,
   constraint PK_MODULO primary key (IDENTIFICADOR)
)
go

/*==============================================================*/
/* Table: PIEZA                                                 */
/*==============================================================*/
create table PIEZA (
   IMAGENPARTE1         varchar(Max)         null,
   NOMBRE               varchar(1)           null,
   IDENTIFICADOR        varchar(1)           not null,
   UNIDADDEMEDIDA       varchar(1)           null,
   PRECIOXUNIDAD        numeric              null,
   IMAGENPARTE_2        varchar(Max)         null,
   TIPO                 varchar(1)           null,
   constraint PK_PIEZA primary key (IDENTIFICADOR)
)
go

/*==============================================================*/
/* Table: TABLACOMPONENTE_MODULO                                */
/*==============================================================*/
create table TABLACOMPONENTE_MODULO (
   ID_MODULO            varchar(1)           not null,
   ID_                  varchar(1)           not null,
   IDENTIFICADOR        varchar(1)           null,
   MOD_IDENTIFICADOR    varchar(1)           null,
   CANTIDAD             numeric              null,
   constraint PK_TABLACOMPONENTE_MODULO primary key (ID_MODULO, ID_)
)
go

/*==============================================================*/
/* Table: TABLAMODULO_COTIZACION                                */
/*==============================================================*/
create table TABLAMODULO_COTIZACION (
   IDCOTIZACION         varchar(1)           not null,
   IDMODULO             varchar(1)           not null,
   IDENTIFICADOR        varchar(1)           null,
   MOD_IDENTIFICADOR    varchar(1)           null,
   EJEY                 decimal              null,
   EJEX                 decimal              null,
   constraint PK_TABLAMODULO_COTIZACION primary key (IDCOTIZACION, IDMODULO)
)
go

/*==============================================================*/
/* Table: TABLAPIEZA_COMPONENTE                                 */
/*==============================================================*/
create table TABLAPIEZA_COMPONENTE (
   IDPIEZA              varchar(1)           not null,
   IDCOLUMNA            varchar(1)           not null,
   IDENTIFICADOR        varchar(1)           null,
   PIE_IDENTIFICADOR    varchar(1)           null,
   CANTIDAD             numeric              null,
   constraint PK_TABLAPIEZA_COMPONENTE primary key (IDPIEZA, IDCOLUMNA)
)
go

alter table TABLACOMPONENTE_MODULO
   add constraint FK_TABLACOM_REFERENCE_COMPONEN foreign key (IDENTIFICADOR)
      references COMPONENTE (IDENTIFICADOR)
go

alter table TABLACOMPONENTE_MODULO
   add constraint FK_TABLACOM_REFERENCE_MODULO foreign key (MOD_IDENTIFICADOR)
      references MODULO (IDENTIFICADOR)
go

alter table TABLAMODULO_COTIZACION
   add constraint FK_TABLAMOD_REFERENCE_COTIZACI foreign key (IDENTIFICADOR)
      references COTIZACION (IDENTIFICADOR)
go

alter table TABLAMODULO_COTIZACION
   add constraint FK_TABLAMOD_REFERENCE_MODULO foreign key (MOD_IDENTIFICADOR)
      references MODULO (IDENTIFICADOR)
go

alter table TABLAPIEZA_COMPONENTE
   add constraint FK_TABLAPIE_REFERENCE_COMPONEN foreign key (IDENTIFICADOR)
      references COMPONENTE (IDENTIFICADOR)
go

alter table TABLAPIEZA_COMPONENTE
   add constraint FK_TABLAPIE_REFERENCE_PIEZA foreign key (PIE_IDENTIFICADOR)
      references PIEZA (IDENTIFICADOR)
go

