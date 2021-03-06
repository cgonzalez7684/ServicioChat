USE [FirmaDigital]
GO
/****** Object:  Table [dbo].[Paquetes]    Script Date: 10/26/2015 13:58:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paquetes](
	[IdPaquete] [int] IDENTITY(1,1) NOT NULL,
	[DescPaquete] [varchar](200) NULL,
	[IdUsuario] [varchar](50) NULL,
	[DtFechaReg] [datetime] NULL,
	[IdEstado] [int] NULL,
	[RutaServidor] [varchar](150) NULL,
	[IdUrgencia] [int] NOT NULL,
	[DtFechaLimite] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPaquete] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Firmantes]    Script Date: 10/26/2015 13:58:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Firmantes](
	[IdPaquete] [int] NOT NULL,
	[IdDocumento] [int] NOT NULL,
	[NomFirmante] [varchar](100) NOT NULL,
	[IdFirmante] [varchar](100) NOT NULL,
	[DtFechaFirma] [datetime] NULL,
	[StrCorreo] [varchar](100) NULL,
	[IdEstado] [int] NULL,
	[IdTipoPersona] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPaquete] ASC,
	[IdDocumento] ASC,
	[IdFirmante] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EstadoPaquetes]    Script Date: 10/26/2015 13:58:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EstadoPaquetes](
	[IdEstado] [int] IDENTITY(1,1) NOT NULL,
	[DescEstado] [varchar](50) NOT NULL,
	[IdActivo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEstado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Documentos]    Script Date: 10/26/2015 13:58:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Documentos](
	[IdPaquete] [int] NOT NULL,
	[IdDocumento] [int] NOT NULL,
	[NomDocumento] [varchar](50) NOT NULL,
	[IdTipo] [int] NULL,
	[DtFechaReg] [datetime] NOT NULL,
	[RutaLocal] [varchar](150) NOT NULL,
	[NomTecnico] [varchar](max) NOT NULL,
	[NomMaquina] [varchar](max) NOT NULL,
	[DocBinary] [varbinary](max) NOT NULL,
	[ExtArchivo] [varchar](4) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPaquete] ASC,
	[IdDocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 10/26/2015 13:58:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamentos](
	[IdDepartamento] [int] IDENTITY(1,1) NOT NULL,
	[DescDepartamento] [varchar](100) NOT NULL,
	[DtFechaReg] [datetime] NOT NULL,
	[IdUsuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDepartamento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CommentSeguimiento]    Script Date: 10/26/2015 13:58:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CommentSeguimiento](
	[IdPaquete] [int] NOT NULL,
	[IdDocumento] [int] NOT NULL,
	[IdFirmante] [varchar](100) NOT NULL,
	[IdUsuarioComenta] [varchar](50) NOT NULL,
	[DtFechaComentario] [datetime] NOT NULL,
	[Seguimiento] [varchar](500) NOT NULL,
	[crevisado] [int] NOT NULL,
	[nNotifica] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 10/26/2015 13:58:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bitacora](
	[IdBitacora] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [varchar](50) NOT NULL,
	[NomMaquina] [varchar](max) NOT NULL,
	[IdPaquete] [int] NOT NULL,
	[Referencia] [varchar](max) NOT NULL,
	[DtFechaMovi] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdBitacora] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Archivos]    Script Date: 10/26/2015 13:58:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Archivos](
	[doc] [varbinary](max) NULL,
	[nombre] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposDocumentos]    Script Date: 10/26/2015 13:58:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposDocumentos](
	[IdTipo] [int] IDENTITY(1,1) NOT NULL,
	[IdDepartamento] [int] NOT NULL,
	[DescTipo] [varchar](150) NOT NULL,
	[DtFechaReg] [datetime] NOT NULL,
	[IdUsuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipo] ASC,
	[IdDepartamento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[proc_Consulta_Documentos_General]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/********************************************************************************************/
/* PROGRAMADOR    : Carlos González													        */
/* FECHA CREACION : 20-MARZO-2015															*/
/* PROCEDIMIENTO  : proc_Consulta_Documentos_General									    */
/* OBJETIVO       : Realizar consultas de los documentos general							*/
/* ENTRADAS       :																			*/
/* SALIDAS		  :																			*/
/********************************************************************************************/
          

