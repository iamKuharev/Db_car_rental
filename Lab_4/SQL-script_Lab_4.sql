USE car_rental;

SELECT * FROM car_rental.booking;

SET SQL_SAFE_UPDATES = 0;

DELETE FROM `cars` WHERE `mileage` > 400000;  

DELETE FROM `staff` WHERE `date_of_dismissal` > "2022-01-01";

DELETE FROM `clients` WHERE `date_of_birth` > NOW();

DELETE FROM `lease_agreement` WHERE `date_of_signing` > "2022-01-01";

DELETE FROM `booking` WHERE `payment_method` != "Банковская карта" AND `payment_method` != "Наличными";

------------------------------------------------------------------------------------------------------------------------
UPDATE `clients`
	SET `phone_number` = "+7 917 384 85 97" 
		WHERE `full_name` = "Языкова Оксана Яковна" AND `date_of_birth` = "1982-04-30" AND `passport` = "4818 592645";  

UPDATE `cars`
	SET `registration_number` = "А652АВ 134" 
		WHERE `brand` = "Hyundai" AND `model` = "Solaris" AND `VIN` = "WMWRC31060TB95535" AND `year_of_release` = "2017";  
        
UPDATE `additional_services`
	SET `description` = "Аренда автомобиля с водителем ( на 8 часов )."
		WHERE `title` = "Аренда с водителем";
        
UPDATE `options`
	SET `description` = "Система, в которую входят мини-компьютер, датчики, радары и другие детали, которые 
	автоматически управляют выставленной скоростью движения машины без нажатия на педаль газа."
		WHERE `title` =  "Круиз-контроль";
UPDATE `positions`
	SET `wages` = 25500
		WHERE `title` = "Менеджер по уборке помещений";

------------------------------------------------------------------------------------------------------------------------
/* 11) Вывод записей таблицы `lease_agreement` с столбцами contract_number, id_staff_extradition и id_staff_reception. 
 Новое имя таблицы staff_extradition_and_reception. Новое имя столбца contract_number - "Номер контракта"*/
SELECT staff_extradition_and_reception.contract_number AS "Номер контракта", 
		staff_extradition_and_reception.id_staff_extradition, staff_extradition_and_reception.id_staff_reception
	FROM `lease_agreement` AS `staff_extradition_and_reception`;
    
/* 12) Вывод записей таблицы `lease_agreement` со столбцами contract_number, date_of_signing и rental_duration. 
 Новое имя таблицы rental_period. Новое имя столбца contract_number - "Номер контракта". 
 Новое имя столбца date_of_signing - "Дата подписания".Новое имя столбца rental_duration - "Cрок аренды (дней)".*/
SELECT rental_period.contract_number AS "Номер контракта", rental_period.date_of_signing AS "Дата подписания", rental_period.rental_duration AS "Cрок аренды (дней)"
	FROM `lease_agreement` AS `rental_period`;

/* 13) Вывод неповторяющихся записей таблицы `cars` со столбцами brand, year_of_release. 
 Новое имя столбца brand - "Марка". 
 Новое имя столбца year_of_release - "Год выпуска".*/
SELECT DISTINCT `brand` AS "Марка", `year_of_release` AS "Год выпуска"
	FROM `cars`;

/* 14) Вывод автомобилей маркок Lada и Renault.*/
SELECT * 
	FROM `cars`
		WHERE `brand` = "Lada" OR `brand` = "Renault";

/* 15) Вывод записей таблицы `booking` со столбцами payment_method, pledge и id_cars. При условии, что залог не меньше 10 000*/
SELECT `payment_method` AS "Способ оплаты", `pledge` AS "Залог",  `id_cars`
	FROM `booking`
		WHERE NOT `pledge` <= 10000;
        
/* 16)  Вывод неповторяющихся записей таблицы `lease_agreement` со столбцами rental_duration, pledge и price.
 Условия выбора записей: залог больше 10 000 и цена не меньше 4 000. 
 Новое имя столбца rental_duration - "Длительность аренды (в днях)". 
 Новое имя столбца pledge - "Залог". 
 Новое имя столбца price - "Цена".*/
SELECT DISTINCT `rental_duration` AS "Длительность аренды (в днях)", `pledge` AS "Залог",  `price` AS "Цена"
	FROM `lease_agreement`
		WHERE `pledge` > 10000 AND (NOT `price`< 4000);

/* 17) Вывод записей таблицы `lease_agreement` со столбцами date_of_signing, rental_duration и id_cars.
 Условие выбора записей: дата подписания 24.06.2021 и 26.06.2021 */
SELECT `date_of_signing`, `rental_duration`, `id_cars`
	FROM `lease_agreement`
		WHERE `date_of_signing` IN ("2021-06-24", "2021-06-26");
        
