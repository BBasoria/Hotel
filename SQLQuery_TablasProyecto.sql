--SCRIPTS

--CREATE TABLE Usuario_teléfono(
--ID_usuario_teléfono int not null identity(1,1), 
--Teléfono_Casa varchar(10) not null, 
--Teléfono_Celular varchar(10) not null,
--constraint PK_Usuarioteléfono
--	primary key(ID_usuario_teléfono)
--);


--CREATE TABLE Usuario(
--Correo_electrónico varchar(30) not null, 
--Contraseña varchar(30) not null,
--Nueva_contraseña varchar(30) not null,
--Nombre varchar(20) not null,
--ApellidoP varchar(10) not null,
--ApellidoM varchar(10) not null,
--Nombre_calle varchar(20) not null,
--Numero_de_casa int not null,
--Municipio varchar(20) not null,
--Código_postal varchar(5) not null, 
--Ciudad varchar(15) not null, 
--Estado varchar(15) not null, 
--País varchar(15) not null,
--Número_de_nomina money not null, 
--Fecha_de_Nacimiento date not null, 
--Teléfono int not null,
--constraint PK_Correoelectrónico
--	primary key(Correo_electrónico),
--constraint FK_Teléfono
--	foreign key(Teléfono)--es del Teléfono dentro de la tabla usuario
--		references Usuario_teléfono(ID_usuario_teléfono)--referencia de la tabla Usuario_teléfono con su llave primaria
--);

--CREATE TABLE Administrador_(
--ID_admin int not null identity(1,1), 
--Correo_electrónico varchar(30) not null, 
--Status_ char(1) default ('Y') not null,
--constraint PK_Administrador
--	primary key(ID_admin),
--constraint FK_Correoelectrónico
--	foreign key(Correo_electrónico)--es del Correo_electónico dentro de la tabla administrador
--		references Usuario(Correo_electrónico)--referencia de la tabla Usuario con su llave primaria
--);

--CREATE TABLE Operativo(
--ID_operativo int not null identity(1,1),
--Correo_electrónico varchar(30) not null, 
--ID_admin int not null,
--Habilitado char(1) default ('Y') not null,
--Fecha_y_hora datetime,
--constraint PK_Operativo
--	primary key(ID_operativo),
--constraint FK_CorreoelectrónicoOperativo
--	foreign key(Correo_electrónico)--es del Correo_electónico dentro de la tabla operativo
--		references Usuario(Correo_electrónico),--referencia de la tabla Usuario con su llave primaria
--constraint FK_AdminOperativo
--	foreign key(ID_admin) --es del ID_admin dentro de la tabla operativo
--		references Administrador_(ID_admin),--referencia de la tabla Administrador con su llave primaria
--);


--CREATE TABLE Cliente_Contacto(
--ID_cliente_contacto int not null identity(1,1),
--Correo_electrónico_Cliente varchar(30) not null,
--Teléfono_Casa varchar(10) not null, 
--Teléfono_Celular varchar(10) not null,
--constraint PK_ClienteContacto
--	primary key(ID_cliente_contacto),
--);

--CREATE TABLE Cliente_Referencia(
--ID_referencia_hotel int not null identity(1,1), 
--Referencia_Hotel varchar(30) not null,
--constraint PK_ClienteReferencia
--	primary key(ID_referencia_hotel),
--);

--CREATE TABLE Cliente( 
--ID_cliente int not null identity(1,1), 
--ID_operativo_cliente int not null, 
--Nombre_cliente varchar(20) not null,
--ApellidoP_cliente varchar(10) not null,
--ApellidoM_cliente varchar(10) not null,
--Nombre_calle_cliente varchar(20) not null,
--Numero_de_casa_cliente int not null,
--Municipio_cliente varchar(20) not null,
--Código_postal_cliente varchar(5) not null, 
--Ciudad_cliente varchar(15) not null, 
--Estado_cliente varchar(15) not null, 
--País_cliente varchar(15) not null, 
--RFC_cliente varchar (13) not null, 
--Fecha_de_Nacimiento_cliente date not null, 
--Estado_Civil_cliente varchar(10) not null, 
--Fecha_y_hora_registro_cliente datetime,
--ID_cliente_contacto int not null,
--ID_referencia_hotel int not null,
--constraint PK_Cliente
--	primary key(ID_cliente),
--constraint FK_OperativoCliente
--	foreign key(ID_operativo_cliente)--es del ID_operativo_cliente dentro de la tabla cliente
--		references Operativo(ID_operativo),--referencia de la tabla Operativo con su llave primaria
--constraint FK_ClienteContacto
--	foreign key(ID_cliente_contacto)--es del ID_cliente_contacto dentro de la tabla cliente
--		references Cliente_Contacto(ID_cliente_contacto),--referencia de la tabla Cliente_Contacto con su llave primaria
--constraint FK_ClienteReferencia
--	foreign key(ID_referencia_hotel)--es del ID_referencia_hotel dentro de la tabla cliente
--		references Cliente_Referencia(ID_referencia_hotel),--referencia de la tabla Cliente_Referencia con su llave primaria
--);


--CREATE TABLE Hotel(
--ID_hotel int not null identity(1,1), 
--ID_admin_hotel int not null,
--Nombre_hotel varchar(20) not null,
--Nombre_calle_hotel varchar(20) not null,
--Municipio_hotel varchar(20) not null,
--Código_postal_hotel varchar(5) not null, 
--Ciudad_hotel varchar(15) not null, 
--Estado_hotel varchar(15) not null, 
--País_hotel varchar(15) not null,
--Número_de_pisos_hotel tinyint, 
--Número_de_habitaciones_hotel tinyint,
--Amenidades_hotel varchar(100), 
--Zona_turística_hotel varchar(250), 
--Servicio_adicional_hotel varchar(250), 
--Sala_de_eventos_hotel varchar(250), 
--Fecha_inicio_operaciones_hotel date, 
--Teléfono_hotel varchar(10) not null,
--Fecha_y_hora_registro_hotel date,
--constraint PK_Hotel
--	primary key(ID_hotel),
--constraint FK_Admin
--	foreign key(ID_admin_hotel)--es del ID_admin dentro de la tabla Hotel
--		references Administrador_(ID_admin),--referencia de la tabla Hotel con su llave primaria
--);

--CREATE TABLE Tipo_de_Habitación(
--Código_tipo_habitación int not null identity(1,1), 
--ID_HotelTipoHabitación int not null,
--Número_de_camas_thabitación smallint not null, 
--Tipo_de_camas_thabitación varchar(30),
--Precio_por_noche_por_persona_thabitación money, 
--Número_de_personas_thabitación smallint, 
--Nivel_de_habitación_thabitación varchar(15), 
--Características_thabitación varchar(100), 
--Amenidades_thabitación varchar(100), 
--Vista_al_frente_thabitación char(1) default ('Y') not null,
--constraint PK_TipodeHabitación
--	primary key(Código_tipo_habitación),
--ADD CONSTRAINT  FK_HotelTipoHabitación
--    foreign key(ID_HotelTipoHabitación)--es del ID_HotelTipoHabitación dentro de la tabla Tipo_de_Habitación
--        references Hotel(ID_hotel)--referencia de la tabla Hotel con su llave primaria
--);


--CREATE TABLE Habitación(
--Número_habitación int not null identity(1,1), 
--Habitación_creada_Admin int not null, 
--Tipo_de_habitación int not null,
--ID_hotel_habitación int not null, 
--Fecha_y_hora_registro_habitación date not null,
--constraint PK_Habitación
--	primary key(Número_habitación),
--constraint FK_HabitacióncreadaAdmin
--	foreign key(Habitación_creada_Admin)--es del Habitación_creada_Admin dentro de la tabla Habitación
--		references Administrador_(ID_admin),--referencia de la tabla Administrador con su llave primaria
--constraint FK_TipodeHabitación
--	foreign key(Tipo_de_habitación)--es del Tipo_de_habitación dentro de la tabla Habitación
--		references Tipo_de_habitación(Código_tipo_habitación),--referencia de la tabla Tipo_de_Habitación con su llave primaria
--constraint FK_Hotel
--	foreign key(ID_hotel_habitación)--es del ID_Hotel dentro de la tabla Habitación
--		references Hotel(ID_hotel),--referencia de la tabla Hotel con su llave primaria
--);

--CREATE TABLE Reservación(
--Número_habitación_reservación int not null,
--ID_cliente_reservación int not null, 
--ID_hotel_reservación int not null, 
--Fecha_creación_reservación date not null,
--Fecha_entrada_reservación date not null,
--Fecha_salida_reservación date not null,
--Tipo_de_pago varchar(20) not null, 
--Fecha_y_hora_registro_reservación datetime not null, 
--Status_reservación char(1) default ('Y') not null, 
--Dinero_faltante money, 
--Anticipo_de_reservación money, 
--Monto_total money,
--Número_de_personas_en_habitación_reservación TINYINT, 
--Código_reservación UNIQUEIDENTIFIER,
--Rango_de_fechas int,
--ServiciosUsados bit default (0) not null
--constraint PK_Reservación
--	primary key(Código_reservación),
--constraint FK_NúmeroHabitaciónReservación
--	foreign key(Número_habitación_reservación)--es del Número_habitacion dentro de la tabla reservación
--		references Habitación(Número_habitación),--referencia de la tabla Habitación con su llave primaria
--constraint FK_ClienteReservación
--	foreign key(ID_cliente_reservación)--es del ID_cliente dentro de la tabla reservación
--		references Cliente(ID_cliente),--referencia de la tabla Cliente con su llave primaria
--constraint FK_HotelReservación
--	foreign key(ID_hotel_reservación)--es del ID_hotel dentro de la tabla reservación
--		references Hotel(ID_hotel),--referencia de la tabla Hotel con su llave primaria
--);

--CREATE TABLE Habitación_reservada(
--ID_habitación_reservada int not null identity(1,1), 
--Número_habitación_reservada int, 
--Código_reservación_reservada UNIQUEIDENTIFIER,
--Fecha_y_hora_registro_reservada datetime, 
--Disponible char(1) default ('Y') not null,
--constraint PK_Habitaciónreservada
--	primary key(ID_habitación_reservada),
--constraint FK_Númerohabitaciónreservada
--	foreign key(Número_habitación_reservada)--es del Número_habitación dentro de la tabla Habitación_reservada
--		references Habitación(Número_habitación),--referencia de la tabla Habitación con su llave primaria
--constraint FK_Códigoreservacióneservada
--	foreign key(Código_reservación_reservada)--es del Código_reservación dentro de la tabla Habitación_reservada
--		references Reservación(Código_reservación),--referencia de la tabla Habitación con su llave primaria
--);

--CREATE TABLE NuevasContraseñas (--Un usuario no puede estar más de dos veces. Esto es diferente a la Nueva contraseña en la Tabla Usuario, es como el historial de las contraseñas de cada Usuario
----Una vez se use la Nueva Contraseña de la Tabla Usuario, obligaran al usuario a poner una contraseña diferente y la Nueva Contraseña se moverá aquí
--ID_Contraseñas int not null identity(1,1), 
--ID_operativo int not null,
--Contraseña varchar(30) not null,
--Fecha_y_hora datetime,
--constraint PK_Contraseñas
--	primary key(ID_Contraseñas), 
--constraint FK_ID_operativo_habilitado
--	foreign key (ID_operativo)--es el ID de la tabla Operativo
--		references Operativo(ID_operativo)--referencia a la tabla Operativo con su llave primaria
--);

--_______________________________________________________INICIO DE PROCEDIMIENTOS DE INICIO DE SESIÓN______________________________________________________


--CREATE PROCEDURE InhabilitarOperativoIS(
--@Correo varchar(30)
--)
--AS
--BEGIN
--UPDATE Operativo
--SET Habilitado= 'N' 
--WHERE Correo_electrónico = @Correo
--END

--CREATE PROCEDURE ChequeoOperativo(
--@Correo varchar(30)
--)
--AS
--BEGIN
--Select Correo_electrónico from Operativo 
--where Correo_electrónico = @Correo
--AND Habilitado = 'N'
--END

--CREATE PROCEDURE BusquedaOperativo(
--@Correo varchar(30)
--)
--AS
--BEGIN
--Select Correo_electrónico from Operativo where Correo_electrónico = @Correo
--END

--CREATE PROCEDURE BusquedaOperativoYNuevaContraseña(
--@Correo varchar(30),
--@Contraseña varchar(30)
--)
--AS
--BEGIN
--SELECT Operativo.Correo_electrónico AS OperativoCorreo, Usuario.Correo_electrónico AS UsuarioCorreo 
--FROM Operativo
--JOIN Usuario ON Operativo.Correo_electrónico = Usuario.Correo_electrónico 
--WHERE Usuario.Nueva_contraseña =@Contraseña
--AND Operativo.Correo_electrónico = @Correo
--END

--CREATE PROCEDURE SiesHabilitadoOperativo(
--@Correo varchar(30),
--@Contraseña varchar(30)
--)
--AS
--BEGIN
--Select Correo_electrónico from Usuario 
--where Correo_electrónico = @Correo
--AND Contraseña= @Contraseña
--AND Nueva_contraseña = 'nocontraseña'
                        
--END

--CREATE PROCEDURE ValidoOperativo(
--@Correo varchar(30)
--)
--AS
--BEGIN
--Select Correo_electrónico from Operativo 
--where Correo_electrónico = @Correo
--AND Habilitado = 'Y'
--END

--CREATE PROCEDURE BusquedaAdministrador(
--@Correo varchar(30)
--)
--AS
--BEGIN
--Select Correo_electrónico from Administrador_ where Correo_electrónico = @Correo
--END

--CREATE PROCEDURE UsuarioExistente(
--@Correo varchar(30),
--@Contraseña varchar(30),
--@NuevaContraseña varchar(30)
--)
--AS
--BEGIN
--select Correo_electrónico, Contraseña, Nueva_contraseña from Usuario
--where Correo_electrónico = @Correo
--AND Contraseña=@Contraseña
--OR Nueva_contraseña=@NuevaContraseña
--END

--_______________________________________________________FINAL DE PROCEDIMIENTOS DE INICIO DE SESIÓN______________________________________________________

--_______________________________________________________INICIO DE PROCEDIMIENTOS DE NUEVA CONTRASEÑA______________________________________________________