CREATE procedure [dbo].[proc_Consulta_Documentos_General]
@Criterios VARCHAR(MAX)


As

Begin

Declare @CONSULTA NVARCHAR(MAX)

set @CONSULTA = '

select 
		Paquetes.IdUsuario,
		Paquetes.DtFechaLimite,
		case when Paquetes.IdUrgencia = 0 then ''Baja''
			 when Paquetes.IdUrgencia = 1 then ''Media''
			 when Paquetes.IdUrgencia = 2 then ''Alta''
		end as ''IdUrgencia'',		
		documentos.idPaquete,
		documentos.idDocumento,
		documentos.NomDocumento, 
		documentos.RutaLocal,
		Paquetes.RutaServidor,
		Documentos.NomTecnico,
		Documentos.NomMaquina,
		case when Firmantes.IdEstado = 0 then ''Pendiente''
		     when Firmantes.IdEstado = 1 then ''Firmado''		
		     when Firmantes.IdEstado = 2 then ''Rechazado''
		     when Firmantes.IdEstado = 3 then ''Cancelado''
		 end as ''IdEstado'',
		Firmantes.DtFechaFirma,
		isNull((select top 1 0 from CommentSeguimiento 
			where IdPaquete = Firmantes.IdPaquete and IdDocumento = Firmantes.IdDocumento 
				  and IdFirmante = Firmantes.IdFirmante and IdFirmante <> IdUsuarioComenta and crevisado = 0),1) as ''CommentRevisado'',
		firmantes.IdTipoPersona as ''IdTipoPersona'' 
	from 
		Paquetes 
			inner join	documentos on Paquetes.IdPaquete = Documentos.IdPaquete
			inner join firmantes on documentos.iddocumento = firmantes.iddocumento 
		                            and documentos.idpaquete = firmantes.idpaquete
	where '+@Criterios+'		
	Order by Paquetes.DtFechaReg desc
	return

'



EXECUTE sp_executesql @CONSULTA


End
GO
/****** Object:  StoredProcedure [dbo].[UploadDoc]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UploadDoc] 
@doc varbinary (max), @nombre varchar (100) as begin insert into Archivos values(@doc, @nombre) end
GO
/****** Object:  StoredProcedure [dbo].[proc_Consulta_Documentos_Firmar]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/********************************************************************************************/
/* PROGRAMADOR    : Carlos Fonseca													        */
/* FECHA CREACION : 21-SETIEMBRE-2015														*/
/* PROCEDIMIENTO  : proc_Consulta_Documentos_Firmar										    */
/* OBJETIVO       : Hace un conteo de la cantidad de documentos pendientes de firmar     	*/
/* ENTRADAS       :																			*/
/* SALIDAS		  :																			*/
/********************************************************************************************/



CREATE procedure [dbo].[proc_Consulta_Documentos_Firmar]
@IdFirmante char(20) = ''

As

Begin


	select 
		COUNT(*)
	from 
			Paquetes 
			inner join	documentos on Paquetes.IdPaquete = Documentos.IdPaquete
			inner join firmantes on documentos.iddocumento = firmantes.iddocumento 
		                            and documentos.idpaquete = firmantes.idpaquete
	where 
		idfirmante = @IdFirmante 
		AND firmantes.IdEstado = 0
 

End
GO
/****** Object:  StoredProcedure [dbo].[proc_Consulta_Documentos]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/********************************************************************************************/
/* PROGRAMADOR    : Carlos González Romero													*/
/* FECHA CREACION : 08-FEBRERO-2015															*/
/* PROCEDIMIENTO  : proc_Consulta_Documentos												*/
/* OBJETIVO       : Realizar consultas sobre la tabla Documentos							*/
/* ENTRADAS       :																			*/
/* SALIDAS		  :																			*/
/********************************************************************************************/



CREATE procedure [dbo].[proc_Consulta_Documentos]
@TipoBusqueda int = 0,
@usuario char(20) = '',
@IdPaquete int = 0,
@IdDocumento int = 0,
@DtFechaRegIni datetime = null,
@DtFechaRegFin datetime = null,
@IdEstado int = null

