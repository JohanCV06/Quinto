/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     24/07/2018 14:59:03                          */
/*==============================================================*/


if exists (select 1
          from sysobjects
          where  id = object_id('ACTUALIZAR_COMPONENTE')
          and type in ('P','PC'))
   drop procedure ACTUALIZAR_COMPONENTE
go

if exists (select 1
          from sysobjects
          where  id = object_id('ACTUALIZAR_COMPONENTEMODULO')
          and type in ('P','PC'))
   drop procedure ACTUALIZAR_COMPONENTEMODULO
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
          where  id = object_id('ACTUALIZAR_MODULOCROQUIS')
          and type in ('P','PC'))
   drop procedure ACTUALIZAR_MODULOCROQUIS
go

if exists (select 1
          from sysobjects
          where  id = object_id('ACTUALIZAR_PIEZA')
          and type in ('P','PC'))
   drop procedure ACTUALIZAR_PIEZA
go

if exists (select 1
          from sysobjects
          where  id = object_id('ACTUALIZAR_PIEZACOMPONENTE')
          and type in ('P','PC'))
   drop procedure ACTUALIZAR_PIEZACOMPONENTE
go

if exists (select 1
          from sysobjects
          where  id = object_id('ELIMINAR_COMPONENTE')
          and type in ('P','PC'))
   drop procedure ELIMINAR_COMPONENTE
go

if exists (select 1
          from sysobjects
          where  id = object_id('ELIMINAR_COMPONENTEMODULO')
          and type in ('P','PC'))
   drop procedure ELIMINAR_COMPONENTEMODULO
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
          where  id = object_id('ELIMINAR_MODULOCROQUIS')
          and type in ('P','PC'))
   drop procedure ELIMINAR_MODULOCROQUIS
go

if exists (select 1
          from sysobjects
          where  id = object_id('ELIMINAR_PIEZA')
          and type in ('P','PC'))
   drop procedure ELIMINAR_PIEZA
go

if exists (select 1
          from sysobjects
          where  id = object_id('ELIMINAR_PIEZACOMPONENTE')
          and type in ('P','PC'))
   drop procedure ELIMINAR_PIEZACOMPONENTE
go

if exists (select 1
          from sysobjects
          where  id = object_id('INSERTAR_COMPONENTE')
          and type in ('P','PC'))
   drop procedure INSERTAR_COMPONENTE
go

if exists (select 1
          from sysobjects
          where  id = object_id('INSERTAR_COMPONENTEMODULO')
          and type in ('P','PC'))
   drop procedure INSERTAR_COMPONENTEMODULO
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
          where  id = object_id('INSERTAR_MODULOCROQUIS')
          and type in ('P','PC'))
   drop procedure INSERTAR_MODULOCROQUIS
go

if exists (select 1
          from sysobjects
          where  id = object_id('INSERTAR_PIEZA')
          and type in ('P','PC'))
   drop procedure INSERTAR_PIEZA
go

if exists (select 1
          from sysobjects
          where  id = object_id('INSERTAR_PIEZACOMPONENTE')
          and type in ('P','PC'))
   drop procedure INSERTAR_PIEZACOMPONENTE
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
   where r.fkeyid = object_id('MODULO_CROQUIS') and o.name = 'FK_MODULO_C_REFERENCE_CROQUIS')
alter table MODULO_CROQUIS
   drop constraint FK_MODULO_C_REFERENCE_CROQUIS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MODULO_CROQUIS') and o.name = 'FK_MODULO_C_REFERENCE_MODULO')
alter table MODULO_CROQUIS
   drop constraint FK_MODULO_C_REFERENCE_MODULO
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
   ID_COMPONENTE        numeric(20)          not null,
   NOMBRE               varchar(25)          null,
   PRECIO               decimal(9,2)         null,
   FOTO_PARTE1          varchar(Max)         null,
   FOTO_PARTE2          varchar(Max)         null,
   TIPO                 varchar(50)          null,
   constraint PK_COMPONENTE primary key (ID_COMPONENTE)
)
go