--CREATE PROCEDURE NC_Recuperar(
--@Correo varchar(30)
--)
--AS
--BEGIN
--select NC.Contraseña
--from  NuevasContraseñas NC
--join Operativo O on O.ID_operativo=NC.ID_operativo
--where O.Correo_electrónico =@Correo
--Group by NC.Contraseña
--END

--CREATE PROCEDURE NC_Validación(
--@Correo varchar(30),
--@NuevaContraseña varchar(30)
--)
--AS
--BEGIN
--select NC.Contraseña from  NuevasContraseñas NC
--join Operativo O on O.ID_operativo=NC.ID_operativo
--where O.Correo_electrónico =@Correo and NC.Contraseña=@NuevaContraseña
--Group by NC.Contraseña
--END


--CREATE PROCEDURE UpdatePasswordAndInsertHistorical
--    @Correo_electrónico varchar(30),
--    @NewPassword varchar(30)
--AS
--BEGIN
--    DECLARE @ID_operativo INT;
--    DECLARE @PreviousPassword varchar(30);
    
--    -- Get the ID_operativo and previous password based on Correo_electrónico
--    SELECT @ID_operativo = O.ID_operativo,
--           @PreviousPassword = U.Nueva_contraseña
--    FROM Usuario U
--    JOIN Operativo O ON U.Correo_electrónico = O.Correo_electrónico
--    WHERE U.Correo_electrónico = @Correo_electrónico;
    
--    -- Update Contraseña column in Usuario table
--    UPDATE Usuario
--    SET Contraseña = @NewPassword
--    WHERE Correo_electrónico = @Correo_electrónico;
    
--    -- Set Nueva_contraseña column to 'nocontraseña'
--    UPDATE Usuario
--    SET Nueva_contraseña = 'nocontraseña'
--    WHERE Correo_electrónico = @Correo_electrónico;
    
--    -- Insert previous password into NuevasContraseñas table
--    INSERT INTO NuevasContraseñas (ID_operativo, Contraseña, Fecha_y_hora)
--    VALUES (@ID_operativo, @PreviousPassword, GETDATE());
--END;

-- 1 TRIGGER!!
--CREATE TRIGGER trg_UpdateNuevaContraseña
--ON Operativo
--AFTER UPDATE
--AS
--BEGIN
--    IF UPDATE(Habilitado)
--    BEGIN
--        IF EXISTS (
--            SELECT Correo_electrónico, Habilitado
--            FROM inserted
--            WHERE Habilitado = 'Y'
--        )
--        BEGIN
--            UPDATE Usuario
--            SET Nueva_contraseña = (
--                SELECT TOP 8
--                    SUBSTRING(tblSource.vsSource, tblValue.number + 1, 1)
--                FROM (
--                    SELECT 'abcdefhkmnpqrstuvwxyzABCDEFHKMNPQRSTUVWXYZ23456789+=-_~#$%*()' AS vsSource
--                ) AS tblSource
--                JOIN master..spt_values AS tblValue ON tblValue.number < LEN(tblSource.vsSource)
--                WHERE tblValue.type = 'P'
--                ORDER BY NEWID()
--                FOR XML PATH('')
--            )
--            WHERE Correo_electrónico IN (
--                SELECT Correo_electrónico
--                FROM inserted
--                WHERE Habilitado = 'Y'
--            )
--        END
--    END
--END

--2 TRIGGER!!
--CREATE TRIGGER Trg_ActualizarNuevasContraseñas
--ON NuevasContraseñas
--AFTER INSERT
--AS
--BEGIN
--    SET NOCOUNT ON;
    
--    ;WITH CTE AS (
--        SELECT 
--            ID_Contraseñas,
--            ID_operativo,
--            Contraseña,
--            Fecha_y_hora,
--            ROW_NUMBER() OVER (PARTITION BY ID_operativo ORDER BY Fecha_y_hora DESC) AS RowNum
--        FROM NuevasContraseñas
--    )
--    DELETE FROM CTE WHERE RowNum > 2;
--END;

--_______________________________________________________FINAL DE PROCEDIMIENTOS DE NUEVA CONTRASEÑA______________________________________________________

--Las páginas del Menú de Administrador
--_______________________________________________________INICIO DE PROCEDIMIENTOS DE REGISTRAR OPERATIVO ______________________________________________________

--CREATE PROCEDURE InsertData (
--    @Teléfono_Casa varchar(10),
--    @Teléfono_Celular varchar(10),
--    @Correo_electrónico varchar(30),
--    @Contraseña varchar(30),
--    @Nombre varchar(20),
--    @ApellidoP varchar(10),
--    @ApellidoM varchar(10),
--    @Nombre_calle varchar(20),
--    @Numero_de_casa int,
--    @Municipio varchar(20),
--    @Código_postal varchar(5),
--    @Ciudad varchar(15),
--    @Estado varchar(15),
--    @País varchar(15),
--    @Número_de_nomina money,
--    @Fecha_de_Nacimiento date,
--    @Correo_electrónico_admin varchar(30)
--)
--AS
--BEGIN
--    SET NOCOUNT ON;

--    -- Insert into Usuario_teléfono table
--    INSERT INTO Usuario_teléfono (Teléfono_Casa, Teléfono_Celular)
--    VALUES (@Teléfono_Casa, @Teléfono_Celular);

--    -- Insert into Usuario table
--    INSERT INTO Usuario (
--        Correo_electrónico, Contraseña, Nueva_contraseña, Nombre, ApellidoP, ApellidoM,
--        Nombre_calle, Numero_de_casa, Municipio, Código_postal, Ciudad, Estado, País,
--        Número_de_nomina, Fecha_de_Nacimiento, Teléfono
--    )
--    VALUES (
--        @Correo_electrónico, @Contraseña, 'nocontraseña', @Nombre, @ApellidoP, @ApellidoM,
--        @Nombre_calle, @Numero_de_casa, @Municipio, @Código_postal, @Ciudad, @Estado, @País,
--        @Número_de_nomina, @Fecha_de_Nacimiento, SCOPE_IDENTITY()
--    );

--    -- Get the ID_admin based on Correo_electrónico_admin
--    DECLARE @ID_admin int;
--    SELECT @ID_admin = ID_admin FROM Administrador_ WHERE Correo_electrónico = @Correo_electrónico_admin;

--    -- Insert into Operativo table
--    INSERT INTO Operativo (Correo_electrónico, ID_admin, Fecha_y_hora)
--    VALUES (@Correo_electrónico, @ID_admin, GETDATE());
--END;

--CREATE PROCEDURE QueNoSeRepita(
--@Correo varchar(30),
--@Contraseña varchar(30)
--)
--AS
--BEGIN
--Select Correo_electrónico from Usuario
--where Correo_electrónico=@Correo
--OR Contraseña=@Contraseña
--END
--_______________________________________________________FINAL DE PROCEDIMIENTOS DE REGISTRAR OPERATIVO______________________________________________________

--_______________________________________________________INICIO DE PROCEDIMIENTOS DE TIPO DE HABITACIÓN ______________________________________________________


----Para que llene la tabla en tipos de habitación
--CREATE PROCEDURE ObtenerTiposDeHabitacion
--AS
--BEGIN

--    SELECT Código_tipo_habitación, Número_de_camas_thabitación, Tipo_de_camas_thabitación, Precio_por_noche_por_persona_thabitación,
--           Número_de_personas_thabitación, Nivel_de_habitación_thabitación, Características_thabitación, Amenidades_thabitación,
--           Vista_al_frente_thabitación, Nombre_hotel
--    FROM Tipo_de_Habitación
--	join Hotel on ID_hotel=ID_HotelTipoHabitación
--END;

----Para agregar el tipo de habitacion

--CREATE PROCEDURE InsertarTipoHabitacion
--	@Hotel varchar(30),
--    @numcamas smallint,
--    @tipocama VARCHAR(30),
--    @precio money,
--    @numpersonas smallint,
--    @nivel VARCHAR(15),
--    @caracteristicas VARCHAR(100),
--    @amenidades VARCHAR(100),
--    @vistas char(1)
--AS
--BEGIN
--	DECLARE @NombreHotel varchar(30)

--	select @NombreHotel = ID_hotel from Hotel
--	where Nombre_hotel = @Hotel
--    INSERT INTO Tipo_de_Habitación
--	(ID_HotelTipoHabitación, Número_de_camas_thabitación,Tipo_de_camas_thabitación,Precio_por_noche_por_persona_thabitación,
--	Número_de_personas_thabitación,Nivel_de_habitación_thabitación,Características_thabitación,Amenidades_thabitación,Vista_al_frente_thabitación)
--    VALUES (@NombreHotel, @numcamas, @tipocama, @precio, @numpersonas, @nivel, @caracteristicas, @amenidades, @vistas)

--END;

--CREATE PROCEDURE EliminarTipoDeHabitacion
--    @CodigoTipoHabitacion INT
--AS
--BEGIN
--DECLARE @TIPO INT
--DECLARE @HAB INT

--SELECT @TIPO= Código_tipo_habitación  FROM Tipo_de_Habitación WHERE Código_tipo_habitación = @CodigoTipoHabitacion
--SELECT @HAB= Número_habitación FROM Habitación WHERE Tipo_de_habitación=@TIPO

--DELETE FROM Reservación WHERE Número_habitación_reservación=@HAB
--DELETE FROM Habitación WHERE Tipo_de_habitación= @TIPO
--DELETE FROM Tipo_de_Habitación WHERE Código_tipo_habitación =@TIPO;
--END;


----Para actualizar el tipo de habitacion
--CREATE PROCEDURE ActualizarTipoDeHabitacion
--@Hotel varchar(30),
--    @NumCamas smallint,
--    @TipoCamas VARCHAR(30),
--    @PrecioNoche money,
--    @NumPersonas smallint,
--    @NivelHabitacion varchar(15),
--    @Caracteristicas VARCHAR(100),
--    @Amenidades VARCHAR(100),
--    @VistaFrente char(1),
--    @CodigoTipoHabitacion INT
--AS
--BEGIN
--DECLARE @NombreHotel int

--select @NombreHotel = ID_hotel from Hotel where Nombre_hotel = @Hotel

--    UPDATE Tipo_de_Habitación
--    SET Número_de_camas_thabitación = @NumCamas,
--        Tipo_de_camas_thabitación = @TipoCamas,
--        Precio_por_noche_por_persona_thabitación = @PrecioNoche,
--        Número_de_personas_thabitación = @NumPersonas,
--        Nivel_de_habitación_thabitación = @NivelHabitacion,
--        Características_thabitación = @Caracteristicas,
--        Amenidades_thabitación = @Amenidades,
--        Vista_al_frente_thabitación = @VistaFrente,
--		ID_HotelTipoHabitación= @NombreHotel
--    WHERE Código_tipo_habitación = @CodigoTipoHabitacion;
--END;

--CREATE PROCEDURE VerificarHotel

--AS
--BEGIN

--Select ID_hotel FROM Hotel

--END;

--_______________________________________________________FINAL DE PROCEDIMIENTOS DE TIPO DE HABITACIÓN ______________________________________________________

--_______________________________________________________INICIO DE PROCEDIMIENTOS DE HOTELES  ______________________________________________________

--DE LA VENTANA DE HOTEL
----Para cargar todo en el dgv todos los hoteles
--CREATE PROCEDURE CargarHotel2
--AS
--BEGIN
--select ID_hotel, ID_admin_hotel, Nombre_hotel, Nombre_calle_hotel, Municipio_hotel, Código_postal_hotel,
--       Ciudad_hotel, Estado_hotel, País_hotel, Número_de_pisos_hotel, Número_de_Habitaciones_hotel, Amenidades_hotel, Zona_turística_hotel,
--       Servicio_adicional_hotel, Sala_de_eventos_hotel, Fecha_inicio_operaciones_hotel, Teléfono_hotel 
--	   from Hotel;
--END;

----Para insertar hotel
--CREATE PROCEDURE InsertarHotel 
--    @AdminHotel varchar (30),
--    @Nombre VARCHAR(20),
--    @Calle VARCHAR(20),
--    @Municipio VARCHAR(20),
--    @CodigoPostal VARCHAR(5),
--    @Ciudad VARCHAR(15),
--    @Estado VARCHAR(15),
--    @Pais VARCHAR(15),
--    @NumPisos tinyint,
--    @NumHabitaciones tinyint,
--    @Amenidades VARCHAR(100),
--    @ZonaTuristica VARCHAR(250),
--    @ServicioAdicional VARCHAR(250),
--    @SalaEventos VARCHAR(250),
--    @FechaInicio DATE,
--    @Telefono VARCHAR(10)
--AS
--BEGIN
--DECLARE @IDAdminHotel int

--SELECT @IDAdminHotel= ID_admin FROM Administrador_ where Correo_electrónico=@AdminHotel

--    INSERT INTO Hotel (ID_admin_hotel, Nombre_hotel, Nombre_calle_hotel, Municipio_hotel, Código_postal_hotel, Ciudad_hotel, Estado_hotel, País_hotel, 
--	Número_de_pisos_hotel, Número_de_habitaciones_hotel, Amenidades_hotel, Zona_turística_hotel, Servicio_adicional_hotel, Sala_de_eventos_hotel, 
--	Fecha_inicio_operaciones_hotel, Teléfono_hotel, Fecha_y_hora_registro_hotel)

--    VALUES (@IDAdminHotel, @Nombre, @Calle, @Municipio, @CodigoPostal, @Ciudad, @Estado, @Pais, @NumPisos, @NumHabitaciones, @Amenidades, 
--	@ZonaTuristica, @ServicioAdicional, @SalaEventos, @FechaInicio, @Telefono, GETDATE())
--END;

----Para eliminar Hotel
----Eliminar no es lago que ponemos
--CREATE PROCEDURE EliminarHotel
--    @IDHotel varchar (30),
--    @AdminHotel varchar(30)
--AS
--BEGIN
--DECLARE @IDAdminHotel int
--select @IDAdminHotel= ID_admin FROM Administrador_ where Correo_electrónico=@AdminHotel
--    DELETE FROM Hotel
--    WHERE ID_hotel = @IDHotel AND ID_admin_hotel = @IDAdminHotel --@IDAdminHotel
--END;

