/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     24/07/2018 03:11:34 p.m.                     */
/*==============================================================*/


if exists (select 1
          from sysobjects
          where  id = object_id('ACTUALIZAR_COMPONENTE')
          and type in ('P','PC'))
   drop procedure ACTUALIZAR_COMPONENTE
go

if exists (select 1
          from sysobjects
          where  id = object_id('ACTUALIZAR_COMPONENTE_MODULO')
          and type in ('P','PC'))
   drop procedure ACTUALIZAR_COMPONENTE_MODULO
go

if exists (select 1
          from sysobjects
          where  id = object_id('ACTUALIZAR_CROQUIS')
          and type in ('P','PC'))
   drop procedure ACTUALIZAR_CROQUIS
go

if exists (select 1
          from sysobjects
          where  id = object_id('ACTUALIZAR_MODULO')
          and type in ('P','PC'))
   drop procedure ACTUALIZAR_MODULO
go

if exists (select 1
          from sysobjects
          where  id = object_id('ACTUALIZAR_MODULO_CROQUIS')
          and type in ('P','PC'))
   drop procedure ACTUALIZAR_MODULO_CROQUIS
go

if exists (select 1
          from sysobjects
          where  id = object_id('ACTUALIZAR_PIEZA')
          and type in ('P','PC'))
   drop procedure ACTUALIZAR_PIEZA
go

if exists (select 1
          from sysobjects
          where  id = object_id('ACTUALIZAR_PIEZA_COMPONENTE')
          and type in ('P','PC'))
   drop procedure ACTUALIZAR_PIEZA_COMPONENTE
go

if exists (select 1
          from sysobjects
          where  id = object_id('ELIMINAR_COMPONENTE')
          and type in ('P','PC'))
   drop procedure ELIMINAR_COMPONENTE
go

if exists (select 1
          from sysobjects
          where  id = object_id('ELIMINAR_COMPONENTE_MODULO')
          and type in ('P','PC'))
   drop procedure ELIMINAR_COMPONENTE_MODULO
go

if exists (select 1
          from sysobjects
          where  id = object_id('ELIMINAR_CROQUIS')
          and type in ('P','PC'))
   drop procedure ELIMINAR_CROQUIS
go

if exists (select 1
          from sysobjects
          where  id = object_id('ELIMINAR_MODULO')
          and type in ('P','PC'))
   drop procedure ELIMINAR_MODULO
go

if exists (select 1
          from sysobjects
          where  id = object_id('ELIMINAR_MODULO_CROQUIS')
          and type in ('P','PC'))
   drop procedure ELIMINAR_MODULO_CROQUIS
go

if exists (select 1
          from sysobjects
          where  id = object_id('ELIMINAR_PIEZA')
          and type in ('P','PC'))
   drop procedure ELIMINAR_PIEZA
go

if exists (select 1
          from sysobjects
          where  id = object_id('ELIMINAR_PIEZA_COMPONENTE')
          and type in ('P','PC'))
   drop procedure ELIMINAR_PIEZA_COMPONENTE
go

if exists (select 1
          from sysobjects
          where  id = object_id('INSERTAR_COMPONENTE')
          and type in ('P','PC'))
   drop procedure INSERTAR_COMPONENTE
go

if exists (select 1
          from sysobjects
          where  id = object_id('INSERTAR_COMPONENT_MODULO')
          and type in ('P','PC'))
   drop procedure INSERTAR_COMPONENT_MODULO
go

if exists (select 1
          from sysobjects
          where  id = object_id('INSERTAR_CROQUIS')
          and type in ('P','PC'))
   drop procedure INSERTAR_CROQUIS
go

if exists (select 1
          from sysobjects
          where  id = object_id('INSERTAR_MODULO')
          and type in ('P','PC'))
   drop procedure INSERTAR_MODULO
go

if exists (select 1
          from sysobjects
          where  id = object_id('INSERTAR_MODULO_CROQUIS')
          and type in ('P','PC'))
   drop procedure INSERTAR_MODULO_CROQUIS
go

if exists (select 1
          from sysobjects
          where  id = object_id('INSERTAR_PIEZA')
          and type in ('P','PC'))
   drop procedure INSERTAR_PIEZA
go

if exists (select 1
          from sysobjects
          where  id = object_id('INSERTAR_PIEZA_COMPONENTE')
          and type in ('P','PC'))
   drop procedure INSERTAR_PIEZA_COMPONENTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('COMPONENTE_MODULO') and o.name = 'FK_COMPONEN_REFERENCE_COMPONEN')
