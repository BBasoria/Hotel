--TABLA USUARIO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Correo del usuario registrado',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='Correo electrónico PK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Contraseña del perfil',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='Contraseña';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Contraseña temporal del perfil',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='Nueva Contraseña';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Primer nombre del usuario',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='Nombre';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Apellido paterno del usuario',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='Apellido P';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Apellido materno del usuario',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='Apellido M';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Calle en la que reside',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='Nombre calle';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Número de domicilio',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='Número casa';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Municipio en el que reside',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='Municipio';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Código postal del domicilio',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='Código postal';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Ciudad en el que reside',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='Ciudad';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Estado en el que reside',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='Estado';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='País en el que reside',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='País';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Número de nómina del usuario',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='Número de nómina';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Fecha de nacimiento del usuario',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='Fecha de Nacimiento';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Código de la tabla Usuario teléfono',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario',
@level2type =N'Column', @level2name ='ID usuario teléfono FK';
GO

--TABLA USUARIO TELEFONO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Identificación de los números del usuario',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario teléfono',
@level2type =N'Column', @level2name ='ID usuario teléfono PK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Teléfono de casa',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario teléfono',
@level2type =N'Column', @level2name ='Teléfono de Casa';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Teléfono Celular',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Usuario teléfono',
@level2type =N'Column', @level2name ='Teléfono Celular';
GO

--TABLA ADMINISTRADOR
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Identificación del administrador',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Administrador',
@level2type =N'Column', @level2name ='ID admin PK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Identificación de la tabla Usuario',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Administrador',
@level2type =N'Column', @level2name ='Correo eléctronico';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Estado actual del usuario',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Administrador',
@level2type =N'Column', @level2name ='Status';
GO

--TABLA OPERATIVO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Identificación del operativo registrado',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Operativo',
@level2type =N'Column', @level2name ='ID operativo PK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Identificación de la tabla Usuario',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Operativo',
@level2type =N'Column', @level2name ='Correo eléctronico';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Identificación de la tabla Administrador',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Operativo',
@level2type =N'Column', @level2name ='ID Admin FK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Estado activo del operativo',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Operativo',
@level2type =N'Column', @level2name ='Habilitado';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Tiempo cuando se registró el operativo',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Operativo',
@level2type =N'Column', @level2name ='Fecha y hora';
GO

--TABLA CLIENTE
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Identificación del cliente registrado',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='ID cliente PK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Primer nombre del cliente registrado',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='Nombre';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Apellido paterno del cliente registrado',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='ApellidoP';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Apellido materno del cliente registrado',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='ApellidoM';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Calle en la que reside el cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='Nombre calle';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Número de domicilio del cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='Número casa';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Municipio en el que reside el cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='Municipio';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Código postal del domicilio del cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='Código postal';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Ciudad en el que reside el cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='Ciudad';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Estado en el que reside el cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='Estado';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='País en el que reside el cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='País';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='RFC del cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='RFC';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Fecha de nacimiento del cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='Fecha de nacimiento';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Estado Civil del cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='Estado Civil';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Tiempo cuando se registró el cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='Fecha y hora';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Código de la tabla Cliente Contacto',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='ID cliente contacto FK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Código de la tabla Cliente Referencia',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente',
@level2type =N'Column', @level2name ='ID referencia hotel FK';
GO

--TABLA CLIENTE CONTACTO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Identificación de los contactos del cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente Contacto',
@level2type =N'Column', @level2name ='ID cliente contacto PK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Correo electrónico del cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente Contacto',
@level2type =N'Column', @level2name ='Correo electrónico';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Teléfono de la casa del cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente Contacto',
@level2type =N'Column', @level2name ='Teléfono de Casa';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Teléfono del celular del cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente Contacto',
@level2type =N'Column', @level2name ='Teléfono Celular';
GO
--TABLA CLIENTE REFERENCIA
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Identificación de la referencia del cliente sobre el hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente Referencia',
@level2type =N'Column', @level2name ='ID referencia hotel PK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'La referencia que tuvo el cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Cliente Referencia',
@level2type =N'Column', @level2name ='Referencia Hotel';
GO

