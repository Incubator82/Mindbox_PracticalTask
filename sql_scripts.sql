--Создаем таблицу продуктов
CREATE TABLE Products
(
	Id int PRIMARY KEY, 
	Name nvarchar(max)
)

-- Создаем таблицу категорий
CREATE TABLE Categories
(
	Id int PRIMARY KEY, 
	Name nvarchar(max)
)

-- Создаем связующую таблицу
CREATE TABLE LinkTable
(
 idLinkTable int identity not null PRIMARY KEY,
 ProductsId int, 
 CategoriesId int

 CONSTRAINT FK_ProductsId FOREIGN KEY (ProductsId) REFERENCES Products (Id),
 CONSTRAINT FK_CategoriesId FOREIGN KEY (CategoriesId) REFERENCES Categories (Id)
)

-- Заполняем данными
INSERT INTO Categories values (1, 'Молочный'), (2, 'Мясной'), (3, 'Рыбный'), (4, 'Овощи и фрукты'), (5, 'Напитки');

INSERT INTO Products values (1, 'Молоко'), (2, 'Кефир'), (3, 'Йогурт'), 
							(4, 'Баранина'), (5, 'Свинина'),
							(6, 'Форель'),
							(7, 'Помидоры'), (8, 'Огурцы'), (9, 'Яблоки'),
							(10, 'Булочки сдобные');

INSERT INTO LinkTable values (1, 1), (2, 1), (3, 1), (4, 2), (5, 2), (6, 3), (7, 4), (8, 4), (9, 4);

-- Выборка

select p.Name, c.Name
from Products p
	left join LinkTable lt on lt.ProductsId = p.Id
	left join Categories c on c.Id = lt.CategoriesId
order by 1, 2