As

Begin


--TODO LOS DATOS
--If (@TipoBusqueda = 0)
--Begin	
--	Select 
--		IdPaquete as 'sIdPaquete',
--		IdDocumento as 'sIdDocumento',
--		NomDocumento as 'NomDocumento',
--		IdTipo as 'IdTipo',
--		rutalocal as 'RutaLocal'
--	from Documentos
--	return
--End


--If (@TipoBusqueda = 1)
--Begin
--	Select 		
--		IdPaquete as 'sIdPaquete',
--		IdDocumento as 'sIdDocumento',
--		NomDocumento as 'NomDocumento',
--		IdTipo as 'IdTipo',
--		rutalocal as 'RutaLocal'			
--	From Documentos
--	WHere IdPaquete = @IdPaquete
--	return
--End


If (@TipoBusqueda = 0)
Begin
	select 
		Paquetes.IdUsuario,
		Paquetes.DtFechaLimite,
		case when Paquetes.IdUrgencia = 0 then 'Baja'
			 when Paquetes.IdUrgencia = 1 then 'Media'
			 when Paquetes.IdUrgencia = 2 then 'Alta'
		end as 'IdUrgencia',		
		documentos.idPaquete,
		documentos.idDocumento,
		documentos.NomDocumento, 
		documentos.RutaLocal,
		Paquetes.RutaServidor,
		Documentos.NomTecnico,
		Documentos.NomMaquina,
		Documentos.DocBinary,
		Documentos.ExtArchivo,
		0 as total_comentarios 
	from 
		Paquetes 
			inner join	documentos on Paquetes.IdPaquete = Documentos.IdPaquete
		--	inner join firmantes on documentos.iddocumento = firmantes.iddocumento 
		  --                          and documentos.idpaquete = firmantes.idpaquete	
	
	Order by Paquetes.DtFechaReg desc
	return
End

If (@TipoBusqueda = 1)
Begin
	select 
		Paquetes.IdUsuario,
		Paquetes.DtFechaLimite,
		case when Paquetes.IdUrgencia = 0 then 'Baja'
			 when Paquetes.IdUrgencia = 1 then 'Media'
			 when Paquetes.IdUrgencia = 2 then 'Alta'
		end as 'IdUrgencia',
		documentos.idPaquete,
		documentos.idDocumento,
		documentos.NomDocumento, 
		documentos.RutaLocal,
		Paquetes.RutaServidor,
		Documentos.NomTecnico,
		Documentos.NomMaquina,
		Documentos.DocBinary,
		Documentos.ExtArchivo,
		(select COUNT(idpaquete) as totalM from CommentSeguimiento where CommentSeguimiento.IdPaquete = Paquetes.IdPaquete and IdFirmante = @usuario and crevisado = 0) as total_comentarios 
	from 
			Paquetes 
			inner join	documentos on Paquetes.IdPaquete = Documentos.IdPaquete
		--	inner join firmantes on documentos.iddocumento = firmantes.iddocumento 
		  --                          and documentos.idpaquete = firmantes.idpaquete
	where 
		Paquetes.IdUsuario = @usuario 
		and Paquetes.IdPaquete = @IdPaquete		
    Order by Paquetes.DtFechaReg desc
	return
End


End
GO
/****** Object:  StoredProcedure [dbo].[proc_Actualizar_Paquete]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[proc_Actualizar_Paquete] 
@DescPaquete varchar(200),
@IdUrgencia int = 0,
@DtFechaLimite datetime,
@IdPaquete int 

As

Begin

	

	set xact_abort on
	Begin Try
		Begin Tran
		
			Update Paquetes
			set DescPaquete = @DescPaquete,
			    IdUrgencia = @IdUrgencia,
			    DtFechaLimite = @DtFechaLimite
			 WHere IdPaquete = @IdPaquete		
			
		commit
			
	End Try

	Begin catch
		Raiserror('[proc_Actualizar_Paquete]. Error en actualizando el paquete',11,1)
		Rollback
		
	end catch

End
GO
/****** Object:  StoredProcedure [dbo].[proc_Actualiza_Firma]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/********************************************************************************************/
/* PROGRAMADOR    : Carlos Fonseca													        */
/* FECHA CREACION : 20-MARZO-2015															*/
/* PROCEDIMIENTO  : proc_Actualiza_Firma										            */
/* OBJETIVO       : Actualiza el estado de firmado para un usuario de un documento de un paquete*/
/* ENTRADAS       :																			*/
/* SALIDAS		  :																			*/
/********************************************************************************************/