/* 18) Вывод записей таблицы `cars` со столбцами Марка, модель, регистрационный номер и год выпуска.
 Условие выбора записей: года выпуска все кроме 2020 и 2019 годов. */
SELECT `brand` AS "Марка", `model` AS "Модель", `registration_number` AS "Регистрационный номер", `year_of_release` AS "Год выпуска"
	FROM `cars`
		WHERE `year_of_release` NOT IN(2020, 2019);
        
/* 19) Вывод записей таблицы `positions`.
 Условие выбора записей: зарплата от 40 000 до 100 000.*/
SELECT *
	FROM `positions`
		WHERE `wages` BETWEEN 40000 AND 100000;

/* 20) Вывод записей таблицы `positions`.
Условие выбора записей: мощность автомобиля от 100 до 150.*/
SELECT *
	FROM `numerical_value_of_the_characteristic`
		WHERE (`meaning` BETWEEN 100 AND 150) AND (`id_technical_specifications` = 1);
        
/* 21)  Вывод записей таблицы `staff` со столбацми имя, фамилия, отчество и дата увольнения.
Условие выбора записей: уволеные сотрудники (столбец дата уволнения не нулевой)*/
SELECT `name` AS "Имя", `surname` AS "Фамилия", `patronymic` AS "Отчество", `date_of_dismissal` AS "Дата увольнения"
	FROM `staff`
		WHERE `date_of_dismissal` IS NOT NULL;

/* 22) Вывод записей таблицы `staff` со столбацми имя, фамилия, отчество и дата найма.
 Условие выбора записей: сотрудники был наняты в 2010 и 2011 годах.
Функция EXTRACT извлекает из столбца дата найма год */
SELECT `name` AS "Имя", `surname` AS "Фамилия", `patronymic` AS "Отчество", `date_of_employment` AS "Дата найма"
	FROM `staff`
		WHERE EXTRACT(YEAR from `date_of_employment`) IN(2010, 2011);
        
/* 23) Вывод записей таблицы `lease_agreement`.
 Условие выбора записей: дата подписание котракта с 1 по 20 число .
Функция EXTRACT извлекает из столбца "date_of_signing" дни. */
SELECT *
	FROM `lease_agreement`
		WHERE EXTRACT(DAY from `date_of_signing`) BETWEEN 1 AND 20;
	
/* 24) Вывод записей таблицы `staff` с дополнительным столбцом "deadline_for_delivery", который заполняется
 значениями из "duration_to". К каждому значенею было добавлено 2 часа. */
SELECT *, DATE_ADD(`duration_to`, INTERVAL 2 HOUR) AS "deadline_for_delivery"
	FROM `booking` ;
		
 /* 25) Вывод записей таблицы `clients` с дополнительным столбцом "age", в котором указывается полный возраст человека. */       
SELECT *, TIMESTAMPDIFF(YEAR, `date_of_birth`, NOW()) AS "age"
	FROM `clients`;

/* 26) Использование SELECT без FROM. Деление 236/10 результат: 23,6. Целочисленое деление 
236 DIV 10 результат: 23. Нахождение остатка от целочисленного деления 236 % 10 результат: 6.
SYSDATE - Получение системной даты.*/
SELECT 
    236/10,
    236 DIV 10,
    236 % 10,
    SYSDATE();
    
/* 27) Функция EXTRACT извлекает из столбца "date_of_signing" дни. Функции CAST и CONVERT преобразовывают тип данных в float.*/
SELECT 
	EXTRACT(DAY from `date_of_birth`),
    CAST(EXTRACT(DAY from `date_of_birth`) AS float)/100,
    CONVERT(EXTRACT(DAY from `date_of_birth`), float)/100
		FROM `clients`;

/* 28) Преобразование типа данных VARCHAR в double. Так как в столбце driver's_icense числа записаны через пробел, преобразуется только первое число.*/
SELECT
	`driver's_icense`,
	CONVERT(`driver's_icense`, double)
		FROM `clients`;

/* 29) Функция EXTRACT извлекает из столбца "date_of_signing" дни. Функции CAST преобразовывают тип данных в float. 
Делим это число на 1000 и округляем до 2 знаков после запятой.*/
SELECT 
	EXTRACT(DAY from `date_of_birth`),
    ROUND(CAST(EXTRACT(DAY from `date_of_birth`) AS float)/1000, 2)
		FROM `clients`;

/* 30)  Вывод записей таблицы `numerical_value_of_the_characteristic` с дополнительным столбцом "rounded_value", который заполняется 
округленными значениями из "meaning". Условие выбора записей: Техническая характеристика время разгона 0-100 км/ч. */
SELECT * ,
	ROUND(`meaning`, 0) AS "rounded_value"
		FROM `numerical_value_of_the_characteristic`
			WHERE `id_technical_specifications` = 4;
   ------------------------------------------------------------------------------------------------------------------------         