--CREATE PROCEDURE ActualizarHotel
--    @Hotel varchar(30),
--	@AdminHotel varchar(30),
--    @Nombre VARCHAR(20),
--    @Calle VARCHAR(20),
--    @Municipio VARCHAR(20),
--    @CodigoPostal VARCHAR(5),
--    @Ciudad VARCHAR(15),
--    @Estado VARCHAR(15),
--    @Pais VARCHAR(15),
--    @NumPisos tinyint,
--    @NumHabitaciones tinyint,
--    @Amenidades VARCHAR(100),
--    @ZonaTuristica VARCHAR(250),
--    @ServicioAdicional VARCHAR(250),
--    @SalaEventos VARCHAR(250),
--    @FechaInicio DATE,
--    @Telefono VARCHAR(10)
--AS
--BEGIN
--DECLARE @IDAdminHotel int
--Select @IDAdminHotel= ID_admin FROM Administrador_ where Correo_electrónico=@AdminHotel

--    UPDATE Hotel
--    SET ID_admin_hotel = @IDAdminHotel,
--        Nombre_hotel = @Nombre,
--        Nombre_calle_hotel = @Calle,
--        Municipio_hotel = @Municipio,
--        Código_postal_hotel = @CodigoPostal,
--        Ciudad_hotel = @Ciudad,
--        Estado_hotel = @Estado,
--        País_hotel = @Pais,
--        Número_de_pisos_hotel = @NumPisos,
--        Número_de_habitaciones_hotel = @NumHabitaciones,
--        Amenidades_hotel = @Amenidades,
--        Zona_turística_hotel = @ZonaTuristica,
--        Servicio_adicional_hotel = @ServicioAdicional,
--        Sala_de_eventos_hotel = @SalaEventos,
--        Fecha_inicio_operaciones_hotel = @FechaInicio,
--        Teléfono_hotel = @Telefono,
--        Fecha_y_hora_registro_hotel = GETDATE()
--    WHERE Nombre_hotel=@Hotel
--END;

--_______________________________________________________FINAL DE PROCEDIMIENTOS DE HOTELES  ______________________________________________________

--_______________________________________________________INICIO DE PROCEDIMIENTOS DE HABITACIÓN  ______________________________________________________

--DE LA VENTANA DE HABITACIÓN
--Para cargar en el dgv todos los tipos de habitaciones
--CREATE PROCEDURE CargarTipoHabitacion
--AS
--BEGIN

--select th.Código_tipo_habitación, Número_de_camas_thabitación, Tipo_de_camas_thabitación, Precio_por_noche_por_persona_thabitación,
--       Número_de_personas_thabitación, Nivel_de_habitación_thabitación, Características_thabitación, Amenidades_thabitación,
--       Vista_al_frente_thabitación, h.Nombre_hotel
--	   from Tipo_de_Habitación th
--	   INNER JOIN Hotel h ON ID_hotel = th.ID_HotelTipoHabitación
--END;

--Para cargar en el dgv todos las habitaciones
--CREATE PROCEDURE CargarHabitacion
--AS
--BEGIN
--select Número_habitación, Habitación_creada_Admin, Tipo_de_habitación, ID_hotel_habitación,
--       Fecha_y_hora_registro_habitación 
--	   from Habitación;
--END;

--Para cargar en el dgv todos los hoteles
--CREATE PROCEDURE CargarHotelconHabitación
--@IDHOTEL int
--AS
--BEGIN
--select ID_hotel, ID_admin_hotel, Nombre_hotel, Nombre_calle_hotel, Municipio_hotel, Código_postal_hotel,
--       Ciudad_hotel, Estado_hotel, País_hotel, Número_de_pisos_hotel, Número_de_habitaciones_hotel, Amenidades_hotel, Zona_turística_hotel,
--       Servicio_adicional_hotel, Sala_de_eventos_hotel, Fecha_inicio_operaciones_hotel, Teléfono_hotel 
--	   from Hotel
--	   where ID_hotel=@IDHOTEL
--END;

--Para crear una habitación

--CREATE PROCEDURE InsertarHabitacion

--    @HabitacionCreadaAdmin varchar (30),
--    @TipoHabitacion INT,
--    @IDHotel INT,
--    @FechaHoraRegistro DATE
--AS
--BEGIN
--DECLARE @IDADMIN int
--SELECT @IDADMIN = ID_admin FROM Administrador_ WHERE Correo_electrónico=@HabitacionCreadaAdmin
--    INSERT INTO Habitación (Habitación_creada_Admin, Tipo_de_habitación, ID_hotel_habitación, Fecha_y_hora_registro_habitación)
--    VALUES (@IDADMIN, @TipoHabitacion, @IDHotel, @FechaHoraRegistro)
--END;


----Para actualizar habitación
--CREATE PROCEDURE ActualizarHabitacion
--    @TipoHabitacion INT,
--    @IDHotel INT,
--    @FechaHoraRegistro DATE,
--    @NumeroHabitacion INT
--AS
--BEGIN
--    UPDATE Habitación
--    SET Tipo_de_habitación = @TipoHabitacion,
--        ID_hotel_habitación = @IDHotel,
--        Fecha_y_hora_registro_habitación = @FechaHoraRegistro
--    WHERE Número_habitación = @NumeroHabitacion
--END;

----Para eliminar Habitación
--CREATE PROCEDURE EliminarHabitacion
--    @NumeroHabitacion INT
--AS
--BEGIN
--    DELETE FROM Habitación
--    WHERE Número_habitación = @NumeroHabitacion
--END;

--Para cargar en el dgv todos los tipos de habitaciones
--CREATE PROCEDURE CargarTipoHabitacionconHotel
--	@ID_Hotel int
--AS
--BEGIN

--select th.Código_tipo_habitación, Número_de_camas_thabitación, Tipo_de_camas_thabitación, Precio_por_noche_por_persona_thabitación,
--       Número_de_personas_thabitación, Nivel_de_habitación_thabitación, Características_thabitación, Amenidades_thabitación,
--       Vista_al_frente_thabitación, h.Nombre_hotel
--	   from Tipo_de_Habitación th
--	   INNER JOIN Hotel h ON ID_hotel = th.ID_HotelTipoHabitación
--	   where ID_hotel = @ID_Hotel;
--END;

--_______________________________________________________FINAL DE PROCEDIMIENTOS DE HABITACIÓN  ______________________________________________________

--_______________________________________________________ INICIO DE PROCEDIMIENTOS DE REPORTE DE OCUPACIÓN  ____________________________________________________

--FUNCION1
--CREATE FUNCTION ObtenerTotalHabitacionesOcupadas()
--RETURNS INT
--AS
--BEGIN
--    DECLARE @TotalHabitacionesOcupadas INT;

--    SELECT @TotalHabitacionesOcupadas = COUNT(hr.Número_habitación_reservada)
--    FROM Habitación_reservada hr
--    INNER JOIN Habitación h ON hr.Número_habitación_reservada = h.ID_hotel_habitación
--    INNER JOIN Hotel ho ON h.ID_hotel_habitación = ho.ID_hotel;

--    RETURN @TotalHabitacionesOcupadas;
--END;

--FUNCION2
--CREATE FUNCTION ObtenerHabitacionesDisponiblesEnHotel(@IDHotel INT)
--RETURNS INT
--AS
--BEGIN
--    DECLARE @HabitacionesDisponibles INT;

--    SELECT @HabitacionesDisponibles = COUNT(Número_de_habitaciones_hotel)
--    FROM Hotel
--    WHERE ID_hotel = @IDHotel;

--    RETURN @HabitacionesDisponibles;
--END;

--FUNCION3
--CREATE FUNCTION Porcentaje_Ocupacion(@IDHotel INT)
--RETURNS DECIMAL(5,2)
--AS
--BEGIN
--    DECLARE @HabitacionesTotales INT;
--    DECLARE @HabitacionesOcupadas INT;
--    DECLARE @PorcentajeOcupacion DECIMAL(5,2);

--    -- Obtener el número total de habitaciones en el hotel
--    SELECT @HabitacionesTotales = COUNT(*)
--    FROM Habitación
--    WHERE ID_hotel_habitación = @IDHotel;

--    -- Obtener el número de habitaciones ocupadas en el hotel
--    SELECT @HabitacionesOcupadas = COUNT(*)
--    FROM Habitación ha
--    INNER JOIN Reservación r ON r.Número_habitación_reservación = ha.Número_habitación
--    WHERE ha.ID_hotel_habitación = @IDHotel
--    AND r.Status_reservación = 'Y';

--    -- Calcular el porcentaje de ocupación
--	    SET @PorcentajeOcupacion = (@HabitacionesOcupadas * @HabitacionesTotales) / 100 ;
--    --SET @PorcentajeOcupacion = (@HabitacionesOcupadas * 100.0) / @HabitacionesTotales;

--    RETURN @PorcentajeOcupacion;
--END;

----FUNCTION 4
--CREATE FUNCTION SumaPersonasHospedadasPorHotel(@IDHotel INT)
--RETURNS INT
--AS
--BEGIN
--    	DECLARE @TotalPersonasHospedadas INT;

--SELECT @TotalPersonasHospedadas = SUM(r.Número_de_personas_en_habitación_reservación)
--FROM Reservación r
--INNER JOIN Habitación h ON r.Número_habitación_reservación = h.Número_habitación
--WHERE r.ID_hotel_reservación=@IDHotel
--    RETURN @TotalPersonasHospedadas;
--END;

----FUNCTION 5
--CREATE FUNCTION SumaPersonasHospedadasPorHotelM(
--    @IDHotel INT,
--    @Year INT,
--    @Month INT
--)
--RETURNS INT
--AS
--BEGIN
--    DECLARE @TotalPersonasHospedadas INT;

--    SELECT @TotalPersonasHospedadas = SUM(r.Número_de_personas_en_habitación_reservación)
--    FROM Reservación r
--    INNER JOIN Habitación h ON r.Número_habitación_reservación = h.Número_habitación
--    WHERE r.ID_hotel_reservación = @IDHotel
--        AND DATEPART(YEAR, r.Fecha_entrada_reservación) = @Year
--        AND DATEPART(MONTH, r.Fecha_entrada_reservación) = @Month;

--    RETURN @TotalPersonasHospedadas;
--END;


----VISTA1--La vista para los hoteles al cargar pantalla
--CREATE VIEW vHotel1 AS
--	SELECT
--    h.ID_hotel,
--    h.Ciudad_hotel,
--    h.Nombre_hotel,
--    FORMAT(h.Fecha_inicio_operaciones_hotel, 'yyyy-MM') AS Inicio_hotel,
--    (
--        SELECT STRING_AGG(Nivel_de_habitación_thabitación, ', ')
--        FROM (
--            SELECT DISTINCT T.Nivel_de_habitación_thabitación
--            FROM Tipo_de_Habitación T
--            WHERE T.ID_HotelTipoHabitación = h.ID_hotel
--        ) AS subquery
--    ) AS Tipos_Existentes,
--    dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel) AS Cantidad_Habitaciones,
--    (dbo.ObtenerTotalHabitacionesOcupadas() * dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel)) / 100.0 AS Porcentaje_Ocupacion,
--	dbo.SumaPersonasHospedadasPorHotel(h.ID_hotel) AS Total_Personas_Hospedadas_en_Hotel,
--    v.Total_Personas_Hospedadas,
--    v.Año,
--    v.Mes
--FROM
--    Hotel h
--INNER JOIN
--(
--    SELECT
--        r.ID_hotel_reservación,
--        DATEPART(YEAR, r.Fecha_entrada_reservación) AS Año,
--        DATEPART(MONTH, r.Fecha_entrada_reservación) AS Mes,
--        dbo.SumaPersonasHospedadasPorHotelM(r.ID_hotel_reservación, DATEPART(YEAR, r.Fecha_entrada_reservación), DATEPART(MONTH, r.Fecha_entrada_reservación)) AS Total_Personas_Hospedadas
--    FROM
--        Reservación r
--) v ON h.ID_hotel = v.ID_hotel_reservación
--LEFT JOIN Tipo_de_Habitación T ON T.ID_HotelTipoHabitación = h.ID_hotel
--GROUP BY
--    h.ID_hotel,
--    h.Ciudad_hotel,
--    h.Nombre_hotel,
--    FORMAT(h.Fecha_inicio_operaciones_hotel, 'yyyy-MM'),
--    dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel),
--    (dbo.ObtenerTotalHabitacionesOcupadas() * dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel)) / 100.0,
--    v.Total_Personas_Hospedadas,
--    v.Año,
--    v.Mes;


--CREATE PROCEDURE ObtenerDatosHotel
--AS
--BEGIN
--    SET NOCOUNT ON;

--    SELECT DISTINCT
--	Nombre_hotel, Ciudad_hotel, Inicio_hotel, Tipos_Existentes,Cantidad_Habitaciones, Porcentaje_Ocupacion,Total_Personas_Hospedadas_en_Hotel, Total_Personas_Hospedadas, Año, Mes
--    FROM vHotel1;
--END;


--Para obtener los datos del hotel resumido
--CREATE PROCEDURE ObtenerDatosHotelResum
--AS
--BEGIN
--    SET NOCOUNT ON;

--    select Distinct
--	Nombre_hotel, Ciudad_hotel, Inicio_hotel, Porcentaje_Ocupacion, Total_Personas_Hospedadas_en_Hotel FROM vHotel1;
--END;

----Filtrar los hoteles del pais
--CREATE PROCEDURE GetFiltroHotelPais1
--    @PaisHotel VARCHAR(15),
--    @AnoOperacionesHotel int--date
--AS
--BEGIN
    
--	SELECT DISTINCT
--    v.Nombre_hotel,
--    v.Ciudad_hotel,
--    v.Inicio_hotel,
--    v.Tipos_Existentes,
--    v.Cantidad_Habitaciones,
--    v.Porcentaje_Ocupacion,
--    v.Total_Personas_Hospedadas_en_Hotel,
--    v.Total_Personas_Hospedadas,
--    v.Año,
--    v.Mes
--FROM
--    vHotel1 v
--    INNER JOIN Hotel h ON h.ID_hotel = v.ID_hotel
--WHERE
--    h.País_hotel = @PaisHotel AND CAST(LEFT(v.Inicio_hotel, 4) AS INT) = @AnoOperacionesHotel;
--END;



----Filtrar los hoteles del pais resumido
--CREATE PROCEDURE GetFiltroHotelPaisResum
--    @PaisHotel VARCHAR(15),
--    @AnoOperacionesHotel int--date
--AS
--BEGIN
--	SELECT DISTINCT
--    v.Nombre_hotel,
--    v.Ciudad_hotel,
--    v.Inicio_hotel,
--    v.Porcentaje_Ocupacion
--FROM
--    vHotel1 v
--    INNER JOIN Hotel h ON h.ID_hotel = v.ID_hotel
--WHERE
--    h.País_hotel = @PaisHotel AND CAST(LEFT(v.Inicio_hotel, 4) AS INT) = @AnoOperacionesHotel;
--END;