CREATE procedure [dbo].[proc_Actualiza_Firma]
@IdPaquete int,
@IdDocumento int,
@IdFirmante varchar(100),
@estadoFirma int


As

Begin
	
	
	Declare @Dtfechafirma datetime
	
	set @Dtfechafirma = GETDATE()
	if (@estadoFirma = 0)
	Begin
	set @Dtfechafirma = NULL
	End
	
	
	update 
		Firmantes 
	set idestado = @estadoFirma,
		Dtfechafirma = @Dtfechafirma
	where  
	    idPaquete = @idPaquete and
	    idDocumento = @iddocumento and
	    idFirmante = @IdFirmante


End
GO
/****** Object:  StoredProcedure [dbo].[proc_Actualiza_DocBinario_Firmado]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/********************************************************************************************/
/* PROGRAMADOR    : Carlos González Romero											        */
/* FECHA CREACION : 20-MARZO-2015															*/
/* PROCEDIMIENTO  : [proc_Actualiza_DocBinario_Firmado]							            */
/* OBJETIVO       : Actualiza el documento binario ya firmado por el firmante               */
/* ENTRADAS       :																			*/
/* SALIDAS		  :																			*/
/********************************************************************************************/

create procedure [dbo].[proc_Actualiza_DocBinario_Firmado]
@IdPaquete int,
@IdDocumento int,
@DocBinary varbinary(max)

As

Begin
	
	
BEgin try	
	
		Declare		
		@Error varchar(max)
		
	Begin Transaction	
		Update 
			Documentos 
		set DocBinary = @DocBinary			
		where  
			idPaquete = @idPaquete and
			idDocumento = @iddocumento
	Commit Transaction
	    
End try
Begin Catch
	Rollback Transaction
	set @Error = '[proc_Actualiza_DocBinario_Firmado]. Se produjó un error al intentar guardar el documento firmado en la base de datos, por favor vuelva a intentar.'
	Raiserror(@Error,11,1)
End Catch
	    
	    


End
GO
/****** Object:  StoredProcedure [dbo].[proc_Registra_Seguimiento]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_Registra_Seguimiento] 
@IdPaquete int = null,
@IdDocumento int = null,
@IdFirmante varchar(100) = null,
@IdUsuarioComenta varchar(50) = null,
@Seguimiento varchar(500) = null

As

Begin

	set xact_abort on
	Begin Try
		Begin Tran
			Insert into CommentSeguimiento (IdPaquete,IdDocumento,IdFirmante, IdUsuarioComenta, DtFechaComentario,Seguimiento,crevisado)
			Values (@IdPaquete, @IdDocumento,@IdFirmante, @IdUsuarioComenta,GETDATE(),@Seguimiento,0)
		commit
		return
	End Try

	Begin catch
		Raiserror('',11,1)
		Rollback
		
	end catch

End
GO
/****** Object:  StoredProcedure [dbo].[proc_Registra_Paquetes]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[proc_Registra_Paquetes] 
@DescPaquete varchar(200),
@IdUsuario varchar(50),
@IdUrgencia int = 0,
@DtFechaLimite datetime,
@RutaServidor varchar(150),
@IdPaquete int output

As

Begin

	

	set xact_abort on
	Begin Try
		Begin Tran
		
			
			Insert into Paquetes (DescPaquete,IdUsuario,DtFechaReg,IdUrgencia,DtFechaLimite,IdEstado,RutaServidor)
			Values (@DescPaquete,@IdUsuario,GETDATE(),@IdUrgencia,@DtFechaLimite,1,@RutaServidor)
			
		commit
			select @IdPaquete = @@identity
		return @IdPaquete
	End Try

	Begin catch
		Raiserror('[proc_Registra_Paquetes]. Error en el registro del paquete',11,1)
		Rollback
		
	end catch

End
GO
/****** Object:  StoredProcedure [dbo].[proc_Registra_Lectura]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/********************************************************************************************/
/* PROGRAMADOR    : Carlos Fonseca													        */
/* FECHA CREACION : 21-04-2015															    */
/* PROCEDIMIENTO  : proc_Consulta_Mensajes												    */
/* OBJETIVO       : Realizar consultas sobre los mensajes pendientes de leer      			*/
/* ENTRADAS       :																			*/
/* SALIDAS		  :																			*/
/********************************************************************************************/



