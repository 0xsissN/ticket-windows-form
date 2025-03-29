CREATE DATABASE BOLETERIA;

CREATE TABLE ARTISTA (
    id_artista SERIAL PRIMARY KEY,
    manager VARCHAR(50),
    nom_artistico VARCHAR(50),
    fecha_nacimiento DATE,
    nombre VARCHAR(50),
    ap_paterno VARCHAR(50),
    ap_materno VARCHAR(50)
);

CREATE TABLE CLIENTE (
    id_cliente SERIAL PRIMARY KEY,
    nombre VARCHAR(50),
    ap_paterno VARCHAR(50),
    ap_materno VARCHAR(50),
    fecha_nacimiento DATE,
    telefono VARCHAR(20),
    correo_electronico VARCHAR(100),
    contrasena VARCHAR(50) NOT NULL
);

CREATE TABLE EMPLEADO (
    id_empleado SERIAL PRIMARY KEY,
    cargo VARCHAR(50),
    fecha_contratacion DATE,
    nombre VARCHAR(50),
    ap_paterno VARCHAR(50),
    ap_materno VARCHAR(50),
    fecha_nacimiento DATE,
    telefono VARCHAR(20),
    correo_electronico VARCHAR(100),
    sueldo NUMERIC(10, 2),
    contrasena VARCHAR(50) NOT NULL
);

CREATE TABLE ZONA (
    tipo_zona VARCHAR(50) PRIMARY KEY,
    capacidad INTEGER
);

CREATE TABLE CONCIERTO (
    id_concierto SERIAL PRIMARY KEY,
    ubicacion_concierto VARCHAR(50),
    capacidad_total INTEGER,
    organizacion VARCHAR(50),
    artista_id INTEGER NOT NULL,
    empleado_id INTEGER NOT NULL,
    zona_tipo VARCHAR(50) NOT NULL,
    FOREIGN KEY (artista_id) REFERENCES ARTISTA(id_artista),
    FOREIGN KEY (empleado_id) REFERENCES EMPLEADO(id_empleado),
    FOREIGN KEY (zona_tipo) REFERENCES ZONA(tipo_zona)
);

CREATE TABLE VENTA_BOLETO (
    id_venta SERIAL PRIMARY KEY,
    cantidad_boleto INTEGER,
    concierto_id INTEGER NOT NULL,
    cliente_id INTEGER NOT NULL,
    FOREIGN KEY (concierto_id) REFERENCES CONCIERTO(id_concierto),
    FOREIGN KEY (cliente_id) REFERENCES CLIENTE(id_cliente)
);

CREATE TABLE DETALLE_BOLETO (
    id_detalle_boleto SERIAL PRIMARY KEY,
    fecha_compra DATE,
    fecha_concierto DATE,
    precio_unitario NUMERIC(10, 2),
    hora_inicio TIME,
    hora_final TIME,
    venta_boleto_id INTEGER NOT NULL,
    FOREIGN KEY (venta_boleto_id) REFERENCES VENTA_BOLETO(id_venta)
);

CREATE TABLE FACTURA (
s    id_factura SERIAL PRIMARY KEY,
    fecha_emision DATE,
    metodo_pago VARCHAR(50),
    NIT VARCHAR(20), 
    venta_boleto_id INTEGER NOT NULL,
    FOREIGN KEY (venta_boleto_id) REFERENCES VENTA_BOLETO(id_venta)
);