USE [pollos]
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 04/05/2013 15:37:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[proveedor](
	[NITpro] [varchar](20) NOT NULL,
	[nombre] [varchar](50) NULL,
	[telefono] [varchar](20) NULL,
	[direccion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[NITpro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[producto]    Script Date: 04/05/2013 15:37:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[producto](
	[cod_art] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](max) NULL,
	[unidad_medida] [varchar](100) NULL,
	[precio_unidad] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_art] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 04/05/2013 15:37:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[cod_cli] [int] IDENTITY(1,1) NOT NULL,
	[ci] [varchar](10) NULL,
	[nombre] [varchar](100) NULL,
	[telefono] [varchar](20) NULL,
	[direccion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_cli] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[proveedor_existe]    Script Date: 04/05/2013 15:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proveedor_existe]
@nit varchar(20),
@existe varchar(10) output
as 
if exists(select * from proveedor where(NITpro=@nit))
begin
	set @existe='TRUE'
end
else
begin
	set @existe='FALSE'
end
GO
/****** Object:  StoredProcedure [dbo].[proveedor_buscar]    Script Date: 04/05/2013 15:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proveedor_buscar]
@nit varchar(10)
as
select * from proveedor
where(NITpro like '%' + @nit + '%')
GO
/****** Object:  StoredProcedure [dbo].[update_proveedor]    Script Date: 04/05/2013 15:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_proveedor]
(
	@nombre varchar(50),
	@telefono varchar(20),
	@direccion varchar(100),
	@Original_NITpro varchar(20)
)
AS
	SET NOCOUNT OFF;
UPDATE       proveedor
SET                nombre = @nombre, telefono = @telefono, direccion = @direccion
WHERE        (NITpro = @Original_NITpro)
GO
/****** Object:  Table [dbo].[gastos]    Script Date: 04/05/2013 15:37:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[gastos](
	[cod_gasto] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](max) NULL,
	[precio_gasto] [float] NULL,
	[fecha_gasto] [datetime] NULL,
	[cod_prod] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_gasto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[deposito]    Script Date: 04/05/2013 15:37:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[deposito](
	[cod_depo] [int] IDENTITY(1,1) NOT NULL,
	[cod_art] [int] NULL,
	[cantidad_ingreso] [int] NULL,
	[cantidad_salida] [int] NULL,
	[cantidad_saldo] [int] NULL,
	[fecha_ingreso] [datetime] NULL,
	[precio_compra] [float] NULL,
	[precio_unidad] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_depo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compra]    Script Date: 04/05/2013 15:37:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[compra](
	[nitpro] [varchar](20) NULL,
	[cod_art] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[cliente_existe]    Script Date: 04/05/2013 15:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[cliente_existe]
@ci varchar(20),
@existe varchar(10) output
as
if exists(select * from cliente where(ci=@ci))
begin
	set @existe='TRUE'
end
else
begin
	set @existe='FALSE'
end
GO
/****** Object:  StoredProcedure [dbo].[cliente_buscar]    Script Date: 04/05/2013 15:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[cliente_buscar]
@nombre varchar(10)
as
select * from cliente
where(ci like '%' + @nombre + '%' or nombre like '%' + @nombre + '%')
GO
/****** Object:  StoredProcedure [dbo].[pollos_registrar]    Script Date: 04/05/2013 15:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pollos_registrar]
@nit varchar(20),
@precio_compra float,
@canidad int,
@precio_uni float
as
begin transaction
	insert into compra values(@nit, 1)
	insert into deposito values(1, @canidad, 0, @canidad, GETDATE(), @precio_compra, @precio_uni)
if @@ERROR = 0
begin
	commit transaction
end
else
begin
	rollback transaction
end
GO
/****** Object:  StoredProcedure [dbo].[cambiar_precio]    Script Date: 04/05/2013 15:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[cambiar_precio]
@cod_depo int,
@precio float
as
update deposito set precio_unidad=@precio
where(cod_depo=@cod_depo)
GO
/****** Object:  View [dbo].[almacen]    Script Date: 04/05/2013 15:37:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[almacen]
as
select
d.cod_depo, p.descripcion, p.unidad_medida, d.precio_unidad, (CONVERT(varchar(50), d.cantidad_saldo) + ' Kilogramos') as Stock, d.fecha_ingreso,d.cantidad_saldo
from deposito d inner join producto p
on p.cod_art=d.cod_art
where(d.cantidad_saldo > 0)
GO
/****** Object:  StoredProcedure [dbo].[total_pollos]    Script Date: 04/05/2013 15:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[total_pollos]
@mes int,
@año int,
@totalpollos float output
as
if exists(select * from deposito where(DATEPART(YEAR, fecha_ingreso)=@año and DATEPART(month, fecha_ingreso)=@mes))
begin
	set @totalpollos = (select sum(precio_compra) from deposito where(DATEPART(YEAR, fecha_ingreso)=@año and DATEPART(month,fecha_ingreso)=@mes))
end
else
begin
	set @totalpollos = 0
end
GO
/****** Object:  StoredProcedure [dbo].[total_gasto]    Script Date: 04/05/2013 15:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[total_gasto]
@mes int,
@año int,
@totalgasto float output
as
if exists(select * from gastos where(DATEPART(YEAR, fecha_gasto)=@año and DATEPART(month,fecha_gasto)=@mes))
begin
	set @totalgasto = (select sum(precio_gasto) from gastos where(DATEPART(YEAR, fecha_gasto)=@año and DATEPART(month,fecha_gasto)=@mes))
end
else
begin
	set @totalgasto = 0
end
GO
/****** Object:  Table [dbo].[venta]    Script Date: 04/05/2013 15:37:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta](
	[cod_venta] [int] IDENTITY(1,1) NOT NULL,
	[cod_cliente] [int] NULL,
	[cod_depo] [int] NULL,
	[fecha_venta] [datetime] NULL,
	[cantidad] [int] NULL,
	[costototal] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_venta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[report_gasto]    Script Date: 04/05/2013 15:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[report_gasto]
@mes int,
@año int
as
(select *from gastos  where (DATEPART(YEAR, fecha_gasto)=@año and DATEPART(month,fecha_gasto)=@mes))
GO
/****** Object:  StoredProcedure [dbo].[venta_registro]    Script Date: 04/05/2013 15:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[venta_registro]
@cod_cli int,
@cod_dep int,
@peso float,
@precio_venta float
as
begin transaction
	insert into venta values(@cod_cli, @cod_dep, GETDATE(), @peso, @precio_venta)
	update deposito set cantidad_salida=cantidad_salida + @peso, cantidad_saldo=cantidad_saldo-@peso where(cod_depo=@cod_dep)
if @@ERROR = 0
begin
	commit transaction
end
else
begin
	rollback transaction
end
GO
/****** Object:  StoredProcedure [dbo].[total_venta]    Script Date: 04/05/2013 15:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[total_venta]
@mes int,
@año int,
@totalventa float output
as
if exists(select * from venta where(DATEPART(YEAR, fecha_venta)=@año and DATEPART(month,fecha_venta)=@mes))
begin
	set @totalventa = (select sum(costototal) from venta where(DATEPART(YEAR, fecha_venta)=@año and DATEPART(month,fecha_venta)=@mes))
end
else
begin
	set @totalventa = 0
end
GO
/****** Object:  View [dbo].[reporte_ventas]    Script Date: 04/05/2013 15:37:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[reporte_ventas]
as
select p.descripcion, p.unidad_medida,p.precio_unidad, v.cantidad,v.costototal, v.fecha_venta  
from  producto p, deposito d, venta v where v.cod_depo = d.cod_depo and   d.cod_art = p.cod_art
GO
/****** Object:  StoredProcedure [dbo].[report_venta]    Script Date: 04/05/2013 15:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[report_venta]
@mes int,
@año int

as
(select *from reporte_ventas  where (DATEPART(YEAR, fecha_venta)=@año and DATEPART(month,fecha_venta)=@mes))
GO
/****** Object:  ForeignKey [FK__compra__cod_art__20C1E124]    Script Date: 04/05/2013 15:37:53 ******/
ALTER TABLE [dbo].[compra]  WITH CHECK ADD FOREIGN KEY([cod_art])
REFERENCES [dbo].[producto] ([cod_art])
GO
/****** Object:  ForeignKey [FK__compra__nitpro__21B6055D]    Script Date: 04/05/2013 15:37:53 ******/
ALTER TABLE [dbo].[compra]  WITH CHECK ADD FOREIGN KEY([nitpro])
REFERENCES [dbo].[proveedor] ([NITpro])
GO
/****** Object:  ForeignKey [FK__deposito__cod_ar__22AA2996]    Script Date: 04/05/2013 15:37:53 ******/
ALTER TABLE [dbo].[deposito]  WITH CHECK ADD FOREIGN KEY([cod_art])
REFERENCES [dbo].[producto] ([cod_art])
GO
/****** Object:  ForeignKey [FK__gastos__cod_prod__239E4DCF]    Script Date: 04/05/2013 15:37:53 ******/
ALTER TABLE [dbo].[gastos]  WITH CHECK ADD FOREIGN KEY([cod_prod])
REFERENCES [dbo].[producto] ([cod_art])
GO
/****** Object:  ForeignKey [FK__venta__cod_clien__24927208]    Script Date: 04/05/2013 15:37:53 ******/
ALTER TABLE [dbo].[venta]  WITH CHECK ADD FOREIGN KEY([cod_cliente])
REFERENCES [dbo].[cliente] ([cod_cli])
GO
/****** Object:  ForeignKey [FK__venta__cod_depo__25869641]    Script Date: 04/05/2013 15:37:53 ******/
ALTER TABLE [dbo].[venta]  WITH CHECK ADD FOREIGN KEY([cod_depo])
REFERENCES [dbo].[deposito] ([cod_depo])
GO