/*==============================================================*/
/* Table: COMPONENTE_MODULO                                     */
/*==============================================================*/
create table COMPONENTE_MODULO (
   ID_COMPONENTE        numeric(20)          not null,
   ID_MODULO            numeric(20)          not null,
   CANTIDAD             numeric(5)           null,
   constraint PK_COMPONENTE_MODULO primary key (ID_COMPONENTE, ID_MODULO)
)
go

/*==============================================================*/
/* Table: CROQUIS                                               */
/*==============================================================*/
create table CROQUIS (
   ID_CROQUIS           numeric(20)          not null,
   NOMBRE_CLIENTE       varchar(50)          null,
   FECHA                datetime             null,
   PRECIO_COSTO         decimal(9,2)         null,
   PRECIO_VENTA         decimal(9,2)         null,
   constraint PK_CROQUIS primary key (ID_CROQUIS)
)
go

/*==============================================================*/
/* Table: MODULO                                                */
/*==============================================================*/
create table MODULO (
   ID_MODULO            numeric(20)          not null,
   NOMBRE               varchar(25)          null,
   ANCHO_MM             decimal(9,2)         null,
   ALTO_MM              decimal(9,2)         null,
   PROFUNDIDAD_MM       decimal(9,2)         null,
   TIPO                 varchar(50)          null,
   PRECIO               decimal(9,2)         null,
   FOTO_PARTE1          varchar(Max)         null,
   FOTO_PARTE2          varchar(Max)         null,
   constraint PK_MODULO primary key (ID_MODULO)
)
go

/*==============================================================*/
/* Table: MODULO_CROQUIS                                        */
/*==============================================================*/
create table MODULO_CROQUIS (
   ID_MODULO            numeric(20)          not null,
   ID_CROQUIS           numeric(20)          not null,
   EJE_X                decimal(9,2)         null,
   EJE_Y                decimal(9,2)         null,
   constraint PK_MODULO_CROQUIS primary key (ID_MODULO, ID_CROQUIS)
)
go

/*==============================================================*/
/* Table: PIEZA                                                 */
/*==============================================================*/
create table PIEZA (
   ID_PIEZA             numeric(20)          not null,
   NOMBRE               varchar(25)          null,
   DESCRIPCION          varchar(50)          null,
   FOTO_PARTE1          varchar(max)         null,
   FOTO_PARTE2          varchar(max)         null,
   PRECIO               decimal(9,2)         null,
   UNIDAD_MEDIDA        varchar(15)          null,
   constraint PK_PIEZA primary key (ID_PIEZA)
)
go

/*==============================================================*/
/* Table: PIEZA_COMPONENTE                                      */
/*==============================================================*/
create table PIEZA_COMPONENTE (
   ID_PIEZA             numeric(20)          not null,
   ID_COMPONENTE        numeric(20)          not null,
   CANTIDAD             numeric(5)           null,
   constraint PK_PIEZA_COMPONENTE primary key (ID_PIEZA, ID_COMPONENTE)
)
go

alter table COMPONENTE_MODULO
   add constraint FK_COMPONEN_REFERENCE_COMPONEN foreign key (ID_COMPONENTE)
      references COMPONENTE (ID_COMPONENTE)
         on delete set default
go

alter table COMPONENTE_MODULO
   add constraint FK_COMPONEN_REFERENCE_MODULO foreign key (ID_MODULO)
      references MODULO (ID_MODULO)
         on delete set default
go

alter table MODULO_CROQUIS
   add constraint FK_MODULO_C_REFERENCE_CROQUIS foreign key (ID_CROQUIS)
      references CROQUIS (ID_CROQUIS)
         on delete set default
go

alter table MODULO_CROQUIS
   add constraint FK_MODULO_C_REFERENCE_MODULO foreign key (ID_MODULO)
      references MODULO (ID_MODULO)
         on delete set default
go

