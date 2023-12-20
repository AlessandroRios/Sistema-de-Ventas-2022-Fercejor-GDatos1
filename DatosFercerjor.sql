use DBSVFercejor;

--INSERT INTO NEGOCIO.ROLES VALUES('ADMINISTRADOR')
INSERT INTO NEGOCIO.ROLES VALUES('EMPLEADO')
INSERT INTO PERSONAS.EMPLEADOS VALUES ('Juan','Pepe','90010991',1)
INSERT INTO PERSONAS.EMPLEADOS VALUES ('ales','rios','123456789',2)
INSERT INTO PERSONAS.EMPLEADOS VALUES ('pepe','ñolu','144333',2)
INSERT INTO PERSONAS.EMPLEADOS VALUES ('Javier','García','912345678',2)
INSERT INTO PERSONAS.EMPLEADOS VALUES ('María','Rodríguez','923456789',2)
INSERT INTO PERSONAS.EMPLEADOS VALUES ('Alejandro','López','934567890',2)
INSERT INTO PERSONAS.EMPLEADOS VALUES ('Laura','Martínez','945678901',2)
INSERT INTO PERSONAS.EMPLEADOS VALUES ('Carlos','Fernández','956789012',2)
INSERT INTO PERSONAS.EMPLEADOS VALUES ('Ana','Sánchez','978901234',2)
INSERT INTO PERSONAS.EMPLEADOS VALUES ('David','Ramírez','989012345',2)
INSERT INTO PERSONAS.EMPLEADOS VALUES ('Isabel','Torres','911234567',2)
GO

insert into PERSONAS.USUARIOS Values(1,'jgarcia88','seguri20','2021')
insert into PERSONAS.USUARIOS Values(2,'rmaria45','123maria','2022')
insert into PERSONAS.USUARIOS Values(3,'alopez93','aventura45','2022')
insert into PERSONAS.USUARIOS Values(4,'lmartinez87','flores20','2021')
insert into PERSONAS.USUARIOS Values(5,'cfernandez84','verano78','2023')
insert into PERSONAS.USUARIOS Values(6,'asanchez91','luces2023','2019')
insert into PERSONAS.USUARIOS Values(7,'dramirez95','montaña12','2020')
insert into PERSONAS.USUARIOS Values(8,'itorres88','azul456','2018')
insert into PERSONAS.USUARIOS Values(9,'admin','1234','2018')
GO

INSERT INTO PERSONAS.PROVEEDORES (razonSocial, documento, correo, telefono, estado, fechaRegistro)
VALUES
    ('Repuestos Autos Lima', 'RUC12345678901', 'repuestoslima@gmail.com', '987654321', 'A', GETDATE()),
    ('Autopiezas SAC', 'RUC98765432109', 'autopiezas.sac@gmail.com', '912345678', 'A', GETDATE()),
    ('Automóviles Partes EIRL', 'RUC56789012345', 'autopartes.eirl@gmail.com', '934567890', 'A', GETDATE()),
    ('Repuestos CarPerú', 'RUC23456789012', 'repuestoscarperu@gmail.com', '945678901', 'A', GETDATE()),
    ('Recambios Autos SA', 'RUC78901234567', 'recambiosautos.sa@gmail.com', '956789012', 'A', GETDATE()),
    ('Repuestos Express', 'RUC34567890123', 'repuestos.express@gmail.com', '967890123', 'A', GETDATE()),
    ('Autorepuestos Norte', 'RUC89012345678', 'autorepuestos.norte@gmail.com', '978901234', 'A', GETDATE()),
    ('Accesorios Autos Sur', 'RUC45678901234', 'accesoriosautos.sur@gmail.com', '989012345', 'A', GETDATE()),
    ('Repuestos Online', 'RUC90123456789', 'repuestos.online@gmail.com', '900123456', 'A', GETDATE()),
    ('Repuestos MotorCar', 'RUC01234567890', 'repuestosmotorcar@gmail.com', '911234567', 'A', GETDATE()),
    ('AutoPartes Central', 'RUC67890123456', 'autopartes.central@gmail.com', '922345678', 'A', GETDATE()),
    ('Repuestos Velázquez', 'RUC34567890123', 'repuestosvelazquez@gmail.com', '933456789', 'A', GETDATE()),
    ('Automotriz Ruiz', 'RUC89012345678', 'automotriz.ruiz@gmail.com', '944567890', 'A', GETDATE()),
    ('Autorepuestos Ríos', 'RUC23456789012', 'autorepuestosrios@gmail.com', '955678901', 'A', GETDATE()),
    ('Repuestos SurCars', 'RUC78901234567', 'repuestossurcars@gmail.com', '966789012', 'A', GETDATE()),
    ('Recambios Autos Lima', 'RUC01234567890', 'recambioslima@gmail.com', '977890123', 'A', GETDATE()),
    ('Autopartes Perú', 'RUC45678901234', 'autopartes.peru@gmail.com', '988901234', 'A', GETDATE()),
    ('Repuestos Autos Sur', 'RUC90123456789', 'repuestosautossur@gmail.com', '900123456', 'A', GETDATE()),
    ('Repuestos CarCenter', 'RUC34567890123', 'repuestoscarcenter@gmail.com', '911234567', 'A', GETDATE()),
    ('Accesorios Autos Perú', 'RUC67890123456', 'accesorios.autosperu@gmail.com', '922345678', 'A', GETDATE())
;
GO