CREATE procedure [dbo].[proc_Registra_Lectura]
@IdPaquete int,
@IdDocumento int,
@TipoUpdate int,
@IdFirmante varchar(100) = null


As

Begin



Begin


if (@TipoUpdate = 0)
Begin 
	update CommentSeguimiento
	set crevisado = 1
	where 
		 IdFirmante = @IdFirmante
	      and IdFirmante <> IdUsuarioComenta
	      and IdPaquete = @IdPaquete
	      and IdDocumento = @IdDocumento
	      and crevisado = 0
End

if (@TipoUpdate = 1)
Begin 
	update CommentSeguimiento
	set crevisado = 1
	where IdFirmante <> @IdFirmante
	      and IdFirmante = IdUsuarioComenta
	      and IdPaquete = @IdPaquete
	      and IdDocumento = @IdDocumento
	      and crevisado = 0
End
	      
	      
	      
	return
End





End
GO
/****** Object:  StoredProcedure [dbo].[proc_Registra_Firmantes]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_Registra_Firmantes]
@IdPaquete int,
@IdDocumento int,
@NomFirmante varchar(100),
@IdFirmante varchar(100),
@Correo varchar(100),
@IdTipoPersona int


As



Begin
	
	Declare
		@ExisteDocumento int = 0,
		@Error varchar(max)
	
	
	set xact_abort on
	Begin Try
		Begin Tran
			
			Select @ExisteDocumento = COUNT(IdPaquete) from Documentos where IdDocumento = @IdDocumento
			
			set @Error = '[proc_Registra_Firmantes]. No existe el documento para realizar el registro del firmante ' + @IdFirmante
			
			if (@ExisteDocumento = 0)
			Begin				
				rollback
				raiserror(@Error,11,1)
				return 				
			End		
			
			Insert into Firmantes (IdPaquete,IdDocumento,NomFirmante,IdFirmante,DtFechaFirma,StrCorreo,IdEstado,IdTipoPersona)
			Values (@IdPaquete,@IdDocumento,@NomFirmante,@IdFirmante,Null,@Correo,0,@IdTipoPersona)
			
		commit
		return
	End Try

	Begin catch
		Rollback
		--Se borran todos los firmantes vinculados al paquete
		Delete from Firmantes where IdPaquete = @IdPaquete 
		--Se eliminan todos los documentos vinculados al paquete
		Delete from Documentos where IdPaquete = @IdPaquete
		--Si existe un error en el registro del documento debe eliminar el paquete		
		Delete from Paquetes where IdPaquete = @IdPaquete 
		set @Error = '[proc_Registra_Firmantes]. Error en registro del firmante' + @IdFirmante
		Raiserror(@Error,11,1)
	end catch

End
GO
/****** Object:  StoredProcedure [dbo].[proc_Registra_Documentos]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_Registra_Documentos]
@IdPaquete int,
@IdDocumento int,
@NomDocumento varchar(50),
@IdTipo int,
@RutaLocal varchar(150),
@NomTecnico varchar(max),
@NomMaquina varchar(max),
@DocBinary varbinary(max),
@ExtArchivo varchar(4)

As



Begin

	Declare
		@ExistePaquete int = 0,
		@Error varchar(max)

	set xact_abort on
	Begin Try
		Begin Tran
		
			Select @ExistePaquete = COUNT(IdPaquete) from Paquetes where IdPaquete = @IdPaquete
			
			set @Error = '[proc_Registra_Documentos]. No existe el paqueta para realizar el registro del documento ' + @NomDocumento
			
			if (@ExistePaquete = 0)
			Begin				
				rollback
				raiserror(@Error,11,1)
				return 				
			End		
			
			Insert into Documentos (IdPaquete,IdDocumento,NomDocumento,IdTipo,DtFechaReg,RutaLocal,NomTecnico,NomMaquina,DocBinary,ExtArchivo)
			Values (@IdPaquete,@IdDocumento,@NomDocumento,@IdTipo,GETDATE(),@RutaLocal,@NomTecnico,@NomMaquina,@DocBinary,@ExtArchivo)
			
		commit
		return
	End Try

	Begin catch
		Rollback
		--Si existe un error con la carga del documento se borran todos los documentos cargados para ese paquete
		Delete from Documentos where IdPaquete = @IdPaquete 
		--Si existe un error en el registro del documento debe eliminar el paquete		
		Delete from Paquetes where IdPaquete = @IdPaquete 
		Raiserror(@Error,11,1)
		
	end catch

End
GO
/****** Object:  StoredProcedure [dbo].[proc_Registra_Bitacora]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[proc_Registra_Bitacora] 
@IdUsuario varchar(50),
@NomMaquina varchar(max),
@IdPaquete int,
@Referencia varchar(max)


As

Begin	

	set xact_abort on
	Begin Try
		Begin Tran
		
			
			Insert into Bitacora (IdUsuario,NomMaquina,IdPaquete,Referencia,DtFechaMovi)
			Values (@IdUsuario,@NomMaquina,@IdPaquete,@Referencia, GETDATE())
			
		commit
			
	End Try

	Begin catch
		Raiserror('[proc_Registra_Bitacora]. Error en el registro a realizar en la bitacora',11,1)
		Rollback
		
	end catch

End
GO
/****** Object:  StoredProcedure [dbo].[proc_Enviar_Correo]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_Enviar_Correo]
@Correo varchar(max),
@NombreUsuario varchar(max),
@Paquete varchar(max),
@sIdTipoPersona int
as

Begin

Declare @asunto varchar(max),
        @Tema varchar(max)

set @asunto = 'Usted ha recibido un documento para gestionar correspondiente al paquete: Pk'+@Paquete+',  desde la aplicación SISGEDI del usuario '+@NombreUsuario+'. Su rol en el documento es de:('+(case when @sIdTipoPersona = 0 then 'Firmante' else 'Informado' end)+').'
set @Tema = 'Documento desde SISGEDI de '+@NombreUsuario+', paquete: Pk'+@Paquete+', su rol: ('+(case when @sIdTipoPersona = 0 then 'Firmante' else 'Informado' end)+').'
EXEC msdb.dbo.sp_send_dbmail
    @profile_name = 'CarMail',
    @recipients = @Correo,
    @body = @asunto,
    @subject = @Tema ;
    
End
GO
/****** Object:  StoredProcedure [dbo].[proc_Eliminar_Paquete]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_Eliminar_Paquete]
@IdPaquete int


As



Begin

	Declare
		@ExistePaquete int = 0,
		@Error varchar(max)

	set xact_abort on
	Begin Try
		Begin Tran
		
		
			Delete from Firmantes
			where IdPaquete = @IdPaquete
			
			Delete from Documentos 
			Where IdPaquete = @IdPaquete
			
			Delete From Paquetes
			Where IdPaquete = @IdPaquete
			Select @ExistePaquete = COUNT(IdPaquete) from Paquetes where IdPaquete = @IdPaquete
			
			set @Error = '[proc_Eliminar_Paquete]. Error tratando de elminar el paquete PK' +CAST(@IdPaquete as varchar(3))			
			
		commit
		return
	End Try

	Begin catch
		Rollback		
		Raiserror(@Error,11,1)
		
	end catch

End
GO
/****** Object:  StoredProcedure [dbo].[proc_Eliminar_Firmante]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_Eliminar_Firmante]
@IdPaquete int,
@IdDocumento int,
@IdFirmante varchar(100) 



As



Begin

	Declare		
		@Error varchar(max)

	set xact_abort on
	Begin Try
		Begin Tran
		
		
			Delete from Firmantes
			where IdPaquete = @IdPaquete and IdDocumento = @IdDocumento and IdFirmante = @IdFirmante						
			
			set @Error = '[proc_Eliminar_Firmante]. Error tratando de elminar el firmante' +CAST(@IdFirmante as varchar(3))			
			
		commit
		return
	End Try

	Begin catch
		Rollback		
		Raiserror(@Error,11,1)		
	end catch

End
GO
/****** Object:  StoredProcedure [dbo].[proc_Eliminar_Documento]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_Eliminar_Documento]
@IdPaquete int,
@IdDocumento int
As

Begin

	Declare		
		@Error varchar(max)

	set xact_abort on
	Begin Try
		Begin Tran
		
		
			Delete from Firmantes
			where IdPaquete = @IdPaquete and IdDocumento = @IdDocumento 
			
			Delete from Documentos
			where IdPaquete = @IdPaquete and IdDocumento = @IdDocumento 
			
			set @Error = '[proc_Eliminar_Documento]. Error tratando de elminar el documento DOC_'+CAST(@IdDocumento as varchar(3))			
			
		commit
		return
	End Try

	Begin catch
		Rollback		
		Raiserror(@Error,11,1)		
	end catch

End
GO
/****** Object:  StoredProcedure [dbo].[proc_ConsultaUltimaActualizacionDocBinary]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/********************************************************************************************/
/* PROGRAMADOR    : Carlos González Romero													*/
/* FECHA CREACION : 08-FEBRERO-2015															*/
/* PROCEDIMIENTO  : [proc_ConsultaUltimaActualizacionDocBinary]	   						    */
/* OBJETIVO       : Consulta la ultima actualizacion del archivo para mostrar en el visor	*/
/* ENTRADAS       :																			*/
/* SALIDAS		  :																			*/
/********************************************************************************************/



