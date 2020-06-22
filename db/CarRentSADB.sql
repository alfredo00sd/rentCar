--CREAR BASE DE DATOS
create database CarRentSA
go
use CarRentSA
go
----------///Create tables

--------------///Create management associated tables

	INSERT INTO general_status values ('Disponible');
	INSERT INTO general_status values ('Mantenimiento');
	INSERT INTO general_status values ('Nuevo');
	INSERT INTO general_status values ('fin de renta');
	INSERT INTO general_status values ('rentado');
	INSERT INTO general_status values ('No disponible');
	INSERT INTO general_status values ('Lavanderia');
	INSERT INTO general_status values ('Vendido');
	INSERT INTO general_status values ('Activa');
	INSERT INTO general_status values ('Descartado');

	select * from general_status;
------------------///Create car associated tables
	CREATE TABLE type_of_car --car_type
	(
		id int IDENTITY(1,1) primary key,
		status bit,
		description varchar(20) NOT NULL,
	);
------------------///insert associated data to the table
	INSERT INTO type_of_car values (1, 'Sedán');
	INSERT INTO type_of_car values (1, 'Compacto');
	INSERT INTO type_of_car values (1, 'Jeepeta');
	INSERT INTO type_of_car values (0, 'Camioneta');
	INSERT INTO type_of_car values (1, 'Coupé');
	INSERT INTO type_of_car values (0, 'Sport');
--	INSERT INTO car_type values (1, 'Otro');

select * from type_of_car;

------------------///Create car associated tables
	CREATE TABLE car_brand
	(
		id int IDENTITY(1,1) primary key,
		status bit,
		description varchar(20) NOT NULL
	);
------------------///insert associated data to the table
	INSERT INTO car_brand values (1, 'Honda');
	INSERT INTO car_brand values (1, 'Toyota');
	INSERT INTO car_brand values (1, 'Jeep');
	INSERT INTO car_brand values (0, 'Hummer');
	INSERT INTO car_brand values (1, 'Cadilac');
	INSERT INTO car_brand values (1, 'Mazda');
	INSERT INTO car_brand values (0, 'Tesla');

select * from car_brand;

------------------///Create car associated tables
	CREATE TABLE car_model
	(
		id int IDENTITY(1,1) primary key,
		status bit,
		car_brand_id int foreign key references car_brand(id),
		description varchar(40) NOT NULL
	);
------------------///insert associated data to the table
	INSERT INTO car_model values (0, 7, 'Model S');
	INSERT INTO car_model values (1, 6, 'Mazda 3');
	INSERT INTO car_model values (1, 6, 'Mazada 2 Demio');
	INSERT INTO car_model values (1, 6, 'Mazda 6');
	INSERT INTO car_model values (1, 1, 'Civic EXT');
	INSERT INTO car_model values (1, 2, 'Corrolla S');

select * from car_model;

------------------///Create car associated tables
	CREATE TABLE type_of_fuel
	(
		fuel_type_id int IDENTITY(1,1) primary key,
		status bit,
		fuel_type varchar(20) NOT NULL
	);
------------------///insert associated data to the table
	INSERT INTO type_of_fuel values (1,'Gasolina');
	INSERT INTO type_of_fuel values (1,'GLP');
	INSERT INTO type_of_fuel values (0,'Gas natural');
	INSERT INTO type_of_fuel values (0,'Hibrido');
	INSERT INTO type_of_fuel values (0,'Electrico');

select * from type_of_fuel;

------------------///Create car associated tables
CREATE TABLE carInfo
	(
		id int IDENTITY(1,1) primary key,
		type  varchar(100),
		brand varchar(100),
		model varchar(100),
		photo_path varchar(300),
		fuel_type varchar(100),
		car_status varchar(100),
		quantity_of_fuel varchar(100) NOT NULL,
		car_fabrication_year int NOT NULL,
		car_chassis_number varchar(100) NOT NULL,
		car_engine_number varchar(100) NOT NULL,
		car_license_plate varchar(100) NOT NULL,
		car_color varchar(100) NOT NULL,
		car_number_of_doors int NOT NULL,
		car_acquisition_date date,
		car_capacity_of_passangers int NOT NULL,
		car_conditions varchar(100) NOT NULL,
		use_in_km varchar(100) NOT NULL,
		departure_date date,
		car_inv_commentary varchar(200) NOT NULL
	);
------------------///insert associated data to the table
	
	select * from carInfo;	
	
	select GETDATE();

------------------///insert associated data to the table {disponible, en uso, en mantenimiento} {compra, fin de renta, renta, mantenimiento, venta}