INSERT INTO PERSONAS.CLIENTES (nombre, Apellido, telefono, correo, estado, fechaRegistro)
VALUES
    ('Gonzalo', 'López', '933456789', 'gonzalo.lopez@example.com', '0', GETDATE()),
    ('Valentina', 'Gómez', '944567890', 'valentina.gomez@example.com', '0', GETDATE()),
    ('Manuel', 'Hernández', '955678901', 'manuel.hernandez@example.com', '0', GETDATE()),
    ('Julia', 'Torres', '966789012', 'julia.torres@example.com', '0', GETDATE()),
    ('Federico', 'Ramírez', '977890123', 'federico.ramirez@example.com', '0', GETDATE()),
    ('Celeste', 'Martínez', '988901234', 'celeste.martinez@example.com', '0', GETDATE()),
    ('Sebastián', 'García', '900123456', 'sebastian.garcia@example.com', '0', GETDATE()),
    ('Renata', 'Sánchez', '911234567', 'renata.sanchez@example.com', '0', GETDATE()),
    ('Diego', 'Vargas', '922345678', 'diego.vargas@example.com', '0', GETDATE()),
    ('Antonella', 'Pérez', '933456789', 'antonella.perez@example.com', '0', GETDATE())
;
GO


INSERT INTO NEGOCIO.CATEGORIAS (nombreCategoria)
VALUES
    ('Frenos'),
    ('Suspensión'),
    ('Motor'),
    ('Iluminación'),
    ('Transmisión'),
    ('Dirección'),
    ('Electrónica'),
    ('Escape'),
    ('Carrocería'),
    ('Neumáticos')
;
GO

INSERT INTO NEGOCIO.PRODUCTOS (idCategoria, nombreProducto, descripcion, stock, precioMayoritario, precioMinoritario, estado)
VALUES
    (1, 'Pastillas de freno', 'Pastillas de freno de alta calidad', 100, 50.00, 60.00, 'A'),
    (1, 'Discos de freno', 'Discos de freno perforados y ventilados', 80, 80.00, 90.00, 'A'),
    (1, 'Pinzas de freno', 'Pinzas de freno de repuesto', 50, 120.00, 130.00, 'A'),
    (2, 'Amortiguadores', 'Amortiguadores de suspensión delantera', 60, 200.00, 220.00, 'A'),
    (2, 'Barras estabilizadoras', 'Barras estabilizadoras de repuesto', 40, 150.00, 160.00, 'A'),
    (2, 'Muelles de suspensión', 'Muelles de suspensión reforzados', 70, 180.00, 200.00, 'A'),
    (3, 'Filtro de aire', 'Filtro de aire de alto rendimiento', 120, 25.00, 30.00, 'A'),
    (3, 'Bujías', 'Bujías de encendido para motores de gasolina', 200, 8.00, 10.00, 'A'),
    (3, 'Correa de distribución', 'Correa de distribución de repuesto', 90, 40.00, 50.00, 'A'),
    (4, 'Faros delanteros', 'Faros delanteros LED', 50, 150.00, 170.00, 'A'),
    (4, 'Luces traseras', 'Luces traseras para reemplazo', 70, 100.00, 110.00, 'A'),
    (4, 'Bombillas halógenas', 'Bombillas halógenas H4', 200, 5.00, 6.00, 'A'),
    (5, 'Embrague', 'Kit de embrague completo', 30, 300.00, 350.00, 'A'),
    (5, 'Volante bimasa', 'Volante bimasa de alta resistencia', 20, 400.00, 450.00, 'A'),
    (5, 'Kit de sincronización', 'Kit de sincronización de cadena', 40, 150.00, 160.00, 'A'),
    (6, 'Cremallera de dirección', 'Cremallera de dirección asistida', 25, 200.00, 220.00, 'A'),
    (6, 'Terminales de dirección', 'Terminales de dirección para repuesto', 60, 50.00, 60.00, 'A'),
    (6, 'Brazos de suspensión', 'Brazos de suspensión delanteros', 80, 80.00, 90.00, 'A'),
    (7, 'Centralita electrónica', 'Centralita electrónica de motor', 15, 350.00, 380.00, 'A'),
    (7, 'Sensor de oxígeno', 'Sensor de oxígeno para control de emisiones', 40, 80.00, 90.00, 'A'),
    (7, 'Cableado eléctrico', 'Cableado eléctrico para repuesto', 100, 30.00, 35.00, 'A'),
    (8, 'Silenciador', 'Silenciador de escape deportivo', 35, 120.00, 130.00, 'A'),
    (8, 'Catalizador', 'Catalizador de escape homologado', 30, 200.00, 220.00, 'A'),
    (8, 'Tubos de escape', 'Tubos de escape de acero inoxidable', 50, 80.00, 90.00, 'A'),
    (9, 'Puerta delantera', 'Puerta delantera izquierda para reemplazo', 20, 250.00, 280.00, 'A'),
    (9, 'Espejo retrovisor', 'Espejo retrovisor eléctrico', 60, 50.00, 60.00, 'A'),
    (9, 'Parachoques', 'Parachoques delantero de repuesto', 30, 150.00, 170.00, 'A'),
    (10, 'Neumáticos de verano', 'Juego de neumáticos de verano', 100, 80.00, 90.00, 'A'),
    (10, 'Neumáticos de invierno', 'Juego de neumáticos de invierno', 60, 100.00, 110.00, 'A'),
    (10, 'Neumáticos todo terreno', 'Juego de neumáticos todo terreno', 40, 120.00, 130.00, 'A')
;
GO

SELECT * FROM VistaPedidos
SELECT * FROM NEGOCIO.PRODUCTOS
DELETE FROM NEGOCIO.PRODUCTOS