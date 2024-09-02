# Библиотека для вычисления площади фигур на C#

Тестовое задание на вакансию Cтажер-разработчик C# (back-end)
Для решения задачи я использовал паттерн фабрики вместе с полиморфизмом. Все фигуры реализуют общий интерфейс, а фабрика создает экземпляры фигур на основе входных данных. Данная реализация позволяет вычислять площадь фигур без знания его типа.

### Ответ на третий вопрос:

```
SELECT 
    p.ProductName,
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.ProductID -- Информация о категориях, если она есть
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID; -- Имена категорий
```

### Можно пойти немного иным способом и создать временную таблицу, которая будет содержать название продукта и его категорию, а затем получить все записи из этой таблицы

```
CREATE VIEW ProductTemp AS
SELECT 
    p.ProductName,
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.ProductID -- Информация о категориях, если она есть
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID; -- Имена категорий

SELECT * FROM ProductTemp;
```