alter table COMPONENTE_MODULO
   drop constraint FK_COMPONEN_REFERENCE_COMPONEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('COMPONENTE_MODULO') and o.name = 'FK_COMPONEN_REFERENCE_MODULO')
alter table COMPONENTE_MODULO
   drop constraint FK_COMPONEN_REFERENCE_MODULO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MODULO_CROQUIS') and o.name = 'FK_MODULO_C_REFERENCE_MODULO')
alter table MODULO_CROQUIS
   drop constraint FK_MODULO_C_REFERENCE_MODULO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MODULO_CROQUIS') and o.name = 'FK_MODULO_C_REFERENCE_CROQUIS')
alter table MODULO_CROQUIS
   drop constraint FK_MODULO_C_REFERENCE_CROQUIS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PIEZA_COMPONENTE') and o.name = 'FK_PIEZA_CO_REFERENCE_PIEZA')
alter table PIEZA_COMPONENTE
   drop constraint FK_PIEZA_CO_REFERENCE_PIEZA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PIEZA_COMPONENTE') and o.name = 'FK_PIEZA_CO_REFERENCE_COMPONEN')
alter table PIEZA_COMPONENTE
   drop constraint FK_PIEZA_CO_REFERENCE_COMPONEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COMPONENTE')
            and   type = 'U')
   drop table COMPONENTE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COMPONENTE_MODULO')
            and   type = 'U')
   drop table COMPONENTE_MODULO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CROQUIS')
            and   type = 'U')
   drop table CROQUIS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MODULO')
            and   type = 'U')
   drop table MODULO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MODULO_CROQUIS')
            and   type = 'U')
   drop table MODULO_CROQUIS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PIEZA')
            and   type = 'U')
   drop table PIEZA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PIEZA_COMPONENTE')
            and   type = 'U')
   drop table PIEZA_COMPONENTE
go

/*==============================================================*/
/* Table: COMPONENTE                                            */
/*==============================================================*/
create table COMPONENTE (
   ID_COMPONENTE        numeric              not null,
   NOMBRE_COMPONENTE    varchar(15)          null,
   PRECIO_COMPONENTE    numeric(10)          null,
   FOTO1_COMPONENTE     varchar(MAX)         null,
   FOTO2_COMPONENTE     varchar(MAX)         null,
   TIPO_COMPONENTE      varchar(15)          null,
   constraint PK_COMPONENTE primary key (ID_COMPONENTE)
)
go

/*==============================================================*/
/* Table: COMPONENTE_MODULO                                     */
/*==============================================================*/
create table COMPONENTE_MODULO (
   ID_MODULO            numeric              not null,
   ID_COMPONENTE        numeric              not null,
   CANTIDAD             numeric              null,
   constraint PK_COMPONENTE_MODULO primary key (ID_MODULO, ID_COMPONENTE)
)
go

/*==============================================================*/
/* Table: CROQUIS                                               */
/*==============================================================*/
create table CROQUIS (
   ID_CROQUIS           numeric              not null,
   NOMBRE_CLIENTE       varchar(15)          null,
   FECHA                date                 null,
   PRECIO_COSTO         decimal              null,
   PRECIO_VENTA         decimal              null,
   constraint PK_CROQUIS primary key (ID_CROQUIS)
)
go

/*==============================================================*/
/* Table: MODULO                                                */
/*==============================================================*/
create table MODULO (
   ID_MODULO            numeric              not null,
   NOMBRE_MODULO        varchar(15)          null,
   ANCHO                decimal              null,
   ALTO                 decimal              null,
   FONDO                decimal              null,
   TIPO_MODULO          varchar(15)          null,
   PRECIO_MODULO        numeric              null,
   FOTO1_MODULO         varchar(max)         null,
   FOTO2_MODULO         varchar(max)         null,
   constraint PK_MODULO primary key (ID_MODULO)
)
go

/*==============================================================*/
/* Table: MODULO_CROQUIS                                        */
/*==============================================================*/
create table MODULO_CROQUIS (
   ID_MODULO            numeric              not null,
   ID_CROQUIS           numeric              not null,
   EJE_X                numeric              null,
   EJE_Y                numeric              null,
   constraint PK_MODULO_CROQUIS primary key (ID_MODULO, ID_CROQUIS)
)
go

/*==============================================================*/
/* Table: PIEZA                                                 */
/*==============================================================*/
create table PIEZA (
   ID_PIEZA             numeric              not null,
   NOMBRE_PIEZA         varchar(15)          null,
   DESCRIPCION          varchar(15)          null,
   FOTO1_PIEZA          varchar(max)         null,
   FOTO2_PIEZA          varchar(MAX)         null,
   PRECIO_PIEZA         decimal              null,
   UNIDAD_MEDIDA        numeric              null,
   constraint PK_PIEZA primary key (ID_PIEZA)
)
go

