--
-- PostgreSQL database dump
--

-- Dumped from database version 14.2
-- Dumped by pg_dump version 14.2

-- Started on 2022-05-12 10:33:33

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 210 (class 1259 OID 16416)
-- Name: Bezeroa; Type: TABLE; Schema: public;
--

CREATE TABLE public."Bezeroa" (
    "Nan" character(9) NOT NULL,
    "Izena" character(50),
    "Helbidea" character(50),
    "Telf" character(9),
    "Emaila" character(50),
    "NanSaltzailea" character(9)
);


--
-- TOC entry 211 (class 1259 OID 16419)
-- Name: Salmenta; Type: TABLE; Schema: public;
--

CREATE TABLE public."Salmenta" (
    "Id" bigint NOT NULL,
    "Data" date,
    "Zenbatekoa" numeric(9,2),
    "NanBezeroa" character(9)
);

--
-- TOC entry 212 (class 1259 OID 16422)
-- Name: Salmenta_Id_seq; Type: SEQUENCE; Schema: public;
--

ALTER TABLE public."Salmenta" ALTER COLUMN "Id" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Salmenta_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 209 (class 1259 OID 16413)
-- Name: Saltzailea; Type: TABLE; Schema: public;
--

CREATE TABLE public."Saltzailea" (
    "Nan" character(9) NOT NULL,
    "Izena" character(50),
    "Taldea" character(10)
);
--
-- TOC entry 3175 (class 2606 OID 16427)
-- Name: Bezeroa Bezeroa_pkey; Type: CONSTRAINT; Schema: public;
--

ALTER TABLE ONLY public."Bezeroa"
    ADD CONSTRAINT "Bezeroa_pkey" PRIMARY KEY ("Nan");


--
-- TOC entry 3177 (class 2606 OID 16431)
-- Name: Salmenta Salmenta_pkey; Type: CONSTRAINT; Schema: public;
--

ALTER TABLE ONLY public."Salmenta"
    ADD CONSTRAINT "Salmenta_pkey" PRIMARY KEY ("Id");


--
-- TOC entry 3173 (class 2606 OID 16429)
-- Name: Saltzailea Saltzailea_pkey; Type: CONSTRAINT; Schema: public;
--

ALTER TABLE ONLY public."Saltzailea"
    ADD CONSTRAINT "Saltzailea_pkey" PRIMARY KEY ("Nan");


INSERT into public."Bezeroa" ("Nan", "Izena", "Helbidea", "Telf", "Emaila", "NanSaltzailea") VALUES (N'121212121', N'olatz', N'mkij', N'457854125', N'gggg@ggg', N'eeeeeeeee');
INSERT into public."Bezeroa" ("Nan", "Izena", "Helbidea", "Telf", "Emaila", "NanSaltzailea") VALUES (N'131313131', N'sara', N'frtg', N'125478569', N'gggg@ggg', N'bbbbbbbbb');
INSERT into public."Bezeroa" ("Nan", "Izena", "Helbidea", "Telf", "Emaila", "NanSaltzailea") VALUES (N'222222222', N'pepito', N'hhhhh', N'123456543', N'fff@ff', N'aaaaaaaaa');
INSERT into public."Bezeroa" ("Nan", "Izena", "Helbidea", "Telf", "Emaila", "NanSaltzailea") VALUES (N'333333333', N'grillo', N'ccccc', N'323232323', N'ffff@hhhh', N'bbbbbbbbb');
INSERT into public."Bezeroa" ("Nan", "Izena", "Helbidea", "Telf", "Emaila", "NanSaltzailea") VALUES (N'444444444', N'ana', N'cccv', N'958745478', N'ggg@ggg', N'ccccccccc');
INSERT into public."Bezeroa" ("Nan", "Izena", "Helbidea", "Telf", "Emaila", "NanSaltzailea") VALUES (N'555555555', N'luis', N'vvvb', N'128541258', N'gggg@ggg', N'ddddddddd');
INSERT into public."Bezeroa" ("Nan", "Izena", "Helbidea", "Telf", "Emaila", "NanSaltzailea") VALUES (N'666666666', N'juan', N'gggg', N'412563258', N'gggg@ggg', N'eeeeeeeee');
INSERT into public."Bezeroa" ("Nan", "Izena", "Helbidea", "Telf", "Emaila", "NanSaltzailea") VALUES (N'777777777', N'tomas', N'fff', N'745845214', N'gggg@ggg', N'eeeeeeeee');
INSERT into public."Bezeroa" ("Nan", "Izena", "Helbidea", "Telf", "Emaila", "NanSaltzailea") VALUES (N'888888888', N'alberto', N'dd', N'745896325', N'gggg@ggg', N'eeeeeeeee');
INSERT into public."Bezeroa" ("Nan", "Izena", "Helbidea", "Telf", "Emaila", "NanSaltzailea") VALUES (N'999999999', N'maria', N'suuuuuu', N'478521458', N'gggg@ggg', N'bbbbbbbbb');