/* 31) Вывод записей таблицы `defects`. Условие выбора записей: название дефекта начинается с "Неисправность".*/ 
SELECT * 
	FROM `defects`
		WHERE `title` LIKE 'Неисправность%';
        
/* 32) Вывод записей таблицы `defects`. Условие выбора записей: название дефекта содержит слово "бампер". */
SELECT * 
	FROM `defects`
		WHERE `title` LIKE '%бампер%';
        
/* 33)  Вывод записей таблицы `defects`. Условие выбора записей: название дефекта содержит буквы  от "э" до "я". */
SELECT * 
	FROM `defects`
		WHERE `title` RLIKE '[э-я]';

/* 34) Вывод записей таблицы `options`. Условие выбора записей: название опции содержит цифры.*/
SELECT * 
	FROM `options`
		WHERE `title` RLIKE '[0-9]';
        
/* 35) Вывод записей таблицы `cars`. Условие выбора записей: регистрационный номер имеет в начале один символ и
цифру "4" и заканчивается на "134". */
SELECT * 
	FROM `cars`
		WHERE `registration_number` LIKE '_4%134';

/* 36) Вывод записей таблицы `clients`. Условие выбора записей: фамилия "Петров". */
SELECT *
	FROM `clients`	
		WHERE UPPER(`full_name`) LIKE UPPER(N'Петров%');
        
------------------------------------------------------------------------------------------------------------------------
/* 37) Создание копии таблицы technical_specifications. */
CREATE TABLE `technical_specifications_copy` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(45) NOT NULL,
  `description` mediumtext,
  PRIMARY KEY (`id`)
);

INSERT INTO `technical_specifications_copy`
	SELECT *
		FROM `technical_specifications`;

/* 38) Копируем данные уволенных сотрудников в новую таблицу `dismissed_employees`. */
CREATE TABLE `dismissed_employees` (
	`name` varchar(45) NOT NULL,
	`surname` varchar(45) NOT NULL,
	`patronymic` varchar(45) NOT NULL,
	`date_of_birth` date NOT NULL,
	`passport` varchar(12) NOT NULL,
    `date_of_dismissal` varchar(45) DEFAULT NULL
);

INSERT INTO `dismissed_employees` 
	SELECT `name`, `surname`, `patronymic`, `date_of_birth`, `passport`, `date_of_dismissal`
		FROM `staff`
			WHERE `date_of_dismissal` IS NOT NULL;

------------------------------------------------------------------------------------------------------------------------
/* 39) Соединение таблиц booking и cars. Возращаются все общие записи.*/
SELECT *
	FROM `booking` 
		JOIN `cars`
			ON booking.id_cars = cars.id;

/* 40) Возращаются все записи правой таблицы (cars). К каждой записи подбирается запись из левой таблицы (booking).*/
SELECT *
	FROM `booking` 
		RIGHT JOIN `cars`
			ON booking.id_cars = cars.id;
            
/* 41) Возращаются все записи правой таблицы (cars), для которых нет связанных записей из левой таблицы (booking).*/
SELECT *
	FROM `booking` 
		RIGHT JOIN `cars`
			ON booking.id_cars = cars.id
				WHERE booking.id_cars IS NULL;

/* 42) Возращаются все записи левой таблицы (technical_maintenance). К каждой записи подбирается запись из правой таблицы (cars).*/
SELECT  technical_maintenance.id, `service name`, `list_of_works`, `service date`, `the_mileage_on_which_it_was_served`, `id_cars`, 
`brand`, `model`, `registration_number`, `mileage`
	FROM `technical_maintenance` 
		LEFT JOIN `cars`
			ON technical_maintenance.id_cars = cars.id;

/* 43) Возращаются все записи из обеих таблиц. Реализация FULL JOIN. */
SELECT technical_maintenance.id, `service name`, `list_of_works`, `service date`, `the_mileage_on_which_it_was_served`, `id_cars`, 
`brand`, `model`, `registration_number`, `mileage`
	FROM `technical_maintenance` 
		LEFT JOIN `cars`
			ON technical_maintenance.id_cars = cars.id
            
UNION
  
SELECT technical_maintenance.id, `service name`, `list_of_works`, `service date`, `the_mileage_on_which_it_was_served`, `id_cars`, 
`brand`, `model`, `registration_number`, `mileage`
	FROM `technical_maintenance` 
		RIGHT JOIN `cars`
			ON technical_maintenance.id_cars = cars.id;