Create procedure [dbo].[proc_ConsultaUltimaActualizacionDocBinary]
@IdPaquete int = 0,
@IdDocumento int = 0

As

Begin


Select DocBinary from Documentos
Where IdPaquete = @IdPaquete
      and IdDocumento = @IdDocumento


End
GO
/****** Object:  StoredProcedure [dbo].[proc_ConsultaSeguimiento]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/********************************************************************************************/
/* PROGRAMADOR    : Carlos González Romero													*/
/* FECHA CREACION : 08-FEBRERO-2015															*/
/* PROCEDIMIENTO  : proc_ConsultaSeguimiento												*/
/* OBJETIVO       : Realizar consultas sobre la tabla Documentos							*/
/* ENTRADAS       :																			*/
/* SALIDAS		  :																			*/
/********************************************************************************************/

CREATE procedure [dbo].[proc_ConsultaSeguimiento]
@TipoBusqueda int = 0,
@IdPaquete int = null,
@IdDocumento int = null,
@IdFirmante varchar(100) = null


As

Begin


--TODO LOS DATOS
If (@TipoBusqueda = 0)
Begin
	
	Select 
		IdUsuarioComenta,
		Seguimiento,
		convert(date,DtFechaComentario,103)	as DtFechaComentario,
		'Pk' + CAST( CommentSeguimiento.IdPaquete as varchar(20)),
	    CommentSeguimiento.IdDocumento,
		RutaLocal				
	from CommentSeguimiento
	inner join Documentos on CommentSeguimiento.IdPaquete = Documentos.IdPaquete
	and CommentSeguimiento.IdDocumento = Documentos.IdDocumento
	order by DtFechaComentario desc
	return