--CREATE PROCEDURE GetFiltroHotelCiudad1
--    @CiudadHotel VARCHAR(15),
--    @AnoOperacionesHotel INT
--AS
--BEGIN
--   SELECT DISTINCT
--    v.Nombre_hotel,
--    v.Ciudad_hotel,
--    v.Inicio_hotel,
--    v.Tipos_Existentes,
--    v.Cantidad_Habitaciones,
--    v.Porcentaje_Ocupacion,
--    v.Total_Personas_Hospedadas_en_Hotel,
--    v.Total_Personas_Hospedadas,
--    v.Año,
--    v.Mes
--FROM
--    vHotel1 v
--    INNER JOIN Hotel h ON h.ID_hotel = v.ID_hotel
--WHERE
--    h.Ciudad_hotel = @CiudadHotel AND CAST(LEFT(v.Inicio_hotel, 4) AS INT) = @AnoOperacionesHotel;
--END;


----Filtrar los hoteles de ciudad resumido
--CREATE PROCEDURE GetFiltroHotelCiudadResum
--    @CiudadHotel VARCHAR(15),
--    @AnoOperacionesHotel INT
--AS
--BEGIN
--   	SELECT DISTINCT
--    v.Nombre_hotel,
--    v.Ciudad_hotel,
--    v.Inicio_hotel,
--    v.Porcentaje_Ocupacion
--FROM
--    vHotel1 v
--    INNER JOIN Hotel h ON h.ID_hotel = v.ID_hotel
--WHERE
--    h.Ciudad_hotel = @CiudadHotel AND CAST(LEFT(v.Inicio_hotel, 4) AS INT) = @AnoOperacionesHotel;
--END;

--CREATE PROCEDURE GetFiltroHotelAnoNombre
--    @NombreHotel VARCHAR(20),
--    @AnoOperacionesHotel INT
--AS
--BEGIN
--   SELECT DISTINCT
--    v.Nombre_hotel,
--    v.Ciudad_hotel,
--    v.Inicio_hotel,
--    v.Tipos_Existentes,
--    v.Cantidad_Habitaciones,
--    v.Porcentaje_Ocupacion,
--    v.Total_Personas_Hospedadas_en_Hotel,
--    v.Total_Personas_Hospedadas,
--    v.Año,
--    v.Mes
--FROM
--    vHotel1 v
--    INNER JOIN Hotel h ON h.ID_hotel = v.ID_hotel
--WHERE
--    h.Nombre_hotel= @NombreHotel AND CAST(LEFT(v.Inicio_hotel, 4) AS INT) = @AnoOperacionesHotel;
--END;

----Filtrar los hoteles por nombre resumido
--CREATE PROCEDURE GetFiltroHotelNombreResum
--    @NombreHotel VARCHAR(20),
--    @AnoOperacionesHotel INT

--AS
--BEGIN
--   	SELECT DISTINCT
--    v.Nombre_hotel,
--    v.Ciudad_hotel,
--    v.Inicio_hotel,
--    v.Porcentaje_Ocupacion
--FROM
--    vHotel1 v
--    INNER JOIN Hotel h ON h.ID_hotel = v.ID_hotel
--WHERE
--    h.Nombre_hotel = @NombreHotel AND CAST(LEFT(v.Inicio_hotel, 4) AS INT) = @AnoOperacionesHotel;
--END;


----Filtrar los hoteles del año
--CREATE PROCEDURE GetFiltroHotelAno1
--    @AnoOperacionesHotel int--date
--AS
--BEGIN
--   SELECT DISTINCT
--    v.Nombre_hotel,
--    v.Ciudad_hotel,
--    v.Inicio_hotel,
--    v.Tipos_Existentes,
--    v.Cantidad_Habitaciones,
--    v.Porcentaje_Ocupacion,
--    v.Total_Personas_Hospedadas_en_Hotel,
--    v.Total_Personas_Hospedadas,
--    v.Año,
--    v.Mes
--FROM
--    vHotel1 v
--    INNER JOIN Hotel h ON h.ID_hotel = v.ID_hotel
--WHERE
--     CAST(LEFT(v.Inicio_hotel, 4) AS INT) = @AnoOperacionesHotel;
--END;

----Filtrar los hoteles del año resumido

--CREATE PROCEDURE GetFiltroHotelAnoResum
--    @AnoOperacionesHotel int--date
--AS
--BEGIN
--      	SELECT DISTINCT
--    v.Nombre_hotel,
--    v.Ciudad_hotel,
--    v.Inicio_hotel,
--    v.Porcentaje_Ocupacion
--FROM
--    vHotel1 v
--    INNER JOIN Hotel h ON h.ID_hotel = v.ID_hotel
--WHERE
--    CAST(LEFT(v.Inicio_hotel, 4) AS INT) = @AnoOperacionesHotel;
--END;

--_______________________________________________________FINAL DE PROCEDIMIENTOS DE REPORTE DE OCUPACIÓN  ______________________________________________________

--_______________________________________________________INICIO DE PROCEDIMIENTOS DE REPORTE DE VENTAS  ______________________________________________________

----FUNCTION 5
--CREATE FUNCTION cuentamonto(
--@IDH int, 
--@Year int, 
--@Month int)
--RETURNS MONEY
--AS
--BEGIN
--    DECLARE @TotalSum MONEY;

--    SELECT @TotalSum = SUM(Monto_total)
--    FROM Reservación
--	where ID_hotel_reservación=4
--	        AND DATEPART(YEAR, Fecha_entrada_reservación) = @Year
--        AND DATEPART(MONTH, Fecha_entrada_reservación) = @Month;

--    RETURN @TotalSum;
--END;

--FUNCTION 6
--CREATE FUNCTION cuentahospedaje (
--@IDH int, 
--@Year int, 
--@Month int
--)
--RETURNS MONEY
--AS
--BEGIN
--    DECLARE @TotalSum MONEY;

--    SELECT @TotalSum=CAST(T.Precio_por_noche_por_persona_thabitación AS DECIMAL(10, 2)) * r.Número_de_personas_en_habitación_reservación 
--	FROM Reservación r
--	join Hotel h on r.ID_hotel_reservación=h.ID_hotel
--	join Habitación ha on r.Número_habitación_reservación=ha.Número_habitación
--	left join Tipo_de_Habitación T on ha.Tipo_de_habitación=T.Código_tipo_habitación
--	where h.ID_hotel=@IDH
--	        AND DATEPART(YEAR, r.Fecha_entrada_reservación ) = @Year
--        AND DATEPART(MONTH, Fecha_entrada_reservación) = @Month

--    RETURN @TotalSum;
--END;

--VISTA2--la vista para las ventas al cargar pantalla
--CREATE VIEW vVentas1 AS
--SELECT DISTINCT h.ID_hotel ,h.Nombre_hotel, h.Ciudad_hotel,
--FORMAT(h.Fecha_inicio_operaciones_hotel, 'yyyy-MM') AS Inicio_hotel,
--h.Servicio_adicional_hotel, v.Año, v.Mes, v.Monto_total_hotel, z.Monto_hospedaje, v.Monto_total_hotel - z.Monto_hospedaje AS Servicios_adicionales
--FROM Hotel h
--INNER JOIN
--(
--    SELECT DISTINCT
--        r.ID_hotel_reservación,
--        DATEPART(YEAR, r.Fecha_entrada_reservación) AS Año,
--        DATEPART(MONTH, r.Fecha_entrada_reservación) AS Mes,
--        dbo.cuentamonto(r.ID_hotel_reservación, DATEPART(YEAR, r.Fecha_entrada_reservación), DATEPART(MONTH, r.Fecha_entrada_reservación)) AS Monto_total_hotel
--    FROM
--        Reservación r
--) v ON h.ID_hotel = v.ID_hotel_reservación
--INNER JOIN
--(
--    SELECT DISTINCT
--        r.ID_hotel_reservación,
--        DATEPART(YEAR, r.Fecha_entrada_reservación) AS Año,
--        DATEPART(MONTH, r.Fecha_entrada_reservación) AS Mes,
--        dbo.cuentahospedaje(r.ID_hotel_reservación, DATEPART(YEAR, r.Fecha_entrada_reservación), DATEPART(MONTH, r.Fecha_entrada_reservación)) AS Monto_hospedaje
--    FROM
--        Reservación r
--) z ON h.ID_hotel = z.ID_hotel_reservación

--Para obtener los datos del reporte de ventas
--CREATE PROCEDURE ObtenerDatosVentas
--AS
--BEGIN
--    SET NOCOUNT ON;
--    SELECT DISTINCT
--	Nombre_hotel, Ciudad_hotel, Servicio_adicional_hotel, Año, Mes, Monto_total_hotel, Monto_hospedaje, Servicios_adicionales
--    FROM vVentas1;
--END;

--Filtrar las ventas del pais
--CREATE PROCEDURE GetFiltroVentasPais
--    @PaisVentas VARCHAR(20),
--    @AnoVentasPais INT
--AS
--BEGIN
--   SET NOCOUNT ON;
--    SELECT DISTINCT
--	v.Nombre_hotel, v.Ciudad_hotel, v.Servicio_adicional_hotel, v.Año, v.Mes, v.Monto_total_hotel, v.Monto_hospedaje, v.Servicios_adicionales
--    FROM vVentas1 v
--	INNER JOIN Hotel h on h.ID_hotel=v.ID_hotel
--    where h.País_hotel = @PaisVentas AND CAST(LEFT(v.Inicio_hotel, 4) AS INT) = @AnoVentasPais;
--END;

--Filtrar las ventas de la ciudad
--CREATE PROCEDURE GetFiltroVentasCiudad
--    @CiudadVentas VARCHAR(20),
--    @AnoVentasCiudad INT
--AS
--BEGIN
--     SET NOCOUNT ON;
--    SELECT DISTINCT
--	v.Nombre_hotel, v.Ciudad_hotel, v.Servicio_adicional_hotel, v.Año, v.Mes, v.Monto_total_hotel, v.Monto_hospedaje, v.Servicios_adicionales
--    FROM vVentas1 v
--	INNER JOIN Hotel h on h.ID_hotel=v.ID_hotel
--    where h.Ciudad_hotel = @CiudadVentas AND CAST(LEFT(v.Inicio_hotel, 4) AS INT) = @AnoVentasCiudad;
--END;

----Filtrar las ventas por nombre
--CREATE PROCEDURE GetFiltroVentasNombre
--    @NombreVentas VARCHAR(20),
--    @AnoVentasNombre INT
--AS
--BEGIN
--     SET NOCOUNT ON;
--    SELECT DISTINCT
--	v.Nombre_hotel, v.Ciudad_hotel, v.Servicio_adicional_hotel, v.Año, v.Mes, v.Monto_total_hotel, v.Monto_hospedaje, v.Servicios_adicionales
--    FROM vVentas1 v
--	INNER JOIN Hotel h on h.ID_hotel=v.ID_hotel
--    where h.Nombre_hotel = @NombreVentas AND CAST(LEFT(v.Inicio_hotel, 4) AS INT) = @AnoVentasNombre;
--END;

----Filtrar las ventas del año
--CREATE PROCEDURE GetFiltroVentasAno
--    @AnoVentas INT
--AS
--BEGIN
--	  SET NOCOUNT ON;
--    SELECT DISTINCT
--	v.Nombre_hotel, v.Ciudad_hotel, v.Servicio_adicional_hotel, v.Año, v.Mes, v.Monto_total_hotel, v.Monto_hospedaje, v.Servicios_adicionales
--    FROM vVentas1 v
--	INNER JOIN Hotel h on h.ID_hotel=v.ID_hotel
--    where  CAST(LEFT(v.Inicio_hotel, 4) AS INT) = @AnoVentas;
--END;

--_______________________________________________________FINAL DE PROCEDIMIENTOS DE REPORTE DE VENTAS  ______________________________________________________



---LAS OPCIONES DE MENÚ OPERATIVOS

--_______________________________________________________INICIO DE REGISTRAR CLIENTES  ______________________________________________________

--CREATE PROCEDURE GetClienteByRFC
--    @Rfc VARCHAR(13)
--AS
--BEGIN
--    SELECT C.Nombre_cliente, C.ApellidoP_cliente,C.ApellidoM_cliente, C.Nombre_calle_cliente,
--           C.Numero_de_casa_cliente, C.Municipio_cliente, C.Código_postal_cliente, C.Ciudad_cliente,
--           C.Estado_cliente, C.País_cliente, C.RFC_cliente, C.Fecha_de_Nacimiento_cliente,
--           C.Estado_Civil_cliente, R.Referencia_Hotel, O.Teléfono_Casa, O.Teléfono_Celular, O.Correo_electrónico_Cliente
--    FROM Cliente C
--	join Cliente_Referencia R ON R.ID_referencia_hotel=C.ID_referencia_hotel
--    JOIN Cliente_Contacto O ON O.ID_cliente_contacto = C.ID_cliente_contacto
--    WHERE C.RFC_cliente = @Rfc;
--END
--select * from Cliente
--CREATE PROCEDURE GetClienteByEmail
--    @Correo VARCHAR(30)
--AS
--BEGIN
-- SELECT C.Nombre_cliente, C.ApellidoP_cliente,C.ApellidoM_cliente, C.Nombre_calle_cliente,
--           C.Numero_de_casa_cliente, C.Municipio_cliente, C.Código_postal_cliente, C.Ciudad_cliente,
--           C.Estado_cliente, C.País_cliente, C.RFC_cliente, C.Fecha_de_Nacimiento_cliente,
--           C.Estado_Civil_cliente, R.Referencia_Hotel, O.Teléfono_Casa, O.Teléfono_Celular, O.Correo_electrónico_Cliente
--    FROM Cliente C
--	join Cliente_Referencia R ON R.ID_referencia_hotel=C.ID_referencia_hotel
--    JOIN Cliente_Contacto O ON O.ID_cliente_contacto = C.ID_cliente_contacto
--    WHERE O.Correo_electrónico_Cliente=@Correo;
--END