/*==============================================================*/
/* Table: PIEZA_COMPONENTE                                      */
/*==============================================================*/
create table PIEZA_COMPONENTE (
   ID_PIEZA             numeric              not null,
   ID_COMPONENTE        numeric              not null,
   CANTIDAD             numeric              null,
   constraint PK_PIEZA_COMPONENTE primary key (ID_PIEZA, ID_COMPONENTE)
)
go

alter table COMPONENTE_MODULO
   add constraint FK_COMPONEN_REFERENCE_COMPONEN foreign key (ID_COMPONENTE)
      references COMPONENTE (ID_COMPONENTE)
go

alter table COMPONENTE_MODULO
   add constraint FK_COMPONEN_REFERENCE_MODULO foreign key (ID_MODULO)
      references MODULO (ID_MODULO)
go

alter table MODULO_CROQUIS
   add constraint FK_MODULO_C_REFERENCE_MODULO foreign key (ID_MODULO)
      references MODULO (ID_MODULO)
go

alter table MODULO_CROQUIS
   add constraint FK_MODULO_C_REFERENCE_CROQUIS foreign key (ID_CROQUIS)
      references CROQUIS (ID_CROQUIS)
go

alter table PIEZA_COMPONENTE
   add constraint FK_PIEZA_CO_REFERENCE_PIEZA foreign key (ID_PIEZA)
      references PIEZA (ID_PIEZA)
go

alter table PIEZA_COMPONENTE
   add constraint FK_PIEZA_CO_REFERENCE_COMPONEN foreign key (ID_COMPONENTE)
      references COMPONENTE (ID_COMPONENTE)
go

create procedure ACTUALIZAR_COMPONENTE  @ID_COMPONENTE numeric,@NOMBRE_COMPONENTE varchar(15),@PRECIO_COMPONENTE numeric(10),@FOTO1_COMPONENTE varchar(MAX),@FOTO2_COMPONENTE varchar(MAX),@TIPO_COMPONENTE varchar(15) as
begin
update COMPONENTE
set COMPONENTE.NOMBRE_COMPONENTE = @NOMBRE_COMPONENTE, COMPONENTE.PRECIO_COMPONENTE = @PRECIO_COMPONENTE, COMPONENTE.FOTO1_COMPONENTE = @FOTO1_COMPONENTE, COMPONENTE.FOTO2_COMPONENTE = @FOTO2_COMPONENTE, COMPONENTE.TIPO_COMPONENTE = @TIPO_COMPONENTE
where (COMPONENTE.ID_COMPONENTE = @ID_COMPONENTE)
end
go

create procedure ACTUALIZAR_COMPONENTE_MODULO  @ID_MODULO numeric,@ID_COMPONENTE numeric,@CANTIDAD numeric as
begin
update COMPONENTE_MODULO
set COMPONENTE_MODULO.CANTIDAD = @CANTIDAD
where (COMPONENTE_MODULO.ID_MODULO = @ID_MODULO and COMPONENTE_MODULO.ID_COMPONENTE = @ID_COMPONENTE)
end
go

create procedure ACTUALIZAR_CROQUIS  @ID_CROQUIS numeric,@NOMBRE_CLIENTE varchar(15),@FECHA date,@PRECIO_COSTO decimal,@PRECIO_VENTA decimal as
begin
update CROQUIS
set CROQUIS.NOMBRE_CLIENTE = @NOMBRE_CLIENTE, CROQUIS.FECHA = @FECHA, CROQUIS.PRECIO_COSTO = @PRECIO_COSTO, CROQUIS.PRECIO_VENTA = @PRECIO_VENTA
where (CROQUIS.ID_CROQUIS = @ID_CROQUIS)
end
go

create procedure ACTUALIZAR_MODULO  @ID_MODULO numeric,@NOMBRE_MODULO varchar(15),@ANCHO decimal,@ALTO decimal,@FONDO decimal,@TIPO_MODULO varchar(15),@PRECIO_MODULO numeric,@FOTO1_MODULO varchar(max),@FOTO2_MODULO varchar(max) as
begin
update MODULO
set MODULO.NOMBRE_MODULO = @NOMBRE_MODULO, MODULO.ANCHO = @ANCHO, MODULO.ALTO = @ALTO, MODULO.FONDO = @FONDO, MODULO.TIPO_MODULO = @TIPO_MODULO, MODULO.PRECIO_MODULO = @PRECIO_MODULO, MODULO.FOTO1_MODULO = @FOTO1_MODULO, MODULO.FOTO2_MODULO = @FOTO2_MODULO
where (MODULO.ID_MODULO = @ID_MODULO)
end
go