End


If (@TipoBusqueda = 1)
Begin
	
	Select 
		IdUsuarioComenta as Usuario,
		Seguimiento,
		DtFechaComentario as fecha,
		'Pk' + CAST( CommentSeguimiento.IdPaquete as varchar(20)) as paquete,
		CommentSeguimiento.IdDocumento,
		RutaLocal		
	from CommentSeguimiento
	inner join Documentos on CommentSeguimiento.IdPaquete = Documentos.IdPaquete
	and CommentSeguimiento.IdDocumento = Documentos.IdDocumento
	Where CommentSeguimiento.IdPaquete = @IdPaquete
	      and CommentSeguimiento.IdDocumento = @IdDocumento
	      and IdFirmante = @IdFirmante
	 order by DtFechaComentario desc
	return
End

If (@TipoBusqueda = 3)
Begin
	
	Select 
		IdUsuarioComenta,
		Seguimiento,
		DtFechaComentario,
		 'Pk' + CAST( CommentSeguimiento.IdPaquete as varchar(20)),
	    CommentSeguimiento.IdDocumento,
		RutaLocal		
	from CommentSeguimiento
	inner join Documentos on CommentSeguimiento.IdPaquete = Documentos.IdPaquete
	and CommentSeguimiento.IdDocumento = Documentos.IdDocumento
	Where IdFirmante = @IdFirmante
	      and crevisado = 0
	 order by DtFechaComentario desc
	return