/* 44) Возращается объединение каждой строки левой таблицы со всеми строками правой таблицы. */
SELECT staff.id, `name`, `surname`, `patronymic`, `id_positions`, `title`, `wages`
	FROM `staff` 
		CROSS JOIN `positions`;
			
/* 45) Возращаются все записи левой таблицы (lease_agreement). К каждой записи подбирается запись из правой таблицы (booking).*/
SELECT * 
	FROM `lease_agreement` 
		LEFT JOIN `booking`
			ON lease_agreement.date_of_signing = DATE_FORMAT(booking.duration_from, '%Y-%m-%d') ;
            
/* 46) Соединение таблиц cars, cars_to_parking и parking. Возращаются все общие записи.*/
SELECT *
	FROM `cars`
		JOIN `cars_to_parking` p
			ON cars.id = p.id_cars
		JOIN `parking`
			ON p.id_parking = parking.id;
            
/* 47) Возращаются все записи таблицы cars. К каждой записи подбирается запись из таблицы defects.*/
SELECT *
	FROM `cars`
		LEFT JOIN `cars_to_defects` d
			ON cars.id = d.id_cars
		LEFT JOIN `defects`
			ON d.id_defects = defects.id;

/* 48) Возращаются все записи таблицы cars. К каждой записи таблицы options подбирается запись из таблицы cars.*/
SELECT *
	FROM `cars`
		JOIN `options_to_cars` o
			ON cars.id = o.id_cars
		RIGHT JOIN `options`
			ON o.id_options = options.id;
            
/* 49) Соединение таблиц lease_agreement, staff, cars, clients и staff. Возращаются все общие записи.*/
SELECT `contract_number`, `date_of_signing`, id_staff_extradition, s_e.name, s_e.surname, s_e.patronymic, cars.brand, cars.model, 
cars.registration_number, id_staff_reception, cl.full_name, s_r.name, s_r.surname, s_r.patronymic
	FROM `lease_agreement`
		JOIN `staff` s_e
			ON lease_agreement.id_staff_extradition = s_e.id
		JOIN `cars` cars
			ON lease_agreement.id_cars = cars.id
		JOIN `clients` cl
			ON lease_agreement.id_clients = cl.id
		JOIN `staff` s_r
			ON lease_agreement.id_staff_reception = s_r.id;
            
/* 50) Соединение таблиц booking, booking_to_additional_services и additional_services. К каждой записи таблицы booking
 подбирается запись из таблицы additional_services.*/
SELECT *
	FROM `booking`
		LEFT JOIN `booking_to_additional_services` b_a
			ON booking.id = b_a.id_booking
		LEFT JOIN `additional_services`
			ON b_a.id_additional_services = additional_services.id;
            
/* 51) Соединение таблиц lease_agreement, lease_agreement_to_additional_services и additional_services. К каждой записи таблицы additional_services
 подбирается запись из таблицы lease_agreement.*/
SELECT *
	FROM `lease_agreement`
		RIGHT JOIN `lease_agreement_to_additional_services` l_a
			ON lease_agreement.id = l_a.id_lease_agreement
		RIGHT JOIN `additional_services`
			ON l_a.id_additional_services = additional_services.id;

/* 52) Соединение таблиц cars, options_to_cars и options. К каждой записи таблицы cars подбирается запись из таблицы options.*/
SELECT `brand`,`model`,`title`
	FROM `cars`
		LEFT JOIN `options_to_cars` o
			ON cars.id = o.id_cars
		LEFT JOIN `options`
			ON o.id_options = options.id;
            
/* 53) Соединение таблиц staff, positions. Возращаются все общие записи.*/
SELECT *
	FROM `staff`
		JOIN `positions` 
			ON staff.id_positions = positions.id;

/* 54) Соединение таблиц technical_maintenance, cars, cars_to_defects, defects. Возращаются все общие записи.*/
SELECT *
	FROM `technical_maintenance`
		JOIN `cars`
			ON technical_maintenance.id_cars = cars.id
		JOIN `cars_to_defects` d
			ON cars.id = d.id_cars
		JOIN `defects`
			ON d.id_defects = defects.id;
            
/* 55) Соединение таблиц technical_maintenance, cars, cars_to_defects, defects. К каждой записи таблицы cars подбирается запись
 из таблицы technical_maintenance и из таблицы defects.*/
SELECT *
	FROM `technical_maintenance`
		RIGHT JOIN `cars`
			ON technical_maintenance.id_cars = cars.id
		JOIN `cars_to_defects` d
			ON cars.id = d.id_cars
		JOIN `defects`
			ON d.id_defects = defects.id;

/* 56) Соединение таблиц technical_maintenance, cars, cars_to_defects, defects. К каждой записи таблицы defects подбирается запись
 из таблицы technical_maintenance и из таблицы cars.*/
