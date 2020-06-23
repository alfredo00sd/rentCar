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

select * from type_of_car;
select * from car_brand;
select * from type_of_fuel;

select e.employee_card as userCard, u.user_password as userPass, r.rol_key as rol from employees e, users u, roles r where e.employee_card = @userCard and u.user_password = @userClave and u.user_status = 1 and r.rol_id = u.rol_id

select * from users
select * from employees
select user_name, user_password, employee_id, user_status from users where user_name like 't%'

select id, description as modelo from car_model where car_brand_id = 6
select m.id, m.description as modelo, b.id as marcaId, b.description as marca,  m.status from car_model m, car_brand b where b.id = m.car_brand_id

--(@Base64Photo, @CarType, @CarBrand, @CarModel, @CarFabYear, @CarChasisNum, @CarEngineNum, @CarLicensePlate, @CarColor, @FuelType, @QuantityOfFuel, @CarNumberOfDoors, @CarCapacityOfPassangers,  @CarConditions, @CarUseInKM, @CarInvComment, GETDATE(), null, @CarStatus)";

update carInfo set photo_path = @Base64Photo, type = @CarType, brand = @CarBrand, model = @CarModel, car_fabrication_year = @CarFabYear, car_chassis_number = @CarChasisNum, car_engine_number = @CarEngineNum, car_license_plate = @CarLicensePlate, car_color = @CarColor, fuel_type = @FuelType, car_number_of_doors = @CarNumberOfDoors, car_capacity_of_passangers = @CarCapacityOfPassangers, car_conditions = @CarConditions, use_in_km = @CarUseInKM, car_status = @CarStatus, car_inv_commentary = @CarInvComment where id = @CarId

select * from carInfo
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

select * from type_of_fuel;

select * from car_model

select * from type_of_car

select description from type_of_car where description = 'Compacto' 
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
	
	select * from users

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

select * from car_model

select m.id, m.description as modelo, b.id as marcaId, b.description as marca,  m.status from car_model m, car_brand b where b.id = m.car_brand_id;

delete from employees where id = 3

select car_model_id as id, car_model_description as modelo from car_model where car_brand_id = @carBrandId and car_model_status = 14


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