End


End
GO
/****** Object:  StoredProcedure [dbo].[proc_Consulta_Paquetes]    Script Date: 10/26/2015 13:58:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/********************************************************************************************/
/* PROGRAMADOR    : Carlos González Romero													*/
/* FECHA CREACION : 08-FEBRERO-2015															*/
/* PROCEDIMIENTO  : proc_Consulta_Paquetes													*/
/* OBJETIVO       : Realizar consultas sobre la tabla Paquetes								*/
/* ENTRADAS       :																			*/
/*					@TipoBusqueda  = indica el tipo de busqueda por realizar				*/
/*					@IdPaquete     = identifica un paquete en especifico					*/
/*				    @IdUsuario     = identifica un usuario en especifico					*/
/*					@DtFechaRegIni = Fecha de registro inicial del paquete					*/
/*					@DtFechaRegFin = Fecha de registro final del paquete					*/
/*					@IdEstado      = Estado actual del paquete								*/
/* SALIDAS		  :																			*/
/*					Consulta buscada														*/
/********************************************************************************************/


CREATE procedure [dbo].[proc_Consulta_Paquetes]
@TipoBusqueda int = 0,
@IdPaquete int = 0,
@IdUsuario varchar(50) = null,
@DtFechaRegIni datetime = null,
@DtFechaRegFin datetime = null,
@IdEstado int = null

As

Begin




--TODO LOS DATOS
If (@TipoBusqueda = 0)
Begin
	Select 
		IdPaquete as 'IdPaquete',
		DescPaquete as 'Descripcion',
		case when IdUrgencia = 0 then 'Baja' 
			 when IdUrgencia = 1 then 'Media'
			 when IdUrgencia = 2 then 'Alta'			 
		 end as 'Urgencia',		
		convert(date,DtFechaReg,103) as 'FechaRegistro',
		convert(char(10),DtFechaLimite,103) as 'FechaLimite',
		case when IdEstado = 1 then 'Firmado' 
			 when IdEstado = 2 then 'Pendiente'
			 when IdEstado = 3 then 'Anulado'			 
		 end as 'Estado',
		 IdUsuario as 'Propietario',
		 (select COUNT(IdFirmante) as total_firmantes from Firmantes where firmantes.IdPaquete = Paquetes.IdPaquete)as total_firmantes,
		 (select COUNT(IdFirmante) as total_firmas from Firmantes where firmantes.IdPaquete = Paquetes.IdPaquete and IdEstado = 1)as total_firmas,
		 (Select COUNT(IdDocumento) as total_documentos from Documentos where Documentos.IdPaquete = Paquetes.IdPaquete) as total_documentos,
		 0 as 'total_comentarios',
		  (select COUNT(IdFirmante) as total_firmantes from Firmantes where firmantes.IdPaquete = Paquetes.IdPaquete and IdTipoPersona = 1)as total_informados
	from Paquetes
	Where IdUsuario = @IdUsuario
	order by DtFechaReg desc
	return
End

--TODOS LOS USUARIOS
--UN ESTADO ESPECIFICO
--TODAS LAS FECHAS
If (@TipoBusqueda = 1)
Begin
	
	
	Select 
		IdPaquete as 'IdPaquete',
		DescPaquete as 'Descripcion',
		case when IdUrgencia = 0 then 'Baja' 
			 when IdUrgencia = 1 then 'Media'
			 when IdUrgencia = 2 then 'Alta'			 
		