------------------///Create car associated tables
	CREATE TABLE rental_fee 
	(
		rental_fee_id int IDENTITY(1,1) primary key,
		car_info_id int foreign key references car_info(car_info_id),
		rent_per_day numeric(10,2) NOT NULL,
		rental_fee_comment varchar(100)
	);
------------------///insert associated data to the table
	INSERT INTO rental_fee values (1, 2500.10, 'Costo sin impuestos');
	INSERT INTO rental_fee values (1, 2900.10, 'Costo con impuestos');

select * from rental_fee;

------------------///Create car associated tables
	CREATE TABLE penalities	 
	(
		penality_id int IDENTITY(1,1) primary key,
		penality_decription varchar(120), --entrega tarde, tanque vacio, ralladuras, etc
		penality_level varchar(20), -- del 1 al 10
		penality_cost numeric(10,2), --nivel por tiempo
		penality_status int foreign key references general_status(general_status_id)
	);
------------------///insert associated data to the table
	INSERT INTO penalities values ('entrega tarde', 5, 2000, 14);
	INSERT INTO penalities values ('tanque vacio', 2, 0, 14);
	INSERT INTO penalities values ('ralladuras', 7, 3000, 14);
	INSERT INTO penalities values ('falta pieza o accesorio', 9, 10000, 14);

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

insert into customers values ('Juan','Carlos', '402123133', 'Fisica', 'XXXXXXXXXXXXXXXXX', 2000, 1, null);
insert into customers values ('Juan','Carlos', null, 'Fisica', 'XXXXXXXXXXXXXXXXX', 2000, 1, 'ACE123452');

update customers set name = 'Manuel', lastname = 'Canario', identification_card = '402123133', type = 'Fisica', credit_card_no = 'XXX-XXXXXXXXX-X', credit_limit = 0, status = 1, RNC = 'N/A'
where id = 3

select * from rols

alter table customers add RNC varchar(30)  

------------------///Create car associated tables

insert into employees values ('11111111111', 'TD00123', 'Noche', 'Manuel', 'Alvarez Yankee', getDate(), 'ADMI', 2000, 1)
insert into employees values ('11111111111', 'TD00124', 'Noche', 'Pepe', 'Alvarez Yankee', getDate(), 'ADMI', 2000, 1)

select * from employees

delete from employees where id = 3

update employees set employee_card = 'TD12347', work_session = 'Diurna', name = 'Alejandra', lastname = 'Alvarez Lorenzo', work_position = 'Inspector', employee_commission = 20, status = 1 where id = 3 and identification_card = '00114121080'
update employees set employee_card = 'TD12345', work_session = 'Diurna', name = 'Alfredo', lastname = 'Acosta Pena', work_position = 'ADMI', employee_commission = 20, status = 1 where id = 1 and identification_card = '40214810653'
update employees set employee_card = @employeeCard, work_session = @workSession, name = @name, lastname = @lastName, work_position = @workPosition, employee_commission = @comission, status = @status where id = @id and identification_card = ;

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


select * from employees


select * from employees


update employees set employee_card = @EmpCard, work_session = @Session, name = @Name, lastname = @LastName, work_position = @Position, employee_commission = @Comission, status = @Statuts where id = @Id and identification_card = @Cedula

select * from users

select user_name, user_password from users where identification = '11111111111' and employee_id = 1004 


drop table users

drop table employees 

alter table users add column rol_code
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

------------------///Create car associated tables
	CREATE TABLE entry_inspection 
	(
		entry_inspection_id int IDENTITY(1,1) primary key,
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
INSERT INTO entry_inspection values (1, 1, '04-MAY-2020', null, 'Good', 'LLantas delanteras en buenas condiciones', 0, 1, 0, 1, 'Necesita revision de la llanta derecha')

select * from entry_inspection;

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

------------------///Create car associated tables
	CREATE TABLE rent_history 
	(
		rent_history_id int IDENTITY(1,1) primary key,
		car_info_id int foreign key references car_info(car_info_id),
		rented_by int foreign key references users(user_id),
		rented_to int foreign key references customers(customer_id),
		inspection_after_rent int foreign key references entry_inspection(entry_inspection_id),
		inspection_before_rent int foreign key references departure_inspection(departure_inspection_id),
		rent_date date NOT NULL,
		rent_due_date date NOT NULL,
		rented_return_date date,
		rent_fee_per_day varchar(100) NOT NULL,
		penality_applied int,
		rent_status varchar(20) NOT NULL
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