alter table PIEZA_COMPONENTE
   add constraint FK_PIEZA_CO_REFERENCE_PIEZA foreign key (ID_PIEZA)
      references PIEZA (ID_PIEZA)
         on delete set default
go

alter table PIEZA_COMPONENTE
   add constraint FK_PIEZA_CO_REFERENCE_COMPONEN foreign key (ID_COMPONENTE)
      references COMPONENTE (ID_COMPONENTE)
         on delete set default
go

create procedure ACTUALIZAR_COMPONENTE  @ID_COMPONENTE numeric(20),@NOMBRE varchar(25),@PRECIO decimal(9,2),@FOTO_PARTE1 varchar(Max),@FOTO_PARTE2 varchar(Max),@TIPO varchar(50) as
begin
update COMPONENTE
set COMPONENTE.NOMBRE = @NOMBRE, COMPONENTE.PRECIO = @PRECIO, COMPONENTE.FOTO_PARTE1 = @FOTO_PARTE1, COMPONENTE.FOTO_PARTE2 = @FOTO_PARTE2, COMPONENTE.TIPO = @TIPO
where (COMPONENTE.ID_COMPONENTE = @ID_COMPONENTE)
end
go

create procedure ACTUALIZAR_COMPONENTEMODULO  @ID_COMPONENTE numeric(20),@ID_MODULO numeric(20),@CANTIDAD numeric(5) as
begin
update COMPONENTE_MODULO
set COMPONENTE_MODULO.CANTIDAD = @CANTIDAD
where (COMPONENTE_MODULO.ID_COMPONENTE = @ID_COMPONENTE and COMPONENTE_MODULO.ID_MODULO = @ID_MODULO)
end
go

create procedure ACTUALIZAR_CROQUIS  @ID_CROQUIS numeric(20),@NOMBRE_CLIENTE varchar(50),@FECHA datetime,@PRECIO_COSTO decimal(9,2),@PRECIO_VENTA decimal(9,2) as
begin
update CROQUIS
set CROQUIS.NOMBRE_CLIENTE = @NOMBRE_CLIENTE, CROQUIS.FECHA = @FECHA, CROQUIS.PRECIO_COSTO = @PRECIO_COSTO, CROQUIS.PRECIO_VENTA = @PRECIO_VENTA
where (CROQUIS.ID_CROQUIS = @ID_CROQUIS)
end
go

create procedure ACTUALIZAR_MODULO  @ID_MODULO numeric(20),@NOMBRE varchar(25),@ANCHO_MM decimal(9,2),@ALTO_MM decimal(9,2),@PROFUNDIDAD_MM decimal(9,2),@TIPO varchar(50),@PRECIO decimal(9,2),@FOTO_PARTE1 varchar(Max),@FOTO_PARTE2 varchar(Max) as
begin
update MODULO
set MODULO.NOMBRE = @NOMBRE, MODULO.ANCHO_MM = @ANCHO_MM, MODULO.ALTO_MM = @ALTO_MM, MODULO.PROFUNDIDAD_MM = @PROFUNDIDAD_MM, MODULO.TIPO = @TIPO, MODULO.PRECIO = @PRECIO, MODULO.FOTO_PARTE1 = @FOTO_PARTE1, MODULO.FOTO_PARTE2 = @FOTO_PARTE2
where (MODULO.ID_MODULO = @ID_MODULO)
end
go

create procedure ACTUALIZAR_MODULOCROQUIS  @ID_MODULO numeric(20),@ID_CROQUIS numeric(20),@EJE_X decimal(9,2),@EJE_Y decimal(9,2) as
begin
update MODULO_CROQUIS
set MODULO_CROQUIS.EJE_X = @EJE_X, MODULO_CROQUIS.EJE_Y = @EJE_Y
where (MODULO_CROQUIS.ID_MODULO = @ID_MODULO and MODULO_CROQUIS.ID_CROQUIS = @ID_CROQUIS)
end
go

