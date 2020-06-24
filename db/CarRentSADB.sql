--CREAR BASE DE DATOS
create database CarRentSA
go
use CarRentSA
go
----------///Create tables

------------------///Create car associated tables
	CREATE TABLE type_of_car --car_type
	(
		id int IDENTITY(1,1) primary key,
		description varchar(20) NOT NULL,
		status bit
	);
------------------///insert associated data to the table
	INSERT INTO type_of_car values ('Sedán',1);
	INSERT INTO type_of_car values ('Compacto',1);
	INSERT INTO type_of_car values ('Jeepeta',1);
	INSERT INTO type_of_car values ('Camioneta',1);
	INSERT INTO type_of_car values ('Coupé',1);
	INSERT INTO type_of_car values ('Sport',0);
--	INSERT INTO car_type values (1, 'Otro');

select * from type_of_car;

------------------///Create car associated tables
	CREATE TABLE car_brand
	(
		id int IDENTITY(1,1) primary key,
		description varchar(20) NOT NULL,
		status bit	
	);
------------------///insert associated data to the table
	INSERT INTO car_brand values ('Honda',1);
	INSERT INTO car_brand values ('Toyota',1);
	INSERT INTO car_brand values ('Jeep',0);
	INSERT INTO car_brand values ('Hummer',1);
	INSERT INTO car_brand values ('Cadilac',1);
	INSERT INTO car_brand values ('Mazda',1);
	INSERT INTO car_brand values ('Tesla',1);

------------------///Create car associated tables
	CREATE TABLE car_model
	(
		id int IDENTITY(1,1) primary key,
		description varchar(40) NOT NULL,
		car_brand_id int foreign key references car_brand(id),
		car_brandDes varchar(40),
		status bit
	);
------------------///insert associated data to the table
	INSERT INTO car_model values ('Model S',7,'Tesla',0);
	INSERT INTO car_model values ('Mazda 3',6,'Mazda',1);
	INSERT INTO car_model values ('Mazada 2 Demio',6,'Mazda',1);
	INSERT INTO car_model values ('Mazda 6',6,'Mazda',1);
	INSERT INTO car_model values ('Civic EXT',1,'Toyota',1);
	INSERT INTO car_model values ('Corrolla S',2,'Honda',1);

select * from car_model;
------------------///Create car associated tables
	CREATE TABLE type_of_fuel
	(
		id int IDENTITY(1,1) primary key,
		description varchar(20) NOT NULL,
		status bit
	);
------------------///insert associated data to the table
	INSERT INTO type_of_fuel values ('Gasolina',1);
	INSERT INTO type_of_fuel values ('GLP',1);
	INSERT INTO type_of_fuel values ('Gas natural',0);
	INSERT INTO type_of_fuel values ('Hibrido',0);
	INSERT INTO type_of_fuel values ('Electrico',0);

	select * from carInfo

------------------///Create car associated tables

CREATE TABLE carInfo
	(
		id int IDENTITY(1,1) primary key,
		photo_path varchar(150),
		type  varchar(50),
		brand varchar(50),
		model varchar(100),
		fabrication_year int NOT NULL,
		chassis_number varchar(100) NOT NULL,
		engine_number varchar(100) NOT NULL,
		license_plate varchar(100) NOT NULL,
		color varchar(100) NOT NULL,
		fuel_type varchar(50),
		quantity_of_fuel varchar(100) NOT NULL,
		number_of_doors int NOT NULL,
		capacity_of_passangers int NOT NULL,
		conditions varchar(100) NOT NULL,
		use_in_km int NOT NULL,
		comment varchar(200) NOT NULL,
		acquisition_date date,
		departure_date date,
		status bit
	);
-----------------///insert associated data to the table
	
------------------///Create car associated tables
	CREATE TABLE customers 
	(
		id int IDENTITY(1,1) primary key,
		name varchar(30) NOT NULL,
		lastname varchar(60) NOT NULL,
		identification_card varchar(11), --validar cedula dominicana
		type varchar(10) NOT NULL, --tipoDePersona(fisica/juridica)
		credit_card_no varchar(30),
		credit_limit int,
		status bit
	);
------------------///insert associated data to the table

select * from customers;

------------------///Create car associated tables

--Edit Proc
create proc EditEmployee 
@employeeCard varchar(20),
@workSession varchar(20),
@name varchar(30),
@lastName varchar(60),
@workPosition varchar(20),
@comission int,
@status bit, 
@id int
as
update employees set employee_card = @employeeCard, work_session = @workSession, name = @name, lastname = @lastName, work_position = @workPosition, employee_commission = @comission, status = @status 
where id = @id
go
exec EditEmployee 'TD12347', 'Diurna', 'Alejandra', 'Alvarez Lorenzo', 'Inspector', 20, 1, 1 