create procedure ACTUALIZAR_MODULO_CROQUIS  @ID_MODULO numeric,@ID_CROQUIS numeric,@EJE_X numeric,@EJE_Y numeric as
begin
update MODULO_CROQUIS
set MODULO_CROQUIS.EJE_X = @EJE_X, MODULO_CROQUIS.EJE_Y = @EJE_Y
where (MODULO_CROQUIS.ID_MODULO = @ID_MODULO and MODULO_CROQUIS.ID_CROQUIS = @ID_CROQUIS)
end
go

create procedure ACTUALIZAR_PIEZA  @ID_PIEZA numeric,@NOMBRE_PIEZA varchar(15),@DESCRIPCION varchar(15),@FOTO1_PIEZA varchar(max),@FOTO2_PIEZA varchar(MAX),@PRECIO_PIEZA decimal,@UNIDAD_MEDIDA numeric as
begin
update PIEZA
set PIEZA.NOMBRE_PIEZA = @NOMBRE_PIEZA, PIEZA.DESCRIPCION = @DESCRIPCION, PIEZA.FOTO1_PIEZA = @FOTO1_PIEZA, PIEZA.FOTO2_PIEZA = @FOTO2_PIEZA, PIEZA.PRECIO_PIEZA = @PRECIO_PIEZA, PIEZA.UNIDAD_MEDIDA = @UNIDAD_MEDIDA
where (PIEZA.ID_PIEZA = @ID_PIEZA)
end
go

create procedure ACTUALIZAR_PIEZA_COMPONENTE  @ID_PIEZA numeric,@ID_COMPONENTE numeric,@CANTIDAD numeric as
begin
update PIEZA_COMPONENTE
set PIEZA_COMPONENTE.CANTIDAD = @CANTIDAD
where (PIEZA_COMPONENTE.ID_PIEZA = @ID_PIEZA and PIEZA_COMPONENTE.ID_COMPONENTE = @ID_COMPONENTE)
end
go

create procedure ELIMINAR_COMPONENTE  @ID_COMPONENTE numeric as
begin
delete from COMPONENTE
where COMPONENTE.ID_COMPONENTE = @ID_COMPONENTE
end
go

create procedure ELIMINAR_COMPONENTE_MODULO  @ID_MODULO numeric,@ID_COMPONENTE numeric as
begin
delete from COMPONENTE_MODULO
where COMPONENTE_MODULO.ID_MODULO = @ID_MODULO and COMPONENTE_MODULO.ID_COMPONENTE = @ID_COMPONENTE
end
go

create procedure ELIMINAR_CROQUIS  @ID_CROQUIS numeric as
begin
delete from CROQUIS
where CROQUIS.ID_CROQUIS = @ID_CROQUIS
end
go

create procedure ELIMINAR_MODULO  @ID_MODULO numeric as
begin
delete from MODULO
where MODULO.ID_MODULO = @ID_MODULO
end
go

create procedure ELIMINAR_MODULO_CROQUIS  @ID_MODULO numeric,@ID_CROQUIS numeric as
begin
delete from MODULO_CROQUIS
where MODULO_CROQUIS.ID_MODULO = @ID_MODULO and MODULO_CROQUIS.ID_CROQUIS = @ID_CROQUIS
end
go

create procedure ELIMINAR_PIEZA  @ID_PIEZA numeric as
begin
delete from PIEZA
where PIEZA.ID_PIEZA = @ID_PIEZA
end
go

create procedure ELIMINAR_PIEZA_COMPONENTE  @ID_PIEZA numeric,@ID_COMPONENTE numeric as
begin
delete from PIEZA_COMPONENTE
where PIEZA_COMPONENTE.ID_PIEZA = @ID_PIEZA and PIEZA_COMPONENTE.ID_COMPONENTE = @ID_COMPONENTE
end
go