--TABLA RESERVACION
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Código único de la reservación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Reservación',
@level2type =N'Column', @level2name ='Código reservación PK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Código de la tabla Habitación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Reservación',
@level2type =N'Column', @level2name ='Número habitación FK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Código de la tabla Cliente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Reservación',
@level2type =N'Column', @level2name ='ID cliente FK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Código de la tabla Hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Reservación',
@level2type =N'Column', @level2name ='ID hotel FK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Fecha cuando se hace la reservación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Reservación',
@level2type =N'Column', @level2name ='Fecha creación';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Fecha cuando inicia la reservación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Reservación',
@level2type =N'Column', @level2name ='Fecha entrada';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Fecha cuando termina la reservación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Reservación',
@level2type =N'Column', @level2name ='Fecha salida';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Forma elegida de pagar',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Reservación',
@level2type =N'Column', @level2name ='Tipo de pago';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Duración de la reservación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Reservación',
@level2type =N'Column', @level2name ='Rango de fechas';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Estado actual de la reservacion',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Reservación',
@level2type =N'Column', @level2name ='Status';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Saldo pendiente de la reservación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Reservación',
@level2type =N'Column', @level2name ='Dinero faltante';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Monto establecido para que se valide la reservación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Reservación',
@level2type =N'Column', @level2name ='Anticipo de reservación';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Monto final de la reservación y los servicios',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Reservación',
@level2type =N'Column', @level2name ='Monto total'
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Número de personas designada para la habitación solicitada',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Reservación',
@level2type =N'Column', @level2name ='Número de personas en habitación';
GO

--TABLA HOTEL
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Identificación de cada hotel creado',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='ID Hotel PK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Código de la tabla Administrador',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='ID admin FK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Nombre del hotel registrado',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='Nombre';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Calle en la que se encuentra el hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='Nombre calle';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Municipio en el que se encuentra el hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='Municipio';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Código postal del hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='Código postal';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Ciudad en la que se encuentra el hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='Ciudad';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Estado en el que se encuentra el hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='Estado';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='País en el que se encuentra el hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='País';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Número de pisos que tiene el hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='Número de pisos';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Número de habitaciones que tiene el hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='Número de habitaciones';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='bjetos disponibles con el servicio',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='Amenidades';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Zona tuística que tiene el hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='Zona turística';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Servicios que se pueden tomar con costo extras',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='Servicio adicional';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Sala de eventos que tiene el hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='Sala de eventos';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Día que empezó a trabajar el hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='Fecha inicio operaciones';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Teléfonos registrados que tiene el hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='Teléfono';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Fecha y hora que se registró el hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Hotel',
@level2type =N'Column', @level2name ='Fecha y hora';
GO

--TABLA HABITACION
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Número de la habitación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Habitación',
@level2type =N'Column', @level2name ='Número habitación PK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Código de la tabla Administrador',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Habitación',
@level2type =N'Column', @level2name ='Habitación creada Admin FK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Código de la tabla Tipo de habitación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Habitación',
@level2type =N'Column', @level2name ='Tipo de habitación FK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Código de la tabla Hotel',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Habitación',
@level2type =N'Column', @level2name ='ID hotel FK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Tiempo cuando se registró el tipo',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Habitación',
@level2type =N'Column', @level2name ='Fecha y hora';
GO

--TABLA TIPO DE HABITACION
EXEC sp_addextendedproperty
@name =N'MS_Description', @value ='Identificación tipo de habitación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Tipo de habitación',
@level2type =N'Column', @level2name ='Código tipo de habitación PK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Número de camas disponibles por habitación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Tipo de habitación',
@level2type =N'Column', @level2name ='Número de camas';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Tipos de camas disponibles',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Tipo de habitación',
@level2type =N'Column', @level2name ='Tipo de camas';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'El costo por persona por la habitación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Tipo de habitación',
@level2type =N'Column', @level2name ='Precio por noche por persona';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Número de personas posibles',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Tipo de habitación',
@level2type =N'Column', @level2name ='Número de personas';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Nivel que tienen las habitaciones',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Tipo de habitación',
@level2type =N'Column', @level2name ='Nivel de habitación';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Características disponibles de la habitación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Tipo de habitación',
@level2type =N'Column', @level2name ='Características';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Productos disponibles para la habitación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Tipo de habitación',
@level2type =N'Column', @level2name ='Amenidades';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Si la habitación cuenta con la vista al frente',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Tipo de habitación',
@level2type =N'Column', @level2name ='Vista al frente';
GO

--TABLA HABITACION RESERVADA
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Identificación de la habitación reservada',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Habitación reservada',
@level2type =N'Column', @level2name ='ID habitación reservada PK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Código de la tabla Habitación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Habitación reservada',
@level2type =N'Column', @level2name ='Número de habitación FK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Código de la tabla Reservación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Habitación reservada',
@level2type =N'Column', @level2name ='Código reservación FK';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Tiempo en cuanto se reserva la habitación',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Habitación reservada',
@level2type =N'Column', @level2name ='Fecha y hora';
GO
EXEC sp_addextendedproperty
@name =N'MS_Description', @value = 'Si la habitación se encuentra disponible',
@level0type =N'Schema', @level0name ='dbo',
@level1type =N'Table', @level1name ='Habitación reservada',
@level2type =N'Column', @level2name ='Disponible';
GO
