create database musical_instruments;

USE musical_instruments;

CREATE TABLE `discount_cards` (
	id INT NOT NULL AUTO_INCREMENT,
    `discount` INT NOT NULL,
    `Additional privelege` VARCHAR(200) NOT NULL,
    PRIMARY KEY(id)
);

CREATE table `Accessories` (
	id INT NOT NULL AUTO_INCREMENT,
    `Accessorie type`  VARCHAR(200) NOT NULL,
    PRIMARY KEY(id)
);


create table `consultants` (
	id INT NOT NULL AUTO_INCREMENT,
    PRIMARY KEY(id)
);

create table `instruments` (
	id INT NOT NULL AUTO_INCREMENT,
    `instrument type` VARCHAR(200) NOT NULL,
    PRIMARY KEY(id)
);

create table `employees` (
	id INT NOT NULL AUTO_INCREMENT,
    `FullName` VARCHAR(80) NOT NULL,
    `Position` VARCHAR(100) NOT NULL,
    PRIMARY KEY(id)
);

create table `Warehouse emploers` (
	id INT NOT NULL AUTO_INCREMENT,
    PRIMARY KEY(id)
);

create table `customers` (
	id INT NOT NULL AUTO_INCREMENT,
    `FullName` VARCHAR(80) NOT NULL,
    PRIMARY KEY(id),
    `id_discount_cards` INT,
     KEY `fk_customers_discount_cards_idx` (`id_discount_cards`),
    CONSTRAINT `fk_customers_discount_cards` FOREIGN KEY (`id_discount_cards`) REFERENCES `discount_cards` (`id`)
);
-- добавить `capcity` INT NOT NULL,
create table `warehouse` (
	id INT NOT NULL AUTO_INCREMENT,
    PRIMARY KEY(id),
	`id_warehouse_emploers` INT NOT NULL,
    KEY `fk_warehouse_warehouse_emploers_idx` (`id_warehouse_emploers`),
	CONSTRAINT `fk_warehouse_warehouse_emploers` FOREIGN KEY (`id_warehouse_emploers`) REFERENCES `Warehouse emploers` (`id`)
    
);
-- add size INT NOT NULL
create table `products` (
	id INT NOT NULL AUTO_INCREMENT,
    `Price` INT NOT NULL,
    PRIMARY KEY(id),
    `id_consultants` INT NOT NULL,
    KEY `fk_products_consultants_idx` (`id_consultants`),
	CONSTRAINT `fk_products_consultants` FOREIGN KEY (`id_consultants`) REFERENCES `consultants` (`id`)
);
-- add size INT NOT NULL
create table `units` (
	id INT NOT NULL AUTO_INCREMENT,
    `specification`  VARCHAR(80) NOT NULL,
    `studio availobility` VARCHAR(30) NOT NULL,
    PRIMARY KEY(id),
    `id_consultants` INT NOT NULL,
    KEY `fk_units_consultants_idx` (`id_consultants`),
	CONSTRAINT `fk_units_consultants` FOREIGN KEY (`id_consultants`) REFERENCES `consultants` (`id`),
	`id_products` INT NOT NULL,
    KEY `fk_units_products_idx` (`id_products`),
	CONSTRAINT `fk_units_products` FOREIGN KEY (`id_products`) REFERENCES `products` (`id`)
);
-- добавить NOT NULL
create table `products_to_warehouse` (
	`id_warehouse` INT,
    `id_products` INT,
	PRIMARY KEY(`id_warehouse`, `id_products`),
	KEY `fk_products_to_warehouse_warehouse_idx` (`id_warehouse`),
	CONSTRAINT `fk_products_to_warehouse_warehouse` FOREIGN KEY (`id_warehouse`) REFERENCES `warehouse` (`id`),
    KEY `fk_products_to_warehouse_products_idx` (`id_products`),
	CONSTRAINT `fk_products_to_warehouse_products` FOREIGN KEY (`id_products`) REFERENCES `products` (`id`)
);
-- add  `Delivery type` VARCHAR(100) NOT NULL,
 --   `Order type` VARCHAR(100) NOT NULL,
create table `orders` (
	id INT NOT NULL AUTO_INCREMENT,
   `Order date` VARCHAR(100) NOT NULL,
   `Using of discount card` BOOL NOT NULL,
    PRIMARY KEY(id),
    `id_customers` INT,
    `id_consultants` INT,
    KEY `fk_orders_customers_idx` (`id_customers`),
	CONSTRAINT `fk_orders_customers` FOREIGN KEY (`id_customers`) REFERENCES `customers` (`id`),
    KEY `fk_orders_consultants_idx` (`id_consultants`),
	CONSTRAINT `fk_orders_consultants` FOREIGN KEY (`id_consultants`) REFERENCES `consultants` (`id`)
);

-- add NOT NULL
create table `products_to_orders` (
	`id_orders` INT,
    `id_products` INT,
    PRIMARY KEY(`id_orders`, `id_products`),
	KEY `fk_products_to_orders_oreders_idx` (`id_orders`),
	CONSTRAINT `fk_products_to_orders_oreders` FOREIGN KEY (`id_orders`) REFERENCES `orders` (`id`),
    KEY `fk_products_to_orders_products_idx` (`id_products`),
	CONSTRAINT `fk_products_to_orders_products` FOREIGN KEY (`id_products`) REFERENCES `products` (`id`)
);


---------------------------------------------------------------------------------------------------------------------------------

ALTER TABLE `warehouse` 
	ADD `capcity` INT NOT NULL;
    
ALTER TABLE `warehouse` 
	MODIFY `capcity` INT NOT NULL
		AFTER `id`;
        
ALTER TABLE `products`
	ADD `size` INT NOT NULL
		AFTER `price`;
        
ALTER TABLE `units`
	ADD `size` INT NOT NULL
		AFTER `studio availobility`;

ALTER TABLE `products_to_warehouse`
	MODIFY `id_warehouse` INT NOT NULL;

ALTER TABLE `orders`
	ADD `Delivery type` VARCHAR(100) NOT NULL
		AFTER `Order date`;

ALTER TABLE `orders` 
	MODIFY `delivery type` VARCHAR(100) NOT NULL
		AFTER `id`;
        
ALTER TABLE `orders`
	ADD `order type` VARCHAR(100) NOT NULL
		AFTER `delivery type`;

ALTER TABLE `orders` 
	ADD `payment type` VARCHAR(100) NOT NULL
		AFTER `id`;
        
ALTER TABLE `employees`
	MODIFY `fullName` VARCHAR(100) NOT NULL;
    
---------------------------------------------------------------------------------------------------------------------------------

-- 