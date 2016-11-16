-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 16-11-2016 a las 19:17:21
-- Versión del servidor: 10.1.16-MariaDB
-- Versión de PHP: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `blackbuster`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(80) COLLATE utf8_spanish_ci NOT NULL,
  `Membresia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`Id`, `Nombre`, `Membresia`) VALUES
(1, 'Juan Arturo López Chávez', 2),
(2, 'Angelica López Esquerra', 1),
(3, 'Maria Guadalupe Rosas Rodriguez', 1),
(4, 'Julio Estrada Ríos', 2),
(5, 'Mario Medina', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_renta`
--

CREATE TABLE `detalle_renta` (
  `Folio` int(11) NOT NULL,
  `Video` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `detalle_renta`
--

INSERT INTO `detalle_renta` (`Folio`, `Video`) VALUES
(1, 3),
(1, 8),
(1, 9),
(2, 1),
(2, 2),
(2, 5),
(2, 8),
(2, 9),
(2, 11),
(6, 5),
(6, 7),
(6, 8);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `membresia`
--

CREATE TABLE `membresia` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(20) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `membresia`
--

INSERT INTO `membresia` (`Id`, `Nombre`) VALUES
(1, 'Normal'),
(2, 'Gold');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `renta`
--

CREATE TABLE `renta` (
  `Folio` int(11) NOT NULL,
  `Fecha` datetime NOT NULL,
  `Cliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `renta`
--

INSERT INTO `renta` (`Folio`, `Fecha`, `Cliente`) VALUES
(1, '2016-11-14 18:30:00', 2),
(2, '2016-11-14 19:00:00', 4),
(6, '2016-11-16 10:23:00', 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo`
--

CREATE TABLE `tipo` (
  `Id` int(11) NOT NULL,
  `NombreTipo` varchar(20) COLLATE utf8_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `tipo`
--

INSERT INTO `tipo` (`Id`, `NombreTipo`) VALUES
(1, 'Infantil'),
(2, 'Adolescentes'),
(3, 'Adultos');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `video`
--

CREATE TABLE `video` (
  `Codigo` int(11) NOT NULL,
  `Descripcion` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `Precio` decimal(10,2) NOT NULL,
  `Tipo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `video`
--

INSERT INTO `video` (`Codigo`, `Descripcion`, `Precio`, `Tipo`) VALUES
(1, 'Una noche en el museo', '59.90', 1),
(2, 'El día de la independencia', '59.90', 2),
(3, 'Titanic', '59.90', 2),
(4, 'La Ouija', '59.90', 3),
(5, 'El código da vinci', '59.90', 2),
(6, 'Mascotas', '59.90', 1),
(7, 'Aventuras en pañales', '59.90', 1),
(8, 'El crimer del padre Amaro', '59.90', 3),
(9, 'Capitan America', '59.90', 1),
(10, 'Son como niños', '59.90', 2),
(11, 'Furia en el catre', '59.90', 3);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Membresia` (`Membresia`);

--
-- Indices de la tabla `detalle_renta`
--
ALTER TABLE `detalle_renta`
  ADD KEY `Folio` (`Folio`,`Video`),
  ADD KEY `Video` (`Video`);

--
-- Indices de la tabla `membresia`
--
ALTER TABLE `membresia`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `renta`
--
ALTER TABLE `renta`
  ADD PRIMARY KEY (`Folio`),
  ADD KEY `Cliente` (`Cliente`);

--
-- Indices de la tabla `tipo`
--
ALTER TABLE `tipo`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `video`
--
ALTER TABLE `video`
  ADD PRIMARY KEY (`Codigo`),
  ADD KEY `Tipo` (`Tipo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `membresia`
--
ALTER TABLE `membresia`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `renta`
--
ALTER TABLE `renta`
  MODIFY `Folio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `tipo`
--
ALTER TABLE `tipo`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `video`
--
ALTER TABLE `video`
  MODIFY `Codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD CONSTRAINT `cliente_ibfk_1` FOREIGN KEY (`Membresia`) REFERENCES `membresia` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `detalle_renta`
--
ALTER TABLE `detalle_renta`
  ADD CONSTRAINT `detalle_renta_ibfk_1` FOREIGN KEY (`Folio`) REFERENCES `renta` (`Folio`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `detalle_renta_ibfk_2` FOREIGN KEY (`Video`) REFERENCES `video` (`Codigo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `renta`
--
ALTER TABLE `renta`
  ADD CONSTRAINT `renta_ibfk_1` FOREIGN KEY (`Cliente`) REFERENCES `cliente` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `video`
--
ALTER TABLE `video`
  ADD CONSTRAINT `video_ibfk_1` FOREIGN KEY (`Tipo`) REFERENCES `tipo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