create procedure ACTUALIZAR_PIEZA  @ID_PIEZA numeric(20),@NOMBRE varchar(25),@DESCRIPCION varchar(50),@FOTO_PARTE1 varchar(max),@FOTO_PARTE2 varchar(max),@PRECIO decimal(9,2),@UNIDAD_MEDIDA varchar(15) as
begin
update PIEZA
set PIEZA.NOMBRE = @NOMBRE, PIEZA.DESCRIPCION = @DESCRIPCION, PIEZA.FOTO_PARTE1 = @FOTO_PARTE1, PIEZA.FOTO_PARTE2 = @FOTO_PARTE2, PIEZA.PRECIO = @PRECIO, PIEZA.UNIDAD_MEDIDA = @UNIDAD_MEDIDA
where (PIEZA.ID_PIEZA = @ID_PIEZA)
end
go

create procedure ACTUALIZAR_PIEZACOMPONENTE  @ID_PIEZA numeric(20),@ID_COMPONENTE numeric(20),@CANTIDAD numeric(5) as
begin
update PIEZA_COMPONENTE
set PIEZA_COMPONENTE.CANTIDAD = @CANTIDAD
where (PIEZA_COMPONENTE.ID_PIEZA = @ID_PIEZA and PIEZA_COMPONENTE.ID_COMPONENTE = @ID_COMPONENTE)
end
go

create procedure ELIMINAR_COMPONENTE  @ID_COMPONENTE numeric(20) as
begin
delete from COMPONENTE
where COMPONENTE.ID_COMPONENTE = @ID_COMPONENTE
end
go

create procedure ELIMINAR_COMPONENTEMODULO  @ID_COMPONENTE numeric(20),@ID_MODULO numeric(20) as
begin
delete from COMPONENTE_MODULO
where COMPONENTE_MODULO.ID_COMPONENTE = @ID_COMPONENTE and COMPONENTE_MODULO.ID_MODULO = @ID_MODULO
end
go

create procedure ELIMINAR_CROQUIS  @ID_CROQUIS numeric(20) as
begin
delete from CROQUIS
where CROQUIS.ID_CROQUIS = @ID_CROQUIS
end
go

create procedure ELIMINAR_MODULO  @ID_MODULO numeric(20) as
begin
delete from MODULO
where MODULO.ID_MODULO = @ID_MODULO
end
go

create procedure ELIMINAR_MODULOCROQUIS  @ID_MODULO numeric(20),@ID_CROQUIS numeric(20) as
begin
delete from MODULO_CROQUIS
where MODULO_CROQUIS.ID_MODULO = @ID_MODULO and MODULO_CROQUIS.ID_CROQUIS = @ID_CROQUIS
end
go

create procedure ELIMINAR_PIEZA  @ID_PIEZA numeric(20) as
begin
delete from PIEZA
where PIEZA.ID_PIEZA = @ID_PIEZA
end
go

create procedure ELIMINAR_PIEZACOMPONENTE  @ID_PIEZA numeric(20),@ID_COMPONENTE numeric(20) as
begin
delete from PIEZA_COMPONENTE
where PIEZA_COMPONENTE.ID_PIEZA = @ID_PIEZA and PIEZA_COMPONENTE.ID_COMPONENTE = @ID_COMPONENTE
end
go

create procedure INSERTAR_COMPONENTE  @ID_COMPONENTE numeric(20),@NOMBRE varchar(25),@PRECIO decimal(9,2),@FOTO_PARTE1 varchar(Max),@FOTO_PARTE2 varchar(Max),@TIPO varchar(50) as
begin
insert into COMPONENTE (COMPONENTE.ID_COMPONENTE,COMPONENTE.NOMBRE,COMPONENTE.PRECIO,COMPONENTE.FOTO_PARTE1,COMPONENTE.FOTO_PARTE2,COMPONENTE.TIPO)
values(@ID_COMPONENTE,@NOMBRE,@PRECIO,@FOTO_PARTE1,@FOTO_PARTE2,@TIPO)
end
go