SELECT `service name`, `list_of_works`, `service date`,`brand`,`model`,`title` 
	FROM `technical_maintenance`
		JOIN `cars`
			ON technical_maintenance.id_cars = cars.id
		JOIN `cars_to_defects` d
			ON cars.id = d.id_cars
		RIGHT JOIN `defects`
			ON d.id_defects = defects.id;
            
/* 57) Соединение таблиц lease_agreement, cars, lease_agreement_to_additional_services, additional_services. Возращаются все общие записи.*/       
SELECT `contract_number`, `date_of_signing`, `brand`,`model`,`title`
	FROM `lease_agreement`
		JOIN `cars` cars
			ON lease_agreement.id_cars = cars.id
		JOIN `lease_agreement_to_additional_services` l_a
			ON lease_agreement.id = l_a.id_lease_agreement
		JOIN `additional_services`
			ON l_a.id_additional_services = additional_services.id;
		
 /* 58) Соединение таблиц lease_agreement, cars, lease_agreement_to_additional_services, additional_services. К каждой записи таблицы additional_services
 подбирается общая запись из таблиц lease_agreement и cars.*/ 
 SELECT *
	FROM `lease_agreement`
		JOIN `cars` cars
			ON lease_agreement.id_cars = cars.id
		JOIN `lease_agreement_to_additional_services` l_a
			ON lease_agreement.id = l_a.id_lease_agreement
		RIGHT JOIN `additional_services`
			ON l_a.id_additional_services = additional_services.id;
            
------------------------------------------------------------------------------------------------------------------------
/*59) Сортировка записей таблицы booking по возрастанию суммы залога.*/
SELECT *
	FROM `booking`
		ORDER BY `pledge`;
        
/* 60) Сортировка записей таблицы booking по убыванию цены.*/
SELECT *
	FROM `lease_agreement`
		ORDER BY `price` DESC;
        
/* 61) Сортировка записей таблицы lease_agreement одновременно по возрастнаию суммы залога и по убыванию цены.
Записи сначала будут сортироваться по сумме залга, а те записи, в которых сумма залога одинаковая, будут располагаться по убыванию цены. */
SELECT *
	FROM `lease_agreement`
		ORDER BY `pledge` ASC, `price` DESC;
        
/* 62) Сортировка записей таблицы lease_agreement.
Записи сначала будут сортироваться по цене, а те записи, в которых цена одинаковая, будут располагаться по возрастанию суммы залога.*/
SELECT *
	FROM `lease_agreement`
		ORDER BY `price` DESC, `pledge` ASC;

/* 63) Записи группируются по марке автомобиля. Затем ищется количество записей в группе.*/
SELECT `brand`, COUNT(*) as `Количество`
	FROM `cars`
		GROUP BY `brand`;
        
/* 64) Записи группируются по марке автомобиля. Затем ищется самый большой пробег в группе.*/
SELECT `brand`, MAX(`mileage`)  as `Самый большой пробег`
	FROM `cars`
		GROUP BY `brand`;
        
/* 65) Записи группируются по названию технической характеристики автомобиля. Затем ищется наименьшее значение группы.*/
SELECT `title`, MIN(n.meaning) as `Наименьшее значение характеристики`
	FROM `technical_specifications`
		LEFT JOIN `numerical_value_of_the_characteristic` n
			ON technical_specifications.id = n.id_technical_specifications
		GROUP BY `title`;
	
/* 66) Записи группируются по дате подписания. Затем ищется сумма, на которую были заключены договора аренды в этот день.*/
SELECT `date_of_signing`, SUM(`price`) as `Сумарная выручка за день`
	FROM `lease_agreement`
		GROUP BY `date_of_signing`;
        
/* 67) Записи группируются по сумме залога. Затем ищется средняя цена в этой группе. */
SELECT `pledge`, AVG(`price`) as `Средняя цена`
	FROM `lease_agreement`
		GROUP BY `pledge`;
        
/* 68) Записи группируются по дате подписания. Затем ищется наименьшая цена аренды автомобиля в этот день.
Записи сортируются по возрастанию цены.*/
SELECT `date_of_signing`, MIN(`price`) as `Наименьшая цена`
	FROM `lease_agreement`
		GROUP BY `date_of_signing`
			ORDER BY `Наименьшая цена`;
            
/* 69) Записи группируются по марке автомобиля. Затем ищется средний пробег в группе.
Записи сортируются по убыванию пробега.*/
SELECT `brand`, AVG(`mileage`)  as `Средний пробег`
	FROM `cars`
		GROUP BY `brand`
			ORDER BY `Средний пробег` DESC;
            