--CREATE PROCEDURE GetClienteByApellidos
--    @PAP VARCHAR(13),
--	@MAP VARCHAR(13)
--AS
--BEGIN
--SELECT C.Nombre_cliente, C.ApellidoP_cliente,C.ApellidoM_cliente, C.Nombre_calle_cliente,
--           C.Numero_de_casa_cliente, C.Municipio_cliente, C.Código_postal_cliente, C.Ciudad_cliente,
--           C.Estado_cliente, C.País_cliente, C.RFC_cliente, C.Fecha_de_Nacimiento_cliente,
--           C.Estado_Civil_cliente, R.Referencia_Hotel, O.Teléfono_Casa, O.Teléfono_Celular, O.Correo_electrónico_Cliente
--    FROM Cliente C
--	join Cliente_Referencia R ON R.ID_referencia_hotel=C.ID_referencia_hotel
--    JOIN Cliente_Contacto O ON O.ID_cliente_contacto = C.ID_cliente_contacto
--    WHERE C.ApellidoP_cliente=@PAP AND C.ApellidoM_cliente=@MAP
--END



--CREATE PROCEDURE InsertCliente
--(
--    @Nombrecliente varchar(20),
--    @Pcliente varchar(10),
--    @Mcliente varchar(10),
--    @nombrecallecl varchar(20),
--    @numcasacl int,
--    @municipiocliente varchar(20),
--    @codposcliente varchar(5),
--    @ciudadcliente varchar(15),
--    @estadocliente varchar(15),
--    @paíscliente varchar(15),
--    @rfccliente varchar(13),
--    @nacimientocliente date,
--    @estadocivilcl varchar(10),
--    @Referencia varchar(20),
--    @Teléfono_Casa varchar(10),
--    @Teléfono_Celular varchar(10),
--    @Correocliente varchar(20),
--    @Correo_electrónico_operativo varchar(20)
--)
--AS
--BEGIN
--    SET NOCOUNT ON;

--    -- Insert into Cliente_Contacto table
--    DECLARE @ID_cliente_contacto int;
--    INSERT INTO Cliente_Contacto (Teléfono_Casa, Teléfono_Celular, Correo_electrónico_Cliente)
--    VALUES (@Teléfono_Casa, @Teléfono_Celular, @Correocliente);

--    SET @ID_cliente_contacto = SCOPE_IDENTITY();

--    -- Insert into Cliente_Referencia table
--    DECLARE @ID_referencia_hotel int;
--    INSERT INTO Cliente_Referencia (Referencia_Hotel)
--    VALUES (@Referencia);

--    SET @ID_referencia_hotel = SCOPE_IDENTITY();

--    -- Insert into Cliente table
--    DECLARE @ID_Operativo int;
--    SELECT @ID_Operativo = ID_operativo FROM Operativo where Correo_electrónico = @Correo_electrónico_operativo;

--    INSERT INTO Cliente
--    (
--        ID_operativo_cliente, Nombre_cliente, ApellidoP_cliente, ApellidoM_cliente,
--        Nombre_calle_cliente, Numero_de_casa_cliente, Municipio_cliente,
--        Código_postal_cliente, Ciudad_cliente, Estado_cliente, País_cliente,
--        RFC_cliente, Fecha_de_Nacimiento_cliente, Estado_Civil_cliente,
--        Fecha_y_hora_registro_cliente, ID_cliente_contacto, ID_referencia_hotel
--    )
--    VALUES
--    (
--        @ID_Operativo, @Nombrecliente, @Pcliente, @Mcliente,
--        @nombrecallecl, @numcasacl, @municipiocliente,
--        @codposcliente, @ciudadcliente, @estadocliente, @paíscliente,
--        @rfccliente, @nacimientocliente, @estadocivilcl,
--        GETDATE(), @ID_cliente_contacto, @ID_referencia_hotel
--    );
--END;

--CREATE PROCEDURE Actualizarclientes
--(
--    @Nombre varchar(20),
--    @ApePat varchar(10),
--    @ApeMat varchar(10),
--    @NomCalle varchar(20),
--    @NumCasa int,
--    @Municipio varchar(20),
--    @CodPos varchar(5),
--    @Ciudad varchar(15),
--    @Estado varchar(15),
--    @Pais varchar(15),
--    @RFC varchar(13),
--    @Nacimiento date,
--    @Civil varchar(10),
--    @TelCasa varchar(10),
--    @TelCelular varchar(10),
--    @Email varchar(20),
--	@EmailOG varchar(20),
--	@Referencia varchar(20),
--	@IDOPERA varchar(20)
--)
--AS
--BEGIN
--    SET NOCOUNT ON;

--    DECLARE @IDVALUE int;
--    DECLARE @IDVAL int;
--	DECLARE @IDNVO int;
--	DECLARE @ID int;

--	SELECT @ID = ID_cliente FROM Cliente WHERE ID_cliente_contacto= (SELECT ID_cliente_contacto FROM Cliente_Contacto WHERE Correo_electrónico_Cliente=@EmailOG)
--    SELECT @IDVALUE = ID_cliente_contacto FROM Cliente WHERE ID_cliente = @ID;
--    SELECT @IDVAL = ID_referencia_hotel FROM Cliente WHERE ID_cliente = @ID;
--	SELECT @IDNVO = ID_operativo FROM Operativo WHERE Correo_electrónico=@IDOPERA
--   UPDATE Cliente_Referencia
--    SET Referencia_Hotel = @Referencia
--    WHERE ID_referencia_hotel = @IDVAL;

-- UPDATE Cliente_Contacto
--    SET Teléfono_Casa = @TelCasa,
--        Teléfono_Celular = @TelCelular,
--        Correo_electrónico_Cliente = @Email
--    WHERE ID_cliente_contacto = @IDVALUE;


--    UPDATE Cliente
--    SET Nombre_cliente = @Nombre,
--        ApellidoP_cliente = @ApePat,
--        ApellidoM_cliente = @ApeMat,
--        Nombre_calle_cliente = @NomCalle,
--        Numero_de_casa_cliente = @NumCasa,
--        Municipio_cliente = @Municipio,
--        Código_postal_cliente = @CodPos,
--        Ciudad_cliente = @Ciudad,
--        Estado_cliente = @Estado,
--        País_cliente = @Pais,
--        RFC_cliente = @RFC,
--        Fecha_de_Nacimiento_cliente = @Nacimiento,
--        Estado_Civil_cliente = @Civil,
--		ID_operativo_cliente = @IDNVO,
--		Fecha_y_hora_registro_cliente = GETDATE()
--    WHERE ID_cliente = @ID;

--END;

--CREATE PROCEDURE VerificarCorreoCliente
--@Correo varchar (30)
--AS
--BEGIN
--SELECT ID_cliente_contacto FROM Cliente_Contacto WHERE Correo_electrónico_Cliente=@Correo
--END
--_______________________________________________________FINAL DE REGISTRAR CLIENTES ______________________________________________________

--_______________________________________________________INICIO DE PROCEDIMIENTOS DE RESERVACIÓN  ______________________________________________________
--DE LA VENTANA RESERVACIÓN
--Para que carguen los datos al abrir la ventana para los datos de los clientes

--VISTAS 3
--CREATE VIEW dbo.DatosClientes
--AS
--SELECT C.ID_cliente, C.ID_operativo_cliente, C.Nombre_cliente, C.ApellidoP_cliente, C.Nombre_calle_cliente,
--       C.Numero_de_casa_cliente, C.Municipio_cliente, C.Código_postal_cliente, C.Ciudad_cliente, C.Estado_cliente, C.País_cliente,
--       C.RFC_cliente, C.Fecha_de_Nacimiento_cliente, C.Estado_Civil_cliente, C.Fecha_y_hora_registro_cliente, O.ID_cliente_contacto
--FROM Cliente C
--JOIN Cliente_Contacto O ON O.ID_cliente_contacto = C.ID_cliente_contacto
--JOIN Cliente_Referencia R ON R.ID_referencia_hotel = C.ID_referencia_hotel;

--SELECT ID_cliente, ID_operativo_cliente, Nombre_cliente, ApellidoP_cliente, Nombre_calle_cliente,
--       Numero_de_casa_cliente, Municipio_cliente, Código_postal_cliente, Ciudad_cliente, Estado_cliente, País_cliente,
--       RFC_cliente, Fecha_de_Nacimiento_cliente, Estado_Civil_cliente, ID_cliente_contacto
--	   FROM dbo.DatosClientes

--CREATE PROCEDURE ObtenerDatosClientes
--AS
--BEGIN  

--    SELECT ID_cliente, ID_operativo_cliente, Nombre_cliente, ApellidoP_cliente, Nombre_calle_cliente,
--           Numero_de_casa_cliente, Municipio_cliente, Código_postal_cliente, Ciudad_cliente, Estado_cliente, País_cliente,
--           RFC_cliente, Fecha_de_Nacimiento_cliente, Estado_Civil_cliente, ID_cliente_contacto
--    FROM dbo.DatosClientes;
--END;

----Para que carguen los datos al abrir la ventana para los datos de los hoteles
--CREATE PROCEDURE ObtenerDatosHoteles
--AS
--BEGIN
--    SELECT ID_hotel, ID_admin_hotel, Nombre_hotel, Nombre_calle_hotel, Municipio_hotel, Código_postal_hotel,
--           Ciudad_hotel, Estado_hotel, País_hotel, Número_de_pisos_hotel, Número_de_habitaciones_hotel, Amenidades_hotel,
--           Zona_turística_hotel, Servicio_adicional_hotel, Sala_de_eventos_hotel, Teléfono_hotel
--    FROM dbo.DatosHoteles;
--END;

--CREATE PROCEDURE Habitacioneshotel
--@Hotel int
--AS
--BEGIN
----SELECT H.Código
--SELECT  H.Número_habitación , H.Habitación_creada_Admin , H.Tipo_de_habitación ,H.ID_hotel_habitación 
--FROM Habitación H
--Join Hotel Hl ON H.ID_hotel_habitación=Hl.ID_hotel
--WHERE Hl.ID_hotel=@Hotel;
--END

--CREATE PROCEDURE Habitacionesdisponibles
--@Inicio date,
--@Salida date,
--@Hotel int
--AS
--BEGIN

--SELECT H.Número_habitación, H.Tipo_de_habitación
--FROM Habitación H
--JOIN Hotel Hl ON H.ID_hotel_habitación = Hl.ID_hotel
--WHERE Hl.ID_hotel = @Hotel

--EXCEPT

--SELECT H.Número_habitación, H.Tipo_de_habitación
--FROM Habitación H
--LEFT JOIN Habitación_reservada HR ON H.Número_habitación = HR.Número_habitación_reservada
--JOIN Hotel Hl ON H.ID_hotel_habitación = Hl.ID_hotel
--JOIN Reservación R ON R.Número_habitación_reservación = H.Número_habitación
--WHERE HR.ID_habitación_reservada IS NULL
--  AND Hl.ID_hotel = @Hotel
--  AND (R.Fecha_entrada_reservación = @Inicio OR R.Fecha_salida_reservación = @Salida);

--END

--_______________________________________________________FINAL DE PROCEDIMIENTOS DE RESERVACIÓN  ______________________________________________________


CREATE PROCEDURE GetHotelesCiudad
	@Ciudad VARCHAR(13)
AS
BEGIN
	 SELECT ID_hotel, ID_admin_hotel, Nombre_hotel, Nombre_calle_hotel, Municipio_hotel, Código_postal_hotel, 
                Ciudad_hotel, Estado_hotel, País_hotel, Número_de_pisos_hotel, Número_de_habitaciones_hotel, Amenidades_hotel, 
                Zona_turística_hotel, Servicio_adicional_hotel, Sala_de_eventos_hotel, Fecha_inicio_operaciones_hotel, Teléfono_hotel 
                FROM Hotel
				where Ciudad_hotel=@Ciudad
END

CREATE PROCEDURE Monto  
@Hab int  
AS  
BEGIN  
SELECT Precio_por_noche_por_persona_thabitación  
from Tipo_de_Habitación t  
join Habitación h ON h.Tipo_de_habitación= t.Código_tipo_habitación  
where h.Número_habitación=@Hab  
END

CREATE PROCEDURE InsertReservación
(
    @IDHAM INT, 
    @IDCLIE INT, 
    @IDHOTEL INT, 
    @ENTRADA DATE,
    @SALIDA DATE,
    @PAGO VARCHAR(20),
    @NUMPERSONAS INT,
    @ANTICIPO MONEY
)
AS 
BEGIN
    DECLARE @TransHOY DATE;
    DECLARE @Rango INT;
    DECLARE @Monto DECIMAL(10,2);
    DECLARE @Faltante MONEY;

    SELECT @TransHOY = CONVERT(DATE, GETDATE(), 121);

    SET @Rango = DATEDIFF(DAY, @ENTRADA, @SALIDA);

    -- Call the function to calculate Monto and Faltante
    DECLARE @CalculationResult TABLE
    (
        Precio MONEY,
        Monto DECIMAL(10, 2),
        Faltante MONEY
    );

    INSERT INTO @CalculationResult (Precio, Monto, Faltante)
    SELECT Precio, Monto, Faltante
    FROM CalculateMontoAndFaltante(@IDHAM, @NUMPERSONAS, @ANTICIPO);

    -- Retrieve the values from the calculation result
    SELECT @Monto = Monto, @Faltante = Faltante
    FROM @CalculationResult;

    CREATE TABLE #ReservaciónTemp (
        Código_reservación UNIQUEIDENTIFIER
    );

    INSERT INTO Reservación (
        Número_habitación_reservación,
        ID_cliente_reservación,
        ID_hotel_reservación,
        Fecha_creación_reservación,
        Fecha_entrada_reservación,
        Fecha_salida_reservación,
        Tipo_de_pago,
        Fecha_y_hora_registro_reservación,
        Rango_de_fechas,
        Dinero_faltante,
        Anticipo_de_reservación,
        Monto_total,
        Número_de_personas_en_habitación_reservación, 
        Código_reservación
    )
    OUTPUT inserted.Código_reservación INTO #ReservaciónTemp
    VALUES (
        @IDHAM, 
        @IDCLIE, 
        @IDHOTEL, 
        @TransHOY,
        @ENTRADA,
        @SALIDA,
        @PAGO,
        @TransHOY,
        @Rango,
        @Faltante,
        @ANTICIPO,
        @Monto,
        @NUMPERSONAS,
        NEWID()
    );

    SELECT Código_reservación FROM #ReservaciónTemp;

    -- Clean up the temporary table
    DROP TABLE #ReservaciónTemp;
