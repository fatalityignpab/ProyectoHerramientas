-- phpMyAdmin SQL Dump
-- version 4.5.2
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 04-07-2017 a las 02:03:07
-- Versión del servidor: 5.7.9
-- Versión de PHP: 7.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `herramientasaut_v2`
--

DELIMITER $$
--
-- Procedimientos
--
DROP PROCEDURE IF EXISTS `Buscar`$$
CREATE DEFINER=`herr`@`localhost` PROCEDURE `Buscar` (IN `idFact` INT)  BEGIN
	select * from vista_facto where idFactura = idFact;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

DROP TABLE IF EXISTS `bitacora`;
CREATE TABLE IF NOT EXISTS `bitacora` (
  `IP` varchar(15) NOT NULL,
  `USUARIO` varchar(40) NOT NULL,
  `ACCION` varchar(20) NOT NULL,
  `MODIFICADO` varchar(30) NOT NULL,
  `TABLA` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `bitacora`
--

INSERT INTO `bitacora` (`IP`, `USUARIO`, `ACCION`, `MODIFICADO`, `TABLA`) VALUES
('localhost', 'herr', 'BORRAR', '2017-06-04 00:06:30', 'CLIENTE');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `idCliente` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Apellidos` varchar(45) NOT NULL,
  `Direccion` varchar(100) DEFAULT NULL,
  `Telefono` varchar(45) DEFAULT NULL,
  `email` varchar(70) DEFAULT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`idCliente`, `Nombre`, `Apellidos`, `Direccion`, `Telefono`, `email`) VALUES
(1, 'Vianey', 'Olmedo', 'La virgen', '55-4563-7664', 'vianey@gmail.com'),
(2, 'Mario', 'Canseco', 'Central', '55-3234-5543', 'mario@gmail.com'),
(3, 'Israel', 'Picazo', 'Ferrari', '55-4354-6654', 'izferrari26@gmail.com'),
(4, 'IZRA', 'PICAZO', 'FERRARI', '44324453', 'saw_9512@hotmail.com'),
(5, 'Citlalli', 'Rivera Diaz', 'Morelos 22', 'no te lo voy a dar', 'ycitlallidiaz@gmail.com');

--
-- Disparadores `cliente`
--
DROP TRIGGER IF EXISTS `Bitacora_Borrar_cl`;
DELIMITER $$
CREATE TRIGGER `Bitacora_Borrar_cl` BEFORE DELETE ON `cliente` FOR EACH ROW INSERT INTO bitacora(`IP`,`USUARIO`,`ACCION`,`MODIFICADO`,`TABLA`)
            VALUES (SUBSTRING(USER(),(INSTR(USER(),'@')+1)), SUBSTRING(USER(),1,(INSTR(USER(),'@')-1)), 'BORRAR', NOW(), 'CLIENTE')
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle`
--

DROP TABLE IF EXISTS `detalle`;
CREATE TABLE IF NOT EXISTS `detalle` (
  `idDetalle` int(11) NOT NULL AUTO_INCREMENT,
  `Factura_idFactura` int(11) NOT NULL,
  `Productos_idProducto` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  PRIMARY KEY (`idDetalle`,`Factura_idFactura`),
  KEY `fk_Detalle_Factura1_idx` (`Factura_idFactura`),
  KEY `fk_Detalle_Productos1_idx` (`Productos_idProducto`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `detalle`
--

INSERT INTO `detalle` (`idDetalle`, `Factura_idFactura`, `Productos_idProducto`, `Cantidad`) VALUES
(1, 1, 2, 34),
(2, 1, 1, 2),
(3, 2, 2, 34),
(4, 2, 1, 30),
(5, 2, 3, 2),
(6, 3, 2, 20),
(7, 3, 3, 50),
(8, 4, 4, 4),
(9, 5, 4, 22),
(10, 5, 3, 4),
(11, 5, 1, 13),
(12, 6, 3, 3),
(13, 6, 4, 6);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

DROP TABLE IF EXISTS `factura`;
CREATE TABLE IF NOT EXISTS `factura` (
  `idFactura` int(11) NOT NULL AUTO_INCREMENT,
  `Cliente_idCliente` int(11) NOT NULL,
  `Responsable_idResponsable` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  PRIMARY KEY (`idFactura`),
  KEY `fk_Factura_Cliente1_idx` (`Cliente_idCliente`),
  KEY `fk_Factura_Responsable1_idx` (`Responsable_idResponsable`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `factura`
--

INSERT INTO `factura` (`idFactura`, `Cliente_idCliente`, `Responsable_idResponsable`, `Fecha`) VALUES
(1, 1, 1, '2016-12-06'),
(2, 2, 1, '2016-12-06'),
(3, 3, 4, '2017-05-30'),
(4, 2, 3, '2017-06-01'),
(5, 4, 4, '2017-06-04'),
(6, 5, 3, '2017-06-06');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

DROP TABLE IF EXISTS `productos`;
CREATE TABLE IF NOT EXISTS `productos` (
  `idProducto` int(11) NOT NULL AUTO_INCREMENT,
  `Responsable_idResponsable` int(11) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Talla` varchar(45) NOT NULL,
  `Precio` float NOT NULL,
  `Stock` int(11) NOT NULL,
  `FechaIngreso` date NOT NULL,
  `HoraIngreso` time NOT NULL,
  PRIMARY KEY (`idProducto`),
  KEY `fk_Productos_Responsable1_idx` (`Responsable_idResponsable`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`idProducto`, `Responsable_idResponsable`, `Nombre`, `Talla`, `Precio`, `Stock`, `FechaIngreso`, `HoraIngreso`) VALUES
(1, 1, 'Playeras', 'Extra Chico', 340, 500, '2016-12-06', '07:44:03'),
(2, 1, 'Pantalones', 'Mediano', 400, 450, '2016-12-06', '07:44:45'),
(3, 2, 'Shorts', 'Grande', 450, 1000, '2016-12-06', '07:46:08'),
(4, 4, 'Casco Stormtrooper', 'Extra Grande', 300, 500, '2017-06-01', '00:14:29'),
(5, 7, 'Figuritas', 'Mediano', 2.99, 500, '2017-06-06', '14:35:45');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `idResponsable` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Alias` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `Puesto` varchar(45) NOT NULL,
  `FechaIngreso` date NOT NULL,
  `HoraIngreso` time NOT NULL,
  `CORREO` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`idResponsable`),
  UNIQUE KEY `Password_UNIQUE` (`Password`),
  UNIQUE KEY `Alias_UNIQUE` (`Alias`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `responsable`
--

INSERT INTO `responsable` (`idResponsable`, `Nombre`, `Alias`, `Password`, `Puesto`, `FechaIngreso`, `HoraIngreso`, `CORREO`) VALUES
(1, 'Administrador', 'admin', '21232f297a57a5a743894a0e4a801fc3', 'Gerente', '2017-05-21', '17:04:10', 'admin@gmail.com'),
(2, 'Carlos', 'car', 'e6d96502596d7e7887b76646c5f615d9', 'Almacenista', '2016-12-06', '09:08:21', 'carlos@gmail.com'),
(3, 'Fernando', 'fer', '90eb8760c187a2097884ed4c9ffbb6a4', 'Vendedor', '2017-06-06', '14:30:41', 'fernando@gmail.com'),
(4, 'Redes', 'red', '7ed201fa20d25d22b291dc85ae9e5ced', 'Gerente', '2017-06-08', '07:16:13', 'redes2017.10@gmail.com'),
(5, 'Izrael', 'IZFERRARI26', '7a5fe2ec82bd284342d47420cb6b7d93', 'Gerente', '2017-06-01', '07:06:14', 'izferrari26@gmail.com'),
(6, 'Redes2', 'redes', '2aa17ad91450cfb243fe41dc58bef05e', 'Gerente', '2017-06-04', '01:15:29', 'redes2017.10@hotmail.com'),
(7, 'Roberto Gonzalez', 'robert', '202cb962ac59075b964b07152d234b70', 'Almacenista', '2017-06-06', '14:34:33', 'robertglz22@gmail.com');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `ventaunapersona`
--
DROP VIEW IF EXISTS `ventaunapersona`;
CREATE TABLE IF NOT EXISTS `ventaunapersona` (
`idDetalle` int(11)
,`Responsable` varchar(45)
,`Nombre` varchar(45)
,`Talla` varchar(45)
,`Precio` float
,`Comprador` varchar(45)
,`Importe` double
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vistacompleta`
--
DROP VIEW IF EXISTS `vistacompleta`;
CREATE TABLE IF NOT EXISTS `vistacompleta` (
`idFactura` int(11)
,`Responsable` varchar(45)
,`Nombre` varchar(45)
,`Cantidad` int(11)
,`Talla` varchar(45)
,`Precio` float
,`Comprador` varchar(91)
,`Importe` varchar(64)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vistafactura`
--
DROP VIEW IF EXISTS `vistafactura`;
CREATE TABLE IF NOT EXISTS `vistafactura` (
`idFactura` int(11)
,`Responsable` varchar(45)
,`Nombre` varchar(45)
,`Talla` varchar(45)
,`Precio` float
,`Comprador` varchar(45)
,`Importe` double
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vistafinal`
--
DROP VIEW IF EXISTS `vistafinal`;
CREATE TABLE IF NOT EXISTS `vistafinal` (
`idFactura` int(11)
,`Cantidad` int(11)
,`Responsable` varchar(45)
,`Nombre` varchar(45)
,`Talla` varchar(45)
,`Cliente` varchar(45)
,`Precio` float
,`Importe` varchar(64)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vistanueva`
--
DROP VIEW IF EXISTS `vistanueva`;
CREATE TABLE IF NOT EXISTS `vistanueva` (
`idFactura` int(11)
,`Responsable` varchar(45)
,`Nombre` varchar(45)
,`Talla` varchar(45)
,`Precio` float
,`Comprador` varchar(45)
,`Importe` varchar(64)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vistanuevita`
--
DROP VIEW IF EXISTS `vistanuevita`;
CREATE TABLE IF NOT EXISTS `vistanuevita` (
`idFactura` int(11)
,`Responsable` varchar(45)
,`Nombre` varchar(45)
,`Talla` varchar(45)
,`Precio` float
,`Comprador` varchar(45)
,`Importe` varchar(24)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vistaotrapersona`
--
DROP VIEW IF EXISTS `vistaotrapersona`;
CREATE TABLE IF NOT EXISTS `vistaotrapersona` (
`idFactura` int(11)
,`Responsable` varchar(45)
,`Nombre` varchar(45)
,`Talla` varchar(45)
,`Precio` float
,`Comprador` varchar(45)
,`Importe` double
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vistaprod`
--
DROP VIEW IF EXISTS `vistaprod`;
CREATE TABLE IF NOT EXISTS `vistaprod` (
`idProducto` int(11)
,`Responsable` varchar(45)
,`Nombre` varchar(45)
,`Talla` varchar(45)
,`Precio` float
,`Stock` int(11)
,`FechaIngreso` date
,`HoraIngreso` time
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vistaprueba`
--
DROP VIEW IF EXISTS `vistaprueba`;
CREATE TABLE IF NOT EXISTS `vistaprueba` (
`idResponsable` int(11)
,`Nombre` varchar(45)
,`Alias` varchar(45)
,`Password` varchar(45)
,`Puesto` varchar(45)
,`FechaIngreso` date
,`HoraIngreso` time
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vistaprueba2`
--
DROP VIEW IF EXISTS `vistaprueba2`;
CREATE TABLE IF NOT EXISTS `vistaprueba2` (
`idFactura` int(11)
,`Responsable` varchar(45)
,`Nombre` varchar(45)
,`Talla` varchar(45)
,`Precio` float
,`Comprador` varchar(45)
,`Importe` double
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vistasuma`
--
DROP VIEW IF EXISTS `vistasuma`;
CREATE TABLE IF NOT EXISTS `vistasuma` (
`idFactura` int(11)
,`Total` varchar(64)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vista_facto`
--
DROP VIEW IF EXISTS `vista_facto`;
CREATE TABLE IF NOT EXISTS `vista_facto` (
`idFactura` int(11)
,`Cantidad` int(11)
,`Encargado` varchar(45)
,`Nombre` varchar(45)
,`Talla` varchar(45)
,`Precio` float
,`Cliente` varchar(90)
,`Importe` varchar(64)
,`impnum` double
);

-- --------------------------------------------------------

--
-- Estructura para la vista `ventaunapersona`
--
DROP TABLE IF EXISTS `ventaunapersona`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `ventaunapersona`  AS  select `detalle`.`idDetalle` AS `idDetalle`,`responsable`.`Nombre` AS `Responsable`,`productos`.`Nombre` AS `Nombre`,`productos`.`Talla` AS `Talla`,`productos`.`Precio` AS `Precio`,`cliente`.`Nombre` AS `Comprador`,(`productos`.`Precio` * `detalle`.`Cantidad`) AS `Importe` from ((((`detalle` join `responsable`) join `factura`) join `productos`) join `cliente` on(((`productos`.`idProducto` = `detalle`.`Productos_idProducto`) and (`detalle`.`Factura_idFactura` = `factura`.`idFactura`) and (`factura`.`Responsable_idResponsable` = `responsable`.`idResponsable`) and (`factura`.`Cliente_idCliente` = `cliente`.`idCliente`)))) where (`factura`.`idFactura` = 1) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vistacompleta`
--
DROP TABLE IF EXISTS `vistacompleta`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistacompleta`  AS  select `factura`.`idFactura` AS `idFactura`,`responsable`.`Nombre` AS `Responsable`,`productos`.`Nombre` AS `Nombre`,`detalle`.`Cantidad` AS `Cantidad`,`productos`.`Talla` AS `Talla`,`productos`.`Precio` AS `Precio`,concat(`cliente`.`Nombre`,' ',`cliente`.`Apellidos`) AS `Comprador`,concat('$',convert(format((`detalle`.`Cantidad` * `productos`.`Precio`),2) using utf8mb4)) AS `Importe` from ((((`factura` join `detalle`) join `cliente`) join `responsable`) join `productos` on(((`cliente`.`idCliente` = `factura`.`Cliente_idCliente`) and (`responsable`.`idResponsable` = `factura`.`Responsable_idResponsable`) and (`productos`.`idProducto` = `detalle`.`Productos_idProducto`) and (`detalle`.`Factura_idFactura` = `factura`.`idFactura`)))) order by `factura`.`idFactura` ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vistafactura`
--
DROP TABLE IF EXISTS `vistafactura`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistafactura`  AS  select `factura`.`idFactura` AS `idFactura`,`responsable`.`Nombre` AS `Responsable`,`productos`.`Nombre` AS `Nombre`,`productos`.`Talla` AS `Talla`,`productos`.`Precio` AS `Precio`,`cliente`.`Nombre` AS `Comprador`,(`productos`.`Precio` * `detalle`.`Cantidad`) AS `Importe` from ((((`detalle` join `responsable`) join `factura`) join `productos`) join `cliente` on(((`productos`.`idProducto` = `detalle`.`Productos_idProducto`) and (`detalle`.`Factura_idFactura` = `factura`.`idFactura`) and (`factura`.`Responsable_idResponsable` = `responsable`.`idResponsable`) and (`factura`.`Cliente_idCliente` = `cliente`.`idCliente`)))) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vistafinal`
--
DROP TABLE IF EXISTS `vistafinal`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistafinal`  AS  select `f`.`idFactura` AS `idFactura`,`d`.`Cantidad` AS `Cantidad`,`r`.`Nombre` AS `Responsable`,`p`.`Nombre` AS `Nombre`,`p`.`Talla` AS `Talla`,`c`.`Nombre` AS `Cliente`,`p`.`Precio` AS `Precio`,concat('$',format((`d`.`Cantidad` * `p`.`Precio`),'2')) AS `Importe` from ((((`factura` `f` join `responsable` `r` on((`f`.`Responsable_idResponsable` = `r`.`idResponsable`))) join `productos` `p` on((`p`.`Responsable_idResponsable` = `r`.`idResponsable`))) join `cliente` `c` on((`c`.`idCliente` = `f`.`Cliente_idCliente`))) join `detalle` `d` on(((`d`.`Factura_idFactura` = `f`.`idFactura`) and (`d`.`Productos_idProducto` = `p`.`idProducto`)))) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vistanueva`
--
DROP TABLE IF EXISTS `vistanueva`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistanueva`  AS  select `factura`.`idFactura` AS `idFactura`,`responsable`.`Nombre` AS `Responsable`,`productos`.`Nombre` AS `Nombre`,`productos`.`Talla` AS `Talla`,`productos`.`Precio` AS `Precio`,`cliente`.`Nombre` AS `Comprador`,concat('$',format((`detalle`.`Cantidad` * `productos`.`Precio`),2)) AS `Importe` from ((((`factura` join `detalle`) join `cliente`) join `responsable`) join `productos` on(((`cliente`.`idCliente` = `factura`.`Cliente_idCliente`) and (`responsable`.`idResponsable` = `factura`.`Responsable_idResponsable`) and (`productos`.`idProducto` = `detalle`.`Productos_idProducto`)))) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vistanuevita`
--
DROP TABLE IF EXISTS `vistanuevita`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistanuevita`  AS  select `factura`.`idFactura` AS `idFactura`,`responsable`.`Nombre` AS `Responsable`,`productos`.`Nombre` AS `Nombre`,`productos`.`Talla` AS `Talla`,`productos`.`Precio` AS `Precio`,`cliente`.`Nombre` AS `Comprador`,concat('$',(`detalle`.`Cantidad` * `productos`.`Precio`)) AS `Importe` from ((((`factura` join `detalle`) join `cliente`) join `responsable`) join `productos` on(((`cliente`.`idCliente` = `factura`.`Cliente_idCliente`) and (`responsable`.`idResponsable` = `factura`.`Responsable_idResponsable`) and (`productos`.`idProducto` = `detalle`.`Productos_idProducto`) and (`detalle`.`Factura_idFactura` = `factura`.`idFactura`)))) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vistaotrapersona`
--
DROP TABLE IF EXISTS `vistaotrapersona`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistaotrapersona`  AS  select `factura`.`idFactura` AS `idFactura`,`responsable`.`Nombre` AS `Responsable`,`productos`.`Nombre` AS `Nombre`,`productos`.`Talla` AS `Talla`,`productos`.`Precio` AS `Precio`,`cliente`.`Nombre` AS `Comprador`,(`productos`.`Precio` * `detalle`.`Cantidad`) AS `Importe` from ((((`detalle` join `responsable`) join `factura`) join `productos`) join `cliente` on(((`productos`.`idProducto` = `detalle`.`Productos_idProducto`) and (`detalle`.`Factura_idFactura` = `factura`.`idFactura`) and (`factura`.`Responsable_idResponsable` = `responsable`.`idResponsable`) and (`factura`.`Cliente_idCliente` = `cliente`.`idCliente`)))) where (`factura`.`idFactura` = 1) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vistaprod`
--
DROP TABLE IF EXISTS `vistaprod`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistaprod`  AS  select `productos`.`idProducto` AS `idProducto`,`responsable`.`Nombre` AS `Responsable`,`productos`.`Nombre` AS `Nombre`,`productos`.`Talla` AS `Talla`,`productos`.`Precio` AS `Precio`,`productos`.`Stock` AS `Stock`,`productos`.`FechaIngreso` AS `FechaIngreso`,`productos`.`HoraIngreso` AS `HoraIngreso` from (`responsable` join `productos` on((`productos`.`Responsable_idResponsable` = `responsable`.`idResponsable`))) order by `productos`.`idProducto` ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vistaprueba`
--
DROP TABLE IF EXISTS `vistaprueba`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistaprueba`  AS  select `responsable`.`idResponsable` AS `idResponsable`,`responsable`.`Nombre` AS `Nombre`,`responsable`.`Alias` AS `Alias`,`responsable`.`Password` AS `Password`,`responsable`.`Puesto` AS `Puesto`,`responsable`.`FechaIngreso` AS `FechaIngreso`,`responsable`.`HoraIngreso` AS `HoraIngreso` from `responsable` ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vistaprueba2`
--
DROP TABLE IF EXISTS `vistaprueba2`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistaprueba2`  AS  select `factura`.`idFactura` AS `idFactura`,`responsable`.`Nombre` AS `Responsable`,`productos`.`Nombre` AS `Nombre`,`productos`.`Talla` AS `Talla`,`productos`.`Precio` AS `Precio`,`cliente`.`Nombre` AS `Comprador`,(`detalle`.`Cantidad` * `productos`.`Precio`) AS `Importe` from ((((`factura` join `detalle`) join `cliente`) join `responsable`) join `productos` on(((`cliente`.`idCliente` = `factura`.`Cliente_idCliente`) and (`responsable`.`idResponsable` = `factura`.`Responsable_idResponsable`) and (`productos`.`idProducto` = `detalle`.`Productos_idProducto`) and (`detalle`.`Factura_idFactura` = `factura`.`idFactura`)))) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vistasuma`
--
DROP TABLE IF EXISTS `vistasuma`;

CREATE ALGORITHM=UNDEFINED DEFINER=`herr`@`localhost` SQL SECURITY DEFINER VIEW `vistasuma`  AS  select `f`.`idFactura` AS `idFactura`,concat('$',format(sum((`d`.`Cantidad` * `p`.`Precio`)),2)) AS `Total` from ((`factura` `f` join `detalle` `d` on((`d`.`Factura_idFactura` = `f`.`idFactura`))) join `productos` `p` on((`d`.`Productos_idProducto` = `p`.`idProducto`))) group by `f`.`idFactura` ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vista_facto`
--
DROP TABLE IF EXISTS `vista_facto`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vista_facto`  AS  select `f`.`idFactura` AS `idFactura`,`d`.`Cantidad` AS `Cantidad`,`r`.`Nombre` AS `Encargado`,`p`.`Nombre` AS `Nombre`,`p`.`Talla` AS `Talla`,`p`.`Precio` AS `Precio`,concat(`c`.`Nombre`,`c`.`Apellidos`) AS `Cliente`,concat('$',format((`p`.`Precio` * `d`.`Cantidad`),'2')) AS `Importe`,(`p`.`Precio` * `d`.`Cantidad`) AS `impnum` from ((((`factura` `f` join `responsable` `r` on((`f`.`Responsable_idResponsable` = `r`.`idResponsable`))) join `productos` `p` on((`p`.`Responsable_idResponsable` = `r`.`idResponsable`))) join `cliente` `c` on((`c`.`idCliente` = `f`.`Cliente_idCliente`))) join `detalle` `d` on(((`d`.`Factura_idFactura` = `f`.`idFactura`) and (`d`.`Productos_idProducto` = `p`.`idProducto`)))) ;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `detalle`
--
ALTER TABLE `detalle`
  ADD CONSTRAINT `fk_Detalle_Factura1` FOREIGN KEY (`Factura_idFactura`) REFERENCES `factura` (`idFactura`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Detalle_Productos1` FOREIGN KEY (`Productos_idProducto`) REFERENCES `productos` (`idProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `factura`
--
ALTER TABLE `factura`
  ADD CONSTRAINT `fk_Factura_Cliente1` FOREIGN KEY (`Cliente_idCliente`) REFERENCES `cliente` (`idCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Factura_Responsable1` FOREIGN KEY (`Responsable_idResponsable`) REFERENCES `responsable` (`idResponsable`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `productos`
--
ALTER TABLE `productos`
  ADD CONSTRAINT `fk_Productos_Responsable1` FOREIGN KEY (`Responsable_idResponsable`) REFERENCES `responsable` (`idResponsable`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
