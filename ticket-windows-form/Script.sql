CREATE DATABASE BOLETERIA;
USE BOLETERIA;

CREATE TABLE artista (
    id_artista SERIAL PRIMARY KEY,
    manager VARCHAR(50),
    nom_artistico VARCHAR(50) NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    ap_paterno VARCHAR(50) NOT NULL,
    ap_materno VARCHAR(50)
);

CREATE TABLE cliente (
    id_cliente SERIAL PRIMARY KEY,
    nombre VARCHAR(50),
    ap_paterno VARCHAR(50),
    ap_materno VARCHAR(50),
    fecha_nacimiento DATE,
    telefono VARCHAR(20),
    correo_electronico VARCHAR(100),
    contrasena VARCHAR(50) NOT NULL
);

CREATE TABLE concierto (
    id_concierto SERIAL PRIMARY KEY,
    nombre_concierto VARCHAR(50) NOT NULL,
    ubicacion_concierto VARCHAR(50) NOT NULL,
    capacidad_total INTEGER NOT NULL CHECK (capacidad_total > 0),
    organizacion VARCHAR(50) NOT NULL,
    artista_id INTEGER NOT NULL REFERENCES artista(id_artista),
    empleado_id INTEGER NOT NULL REFERENCES empleado(id_empleado),
    zona_id INTEGER NOT NULL REFERENCES zona(id_zona),
    fecha_inicio DATE NOT NULL,
    fecha_fin DATE NOT NULL CHECK (fecha_fin >= fecha_inicio)
);

CREATE TABLE detalle_boleto (
    id_detalle_boleto SERIAL PRIMARY KEY,
    fecha_compra DATE NOT NULL,
    zona_elegida VARCHAR(50) NOT NULL,
    precio_unitario NUMERIC(10,2) NOT NULL CHECK (precio_unitario > 0),
    venta_boleto_id INTEGER NOT NULL REFERENCES venta_boleto(id_venta)
);

CREATE TABLE empleado (
    id_empleado SERIAL PRIMARY KEY,
    cargo VARCHAR(50) NOT NULL,
    fecha_contratacion DATE NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    ap_paterno VARCHAR(50) NOT NULL,
    ap_materno VARCHAR(50),
    fecha_nacimiento DATE NOT NULL,
    telefono VARCHAR(20) NOT NULL UNIQUE,
    correo_electronico VARCHAR(100) NOT NULL UNIQUE,
    sueldo NUMERIC(10,2) NOT NULL CHECK (sueldo > 0),
    contrasena VARCHAR(50) NOT NULL
);

CREATE TABLE recibo (
    id_recibo SERIAL PRIMARY KEY,
    fecha_emision DATE NOT NULL,
    metodo_pago VARCHAR(50) NOT NULL,
    venta_boleto_id INTEGER NOT NULL REFERENCES venta_boleto(id_venta)
);

CREATE TABLE venta_boleto (
    id_venta SERIAL PRIMARY KEY,
    concierto_id INTEGER NOT NULL REFERENCES concierto(id_concierto),
    cliente_id INTEGER NOT NULL REFERENCES cliente(id_cliente),
    costo_total NUMERIC(10,2) NOT NULL CHECK (costo_total >= 0)
);

CREATE TABLE zona (
    id_zona SERIAL PRIMARY KEY,
    nombre_zona VARCHAR(50) NOT NULL UNIQUE
);