END

--3 TRIGGER!!
CREATE TRIGGER SepasodiadeEntrada
ON Reservación
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE R
    SET R.Status_reservación = 'N'
    FROM Reservación AS R
    JOIN inserted AS I ON R.Código_reservación = I.Código_reservación
    WHERE R.Status_reservación = 'Y' AND DATEDIFF(DAY, R.Fecha_entrada_reservación, GETDATE()) = 0;

END

--Para cargar en el dgv todos los tipos de habitaciones

CREATE PROCEDURE CargarTipoHabitacionconHotelR
	@ID_Hotel int
AS
BEGIN

select th.Código_tipo_habitación, Número_de_camas_thabitación, Tipo_de_camas_thabitación, Precio_por_noche_por_persona_thabitación,
       Número_de_personas_thabitación, Nivel_de_habitación_thabitación, Características_thabitación, Amenidades_thabitación,
       Vista_al_frente_thabitación
	   from Tipo_de_Habitación th
	   INNER JOIN Hotel h ON ID_hotel = th.ID_HotelTipoHabitación
	   where ID_hotel = @ID_Hotel;
END;


CREATE PROCEDURE CargarHabitacionesConTipo
@IDTIPO INT
AS
BEGIN
select Número_habitación, Fecha_y_hora_registro_habitación from Habitación where Tipo_de_habitación=@IDTIPO
END

--_______________________________________________________FINAL DE PROCEDIMIENTOS DE RESERVACIÓN  ______________________________________________________

EXEC InsertData   @Teléfono_Casa =2,
    @Teléfono_Celular=2,
    @Correo_electrónico_teléfono ='po',
    @Contraseña ='Fantastico!',
    @Nombre ='a',
    @ApellidoP ='a',
    @ApellidoM ='a',
    @Nombre_calle ='a',
    @Numero_de_casa =2,
    @Municipio='a',
    @Código_postal =2,
    @Ciudad ='a',
    @Estado='a',
    @País ='a',
    @Número_de_nomina =2,
    @Fecha_de_Nacimiento ='1978-04-27',
    @Correo_electrónico_admin='a@hotmail.com'


--CREATE PROCEDURE GetOperativoUsuario
--    @ID_Operativo INT
--AS
--BEGIN
--    SELECT
--        U.Correo_electrónico,
--        U.Contraseña,
--        U.Nombre,
--        U.ApellidoP,
--        U.ApellidoM,
--        U.Fecha_de_Nacimiento,
--        U.Nombre_calle,
--        U.Numero_de_casa,
--        U.Municipio,
--        U.Código_postal,
--        U.Ciudad,
--        U.Estado,
--        U.País,
--        U.Número_de_nomina,
--        UT.Teléfono_Casa,
--        UT.Teléfono_Celular
--    FROM
--        Usuario U
--        JOIN Operativo O ON U.Correo_electrónico = O.Correo_electrónico
--        JOIN Usuario_teléfono UT ON U.Teléfono = UT.ID_usuario_teléfono
--    WHERE
--        O.ID_operativo = @ID_Operativo;
--END;



drop procedure GetCliente
CREATE PROCEDURE GetCliente
	@RFC varchar(20)
AS
BEGIN
    SELECT
       Cl.Nombre_cliente,Cl.ApellidoP_cliente,
	   Cl.ApellidoM_cliente,Cl.Nombre_calle_cliente,Cl.Numero_de_casa_cliente,
	   Cl.Municipio_cliente,Cl.Código_postal_cliente,Cl.Ciudad_cliente, 
	   Cl.Estado_cliente, Cl.País_cliente, CL.RFC_cliente, Cl.Fecha_de_Nacimiento_cliente, 
	   Cl.Estado_Civil_cliente, CR.Referencia_Hotel,CC.Teléfono_Casa,CC.Teléfono_Celular,CC.Correo_electrónico_Cliente
    FROM
        Cliente Cl
        JOIN Cliente_Contacto CC ON Cl.ID_cliente_contacto=CC.ID_cliente_contacto
        JOIN Cliente_Referencia CR ON Cl.ID_referencia_hotel=CR.ID_referencia_hotel
    WHERE
        Cl.RFC_cliente=@RFC
END;









drop procedure Habitacioneshotel
select * from Habitación
CREATE PROCEDURE Habitacioneshotel
 @Hotel int
AS
BEGIN
SELECT  H.Número_habitación  , H.Tipo_de_habitación 
FROM Habitación H
Join Hotel Hl ON H.ID_hotel_habitación=Hl.ID_hotel
WHERE Hl.ID_hotel=@Hotel;
END

--este es el bueno
CREATE FUNCTION CalculateMontoAndFaltante(
    @IDHAM INT,
    @NUMPERSONAS INT,
    @ANTICIPO MONEY
)
RETURNS TABLE
AS
RETURN
(
    SELECT
        Precio,
        Monto,
        Faltante
    FROM (
        SELECT
            T.Precio_por_noche_por_persona_thabitación AS Precio,
            CAST(T.Precio_por_noche_por_persona_thabitación AS DECIMAL(10, 2)) * @NUMPERSONAS AS Monto,
            CAST(T.Precio_por_noche_por_persona_thabitación AS DECIMAL(10, 2)) * @NUMPERSONAS - @ANTICIPO AS Faltante
        FROM
            Habitación H
            JOIN Tipo_de_Habitación T ON H.Tipo_de_habitación = T.Código_tipo_habitación
        WHERE
            H.Número_habitación = @IDHAM
    ) AS Subquery
);

CREATE PROCEDURE EliminarCliente(
@ID int
)
AS
BEGIN
DELETE FROM Cliente_Contacto WHERE ID_cliente_contacto= (select ID_cliente_contacto FROM Cliente where ID_cliente=@ID)
DELETE FROM Cliente_Referencia WHERE ID_referencia_hotel= (select ID_referencia_hotel FROM Cliente where ID_cliente=@ID)
DELETE FROM Cliente WHERE ID_cliente= @ID
END

------------------
drop procedure DeleteOperativo;

CREATE PROCEDURE DeleteOperativo
    @ID int
AS
BEGIN
    DECLARE @value varchar(30);
    DECLARE @value2 varchar(30);

    SELECT @value = Correo_electrónico FROM Operativo WHERE ID_operativo = @ID;

    DELETE FROM Operativo WHERE ID_operativo = @ID;

    SELECT @value2 = Teléfono FROM Usuario WHERE Correo_electrónico = @value;

    DELETE FROM Usuario WHERE Correo_electrónico = @value;

    DELETE FROM Usuario_teléfono WHERE ID_usuario_teléfono = @value2;
END



delete from Usuario_teléfono where ID_usuario_teléfono=4
delete from Usuario where Correo_electrónico='c@hotmail.com'

Insert into Usuario_teléfono( Teléfono_Casa,Teléfono_Celular)
values ('2465783901', '6745893426');

Insert into Usuario (Correo_electrónico, Contraseña,Nombre, ApellidoP,ApellidoM,Nombre_calle,Numero_de_casa,Municipio,
Código_postal,Ciudad,Estado,País,Número_de_nomina,Fecha_de_Nacimiento, Nueva_contraseña, Teléfono) 
values ('c@hotmail.com','789','Alvaro', 'Zepelio','Concha', 'Del Lobo','562', 'Guadalupe','5634','Monterrey', 'Nuevo León', 'México', '7623', '19781204', 'nocontraseña', 8); 


Insert into Usuario (Correo_electrónico, Contraseña,Nombre, ApellidoP,ApellidoM,Nombre_calle,Numero_de_casa,Municipio,
Código_postal,Ciudad,Estado,País,Número_de_nomina,Fecha_de_Nacimiento, Nueva_contraseña, Teléfono) 
values ('a@hotmail.com','123','Bianca', 'Rogríguez','Martínez', 'Ave','605', 'Guadalupe','3425','Monterrey', 'Nuevo León', 'México', '0023', '19780427', 'nocontraseña', 1); 

Insert into Administrador_ (Correo_electrónico)
values ('a@hotmail.com')

Insert into Operativo (Correo_electrónico, ID_admin, Fecha_y_hora)
values('c@hotmail.com',1, GETDATE())

Select* from Usuario_teléfono;
Select* from Usuario;
Select* from Operativo;
Select* from Cliente;
Select* from Cliente_Contacto;
Select* from Cliente_Referencia;
Select* from Administrador_;
Select* from NuevasContraseñas;
Select* from Hotel;
select * from Reservación;
select* from Habitación;

Insert into Reservación(Número_habitación_reservación, ID_cliente_reservación, ID_hotel_reservación, Fecha_creación_reservación, Fecha_entrada_reservación, Fecha_salida_reservación, Tipo_de_pago, Fecha_y_hora_registro_reservación, Status_reservación, Dinero_faltante, Anticipo_de_reservación, Monto_total, Número_de_personas_en_habitación_reservación, Código_reservación)
.
 UPDATE Operativo 
 SET Habilitado= 'Y' 
 WHERE Correo_electrónico ='c@hotmail.com'

ALTER TABLE Operativo CHECK CONSTRAINT ALL

 DELETE from NuevasContraseñas where ID_Contraseñas=2


 select Correo_electrónico, Contraseña, Nueva_contraseña from Usuario 
 where Correo_electrónico = 'b@hotmail.com' 
 AND Contraseña='Ux6-$vZb' 
 OR Nueva_contraseña='Ux6-$vZb' 

  Insert into NuevasContraseñas(ID_operativo,	Contraseña,	Fecha_y_hora)
 values (1, 'Ux6-$vZb', GETDATE())

 SELECT COUNT(*) AS RowCoun
FROM NuevasContraseñas NC
JOIN Operativo O ON O.ID_operativo = NC.ID_operativo
WHERE O.Correo_electrónico = 'b@hotmail.com'
GROUP BY NC.Contraseña

select NC.Contraseña
 from  NuevasContraseñas NC
 join Operativo O on O.ID_operativo=NC.ID_operativo
 where O.Correo_electrónico ='b@hotmail.com' and NC.Contraseña='456'
 Group by NC.Contraseña

 INSERT INTO NuevasContraseñas (ID_operativo, Contraseña, Fecha_y_hora)
SELECT ID_operativo, 667, GETDATE()
FROM Operativo
WHERE Correo_electrónico = 'b@hotmail.com';

Select U.Correo_electrónico, U.Contraseña
from Usuario U
join Operativo O On U.Correo_electrónico=O.Correo_electrónico
where O.ID_operativo=4;


DECLARE @ID int;
DECLARE @value varchar(30);
DECLARE @value2 varchar(30);

set @ID=15

SELECT @value = Correo_electrónico FROM Operativo WHERE ID_operativo = @ID;

DELETE FROM Operativo WHERE ID_operativo = @ID;

SELECT @value2 = Teléfono FROM Usuario WHERE Correo_electrónico = @value;

DELETE FROM Usuario WHERE Correo_electrónico = @value;

DELETE FROM Usuario_teléfono WHERE ID_usuario_teléfono = @value2;

select ID_admin from Administrador_ where Correo_electrónico='a@hotmail.com'

EXEC UpdateOperativoData
 @ID_operativo=18, @Teléfono_Casa='78', @Teléfono_Celular='98',@Correo_electrónico_teléfono='wi', @Contraseña ='" + txtbx_contrasenaop. + "',    @Nombre ='" + .Text + "',    @ApellidoP ='" + .Text + "',    @ApellidoM ='" + .Text + "',    @Nombre_calle ='" + .Text + "',    @Numero_de_casa = 8 ,    @Municipio='" + .Text + "',    @Código_postal='987',    @Ciudad ='" + .Text + "',    @Estado ='" + .Text + "',    @País ='" + .Text + "',    @Número_de_nomina =987,    @Fecha_de_Nacimiento ='99780905',    @Correo_electrónico_admin='a@hotmail.com'

 drop procedure GetCliente


 EXEC Actualizarclientes
@Nombre ='',
    @ApePat ='',
    @ApeMat ='',
    @NomCalle ='',
    @NumCasa =,
    @Municipio ='',
    @CodPos ='',
    @Ciudad ='',
    @Estado ='',
    @Pais ='',
    @RFC ='',
    @Nacimiento='',
    @Civil ='',
    @TelCasa ='',
    @TelCelular ='',
    @Email ='',
	@Referencia='',
    @ID =,
	@IDOPERA =;

	select C.ID_cliente,C.ID_operativo_cliente,C.Nombre_cliente,C.ApellidoP_cliente,C.Nombre_calle_cliente,
                C.Numero_de_casa_cliente, C.Municipio_cliente, C.Código_postal_cliente, C.Ciudad_cliente, C.Estado_cliente,C.País_cliente, C.RFC_cliente,
                 C.Fecha_de_Nacimiento_cliente, C.Estado_Civil_cliente,C.Fecha_y_hora_registro_cliente, O.ID_cliente_contacto    from Cliente C
                join Cliente_Contacto O ON O.ID_cliente_contacto=C.ID_cliente_contacto 
                join Cliente_Referencia R ON R.ID_referencia_hotel=C.ID_referencia_hotel 


				
select C.ID_cliente,C.ID_operativo_cliente,C.Nombre_cliente,C.ApellidoP_cliente,C.Nombre_calle_cliente,
                C.Numero_de_casa_cliente, C.Municipio_cliente, C.Código_postal_cliente, C.Ciudad_cliente, C.Estado_cliente,C.País_cliente, C.RFC_cliente,
                 C.Fecha_de_Nacimiento_cliente, C.Estado_Civil_cliente, O.ID_cliente_contacto
				 from Cliente C
				 join Cliente_Contacto O ON O.ID_cliente_contacto=C.ID_cliente_contacto 
				 where C.RFC_cliente=@Rfc;


				 ALTER TABLE Reservación
ADD New_Código_reservación UNIQUEIDENTIFIER;
select* from Reservación

UPDATE Reservación
SET New_Código_reservación = NEWID();

ALTER TABLE Habitación_reservada
DROP CONSTRAINT FK_Códigoreservacióneservada;

ALTER TABLE Reservación
DROP CONSTRAINT PK_Reservación;

ALTER TABLE Reservación
DROP COLUMN Código_reservación;

select * from Reservación
EXEC sp_rename 'Reservación.New_Código_reservación', 'Código_reservación', 'COLUMN';

ALTER TABLE Reservación
ALTER COLUMN Código_reservación UNIQUEIDENTIFIER NOT NULL;