/* 70) Записи группируются по дате подписания. Затем ищется наименьшая сумма залога и наибольшая цена в этот день.
Записи сначала будут сортироваться по сумме залга, а те записи, в которых сумма залога одинаковая, будут располагаться по убыванию цены. */
SELECT `date_of_signing`, MIN(`pledge`), MAX(`price`)
	FROM `lease_agreement`
		GROUP BY `date_of_signing`
		ORDER BY MIN(`pledge`) ASC, MAX(`price`) DESC;
        
/* 71) Записи группируются по названию сервиса. Затем ищется количество записей в группе. Выбираются только те группы, 
в которых количество строк больше 1.*/
SELECT `service name`, COUNT(*) as `Количество`
	FROM `technical_maintenance`
		GROUP BY `service name`
			HAVING COUNT(*) > 1;
            
/* 72) Записи группируются по марке автомобиля. Затем ищется наименьший пробег в группе.
Выбираются только те группы, в которых количество строк больше 40000.*/
SELECT `brand`, MIN(`mileage`)  as `Минимальный  пробег`
	FROM `cars`
		GROUP BY `brand`
			HAVING MIN(`mileage`) > 40000;

/* 73) Записи группируются по сумме залога. Затем ищется максимальная цена в этой группе.
Выбираются только те группы, в которых цена больше 40000. */
SELECT `pledge`, MAX(`price`) as `Максимальная цена`
	FROM `lease_agreement`
		GROUP BY `pledge`
			HAVING MAX(`price`) > 3000;
            
/* 74) Записи группируются по названию сервиса. Затем ищется средний пробег в группе. Выбираются только те группы, 
в которых средний пробег от 27 000 до 30 000.*/
SELECT `service name`, AVG(`the_mileage_on_which_it_was_served`) as `Средний пробег`
	FROM `technical_maintenance`
		GROUP BY `service name`
			HAVING AVG(`the_mileage_on_which_it_was_served`) BETWEEN 27000 AND 30000;
            
/* 75) Записи группируются по дате подписания. Затем ищется наименьшая сумма, на которую были заключены договора аренды в этот день.
Выбираются только те группы кроме тех, у которых цена не равна 3500 и 5000.*/
SELECT `date_of_signing`, MIN(`price`) as `Сумарная выручка за день`
	FROM `lease_agreement`
		GROUP BY `date_of_signing`
			HAVING MIN(`price`) NOT IN(3500, 5000);

/* 76) Записи группируются по названию сервиса. Затем ищется последний год, в котором обращались в сервис.
Выбираются только те группы кроме тех, у которых последний год обращения был в 2018 или 2020.*/
SELECT `service name`, MAX(EXTRACT(YEAR from `service date`)) as `Год`
	FROM `technical_maintenance`
		GROUP BY `service name`
			HAVING MAX(EXTRACT(YEAR from `service date`)) IN(2018, 2020);

/* 77) Записи группируются по сумме залога. Затем ищется средняя цена в этой группе.
Выбираются только те группы, в которых цена от 4 000 до 5 000 или больше 6 000. 
Записи сортируются по возрастанию цены. */
SELECT `pledge`, AVG(`price`) as `Средняя цена`
	FROM `lease_agreement`
		GROUP BY `pledge`
			HAVING (AVG(`price`) BETWEEN 4000 AND 5000) OR (AVG(`price`) > 6000)
				ORDER BY AVG(`price`);
                
/* 78) Записи группируются по дате подписания. Затем ищется наименьшая сумма залога.
Выбираются только те группы, в которых сумма залога не находится в диапазоне от 8 000 до 10 000. Записи сортируются по сумме залога. */
SELECT `date_of_signing`, MIN(`pledge`)
	FROM `lease_agreement`
		GROUP BY `date_of_signing`
			HAVING NOT MIN(`pledge`) BETWEEN 8000 AND 10000
				ORDER BY MIN(`pledge`) DESC;

----------------------------------------------------------------------------------------------------------------------------
/* 79)  Объединяются все записи из таблиц additional_services, options в одну. */
 SELECT `title`, `description` 
	FROM `additional_services` 
UNION ALL 	
SELECT `title`, `description` 
	FROM `options`;

/* 80) Объединяются все записи из таблиц additional_services, technical_specifications в одну. Из таблицы technical_specifications
выбираются записи, которые не содержут цифр. */
 SELECT `title`, `description` 
	FROM `additional_services` 
UNION ALL 	
SELECT `title`, `description` 
	FROM `technical_specifications`
		  WHERE `title` NOT RLIKE '[0-9]';

/* 81) Объединяются уникальные записи из таблиц additional_services, options в одну. */
SELECT `pledge`, `payment_method` 
	FROM `lease_agreement` 
UNION  	
SELECT `pledge`, `payment_method` 
	FROM `booking`;

----------------------------------------------------------------------------------------------------------------------------

