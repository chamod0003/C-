CREATE TABLE order_vehicle
(
	userid VARCHAR(100) NULL,
	vehicleid VARCHAR(100) PRIMARY KEY,
	pickup_loc VARCHAR(MAX) NOT NULL,
	destination VARCHAR(MAX) NULL,
	passenger VARCHAR(MAX) NULL,
	date_order DATE NULL,
	driver_need varchar(max) null,
	
	 
);
select * from  order_vehicle

drop table order_vehicle;