ALTER TABLE Reservación
ADD CONSTRAINT PK_Reservación PRIMARY KEY (Código_reservación);

ALTER TABLE Habitación_reservada
ADD CONSTRAINT FK_Códigoreservacióneservada
FOREIGN KEY (Código_reservación_reservada)
REFERENCES Reservación (Código_reservación);


constraint FK_Códigoreservacióneservada
	foreign key(Código_reservación_reservada)--es del Código_reservación dentro de la tabla Habitación_reservada
		references Reservación(Código_reservación),--referencia de la tabla Habitación con su llave primaria

CREATE TABLE Habitación_reservada(
ID_habitación_reservada int not null identity(1,1), 
Número_habitación_reservada int, 
Código_reservación_reservada int, 
Fecha_y_hora_registro_reservada datetime, 
Disponible char(1) default ('Y') not null,
constraint PK_Habitaciónreservada
	primary key(ID_habitación_reservada),
constraint FK_Númerohabitaciónreservada
	foreign key(Número_habitación_reservada)--es del Número_habitación dentro de la tabla Habitación_reservada
		references Habitación(Número_habitación),--referencia de la tabla Habitación con su llave primaria
constraint FK_Códigoreservacióneservada
	foreign key(Código_reservación_reservada)--es del Código_reservación dentro de la tabla Habitación_reservada
		references Reservación(Código_reservación),--referencia de la tabla Habitación con su llave primaria
);

-- Create the scalar-valued function

Select Nombre_cliente+ApellidoP_cliente+ApellidoM_cliente
FROM Cliente C
JOIN Hotel H

SELECT OBJECT_DEFINITION(OBJECT_ID('dbo.DatosHoteles')) AS ViewDefinition;
CREATE VIEW dbo.DatosHoteles 
AS  SELECT ID_hotel, ID_admin_hotel, Nombre_hotel, Nombre_calle_hotel, Municipio_hotel, Código_postal_hotel,   
Ciudad_hotel, Estado_hotel, País_hotel, Número_de_pisos_hotel, Número_de_habitaciones_hotel, Amenidades_hotel,           
Zona_turística_hotel, Servicio_adicional_hotel, Sala_de_eventos_hotel, Fecha_inicio_operaciones_hotel, Teléfono_hotel          
FROM Hotel

\ef <Monto>
SELECT OBJECT_DEFINITION(OBJECT_ID('UpdateOperativoData')) AS StoredProcedureDefinition;


CREATE PROCEDURE Habitacioneshotel

@Hotel int

AS

BEGIN

SELECT H.Código

SELECT  H.Número_habitación , H.Habitación_creada_Admin , H.Tipo_de_habitación ,H.ID_hotel_habitación , H.Código

FROM Habitación H

Join Hotel Hl ON H.ID_hotel_habitación=Hl.ID_hotel

WHERE Hl.ID_hotel=@Hotel;

END

CREATE PROCEDURE CheckIn(
 @Cod UNIQUEIDENTIFIER
)
AS 
BEGIN
DECLARE @TransHoy date

Select  C.Nombre_cliente,R.Número_habitación_reservación , R.Fecha_salida_reservación
FROM Reservación R
join Cliente C on C.ID_cliente=R.ID_cliente_reservación
where  Código_reservación=@Cod

 SELECT @TransHoy = CONVERT(DATE, GETDATE(), 121);

UPDATE Reservación
Set Fecha_entrada_reservación=@TransHoy, Hab

END


--constraint FK_OperativoCliente
--	foreign key(ID_operativo_cliente)--es del ID_operativo_cliente dentro de la tabla cliente
--		references Operativo(ID_operativo),--referencia de la tabla Operativo con su llave primaria
--constraint FK_ClienteContacto
--	foreign key(ID_cliente_contacto)--es del ID_cliente_contacto dentro de la tabla cliente
--		references Cliente_Contacto(ID_cliente_contacto),--referencia de la tabla Cliente_Contacto con su llave primaria
--constraint FK_ClienteReferencia
--	foreign key(ID_referencia_hotel)--es del ID_referencia_hotel dentro de la tabla cliente
--		references Cliente_Referencia(ID_referencia_hotel),--referencia de la tabla Cliente_Referencia con su llave primaria
--);

select C.Nombre_cliente, H.Ciudad_hotel, H.Nombre_hotel, Th.Nivel_de_habitación_thabitación,
Ha.Número_habitación, R.Número_de_personas_en_habitación_reservación, R.Código_reservación, 
R.Fecha_creación_reservación, R.Fecha_entrada_reservación, R.Fecha_salida_reservación, R.Status_reservación,
R.Anticipo_de_reservación, R.Monto_total, R.Monto_total
from Reservación R
join Cliente C on R.ID_cliente_reservación=C.ID_cliente
Join Hotel H on R.ID_hotel_reservación=H.ID_hotel
Join Habitación Ha on Ha.Número_habitación=R.Número_habitación_reservación
Join Tipo_de_Habitación Th on Th.Código_tipo_habitación=Ha.Tipo_de_habitación
ORDER BY R.Fecha_creación_reservación ASC;

/*CREATE PROCEDURE EliminarCliente(
@ID int
)
AS
BEGIN
DELETE FROM Cliente_Contacto WHERE ID_cliente_contacto= (select ID_cliente_contacto FROM Cliente where ID_cliente=@ID)
DELETE FROM Cliente_Referencia WHERE ID_referencia_hotel= (select ID_referencia_hotel FROM Cliente where ID_cliente=@ID)
DELETE FROM Cliente WHERE ID_cliente= @ID
END*/
/*
CREATE PROCEDURE CheckIn(
 @Cod UNIQUEIDENTIFIER
)
AS 
BEGIN
DECLARE @TransHoy date

Select  C.Nombre_cliente,R.Número_habitación_reservación , R.Fecha_salida_reservación
FROM Reservación R
join Cliente C on C.ID_cliente=R.ID_cliente_reservación
where  Código_reservación=@Cod

 SELECT @TransHoy = CONVERT(DATE, GETDATE(), 121);

UPDATE Reservación
Set Fecha_entrada_reservación=@TransHoy

END*/
/*
UPDATE Reservación
Set Fecha_entrada_reservación=@TransHoy*/

Select  C.Nombre_cliente,R.Número_habitación_reservación , R.Fecha_salida_reservación
FROM Reservación R
join Cliente C on C.ID_cliente=R.ID_cliente_reservación
where  Código_reservación=@Cod

drop procedure CancelarReservación
CREATE PROCEDURE CancelarReservación (
    @GUID UNIQUEIDENTIFIER
)
AS
BEGIN
    DECLARE @FECHA DATE
    DECLARE @DIFERENCIA INT
    DECLARE @EXITO INT

    SELECT @FECHA = Fecha_entrada_reservación
    FROM Reservación
    WHERE Código_reservación = @GUID

    SET @DIFERENCIA = DATEDIFF(DAY, @FECHA, GETDATE())

    IF @DIFERENCIA = 3
    BEGIN
        UPDATE Reservación
        SET Status_reservación = 'N', Anticipo_de_reservación = '0', Número_habitación_reservación = '0'
        WHERE Código_reservación = @GUID

        SET @EXITO = 1
    END
    ELSE
    BEGIN
        SET @EXITO = 0
    END

    SELECT @EXITO AS EXITO
END


EXEC CancelarReservación @GUID ='5950811B-04D2-4DA1-B212-0793186C6080'
select * from Reservación



------------------------------------------- SEGUNDAS---------------------------

-----INICIO PROCEDURES REGISTRAR OPERATIVOS
CREATE PROCEDURE QueNoSeRepita(
@Correo varchar(30),
@Contraseña varchar(30)
)
AS
BEGIN
Select Correo_electrónico from Usuario
where Correo_electrónico=@Correo
OR Contraseña=@Contraseña
END
select * from Usuario
-----FINALES PROCEDURES REGISTRAR OPERATIVOS

-----INICIO PROCEDURES CHECKOUT

drop procedure CheckOut

EXEC CheckOut  @Cod='91C9AE75-2DFA-4E1B-B1AC-E7C2DD05A1A5',
 @Tipo='Credito',
 @Servicios =1

 select * from Reservación

CREATE PROCEDURE CheckOut(
 @Cod UNIQUEIDENTIFIER,
 @Tipo varchar (20),
 @Servicios bit
)
AS 
BEGIN
DECLARE @TransHoy date
DECLARE @NumHab int
DECLARE @Monto money

select @NumHab = Número_habitación_reservación FROM Reservación
where  Código_reservación=@Cod
set @Monto=0

 SELECT @TransHoy = CONVERT(DATE, GETDATE(), 121);

 SET NOCOUNT ON;
 IF @Servicios=1
	BEGIN 
	SELECT @Monto= Monto_total FROM Reservación
	SET @Monto=@Monto+500

	UPDATE Reservación
Set Fecha_salida_reservación=@TransHoy, Tipo_de_pago=@Tipo, Status_reservación='N', ServiciosUsados=@Servicios, Monto_total=@Monto
where Código_reservación=@Cod
	END 

	ELSE
	BEGIN
	UPDATE Reservación
	Set Fecha_salida_reservación=@TransHoy, Tipo_de_pago=@Tipo, Status_reservación='N', ServiciosUsados=@Servicios
	where Código_reservación=@Cod
	END

UPDATE Habitación_reservada
Set Disponible='Y'
where ID_habitación_reservada=@NumHab


SELECT R.Código_reservación, R.Número_habitación_reservación, C.Nombre_cliente+' '+C.ApellidoP_cliente+' '+C.ApellidoM_cliente as Nombre, H.Nombre_hotel,  R.Fecha_entrada_reservación, 
R.Fecha_salida_reservación, R.Tipo_de_pago, R.Rango_de_fechas, R.Dinero_faltante, R.Anticipo_de_reservación, R.Monto_total, R.Número_de_personas_en_habitación_reservación, R.Fecha_creación_reservación,
H.Servicio_adicional_hotel
FROM Reservación R
join Hotel H on R.ID_hotel_reservación=H.ID_hotel
join Cliente C on R.ID_cliente_reservación=C.ID_cliente
 WHERE Código_reservación =@Cod
END 





--END

--alter table Reservación
--add ServiciosUsados bit default (0) not null

Select * from Habitación_reservada
select * from Reservación
select * from Cliente
select * from Habitación
select * from Hotel

EXEC InsertReservación
@IDHAM ='1', 
@IDCLIE ='3', 
@IDHOTEL ='1', 
@ENTRADA ='2023-04-28',
@SALIDA ='2023-06-08',
@PAGO ='Efectivo',
@NUMPERSONAS ='1',
@ANTICIPO = '6'

select*from Operativo
select * from Reservación
A072717D-9D76-4317-9DA5-7121909F00E2


Insert Into Hotel(ID_admin_hotel, Nombre_hotel, Nombre_calle_hotel, Municipio_hotel, Código_postal_hotel, Ciudad_hotel, Estado_hotel, País_hotel, Número_de_pisos_hotel,
Número_de_habitaciones_hotel, Amenidades_hotel, Zona_turística_hotel, Servicio_adicional_hotel, Sala_de_eventos_hotel, Fecha_inicio_operaciones_hotel, Teléfono_hotel, 
Fecha_y_hora_registro_hotel)
values (1, 'Disney', 'Washington', 'Texas', '323', 'DC', 'New York', 'USA', 45, 23, 'Jabones', 'Parque de diversiones', 'Playa', 'Disponible', GETDATE(), '9323342', GETDATE())

Insert Into Habitación ( Habitación_creada_Admin, Tipo_de_habitación, ID_hotel_habitación,Fecha_y_hora_registro_habitación)
values (1, 1, 1, GETDATE());
Insert Into Tipo_de_Habitación(Número_de_camas_thabitación, Tipo_de_camas_thabitación ,Precio_por_noche_por_persona_thabitación , Número_de_personas_thabitación , Nivel_de_habitación_thabitación , 
Características_thabitación , Amenidades_thabitación , Vista_al_frente_thabitación)
values(2, 'King Size', 23, 2, 'Deluxe', 'Espacioso y grande', 'Jabones', 'N')

--Checar los contraints de una tabla
SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME = 'Habitación_reservada'
--Para checar los contraints activos de una tabla, bastante útil


CREATE VIEW vHotel1 AS
SELECT
    h.Nombre_hotel,
    h.Ciudad_hotel,
    h.Fecha_inicio_operaciones_hotel,
    th.Código_tipo_habitación,
    COUNT(DISTINCT ha.Número_habitación) AS Cantidad_Habitaciones,
    (COUNT(DISTINCT hr.ID_habitación_reservada) * COUNT(DISTINCT ha.Número_habitación)) / 100.0 AS Porcentaje_Ocupacion,
    ISNULL(SUM(r.Número_de_personas_en_habitación_reservación), 0) AS Total_Personas_Hospedadas
FROM Hotel h
INNER JOIN Tipo_de_Habitación th ON th.ID_HotelTipoHabitación = h.ID_hotel
LEFT JOIN Habitación ha ON ha.ID_hotel_habitación = h.ID_hotel
LEFT JOIN Habitación_reservada hr ON hr.Número_habitación_reservada = ha.Número_habitación
LEFT JOIN Reservación r ON r.Código_reservación = hr.Código_reservación_reservada
GROUP BY
    h.Nombre_hotel,
    h.Ciudad_hotel,
    h.Fecha_inicio_operaciones_hotel,
    th.Código_tipo_habitación;

	select * from Hotel

	CREATE VIEW vHotel1 AS
SELECT
    h.Nombre_hotel,
    h.Ciudad_hotel,
    h.Fecha_inicio_operaciones_hotel,
    th.Código_tipo_habitación,
    COUNT(DISTINCT ha.Número_habitación) AS Cantidad_Habitaciones,
    (COUNT(DISTINCT hr.ID_habitación_reservada) * COUNT(DISTINCT ha.Número_habitación)) / 100.0 AS Porcentaje_Ocupacion,
    ISNULL(SUM(r.Número_de_personas_en_habitación_reservación), 0) AS Total_Personas_Hospedadas