/* 82) Поиск записей, в которых залог больше среднего.*/
SELECT *
	FROM `booking`
		WHERE `pledge` > (SELECT CONVERT(AVG(`pledge`), float) FROM `booking`);
        
/* 83) Вернутся записи таблицы positions, если какие-то записи в таблице positions имеют значение wages больше 30 000. */
SELECT *
	FROM `positions` p1
		WHERE p1.wages = ANY(
							SELECT p2.wages
								FROM `positions` p2
									WHERE p2.wages > 30000
							) ;

/* 84) Вернутся записи таблицы lease_agreement, если все записи в таблице booking имеют значение pledge равное 10 000.*/
SELECT *
	FROM `lease_agreement` l
		WHERE l.pledge = ALL(
							SELECT b.pledge
								FROM `booking` b 
									WHERE `pledge` = 10000
							);

/* 85) Вернутся записи таблицы lease_agreement, где год выпуска автомобиля с 2017 по 2021 год. */
SELECT *
	FROM `booking` b
		WHERE EXISTS (
						SELECT `brand`
							FROM `cars` c
								WHERE c.id = b.id_cars AND `year_of_release` BETWEEN 2017 AND 2021
					 );
                     
----------------------------------------------------------------------------------------------------------------------------

/* 86) Объединение всех адресов.*/
SELECT GROUP_CONCAT(`address`) 
	FROM `parking`;
    
/* 87) Объединение всех дефектов с разделителем " - ".*/
SELECT GROUP_CONCAT(`title` SEPARATOR ' - ') 
	FROM `defects`;
    
/* 88) Объединение столбцов марка и модель. Поля складываются через пробел.*/
SELECT CONCAT_WS(' ', `brand`, `model`)
	FROM `cars`;

----------------------------------------------------------------------------------------------------------------------------

/* 89) Соединение таблиц cars, cars_to_defects и defects. Вывод записе по убыванию года выпуска, в которых пробег автомобиля меньше 50 000 и 
в названии дефекта содержится слово 'Неисправность'. */
SELECT *
	FROM `cars`
		JOIN `cars_to_defects` cd
			ON cars.id = cd.id_cars
		JOIN `defects`
			ON cd.id_defects = defects.id
		WHERE `mileage` < 50000 AND `title` LIKE '%Неисправность%'
			ORDER BY `year_of_release`;

/* 90) Поиск последних аренд автомобиля с дефектом бампера. */ 
 SELECT *
	FROM `lease_agreement`
		JOIN `cars` cars
			ON lease_agreement.id_cars = cars.id
		JOIN `cars_to_defects` cd
			ON cars.id = cd.id_cars
		JOIN `defects`
			ON cd.id_defects = defects.id
		WHERE `title` LIKE '%бампер%'
			ORDER BY `date_of_signing`
				LIMIT 5;
      
/* 91) Количество мест на должность. */
SELECT `title`, COUNT(*) AS `Кол-во рабочих мест`
	FROM `staff`
		JOIN `positions` 
			ON staff.id_positions = positions.id
		GROUP BY `title`
        ORDER BY COUNT(*);


            
/* 92) Поиск договоров, в которых дополнительной услугой была доставка автомобиля.*/
SELECT `contract_number`, `date_of_signing`, `id_clients`, `id_cars`, `title`
	FROM `lease_agreement`
		JOIN `lease_agreement_to_additional_services` l_a
			ON lease_agreement.id = l_a.id_lease_agreement
		JOIN `additional_services`
			ON l_a.id_additional_services = additional_services.id
		WHERE additional_services.title LIKE '%доставка%'
        ORDER BY `date_of_signing`;

----------------------------------------------------------------------------------------------------------------------------

/* 93) Забронировать автомобиль. */
INSERT INTO `booking` (`id`, `duration_from`, `duration_to`, `payment_method`, `pledge`, `id_cars`, `id_clients`) 
	VALUES ('11', '2021-07-16 10:00:00', '2021-07-18 16:00:00', 'Банковская карта', '10000', '1', '1');

INSERT INTO `booking_to_additional_services` (`id_booking`, `id_additional_services`) 
	VALUES ('11', '2');

/* 94) Отменить бронь*/
DELETE FROM `booking` 
	WHERE `duration_from` = '2021-07-16 10:00:00' AND `duration_to` = '2021-07-18 16:00:00' AND `id_clients` = 1;

DELETE FROM `booking_to_additional_services` 
	WHERE `id_booking` = '11' AND `id_additional_services` = '2';
    
/* 95) Изменить время брони автомобиля. */
UPDATE `booking`
	SET `duration_from` = '2021-07-17 10:00:00', `duration_to` = '2021-07-19 16:00:00'
		WHERE `duration_from` = '2021-07-16 10:00:00' AND `duration_to` = '2021-07-18 16:00:00' AND `id_clients` = 1;