INSERT into public."Salmenta" ("Data", "Zenbatekoa", "NanBezeroa") VALUES (CAST(N'2021-06-20' AS Date), 4, N'111111111');;
INSERT into public."Salmenta" ("Data", "Zenbatekoa", "NanBezeroa") VALUES (CAST(N'2021-06-21' AS Date), 2, N'111111111');;
INSERT into public."Salmenta" ("Data", "Zenbatekoa", "NanBezeroa") VALUES (CAST(N'2021-06-22' AS Date), 7, N'111111111');;
INSERT into public."Salmenta" ("Data", "Zenbatekoa", "NanBezeroa") VALUES (CAST(N'2021-06-23' AS Date), 1, N'111111111');;
INSERT into public."Salmenta" ("Data", "Zenbatekoa", "NanBezeroa") VALUES (CAST(N'2021-04-23' AS Date), 3, N'222222222');;
INSERT into public."Salmenta" ("Data", "Zenbatekoa", "NanBezeroa") VALUES (CAST(N'2021-04-10' AS Date), 12, N'222222222');;
INSERT into public."Salmenta" ("Data", "Zenbatekoa", "NanBezeroa") VALUES (CAST(N'2021-04-11' AS Date), 2, N'222222222');;
INSERT into public."Salmenta" ("Data", "Zenbatekoa", "NanBezeroa") VALUES (CAST(N'2021-05-11' AS Date), 2, N'333333333');;
INSERT into public."Salmenta" ("Data", "Zenbatekoa", "NanBezeroa") VALUES (CAST(N'2021-05-17' AS Date), 8, N'333333333');;
INSERT into public."Salmenta" ("Data", "Zenbatekoa", "NanBezeroa") VALUES (CAST(N'2021-05-20' AS Date), 3, N'333333333');;
INSERT into public."Salmenta" ("Data", "Zenbatekoa", "NanBezeroa") VALUES (CAST(N'2021-05-11' AS Date), 1, N'333333333');;
INSERT into public."Salmenta" ("Data", "Zenbatekoa", "NanBezeroa") VALUES (CAST(N'2021-05-11' AS Date), 4, N'444444444');;

INSERT into public."Saltzailea" ("Nan", "Izena", "Taldea") VALUES (N'aaaaaaaaa', N'saltzaile1', N'DOP       ');
INSERT into public."Saltzailea" ("Nan", "Izena", "Taldea") VALUES (N'bbbbbbbbb', N'saltzaile2', N'FED       ');
INSERT into public."Saltzailea" ("Nan", "Izena", "Taldea") VALUES (N'ccccccccc', N'saltzaile3', N'DOP       ');
INSERT into public."Saltzailea" ("Nan", "Izena", "Taldea") VALUES (N'ddddddddd', N'saltzaile4', N'FED       ');
INSERT into public."Saltzailea" ("Nan", "Izena", "Taldea") VALUES (N'eeeeeeeee', N'saltzaile5', N'SWS       ');