FROM Hotel h
INNER JOIN Tipo_de_Habitación th ON th.ID_HotelTipoHabitación = h.ID_hotel
LEFT JOIN Habitación ha ON ha.ID_hotel_habitación = h.ID_hotel
LEFT JOIN Habitación_reservada hr ON hr.Número_habitación_reservada = ha.Número_habitación
LEFT JOIN Reservación r ON r.Código_reservación = hr.Código_reservación_reservada
GROUP BY
    h.Nombre_hotel,
    h.Ciudad_hotel,
    h.Fecha_inicio_operaciones_hotel,
    th.Código_tipo_habitación;

	CREATE VIEW vHotel1 AS
SELECT h.Nombre_hotel, h.Ciudad_hotel, h.Fecha_inicio_operaciones_hotel, th.Código_tipo_habitación, --ha.Número_habitación, 
dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel) AS Cantidad_Habitaciones,
(dbo.ObtenerTotalHabitacionesOcupadas() * dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel)) / 100.0 AS Porcentaje_Ocupacion,
dbo.SumaPersonasHospedadasPorHotel(h.ID_hotel) AS Total_Personas_Hospedadas
FROM Habitación ha
INNER JOIN Tipo_de_Habitación th ON ha.Tipo_de_habitación = th.Código_tipo_habitación
INNER JOIN Hotel h ON h.ID_hotel = ID_hotel_habitación
INNER JOIN Reservación r ON r.Número_habitación_reservación = ha.Número_habitación

--se necesita poner en el group by para los resultados que no sean aggregate as SUM, COUNT, AVG, MAX, MIN, or STRING_AGG,
select distinct h.Ciudad_hotel, h.Nombre_hotel ,h.Número_de_habitaciones_hotel, FORMAT(h.Fecha_inicio_operaciones_hotel, 'yyyy-MM') AS Inicio_hotel, STRING_AGG(T.Nivel_de_habitación_thabitación, ', ') AS concatenated_values, dbo.SumaPersonasHospedadasPorHotel(h.ID_hotel) AS Total_Personas_Hospedadas
from Hotel h
inner join Reservación r on h.ID_hotel=r.ID_hotel_reservación 
left join Tipo_de_Habitación T on T.ID_HotelTipoHabitación=h.ID_hotel
GROUP BY h.ID_hotel, h.Ciudad_hotel, h.Nombre_hotel, h.Número_de_habitaciones_hotel, FORMAT(h.Fecha_inicio_operaciones_hotel, 'yyyy-MM');

select * from Reservación

SELECT
    h.ID_hotel,
    y.Year,
    m.Month,
    dbo.SumaPersonasHospedadasPorHotelM(h.ID_hotel, y.Year, m.Month) AS Total_Personas_Hospedadas
FROM
    Hotel h
CROSS JOIN
(
    SELECT DISTINCT DATEPART(YEAR, Fecha_entrada_reservación) AS Year
    FROM Reservación
) y
CROSS JOIN
(
    SELECT DISTINCT DATEPART(MONTH, Fecha_entrada_reservación) AS Month
    FROM Reservación
) m
WHERE dbo.SumaPersonasHospedadasPorHotelM(h.ID_hotel, y.Year, m.Month) IS NOT NULL
ORDER BY
    h.ID_hotel,
    y.Year,
    m.Month;


	
SumaPersonasHospedadasPorHotel
drop procedure SumaPersonasHospedadasPorHotel
CREATE FUNCTION SumaPersonasHospedadasPorHotel(@IDHotel INT)
RETURNS INT
AS
BEGIN
    	DECLARE @TotalPersonasHospedadas INT;

SELECT @TotalPersonasHospedadas = SUM(r.Número_de_personas_en_habitación_reservación)
FROM Reservación r
INNER JOIN Habitación h ON r.Número_habitación_reservación = h.Número_habitación
WHERE r.ID_hotel_reservación=@IDHotel
    RETURN @TotalPersonasHospedadas;
END;

CREATE FUNCTION SumaPersonasHospedadasPorHotelM(
    @IDHotel INT,
    @Year INT,
    @Month INT
)
RETURNS INT
AS
BEGIN
    DECLARE @TotalPersonasHospedadas INT;

    SELECT @TotalPersonasHospedadas = SUM(r.Número_de_personas_en_habitación_reservación)
    FROM Reservación r
    INNER JOIN Habitación h ON r.Número_habitación_reservación = h.Número_habitación
    WHERE r.ID_hotel_reservación = @IDHotel
        AND DATEPART(YEAR, r.Fecha_entrada_reservación) = @Year
        AND DATEPART(MONTH, r.Fecha_entrada_reservación) = @Month;

    RETURN @TotalPersonasHospedadas;
END;




--VISTA1--La vista para los hoteles al cargar pantalla
CREATE VIEW vHotel1 AS
select distinct h.Ciudad_hotel, h.Nombre_hotel , 
 DATEPART(YEAR, r.Fecha_entrada_reservación) AS Year,
        DATEPART(MONTH, r.Fecha_entrada_reservación) AS Month,
FORMAT(h.Fecha_inicio_operaciones_hotel, 'yyyy-MM') AS Inicio_hotel, 
STRING_AGG(T.Nivel_de_habitación_thabitación, ', ') AS Tipos_Existentes, 
dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel) AS Cantidad_Habitaciones, 
(dbo.ObtenerTotalHabitacionesOcupadas() * dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel)) / 100.0 AS Porcentaje_Ocupacion,
dbo.SumaPersonasHospedadasPorHotel(h.ID_hotel) AS Total_Personas_Hospedadas
from Hotel h
inner join Reservación r on h.ID_hotel=r.ID_hotel_reservación 
left join Tipo_de_Habitación T on T.ID_HotelTipoHabitación=h.ID_hotel
GROUP BY h.ID_hotel, h.Ciudad_hotel, h.Nombre_hotel, h.Número_de_habitaciones_hotel, FORMAT(h.Fecha_inicio_operaciones_hotel, 'yyyy-MM'),
DATEPART(YEAR, r.Fecha_entrada_reservación), DATEPART(MONTH, r.Fecha_entrada_reservación);


--Esta versión sí saca los tipos sin repetir
SELECT 
    h.Ciudad_hotel,
    h.Nombre_hotel,
    FORMAT(h.Fecha_inicio_operaciones_hotel, 'yyyy-MM') AS Inicio_hotel, 
 (
        SELECT STRING_AGG(Nivel_de_habitación_thabitación, ', ')
        FROM (
            SELECT DISTINCT T.Nivel_de_habitación_thabitación
            FROM Tipo_de_Habitación T
            WHERE T.ID_HotelTipoHabitación = h.ID_hotel
        ) AS subquery
    ) AS Tipos_Existentes,
    dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel) AS Cantidad_Habitaciones, 
    (dbo.ObtenerTotalHabitacionesOcupadas() * dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel)) / 100.0 AS Porcentaje_Ocupacion,
    SUM(dbo.SumaPersonasHospedadasPorHotel(h.ID_hotel)) AS Total_Personas_Hospedadas,
    DATEPART(YEAR, r.Fecha_entrada_reservación) AS Año,
    DATEPART(MONTH, r.Fecha_entrada_reservación) AS Mes
FROM
    Hotel h
    INNER JOIN Reservación r ON h.ID_hotel = r.ID_hotel_reservación 
    LEFT JOIN Tipo_de_Habitación T ON T.ID_HotelTipoHabitación = h.ID_hotel
GROUP BY h.ID_hotel,  h.Ciudad_hotel, h.Nombre_hotel, FORMAT(h.Fecha_inicio_operaciones_hotel, 'yyyy-MM'), DATEPART(YEAR, r.Fecha_entrada_reservación), DATEPART(MONTH, r.Fecha_entrada_reservación)

	--ESTE ES EL BUENOOO
	SELECT
    h.ID_hotel,
    h.Ciudad_hotel,
    h.Nombre_hotel,
    FORMAT(h.Fecha_inicio_operaciones_hotel, 'yyyy-MM') AS Inicio_hotel,
    (
        SELECT STRING_AGG(Nivel_de_habitación_thabitación, ', ')
        FROM (
            SELECT DISTINCT T.Nivel_de_habitación_thabitación
            FROM Tipo_de_Habitación T
            WHERE T.ID_HotelTipoHabitación = h.ID_hotel
        ) AS subquery
    ) AS Tipos_Existentes,
    dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel) AS Cantidad_Habitaciones,
    (dbo.ObtenerTotalHabitacionesOcupadas() * dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel)) / 100.0 AS Porcentaje_Ocupacion,
	dbo.SumaPersonasHospedadasPorHotel(h.ID_hotel) AS Total_Personas_Hospedadas_en_Hotel,
    v.Total_Personas_Hospedadas,
    v.Año,
    v.Mes
FROM
    Hotel h
INNER JOIN
(
    SELECT
        r.ID_hotel_reservación,
        DATEPART(YEAR, r.Fecha_entrada_reservación) AS Año,
        DATEPART(MONTH, r.Fecha_entrada_reservación) AS Mes,
        dbo.SumaPersonasHospedadasPorHotelM(r.ID_hotel_reservación, DATEPART(YEAR, r.Fecha_entrada_reservación), DATEPART(MONTH, r.Fecha_entrada_reservación)) AS Total_Personas_Hospedadas
    FROM
        Reservación r
) v ON h.ID_hotel = v.ID_hotel_reservación
LEFT JOIN Tipo_de_Habitación T ON T.ID_HotelTipoHabitación = h.ID_hotel
GROUP BY
    h.ID_hotel,
    h.Ciudad_hotel,
    h.Nombre_hotel,
    FORMAT(h.Fecha_inicio_operaciones_hotel, 'yyyy-MM'),
    dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel),
    (dbo.ObtenerTotalHabitacionesOcupadas() * dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel)) / 100.0,
    v.Total_Personas_Hospedadas,
    v.Año,
    v.Mes;


	    @PaisHotel VARCHAR(15),
    @AnoOperacionesHotel int--date
AS
BEGIN
     SELECT DISTINCT
	h.Nombre_hotel, h.Ciudad_hotel, h.Fecha_inicio_operaciones_hotel, dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel) AS Cantidad_Habitaciones,
    (dbo.ObtenerTotalHabitacionesOcupadas() * 100.0) / dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel) AS Porcentaje_Ocupacion,
	dbo.SumaPersonasHospedadasPorHotel(h.ID_hotel) AS Total_Personas_Hospedadas
	FROM Habitación ha
	INNER JOIN Tipo_de_Habitación th ON ha.Tipo_de_habitación = th.Código_tipo_habitación
	INNER JOIN Hotel h ON h.ID_hotel = ID_hotel_habitación
    where h.País_hotel=@PaisHotel AND YEAR(h.Fecha_inicio_operaciones_hotel) = @AnoOperacionesHotel

select * from Hotel

SELECT DISTINCT 
v.Nombre_hotel, v.Ciudad_hotel, v.Inicio_hotel, v.Tipos_Existentes,v.Cantidad_Habitaciones, v.Porcentaje_Ocupacion,v.Total_Personas_Hospedadas_en_Hotel, v.Total_Personas_Hospedadas, v.Año, v.Mes
   FROM vHotel1 v
   	INNER JOIN Hotel h ON h.ID_hotel = v.ID_hotel
    where h.País_hotel='USA' AND YEAR(v.Inicio_hotel) = '2023'

--CREATE PROCEDURE ObtenerDatosHotel
--AS
--BEGIN
--    SET NOCOUNT ON;

--    SELECT DISTINCT
--	Nombre_hotel, Ciudad_hotel, Inicio_hotel, Tipos_Existentes,Cantidad_Habitaciones, Porcentaje_Ocupacion,Total_Personas_Hospedadas_en_Hotel, Total_Personas_Hospedadas, Año, Mes
--    FROM vHotel1;
--END;

--VISTA1--La vista para los hoteles al cargar pantalla
CREATE VIEW vHotel1 AS
	SELECT
    h.ID_hotel,
    h.Ciudad_hotel,
    h.Nombre_hotel,
    FORMAT(h.Fecha_inicio_operaciones_hotel, 'yyyy-MM') AS Inicio_hotel,
    (
        SELECT STRING_AGG(Nivel_de_habitación_thabitación, ', ')
        FROM (
            SELECT DISTINCT T.Nivel_de_habitación_thabitación
            FROM Tipo_de_Habitación T
            WHERE T.ID_HotelTipoHabitación = h.ID_hotel
        ) AS subquery
    ) AS Tipos_Existentes,
    dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel) AS Cantidad_Habitaciones,
    (dbo.ObtenerTotalHabitacionesOcupadas() * dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel)) / 100.0 AS Porcentaje_Ocupacion,
	dbo.SumaPersonasHospedadasPorHotel(h.ID_hotel) AS Total_Personas_Hospedadas_en_Hotel,
    v.Total_Personas_Hospedadas,
    v.Año,
    v.Mes
FROM
    Hotel h
INNER JOIN
(
    SELECT
        r.ID_hotel_reservación,
        DATEPART(YEAR, r.Fecha_entrada_reservación) AS Año,
        DATEPART(MONTH, r.Fecha_entrada_reservación) AS Mes,
        dbo.SumaPersonasHospedadasPorHotelM(r.ID_hotel_reservación, DATEPART(YEAR, r.Fecha_entrada_reservación), DATEPART(MONTH, r.Fecha_entrada_reservación)) AS Total_Personas_Hospedadas
    FROM
        Reservación r
) v ON h.ID_hotel = v.ID_hotel_reservación
LEFT JOIN Tipo_de_Habitación T ON T.ID_HotelTipoHabitación = h.ID_hotel
GROUP BY
    h.ID_hotel,
    h.Ciudad_hotel,
    h.Nombre_hotel,
    FORMAT(h.Fecha_inicio_operaciones_hotel, 'yyyy-MM'),
    dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel),
    (dbo.ObtenerTotalHabitacionesOcupadas() * dbo.ObtenerHabitacionesDisponiblesEnHotel(h.ID_hotel)) / 100.0,
    v.Total_Personas_Hospedadas,
    v.Año,
    v.Mes;

	SELECT DISTINCT
    v.Nombre_hotel,
    v.Ciudad_hotel,
    v.Inicio_hotel,
    v.Tipos_Existentes,
    v.Cantidad_Habitaciones,
    v.Porcentaje_Ocupacion,
    v.Total_Personas_Hospedadas_en_Hotel,
    v.Total_Personas_Hospedadas,
    v.Año,
    v.Mes
FROM
    vHotel1 v
    INNER JOIN Hotel h ON h.ID_hotel = v.ID_hotel
WHERE
    h.País_hotel = 'USA' AND LEFT(v.Inicio_hotel, 4) = '2023';