create procedure INSERTAR_COMPONENTE  @ID_COMPONENTE numeric,@NOMBRE_COMPONENTE varchar(15),@PRECIO_COMPONENTE numeric(10),@FOTO1_COMPONENTE varchar(MAX),@FOTO2_COMPONENTE varchar(MAX),@TIPO_COMPONENTE varchar(15) as
begin
insert into COMPONENTE (COMPONENTE.ID_COMPONENTE,COMPONENTE.NOMBRE_COMPONENTE,COMPONENTE.PRECIO_COMPONENTE,COMPONENTE.FOTO1_COMPONENTE,COMPONENTE.FOTO2_COMPONENTE,COMPONENTE.TIPO_COMPONENTE)
values(@ID_COMPONENTE,@NOMBRE_COMPONENTE,@PRECIO_COMPONENTE,@FOTO1_COMPONENTE,@FOTO2_COMPONENTE,@TIPO_COMPONENTE)
end
go

create procedure INSERTAR_COMPONENT_MODULO  @ID_MODULO numeric,@ID_COMPONENTE numeric,@CANTIDAD numeric as
begin
insert into COMPONENTE_MODULO (COMPONENTE_MODULO.ID_MODULO,COMPONENTE_MODULO.ID_COMPONENTE,COMPONENTE_MODULO.CANTIDAD)
values(@ID_MODULO,@ID_COMPONENTE,@CANTIDAD)
end
go

create procedure INSERTAR_CROQUIS  @ID_CROQUIS numeric,@NOMBRE_CLIENTE varchar(15),@FECHA date,@PRECIO_COSTO decimal,@PRECIO_VENTA decimal as
begin
insert into CROQUIS (CROQUIS.ID_CROQUIS,CROQUIS.NOMBRE_CLIENTE,CROQUIS.FECHA,CROQUIS.PRECIO_COSTO,CROQUIS.PRECIO_VENTA)
values(@ID_CROQUIS,@NOMBRE_CLIENTE,@FECHA,@PRECIO_COSTO,@PRECIO_VENTA)
end
go

create procedure INSERTAR_MODULO  @ID_MODULO numeric,@NOMBRE_MODULO varchar(15),@ANCHO decimal,@ALTO decimal,@FONDO decimal,@TIPO_MODULO varchar(15),@PRECIO_MODULO numeric,@FOTO1_MODULO varchar(max),@FOTO2_MODULO varchar(max) as
begin
insert into MODULO (MODULO.ID_MODULO,MODULO.NOMBRE_MODULO,MODULO.ANCHO,MODULO.ALTO,MODULO.FONDO,MODULO.TIPO_MODULO,MODULO.PRECIO_MODULO,MODULO.FOTO1_MODULO,MODULO.FOTO2_MODULO)
values(@ID_MODULO,@NOMBRE_MODULO,@ANCHO,@ALTO,@FONDO,@TIPO_MODULO,@PRECIO_MODULO,@FOTO1_MODULO,@FOTO2_MODULO)
end
go

create procedure INSERTAR_MODULO_CROQUIS  @ID_MODULO numeric,@ID_CROQUIS numeric,@EJE_X numeric,@EJE_Y numeric as
begin
insert into MODULO_CROQUIS (MODULO_CROQUIS.ID_MODULO,MODULO_CROQUIS.ID_CROQUIS,MODULO_CROQUIS.EJE_X,MODULO_CROQUIS.EJE_Y)
values(@ID_MODULO,@ID_CROQUIS,@EJE_X,@EJE_Y)
end
go

create procedure INSERTAR_PIEZA  @ID_PIEZA numeric,@NOMBRE_PIEZA varchar(15),@DESCRIPCION varchar(15),@FOTO1_PIEZA varchar(max),@FOTO2_PIEZA varchar(MAX),@PRECIO_PIEZA decimal,@UNIDAD_MEDIDA numeric as
begin
insert into PIEZA (PIEZA.ID_PIEZA,PIEZA.NOMBRE_PIEZA,PIEZA.DESCRIPCION,PIEZA.FOTO1_PIEZA,PIEZA.FOTO2_PIEZA,PIEZA.PRECIO_PIEZA,PIEZA.UNIDAD_MEDIDA)
values(@ID_PIEZA,@NOMBRE_PIEZA,@DESCRIPCION,@FOTO1_PIEZA,@FOTO2_PIEZA,@PRECIO_PIEZA,@UNIDAD_MEDIDA)
end
go

create procedure INSERTAR_PIEZA_COMPONENTE  @ID_PIEZA numeric,@ID_COMPONENTE numeric,@CANTIDAD numeric as
begin
insert into PIEZA_COMPONENTE (PIEZA_COMPONENTE.ID_PIEZA,PIEZA_COMPONENTE.ID_COMPONENTE,PIEZA_COMPONENTE.CANTIDAD)
values(@ID_PIEZA,@ID_COMPONENTE,@CANTIDAD)
end
go

