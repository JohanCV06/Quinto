/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     22/06/2018 13:27:38                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('COMPONENTEMODULO') and o.name = 'FK_COMPONEN_REFERENCE_COMPONEN')
alter table COMPONENTEMODULO
   drop constraint FK_COMPONEN_REFERENCE_COMPONEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('COMPONENTEMODULO') and o.name = 'FK_COMPONEN_REFERENCE_MODULO')
alter table COMPONENTEMODULO
   drop constraint FK_COMPONEN_REFERENCE_MODULO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MODULOCOTIZACION') and o.name = 'FK_MODULOCO_REFERENCE_MODULO')
alter table MODULOCOTIZACION
   drop constraint FK_MODULOCO_REFERENCE_MODULO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MODULOCOTIZACION') and o.name = 'FK_MODULOCO_REFERENCE_COTIZACI')
alter table MODULOCOTIZACION
   drop constraint FK_MODULOCO_REFERENCE_COTIZACI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PIEZACOMPONENTE') and o.name = 'FK_PIEZACOM_REFERENCE_PIEZA')
alter table PIEZACOMPONENTE
   drop constraint FK_PIEZACOM_REFERENCE_PIEZA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PIEZACOMPONENTE') and o.name = 'FK_PIEZACOM_REFERENCE_COMPONEN')
alter table PIEZACOMPONENTE
   drop constraint FK_PIEZACOM_REFERENCE_COMPONEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COMPONENTE')
            and   type = 'U')
   drop table COMPONENTE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COMPONENTEMODULO')
            and   type = 'U')
   drop table COMPONENTEMODULO
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
           where  id = object_id('MODULOCOTIZACION')
            and   type = 'U')
   drop table MODULOCOTIZACION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PIEZA')
            and   type = 'U')
   drop table PIEZA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PIEZACOMPONENTE')
            and   type = 'U')
   drop table PIEZACOMPONENTE
go

/*==============================================================*/
/* Table: COMPONENTE                                            */
/*==============================================================*/
create table COMPONENTE (
   IDENTIFICADORCOMPONENTE numeric(3,0)         not null,
   NOMBRE               varchar(20)          null,
   IMAGEN1              varchar(Max)         null,
   IMAGEN2              varchar(Max)         null,
   PRECIO_COSTO         numeric(12,2)        null,
   constraint PK_COMPONENTE primary key (IDENTIFICADORCOMPONENTE)
)
go

/*==============================================================*/
/* Table: COMPONENTEMODULO                                      */
/*==============================================================*/
create table COMPONENTEMODULO (
   IDENTIFICADORCOMPONENTE numeric(3,0)         not null,
   CANTIDAD             numeric(9)           null,
   IDENTIFICADORMODULO  numeric(3,0)         not null,
   constraint PK_COMPONENTEMODULO primary key (IDENTIFICADORCOMPONENTE, IDENTIFICADORMODULO)
)
go

/*==============================================================*/
/* Table: COTIZACION                                            */
/*==============================================================*/
create table COTIZACION (
   IDENTIFICADORCOTIZACION numeric(3,0)         not null,
   CLIENTE              varchar(30)          null,
   PRECIOCOSTO          numeric(9)           null,
   PRECIOVENTA          numeric(9)           null,
   FECHA                datetime             null,
   constraint PK_COTIZACION primary key (IDENTIFICADORCOTIZACION)
)
go

/*==============================================================*/
/* Table: MODULO                                                */
/*==============================================================*/
create table MODULO (
   IDENTIFICADORMODULO  numeric(3,0)         not null,
   NOMBRE               varchar(30)          null,
   DESCRIPCION          varchar(max)         null,
   TIPO                 varchar(20)          null,
   IMAGENTEXTOUNO       varchar(max)         null,
   IMAGENTEXTODOS       varchar(max)         null,
   LARGO                numeric(5,2)         null,
   ANCHO                numeric(5,2)         null,
   ALTO                 numeric(5,2)         null,
   PRECIO               numeric(9)           null,
   constraint PK_MODULO primary key (IDENTIFICADORMODULO)
)
go

/*==============================================================*/
/* Table: MODULOCOTIZACION                                      */
/*==============================================================*/
create table MODULOCOTIZACION (
   IDENTIFICADORMODULO  numeric(3,0)         not null,
   IDENTIFICADORCOTIZACION numeric(3,0)         not null,
   EJEX                 numeric(5,2)         null,
   EJEY                 numeric(5,2)         null,
   constraint PK_MODULOCOTIZACION primary key (IDENTIFICADORMODULO, IDENTIFICADORCOTIZACION)
)
go

/*==============================================================*/
/* Table: PIEZA                                                 */
/*==============================================================*/
create table PIEZA (
   IDENTIFICADOR        numeric(3,0)         not null,
   NOMBRE               varchar(20)          null,
   UNIDAD_DE_MEDIDA     varchar(10)          null,
   PRECIOXUNIDAD        numeric(6,2)         null,
   TIPO                 varchar(10)          null,
   IMAGEN1              varchar(Max)         null,
   IMAGEN2              varchar(Max)         null,
   constraint PK_PIEZA primary key (IDENTIFICADOR)
)
go

/*==============================================================*/
/* Table: PIEZACOMPONENTE                                       */
/*==============================================================*/
create table PIEZACOMPONENTE (
   IDENTIFICADOR        numeric(3,0)         not null,
   IDENTIFICADORCOMPONENTE numeric(3,0)         not null,
   CANTIDAD             numeric(4,0)         null,
   constraint PK_PIEZACOMPONENTE primary key (IDENTIFICADOR, IDENTIFICADORCOMPONENTE)
)
go

alter table COMPONENTEMODULO
   add constraint FK_COMPONEN_REFERENCE_COMPONEN foreign key (IDENTIFICADORCOMPONENTE)
      references COMPONENTE (IDENTIFICADORCOMPONENTE)
go

alter table COMPONENTEMODULO
   add constraint FK_COMPONEN_REFERENCE_MODULO foreign key (IDENTIFICADORMODULO)
      references MODULO (IDENTIFICADORMODULO)
go

alter table MODULOCOTIZACION
   add constraint FK_MODULOCO_REFERENCE_MODULO foreign key (IDENTIFICADORMODULO)
      references MODULO (IDENTIFICADORMODULO)
go

alter table MODULOCOTIZACION
   add constraint FK_MODULOCO_REFERENCE_COTIZACI foreign key (IDENTIFICADORCOTIZACION)
      references COTIZACION (IDENTIFICADORCOTIZACION)
go

alter table PIEZACOMPONENTE
   add constraint FK_PIEZACOM_REFERENCE_PIEZA foreign key (IDENTIFICADOR)
      references PIEZA (IDENTIFICADOR)
go

alter table PIEZACOMPONENTE
   add constraint FK_PIEZACOM_REFERENCE_COMPONEN foreign key (IDENTIFICADORCOMPONENTE)
      references COMPONENTE (IDENTIFICADORCOMPONENTE)
go