------------------///Create car associated tables
	CREATE TABLE employees 
	(
		id int IDENTITY(1,1) primary key,
		identification_card varchar(11),
		employee_card varchar(20),
		work_session varchar(20),
		name varchar(30) NOT NULL,
		lastname varchar(60) NOT NULL,
		contract_start_date date NOT NULL,
		work_position varchar(20) NOT NULL, --Ventas, mecanica, gerencia, promotor, inspector
		employee_commission int, -- > Comision por ventas realizadas o reparacion oportuna de carro
		status bit
	);
------------------///insert associated data to the table

select * from employees;

------------------///Create car associated tables
	CREATE TABLE rols
	(
		rol_id int IDENTITY(1,1) primary key,
		rol_key varchar(20) NOT NULL,
		rol_description varchar(30),
		rol_status bit,
	);
------------------///insert associated data to the table
	INSERT INTO rols values ('ADMI', 'Administrador del negocio', 1);
	INSERT INTO rols values ('GEST', 'Gestor de rentas', 1);
	INSERT INTO rols values ('INSP', 'Inspector de carros', 1);

select * from rols;

--drop table users;
------------------///Create car associated tables
	CREATE TABLE users 
	(
		user_id int IDENTITY(1,1) primary key,
		employee_id int,
		rol_code varchar(20),
		identification varchar(15),
		user_name varchar(20) NOT NULL,
		user_password varchar(30) NOT NULL,
		user_status bit		
	);
------------------///insert associated data to the table

select * from users;


drop table inspection

select * from inspection

------------------///Create car associated tables
	CREATE TABLE inspection 
	(
		id int IDENTITY(1,1) primary key,
		car_id int,
		car_details varchar(200),
		customer_id int,
		customer_details varchar(200),
		quantity_of_fuel varchar(200),
		has_refaction bit,
		has_scratches bit,
		has_cat bit,
		wheel_1_check bit,
		wheel_2_check bit,
		wheel_3_check bit,
		wheel_4_check bit,
		date_of_inspection varchar(200),
		inspector_id int,
		inspector varchar(200),
		comment varchar(200),
		state bit
	);

	select * from inspection

------------------///insert associated data to the table

------------------///Create car associated tables
	CREATE TABLE departure_inspection 
	(
		departure_inspection_id int IDENTITY(1,1) primary key,
		car_info_id int foreign key references car_info(car_info_id),
		inspector_id int foreign key references users(user_id),
		inspection_date date NOT NULL,
		last_inspection_date date,
		car_condition varchar(20) NOT NULL,
		tires_condition varchar(100) NOT NULL,
		has_refaction_tire bit,
		has_full_toolkit bit,
		has_scratch bit,
		needs_wash bit,
		inspection_comment varchar(200) NOT NULL,
	);
------------------///insert associated data to the table
INSERT INTO departure_inspection values (1, 1, '04-MAY-2020', null, 'Good', 'LLantas delanteras en buenas condiciones', 0, 1, 0, 1, 'Necesita revision de la llanta derecha');
INSERT INTO departure_inspection values (1, 1, '04-MAY-2020', null, 'Good', 'LLantas delanteras en buenas condiciones', 0, 1, 0, 1, 'Necesita revision de la llanta derecha');

select * from departure_inspection;

select * from rents
select * from inspection


create table rents(
	id int IDENTITY(1,1) primary key,
	inspectionId int,
	employeeInfo varchar(100),
	carId int,
	carInfo varchar(200),
	customerInfo varchar(200),
	rent_date varchar(50),
	devolution_date varchar(50),
	mont_x_day int,
	quantity_of_days int,
	comment varchar(200),
	state bit
);
select * from carInfo
  select * from carInfo where status = 1  
	select * from rents

	  delete from rents
	  select * from inspection

------------------///Create car associated tables
	CREATE TABLE rent_history 
	(
		rent_history_id int IDENTITY(1,1) primary key,
		car_id int foreign key references car_info(car_info_id),
		rented_by int foreign key references users(user_id),
		rented_to int foreign key references customers(customer_id),
		inspection_after_rent int foreign key references entry_inspection(entry_inspection_id),
		inspection_before_rent int foreign key references departure_inspection(departure_inspection_id),
		rent_date date NOT NULL,
		rent_due_date date NOT NULL,
		rent_return_date date,
		rent_fee_per_day varchar(100) NOT NULL,
		penality_applied bit,
		rent_status bit
	);

------------------///insert associated data to the table
INSERT INTO rent_history values (1, 1, 1, 2, null, '25-MAY-2020', '30-JUN-2020', null, 2000, null, 'En renta');

select * from rent_history;		
--Procedures
--Calcular cantidad de carros en inventario por marca, modelo, tipo de carro, combustible etc
Procesos
	Inspecion del vehiculo
	Renta y Devolucion
	{noRenta, rentadoPor, CarInv, Client, fechaRenta, FechaDevolucion, 	MontxDia, cantidadEnDias, Commentario, estado}

Consultas
	Search for 
		Rents by clients, date, car etc.
Reportes
	Rent repo (by date, type of car etc.)

Extras : Generacion de factura a correo.