create procedure INSERTAR_COMPONENTEMODULO  @ID_COMPONENTE numeric(20),@ID_MODULO numeric(20),@CANTIDAD numeric(5) as
begin
insert into COMPONENTE_MODULO (COMPONENTE_MODULO.ID_COMPONENTE,COMPONENTE_MODULO.ID_MODULO,COMPONENTE_MODULO.CANTIDAD)
values(@ID_COMPONENTE,@ID_MODULO,@CANTIDAD)
end
go

create procedure INSERTAR_CROQUIS  @ID_CROQUIS numeric(20),@NOMBRE_CLIENTE varchar(50),@FECHA datetime,@PRECIO_COSTO decimal(9,2),@PRECIO_VENTA decimal(9,2) as
begin
insert into CROQUIS (CROQUIS.ID_CROQUIS,CROQUIS.NOMBRE_CLIENTE,CROQUIS.FECHA,CROQUIS.PRECIO_COSTO,CROQUIS.PRECIO_VENTA)
values(@ID_CROQUIS,@NOMBRE_CLIENTE,@FECHA,@PRECIO_COSTO,@PRECIO_VENTA)
end
go

create procedure INSERTAR_MODULO  @ID_MODULO numeric(20),@NOMBRE varchar(25),@ANCHO_MM decimal(9,2),@ALTO_MM decimal(9,2),@PROFUNDIDAD_MM decimal(9,2),@TIPO varchar(50),@PRECIO decimal(9,2),@FOTO_PARTE1 varchar(Max),@FOTO_PARTE2 varchar(Max) as
begin
insert into MODULO (MODULO.ID_MODULO,MODULO.NOMBRE,MODULO.ANCHO_MM,MODULO.ALTO_MM,MODULO.PROFUNDIDAD_MM,MODULO.TIPO,MODULO.PRECIO,MODULO.FOTO_PARTE1,MODULO.FOTO_PARTE2)
values(@ID_MODULO,@NOMBRE,@ANCHO_MM,@ALTO_MM,@PROFUNDIDAD_MM,@TIPO,@PRECIO,@FOTO_PARTE1,@FOTO_PARTE2)
end
go

create procedure INSERTAR_MODULOCROQUIS  @ID_MODULO numeric(20),@ID_CROQUIS numeric(20),@EJE_X decimal(9,2),@EJE_Y decimal(9,2) as
begin
insert into MODULO_CROQUIS (MODULO_CROQUIS.ID_MODULO,MODULO_CROQUIS.ID_CROQUIS,MODULO_CROQUIS.EJE_X,MODULO_CROQUIS.EJE_Y)
values(@ID_MODULO,@ID_CROQUIS,@EJE_X,@EJE_Y)
end
go

create procedure INSERTAR_PIEZA  @ID_PIEZA numeric(20),@NOMBRE varchar(25),@DESCRIPCION varchar(50),@FOTO_PARTE1 varchar(max),@FOTO_PARTE2 varchar(max),@PRECIO decimal(9,2),@UNIDAD_MEDIDA varchar(15) as
begin
insert into PIEZA (PIEZA.ID_PIEZA,PIEZA.NOMBRE,PIEZA.DESCRIPCION,PIEZA.FOTO_PARTE1,PIEZA.FOTO_PARTE2,PIEZA.PRECIO,PIEZA.UNIDAD_MEDIDA)
values(@ID_PIEZA,@NOMBRE,@DESCRIPCION,@FOTO_PARTE1,@FOTO_PARTE2,@PRECIO,@UNIDAD_MEDIDA)
end
go

create procedure INSERTAR_PIEZACOMPONENTE  @ID_PIEZA numeric(20),@ID_COMPONENTE numeric(20),@CANTIDAD numeric(5) as
begin
insert into PIEZA_COMPONENTE (PIEZA_COMPONENTE.ID_PIEZA,PIEZA_COMPONENTE.ID_COMPONENTE,PIEZA_COMPONENTE.CANTIDAD)
values(@ID_PIEZA,@ID_COMPONENTE,@CANTIDAD)
end
go