/* 96) Поменять автомобиль. */
UPDATE `booking`
	SET `id_cars` = 2
		WHERE `duration_from` = '2021-07-17 10:00:00' AND `duration_to` = '2021-07-19 16:00:00' AND `id_clients` = 1;

/* 97) Изменить выбор доп. услуг.*/
UPDATE `booking_to_additional_services`
	SET `id_additional_services` = '3'
		WHERE `id_booking` = '11' AND `id_additional_services` = '2';
        
/* 98) Отправить автомобиль на ремонт. */
INSERT INTO `car_rental`.`technical_maintenance` (`service name`, `list_of_works`, `service date`, `the_mileage_on_which_it_was_served`, `id_cars`) 
	VALUES ('Fit service', 'Ремонт АКПП', '2021-06-15', '80060', '10');
    
/* 99)	Показать арендованные/ забронированные автомобили на текущие сутки*/
-- арендованные
SELECT `brand`, `model`, `registration_number`, DATE_ADD(`date_of_signing`, INTERVAL `rental_duration` DAY) AS `Окончание аренды`
	FROM `lease_agreement`
		JOIN `cars`
			ON lease_agreement.id_cars = cars.id
		WHERE DATE_ADD(`date_of_signing`, INTERVAL `rental_duration` DAY) >= CURRENT_DATE() AND `date_of_signing` < CURRENT_DATE();

-- забронированные
SELECT `brand`, `model`, `registration_number`
	FROM `booking`
		JOIN `cars`
			ON booking.id_cars = cars.id
		WHERE `duration_to` >= NOW() AND `duration_from` < NOW();

/* 100) Показать автомобили, которые возвращаются с аренды на текущие сутки. */
SELECT `brand`, `model`, `registration_number`, DATE_ADD(`date_of_signing`, INTERVAL `rental_duration` DAY) AS `Окончание аренды`
	FROM `lease_agreement`
		JOIN `cars`
			ON lease_agreement.id_cars = cars.id
		WHERE DATE_ADD(`date_of_signing`, INTERVAL `rental_duration` DAY) = CURRENT_DATE();
  
  /* 101) Показать статистику выбираемых автомобилей. */
SELECT *, COUNT(*) AS `quantity`
	FROM(
			SELECT `id_cars`, `brand`
				FROM `lease_agreement` 
					JOIN `cars`
						ON lease_agreement.id_cars = cars.id
			UNION ALL 	
			SELECT `id_cars`, `brand`
				FROM `booking`
					JOIN `cars`
						ON booking.id_cars = cars.id
           )t
			GROUP BY `brand`
				ORDER BY COUNT(*) DESC;
-----------------------------------------------------------------------------------------------------------------------------------
        
/* Для сотрудника за период с 2021-06-10 по 2021-06-20 сумму стоимостей договоров.*/
SELECT `name`, `surname`, `patronymic`, SUM(`price`)
	FROM `lease_agreement`
		JOIN `staff` 
			ON lease_agreement.id_staff_extradition = staff.id
		WHERE `name` = 'Василий' AND `surname` = 'Сидоров' AND `patronymic` = 'Александрович' AND `date_of_signing` BETWEEN '2021-06-10' AND '2021-06-20'
			GROUP BY `name`, `surname`, `patronymic`;
        
        
/* Топ 5 самых популярных  опций. */
SELECT o.id, `title`, COUNT(*)
	FROM `cars`
		JOIN `options_to_cars` oc
			ON cars.id = oc.id_cars
		JOIN `options` o
			ON oc.id_options = o.id
		GROUP BY `title`
			ORDER BY COUNT(*) DESC
				LIMIT 5;
                
/* Для автомобиля вывести все его характеристики. */
SELECT `title`, `meaning` 
	FROM `cars`
		JOIN `cars_numerical_value` cnv
			ON cars.id = cnv.id_cars
		JOIN `numerical_value_of_the_characteristic` n
			ON cnv.id_numerical_value = n.id
		JOIN `technical_specifications` ts
			ON n.id_technical_specifications = ts.id
		WHERE `brand` = 'BMW' AND `model` = '5 серия' AND `registration_number` = 'М238ММ 134'
UNION
SELECT `title`, `meaning` 
	FROM `cars`
		JOIN `cars_to_letter_value` clv
			ON cars.id = clv.id_cars
		JOIN `letter_value_of_the_characteristic` l
			ON clv.id_letter_value = l.id
		JOIN `technical_specifications` ts
			ON l.id_technical_specifications = ts.id
		WHERE `brand` = 'BMW' AND `model` = '5 серия' AND `registration_number` = 'М238ММ 134';
